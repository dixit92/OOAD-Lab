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
                html.SaveFile(saveFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            //BOLD ITALICS
            String txt = text.Text;
            string txt2 = "";
            string sub = "";
            string sup = "";
            string bold = "";
            string italics = "";
            int[] array = new int[text.TextLength];
            int[] array1 = new int[text.TextLength];
            for (int j = 0; j < text.TextLength - 1; j++)
            {
                array[j] = 0;
                array1[j] = 0;
                text.Select(j, 1);
                if (text.SelectionFont.Bold)
                    array[j] = 1;
                if (text.SelectionFont.Italic)
                    array[j] = 2;
                if (text.SelectionCharOffset == -10)
                    array1[j] = 1;
                if (text.SelectionCharOffset == +10)
                    array1[j] = 2;
                // MessageBox.Show("" + array1[j]);
            }
            int i = 0;
            while (i < txt.Length - 1)
            {
                if (array1[i] == 0)
                {
                    while (array1[i] == 0 && i < txt.Length - 1)
                    {
                        if (array[i] == 0 && array1[i] == 0)
                        {
                            while (array[i] == 0 && i < txt.Length - 1 && array1[i] == 0)
                            {
                                txt2 += txt.Substring(i, 1);
                                i++;
                            }
                        }
                        else if (array[i] == 1 && array1[i] == 0)
                        {

                            while (array[i] == 1 && i < txt.Length - 1 && array1[i] == 0)
                            {
                                bold += txt.Substring(i, 1);

                                i++;
                            }
                            txt2 += "<b>" + bold + "</b>";
                            bold = "";
                        }
                        else
                        {

                            while (array[i] == 2 && i < txt.Length - 1 && array1[i] == 0)
                            {
                                italics += txt.Substring(i, 1);

                                i++;
                            }
                            txt2 += "<i>" + italics + "</i>";
                            italics = "";
                        }
                        //i++;
                    }
                }
                else if (array1[i] == 1)
                {
                    while (array1[i] == 1 && i < txt.Length - 1)
                    {
                        if (array[i] == 0 && array1[i] == 1)
                        {
                            while (array[i] == 0 && i < txt.Length - 1 && array1[i] == 1)
                            {
                                sub += txt.Substring(i, 1);
                                i++;
                            }
                        }
                        else if (array[i] == 1 && array1[i] == 1)
                        {

                            while (array[i] == 1 && i < txt.Length - 1 && array1[i] == 1)
                            {
                                bold += txt.Substring(i, 1);

                                i++;
                            }
                            sub += "<b>" + bold + "</b>";
                            bold = "";
                        }
                        else
                        {

                            while (array[i] == 2 && i < txt.Length - 1 && array1[i] == 1)
                            {
                                italics += txt.Substring(i, 1);

                                i++;
                            }
                            sub += "<i>" + italics + "</i>";
                            italics = "";
                        }
                        //i++;
                    }
                    txt2 += "<sub>" + sub + "</sub>";
                    sub = "";
                }
                else
                {
                    while (array1[i] == 2 && i < txt.Length - 1)
                    {
                        if (array[i] == 0 && array1[i] == 2)
                        {
                            while (array[i] == 0 && i < txt.Length - 1 && array1[i] == 2)
                            {
                                sup += txt.Substring(i, 1);
                                i++;
                            }
                        }
                        else if (array[i] == 1 && array1[i] == 2)
                        {

                            while (array[i] == 1 && i < txt.Length - 1 && array1[i] == 2)
                            {
                                bold += txt.Substring(i, 1);

                                i++;
                            }
                            sup += "<b>" + bold + "</b>";
                            bold = "";
                        }
                        else
                        {

                            while (array[i] == 2 && i < txt.Length - 1 && array1[i] == 2)
                            {
                                italics += txt.Substring(i, 1);

                                i++;
                            }
                            sup += "<i>" + italics + "</i>";
                            italics = "";
                        }
                        // i++;
                    }
                    txt2 += "<sup>" + sup + "</sup>";
                    sup = "";
                }


            }
            txt = txt2;

            //<BR> CODE
            
            int nchar = NoChars.Value;
            MessageBox.Show("" + nchar);
            int len = txt.Length;
            txt2 = "";
            int count=0;
            int max = 0;
            for (i = 0; i < len; i++)
            {
                if (txt.Substring(i, 1) == "<")
                {

                    while (txt.Substring(i, 1) != ">" && i < len-1)
                    {
                        max++;
                        txt2 += txt.Substring(i, 1);
                        i++;
                        if (max > 5)
                            break;
                    }
                }
                txt2 = txt2 + txt.Substring(i,1);
                count++;
                if (count == nchar)
                {
                    txt2 += "<br>";
                    count = 0;
                }
            }
            txt = txt2;
            //Find PP (paragraphs) and insert </p><p> at every instance
            txt = txt.Replace("PP", "</p><p>");

            //End: Add HTML, FONT and <p> to the final result
            txt = txt.Insert(0, "<html><font face=\"" + font.Text + "\" size=" + size.Text + " color=\""
                + color.Text + "\">" +"<p>");
            txt = txt.Insert(txt.Length, "</p></font></html>");
            html.Text = txt;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
