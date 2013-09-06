namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italics = new System.Windows.Forms.ToolStripButton();
            this.Sub = new System.Windows.Forms.ToolStripButton();
            this.Sup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.font = new System.Windows.Forms.ToolStripComboBox();
            this.size = new System.Windows.Forms.ToolStripComboBox();
            this.color = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.NoChars = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.textPane = new System.Windows.Forms.TabPage();
            this.text = new System.Windows.Forms.RichTextBox();
            this.htmlPane = new System.Windows.Forms.TabPage();
            this.html = new System.Windows.Forms.RichTextBox();
            this.convert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoChars)).BeginInit();
            this.tabs.SuspendLayout();
            this.textPane.SuspendLayout();
            this.htmlPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Italics,
            this.Sub,
            this.Sup,
            this.toolStripSeparator1,
            this.font,
            this.size,
            this.color,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(10, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "B";
            this.Bold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italics
            // 
            this.Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italics.Image = ((System.Drawing.Image)(resources.GetObject("Italics.Image")));
            this.Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italics.Name = "Italics";
            this.Italics.Size = new System.Drawing.Size(23, 22);
            this.Italics.Text = "I";
            this.Italics.Click += new System.EventHandler(this.Italics_Click);
            // 
            // Sub
            // 
            this.Sub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sub.Image = ((System.Drawing.Image)(resources.GetObject("Sub.Image")));
            this.Sub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(23, 22);
            this.Sub.Text = "Sub";
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Sup
            // 
            this.Sup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sup.Image = ((System.Drawing.Image)(resources.GetObject("Sup.Image")));
            this.Sup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(23, 22);
            this.Sup.Text = "Sup";
            this.Sup.Click += new System.EventHandler(this.Sup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // font
            // 
            this.font.AutoCompleteCustomSource.AddRange(new string[] {
            "Times New Roman",
            "Caribri",
            "Arial"});
            this.font.Items.AddRange(new object[] {
            "Times new roman",
            "Caribri",
            "Arial"});
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(121, 25);
            this.font.Text = "Font";
            // 
            // size
            // 
            this.size.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(75, 25);
            this.size.Text = "Size";
            // 
            // color
            // 
            this.color.Items.AddRange(new object[] {
            "Black",
            "White",
            "Grey",
            "Red",
            "Blue",
            "Green"});
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 25);
            this.color.Text = "Color";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // NoChars
            // 
            this.NoChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoChars.Location = new System.Drawing.Point(541, 42);
            this.NoChars.Maximum = 132;
            this.NoChars.Name = "NoChars";
            this.NoChars.Size = new System.Drawing.Size(213, 45);
            this.NoChars.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "132";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.textPane);
            this.tabs.Controls.Add(this.htmlPane);
            this.tabs.Location = new System.Drawing.Point(4, 75);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(738, 368);
            this.tabs.TabIndex = 5;
            // 
            // textPane
            // 
            this.textPane.Controls.Add(this.text);
            this.textPane.Location = new System.Drawing.Point(4, 22);
            this.textPane.Name = "textPane";
            this.textPane.Padding = new System.Windows.Forms.Padding(3);
            this.textPane.Size = new System.Drawing.Size(730, 342);
            this.textPane.TabIndex = 0;
            this.textPane.Text = "Text";
            this.textPane.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(730, 346);
            this.text.TabIndex = 0;
            this.text.Text = "";
            // 
            // htmlPane
            // 
            this.htmlPane.Controls.Add(this.html);
            this.htmlPane.Location = new System.Drawing.Point(4, 22);
            this.htmlPane.Name = "htmlPane";
            this.htmlPane.Padding = new System.Windows.Forms.Padding(3);
            this.htmlPane.Size = new System.Drawing.Size(730, 342);
            this.htmlPane.TabIndex = 1;
            this.htmlPane.Text = "HTML";
            this.htmlPane.UseVisualStyleBackColor = true;
            // 
            // html
            // 
            this.html.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.html.Location = new System.Drawing.Point(0, 1);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(742, 342);
            this.html.TabIndex = 0;
            this.html.Text = "";
            // 
            // convert
            // 
            this.convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.convert.Location = new System.Drawing.Point(606, 24);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(94, 23);
            this.convert.TabIndex = 6;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 466);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoChars);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoChars)).EndInit();
            this.tabs.ResumeLayout(false);
            this.textPane.ResumeLayout(false);
            this.htmlPane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italics;
        private System.Windows.Forms.ToolStripButton Sub;
        private System.Windows.Forms.ToolStripButton Sup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox font;
        private System.Windows.Forms.TrackBar NoChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage textPane;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.TabPage htmlPane;
        private System.Windows.Forms.RichTextBox html;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.ToolStripComboBox size;
        private System.Windows.Forms.ToolStripComboBox color;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

