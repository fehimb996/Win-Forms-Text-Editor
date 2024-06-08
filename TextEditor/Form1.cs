using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // funkcija za mapiranje shortcut
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            // Inicijalizacija za label
            wordCountStatusLabel.Text = "Word Count: 0";
            characterCountStatusLabel.Text = "Character Count: 0";
            lineCountLabel.Text = "Line: " + currentLine;
        }
        // switch za promene
        bool textChanged = false;
        private int currentLine = 1; // Initialize the line count to 1

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Dugme za zatvaranje aplikacije
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom zatvaranja programa.\n{ex.Message}", "Informacija");
                return;
            }
        }
        // Otvaranje fajla
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDlg = new OpenFileDialog();
                openFileDlg.Filter = "Rich text fajlovi (*.rtf)|*.rtf|Tekst fajlovi (*.txt)|*.txt";
                openFileDlg.FileName = "";

                if(openFileDlg.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                string ext = Path.GetExtension(openFileDlg.FileName);

                if(ext == ".rtf")
                {
                    RT.LoadFile(openFileDlg.FileName, RichTextBoxStreamType.RichText);
                } 
                else if(ext == ".txt")
                {
                    RT.LoadFile(openFileDlg.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    MessageBox.Show("Tip fajla nije podržan.", "Informacija");
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show($"Desila se greška u otvaranju fajla.\n{ex.Message}", "Greška");
                //return;

                // ako je korisnik uneo string, upisi detalje u log fajl na putanji
                string errorLogPath = @"C:\Users\Fehim\Documents\errorLog.txt";

                // vreme 
                string errorMessage = $"Datum i vreme greške: {DateTime.Now.ToString()}\n{ex.ToString()}\n";

                Console.WriteLine("Doslo je do greške. Detalji su zapisani u error log fajl");
                Console.ReadLine();

                LogError(errorLogPath, errorMessage);
            }
        }
        // RichTextBox
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
            UpdateWordCount();
            UpdateCharacterCount();

            // racunavanje broj linija u RT
            int lineCount = RT.Lines.Length;

            // Only update the line count when the line count changes
            if (lineCount != currentLine)
            {
                currentLine = lineCount;
                lineCountLabel.Text = "Line: " + currentLine;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // Zatvaranje aplikacije
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (textChanged == true)
                {
                    if (MessageBox.Show("Da li želite da zatvorite aplikaciju?\nSav nesačuvan sadržaj će biti izgubljen.", "Sadržaj je promenjen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
                else
                {
                    e.Cancel = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Greška prilikom zatvaranja.\n{ex.Message}","Informacija");
                return;
            }
            
        }
        // Snimanje fajl
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDlg.Filter = "Rich text file (*.rtf)|*.rtf|Plain text file (*.txt)|*.txt";
            saveFileDlg.DefaultExt = "*.rtf";
            saveFileDlg.FilterIndex = 1;
            saveFileDlg.Title = "Sačuvaj fajl";

            try
            {
                if (saveFileDlg.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                RT.SaveFile(saveFileDlg.FileName, RichTextBoxStreamType.RichText);

                // RT.SaveFile(saveFileDlg.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom snimanja fajla.\n{ex.Message}", "Informacija");
                return;
            }
        }

        private void fontcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DColor.Color = RT.SelectionColor;
                if (DColor.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                RT.SelectionColor = DColor.Color;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error context menu.\n{ex.Message}","Greška");
                return;
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        // shortcuts CRTL +
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void DFont_Apply(object sender, EventArgs e)
        {

        }
        // Select font
        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DFont.Font = new Font(RT.SelectionFont.FontFamily, RT.SelectionFont.Size);

                if (DFont.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                RT.SelectionFont = new Font(DFont.Font.FontFamily, DFont.Font.Size);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Greška.\n{ex.Message}", "Informacija");
            }
        }
        // Font bold
        private void fontBoldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // fontBoldToolStripMenuItem.Checked = !fontBoldToolStripMenuItem.Checked;
            bool isBold = RT.SelectionFont != null && RT.SelectionFont.Bold;

            Font newFont;
            if (isBold)
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style | FontStyle.Bold);
            }

            RT.SelectionFont = newFont;
        }
        // font color
        private void fontColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DColor.Color = RT.SelectionColor;

            if (DColor.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            RT.SelectionColor = DColor.Color;
        }
        // font family save
        private void fontFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DFont.Font = new Font(RT.SelectionFont.FontFamily, RT.SelectionFont.Size);

            if (DFont.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            RT.SelectionFont = new Font(DFont.Font.FontFamily, DFont.Font.Size);
        }
        // font italic
        private void fontItalicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Proverka da li je tekst koji je izabran već strikethrough
            bool isItalic = RT.SelectionFont != null && RT.SelectionFont.Italic;

            Font newFont;
            if (isItalic)
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style | FontStyle.Italic);
            }

            RT.SelectionFont = newFont;
        }
        // font underline
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Proverka da li je tekst koji je izabran već underline
            bool isUnderline = RT.SelectionFont != null && RT.SelectionFont.Underline;

            Font newFont;
            if (isUnderline)
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style | FontStyle.Underline);
            }

            RT.SelectionFont = newFont;
        }
        // font strikethrough
        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Proverka da li je tekst koji je izabran već strikethrough
            bool isStrikethrough = RT.SelectionFont != null && RT.SelectionFont.Strikeout;

            Font newFont;
            if (isStrikethrough)
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style & ~FontStyle.Strikeout);
            }
            else
            {
                newFont = new Font(RT.SelectionFont, RT.SelectionFont.Style | FontStyle.Strikeout);
            }
            RT.SelectionFont = newFont;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {

        }
        // pronadji i zameni
        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            try
            {
                // Proveravamo da li neki tekst postoji u RichTextBox
                if (string.IsNullOrEmpty(RT.Text))
                {
                    MessageBox.Show("Tekst box je prazan. Unesite neki tekst da biste mogli pretražiti tekst.", "Informacija");
                    return;
                }

                string searchText = txtFind.Text;
                string replaceText = txtReplace.Text;

                // Proveravamo da li postoji tekst u pronađi textbox
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Unesite tekst koju tražite", "Informacija");
                    return;
                }

                // Proveravamo da li je zamena prazna
                if (string.IsNullOrEmpty(replaceText))
                {
                    MessageBox.Show("Niste uneli zamenski tekst. Unesite tekst za zamenu.", "Informacija");
                    return;
                }

                int startIndex = 0;

                // Search for the text
                int index = RT.Find(searchText, startIndex, RT.TextLength, RichTextBoxFinds.None);

                if (index == -1)
                {
                    // The search text was not found
                    MessageBox.Show("Tekst koji želite da zamenite nije pronađen.", "Informacija");
                    return;
                }

                // Continue with the replacement
                RT.Select(index, searchText.Length);
                RT.SelectedText = replaceText;
                startIndex = index + replaceText.Length;

                //// Uradimo zamenu
                //int startIndex = 0;
                //while (startIndex < RT.TextLength)
                //{
                //    int index = RT.Find(searchText, startIndex, RT.TextLength, RichTextBoxFinds.None);
                //    if (index == -1)
                //        break;

                //    RT.Select(index, searchText.Length);
                //    RT.SelectedText = replaceText;
                //    startIndex = index + replaceText.Length;
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Greška prilikom pretrage teksta.\n {ex.Message}", "Greška");
            }
        }
        // background color
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Menjamo boju za background
                RT.SelectionBackColor = colorDialog.Color;
            }
        }
        // Word count funkcija
        private int GetWordCount()
        {
            string text = RT.Text;
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Azuriranje reci
        private void UpdateWordCount()
        {
            int wordCount = GetWordCount();
            wordCountStatusLabel.Text = $"Word Count: {wordCount}";
        }
        // Character count funkcija
        private int GetCharacterCount()
        {
            string text = RT.Text;
            return text.Length;
        }

        // Azuriranje slova
        private void UpdateCharacterCount()
        {
            int characterCount = GetCharacterCount();
            characterCountStatusLabel.Text = $"Character Count: {characterCount}";
        }
        // Error log
        static void LogError(string filePath, string errorMessage)
        {
            try
            {
                // pomocu streamwritera unesi error message u fajl error.txt
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska prilikom upisa u log fajl: {ex.ToString()}");
            }
        }

        //private string ConvertRichTextToPlainTextWithFormatting(RichTextBox richTextBox)
        //{
        //    // Create a StringBuilder to build the plain text with formatting
        //    StringBuilder plainTextWithFormatting = new StringBuilder();

        //    // Iterate through each line in the RichTextBox
        //    foreach (string line in richTextBox.Lines)
        //    {
        //        // Append the line text
        //        plainTextWithFormatting.AppendLine(line);

        //        // Get the formatting for the line and append it as RTF
        //        int lineStart = plainTextWithFormatting.Length - line.Length;
        //        int lineEnd = plainTextWithFormatting.Length - 1;
        //        string lineFormatting = richTextBox.Rtf.Substring(lineStart, lineEnd - lineStart + 1);

        //        // Append the line formatting
        //        plainTextWithFormatting.AppendLine(lineFormatting);
        //    }

        //    return plainTextWithFormatting.ToString();
        //}
    }
}
