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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            Count = slider.Value;
            Close();
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(slider.Value);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(slider.Value);
        }
    }
}
