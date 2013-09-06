using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            if (text.SelectionFont != null)
            {
                System.Drawing.Font currentFont = text.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (text.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                text.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //text.SelectedText = "<b>" + text.SelectedText + "</b>";
            }
        }

        private void Italics_Click(object sender, EventArgs e)
        {
           // text.SelectedText = "<i>" + text.SelectedText + "</i>";
            if (text.SelectionFont != null)
            {
                System.Drawing.Font currentFont = text.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (text.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                text.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                //text.SelectedText = "<b>" + text.SelectedText + "</b>";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (text.SelectionCharOffset == 0)
                text.SelectionCharOffset = -10;
            else
                text.SelectionCharOffset = 0;
            //text.SelectedText = "<sub>" + text.SelectedText + "</sub>";
        }

        private void Sup_Click(object sender, EventArgs e)
        {
            if (text.SelectionCharOffset == 0)
                text.SelectionCharOffset = 10;
            else
                text.SelectionCharOffset = 0;
            // text.SelectedText = "<sup>" + text.SelectedText + "</sup>";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string f=font.SelectedItem.ToString();
            string s=size.SelectedItem.ToString();
            string c=color.SelectedItem.ToString();
            text.SelectedText = "<font face=\"" + f + "\" size=\"" + s + "\" color=\"" + c + "\" >" + text.SelectedText + "</font>";
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result=openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                // Open the selected file to read.
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    text.Text = reader.ReadToEnd();
                }
                fileStream.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files|*.*";
            string saveFile="";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveFile = sfd.FileName;
                text.SaveFile(saveFile, RichTextBoxStreamType.PlainText);
            }
        }

        
    }
}
