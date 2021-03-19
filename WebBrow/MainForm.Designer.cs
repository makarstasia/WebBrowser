
namespace WebBrow
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton2 = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.poisktoolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.plusButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VkladkiControl = new System.Windows.Forms.TabControl();
            this.TekyPage = new System.Windows.Forms.TabPage();
            this.tekylistBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.текущиеВкладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePage = new System.Windows.Forms.TabPage();
            this.savelistBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cleanbutton = new System.Windows.Forms.Button();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.VkladkiControl.SuspendLayout();
            this.TekyPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.savePage.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton2,
            this.refreshButton,
            this.stopButton,
            this.poisktoolStripTextBox1,
            this.goButton,
            this.plusButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(986, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(34, 28);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton2
            // 
            this.forwardButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton2.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton2.Image")));
            this.forwardButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton2.Name = "forwardButton2";
            this.forwardButton2.Size = new System.Drawing.Size(34, 28);
            this.forwardButton2.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(34, 28);
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(34, 28);
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // poisktoolStripTextBox1
            // 
            this.poisktoolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.poisktoolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.poisktoolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.poisktoolStripTextBox1.Name = "poisktoolStripTextBox1";
            this.poisktoolStripTextBox1.Size = new System.Drawing.Size(400, 33);
            this.poisktoolStripTextBox1.TextChanged += new System.EventHandler(this.poisktoolStripTextBox1_TextChanged);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(34, 28);
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plusButton.Image = ((System.Drawing.Image)(resources.GetObject("plusButton.Image")));
            this.plusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(34, 28);
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VkladkiControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(654, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 417);
            this.panel1.TabIndex = 1;
            // 
            // VkladkiControl
            // 
            this.VkladkiControl.Controls.Add(this.TekyPage);
            this.VkladkiControl.Controls.Add(this.savePage);
            this.VkladkiControl.Controls.Add(this.historyPage);
            this.VkladkiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VkladkiControl.Location = new System.Drawing.Point(0, 0);
            this.VkladkiControl.Name = "VkladkiControl";
            this.VkladkiControl.SelectedIndex = 0;
            this.VkladkiControl.Size = new System.Drawing.Size(332, 417);
            this.VkladkiControl.TabIndex = 0;
            // 
            // TekyPage
            // 
            this.TekyPage.Controls.Add(this.tekylistBox);
            this.TekyPage.Location = new System.Drawing.Point(4, 29);
            this.TekyPage.Name = "TekyPage";
            this.TekyPage.Padding = new System.Windows.Forms.Padding(3);
            this.TekyPage.Size = new System.Drawing.Size(324, 384);
            this.TekyPage.TabIndex = 0;
            this.TekyPage.Text = "Текущие вкладки";
            this.TekyPage.UseVisualStyleBackColor = true;
            // 
            // tekylistBox
            // 
            this.tekylistBox.ContextMenuStrip = this.contextMenuStrip1;
            this.tekylistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tekylistBox.FormattingEnabled = true;
            this.tekylistBox.ItemHeight = 20;
            this.tekylistBox.Location = new System.Drawing.Point(3, 3);
            this.tekylistBox.Name = "tekylistBox";
            this.tekylistBox.Size = new System.Drawing.Size(318, 378);
            this.tekylistBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текущиеВкладкиToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 68);
            // 
            // текущиеВкладкиToolStripMenuItem
            // 
            this.текущиеВкладкиToolStripMenuItem.Name = "текущиеВкладкиToolStripMenuItem";
            this.текущиеВкладкиToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.текущиеВкладкиToolStripMenuItem.Text = "Сохранить вкладку";
            this.текущиеВкладкиToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВкладкуToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // savePage
            // 
            this.savePage.Controls.Add(this.savelistBox);
            this.savePage.Location = new System.Drawing.Point(4, 29);
            this.savePage.Name = "savePage";
            this.savePage.Padding = new System.Windows.Forms.Padding(3);
            this.savePage.Size = new System.Drawing.Size(324, 384);
            this.savePage.TabIndex = 1;
            this.savePage.Text = "Сохраненные";
            this.savePage.UseVisualStyleBackColor = true;
            // 
            // savelistBox
            // 
            this.savelistBox.ContextMenuStrip = this.contextMenuStrip2;
            this.savelistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savelistBox.FormattingEnabled = true;
            this.savelistBox.ItemHeight = 20;
            this.savelistBox.Location = new System.Drawing.Point(3, 3);
            this.savelistBox.Name = "savelistBox";
            this.savelistBox.Size = new System.Drawing.Size(318, 378);
            this.savelistBox.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 36);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(148, 32);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.richTextBox1);
            this.historyPage.Controls.Add(this.cleanbutton);
            this.historyPage.Location = new System.Drawing.Point(4, 29);
            this.historyPage.Name = "historyPage";
            this.historyPage.Size = new System.Drawing.Size(324, 384);
            this.historyPage.TabIndex = 2;
            this.historyPage.Text = "История";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(324, 343);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // cleanbutton
            // 
            this.cleanbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cleanbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanbutton.Location = new System.Drawing.Point(0, 343);
            this.cleanbutton.Name = "cleanbutton";
            this.cleanbutton.Size = new System.Drawing.Size(324, 41);
            this.cleanbutton.TabIndex = 0;
            this.cleanbutton.Text = "очистить ";
            this.cleanbutton.UseVisualStyleBackColor = true;
            this.cleanbutton.Click += new System.EventHandler(this.cleanbutton_Click);
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 33);
            this.webControl1.Size = new System.Drawing.Size(654, 417);
            this.webControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MBrowser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.VkladkiControl.ResumeLayout(false);
            this.TekyPage.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.savePage.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.historyPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton2;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripTextBox poisktoolStripTextBox1;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStripButton plusButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl VkladkiControl;
        private System.Windows.Forms.TabPage TekyPage;
        private System.Windows.Forms.TabPage savePage;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.ListBox tekylistBox;
        private System.Windows.Forms.ListBox savelistBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem текущиеВкладкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.Button cleanbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

