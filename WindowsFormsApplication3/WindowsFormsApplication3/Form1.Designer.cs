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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italics = new System.Windows.Forms.ToolStripButton();
            this.Sub = new System.Windows.Forms.ToolStripButton();
            this.Sup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.font = new System.Windows.Forms.ToolStripComboBox();
            this.size = new System.Windows.Forms.ToolStripComboBox();
            this.color = new System.Windows.Forms.ToolStripComboBox();
            this.fontSet = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.textPane = new System.Windows.Forms.TabPage();
            this.text = new System.Windows.Forms.RichTextBox();
            this.htmlPane = new System.Windows.Forms.TabPage();
            this.html = new System.Windows.Forms.RichTextBox();
            this.convert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textPro = new System.Windows.Forms.ToolStripProgressBar();
            this.proLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.textPane.SuspendLayout();
            this.htmlPane.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.imagepages_backgrounds_abstract_lines_hd_px;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(93, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "review";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.imagepages_backgrounds_abstract_lines_hd_px;
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
            this.fontSet});
            this.toolStrip1.Location = new System.Drawing.Point(10, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::WindowsFormsApplication3.Properties.Resources.font_bold;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "Bold";
            this.Bold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italics
            // 
            this.Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italics.Image = global::WindowsFormsApplication3.Properties.Resources.font_italic;
            this.Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italics.Name = "Italics";
            this.Italics.Size = new System.Drawing.Size(23, 22);
            this.Italics.Text = "Italics";
            this.Italics.Click += new System.EventHandler(this.Italics_Click);
            // 
            // Sub
            // 
            this.Sub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sub.Image = global::WindowsFormsApplication3.Properties.Resources.arrow_bottom;
            this.Sub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(23, 22);
            this.Sub.Text = "SubScript";
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Sup
            // 
            this.Sup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sup.Image = global::WindowsFormsApplication3.Properties.Resources.arrow_top;
            this.Sup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(23, 22);
            this.Sup.Text = "SuperScript";
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
            this.font.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.font.Items.AddRange(new object[] {
            "Times New Roman",
            "Calibri",
            "Arial",
            "Cambria"});
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(121, 25);
            this.font.Text = "Font";
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.size.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(75, 25);
            this.size.Text = "Size";
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.color.Items.AddRange(new object[] {
            "Black",
            "Grey",
            "Red",
            "Blue",
            "Green"});
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 25);
            this.color.Text = "Color";
            // 
            // fontSet
            // 
            this.fontSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontSet.Image = global::WindowsFormsApplication3.Properties.Resources.font_size;
            this.fontSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontSet.Name = "fontSet";
            this.fontSet.Size = new System.Drawing.Size(23, 22);
            this.fontSet.Text = "toolStripButton2";
            this.fontSet.Click += new System.EventHandler(this.fontSet_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.textPane);
            this.tabs.Controls.Add(this.htmlPane);
            this.tabs.Location = new System.Drawing.Point(7, 56);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(747, 387);
            this.tabs.TabIndex = 5;
            // 
            // textPane
            // 
            this.textPane.Controls.Add(this.text);
            this.textPane.Location = new System.Drawing.Point(4, 22);
            this.textPane.Name = "textPane";
            this.textPane.Padding = new System.Windows.Forms.Padding(3);
            this.textPane.Size = new System.Drawing.Size(739, 361);
            this.textPane.TabIndex = 0;
            this.textPane.Text = "Text";
            this.textPane.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.BackColor = System.Drawing.Color.Gainsboro;
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(743, 365);
            this.text.TabIndex = 0;
            this.text.Text = "";
            // 
            // htmlPane
            // 
            this.htmlPane.Controls.Add(this.html);
            this.htmlPane.Location = new System.Drawing.Point(4, 22);
            this.htmlPane.Name = "htmlPane";
            this.htmlPane.Padding = new System.Windows.Forms.Padding(3);
            this.htmlPane.Size = new System.Drawing.Size(739, 361);
            this.htmlPane.TabIndex = 1;
            this.htmlPane.Text = "HTML";
            this.htmlPane.UseVisualStyleBackColor = true;
            // 
            // html
            // 
            this.html.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.html.BackColor = System.Drawing.SystemColors.ControlLight;
            this.html.Location = new System.Drawing.Point(0, 1);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(742, 342);
            this.html.TabIndex = 0;
            this.html.Text = "";
            // 
            // convert
            // 
            this.convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.convert.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.imagepages_backgrounds_abstract_lines_hd_px;
            this.convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convert.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.convert.Location = new System.Drawing.Point(557, 27);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(181, 23);
            this.convert.TabIndex = 6;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.imagepages_backgrounds_abstract_lines_hd_px;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textPro,
            this.proLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textPro
            // 
            this.textPro.Name = "textPro";
            this.textPro.Size = new System.Drawing.Size(100, 16);
            this.textPro.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // proLabel
            // 
            this.proLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.proLabel.Name = "proLabel";
            this.proLabel.Size = new System.Drawing.Size(46, 17);
            this.proLabel.Text = "started.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.imagepages_backgrounds_abstract_lines_hd_px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HTML Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.textPane.ResumeLayout(false);
            this.htmlPane.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage textPane;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.TabPage htmlPane;
        private System.Windows.Forms.RichTextBox html;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.ToolStripComboBox size;
        private System.Windows.Forms.ToolStripComboBox color;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton fontSet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar textPro;
        private System.Windows.Forms.ToolStripStatusLabel proLabel;
    }
}

