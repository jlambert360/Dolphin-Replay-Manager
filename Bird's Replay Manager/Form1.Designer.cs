using System.Drawing;
using System.Windows.Forms;

namespace Bird_s_Replay_Manager
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.titleBarPanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelReplaySubmenu = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.moveReplaysButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.useReplayButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.toolsButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelSideMenu.SuspendLayout();
            this.titleBarPanel2.SuspendLayout();
            this.panelReplaySubmenu.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.panelToolBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.titleBarPanel2);
            this.panelSideMenu.Controls.Add(this.panelReplaySubmenu);
            this.panelSideMenu.Controls.Add(this.toolsButton);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // titleBarPanel2
            // 
            this.titleBarPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.titleBarPanel2.Controls.Add(this.panel1);
            this.titleBarPanel2.Controls.Add(this.label1);
            this.titleBarPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel2.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel2.Name = "titleBarPanel2";
            this.titleBarPanel2.Size = new System.Drawing.Size(250, 34);
            this.titleBarPanel2.TabIndex = 2;
            this.titleBarPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel2_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bird_s_Replay_Manager.Properties.Resources.ujelly;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bird\'s Dolphin Replay Manager";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelReplaySubmenu
            // 
            this.panelReplaySubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReplaySubmenu.Controls.Add(this.deleteButton);
            this.panelReplaySubmenu.Controls.Add(this.refreshButton);
            this.panelReplaySubmenu.Controls.Add(this.moveReplaysButton);
            this.panelReplaySubmenu.Controls.Add(this.renameButton);
            this.panelReplaySubmenu.Controls.Add(this.useReplayButton);
            this.panelReplaySubmenu.Controls.Add(this.locationButton);
            this.panelReplaySubmenu.Location = new System.Drawing.Point(0, 155);
            this.panelReplaySubmenu.Name = "panelReplaySubmenu";
            this.panelReplaySubmenu.Size = new System.Drawing.Size(250, 248);
            this.panelReplaySubmenu.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.Location = new System.Drawing.Point(0, 160);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(250, 40);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete replay";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.refreshButton.Location = new System.Drawing.Point(0, 200);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.refreshButton.Size = new System.Drawing.Size(250, 40);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh list";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // moveReplaysButton
            // 
            this.moveReplaysButton.FlatAppearance.BorderSize = 0;
            this.moveReplaysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveReplaysButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.moveReplaysButton.Location = new System.Drawing.Point(0, 120);
            this.moveReplaysButton.Name = "moveReplaysButton";
            this.moveReplaysButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.moveReplaysButton.Size = new System.Drawing.Size(250, 40);
            this.moveReplaysButton.TabIndex = 3;
            this.moveReplaysButton.Text = "Move all replay files to replay folder";
            this.moveReplaysButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveReplaysButton.UseVisualStyleBackColor = true;
            this.moveReplaysButton.Click += new System.EventHandler(this.moveReplaysButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.FlatAppearance.BorderSize = 0;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.renameButton.Location = new System.Drawing.Point(0, 80);
            this.renameButton.Name = "renameButton";
            this.renameButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.renameButton.Size = new System.Drawing.Size(250, 40);
            this.renameButton.TabIndex = 2;
            this.renameButton.Text = "Rename selected replay";
            this.renameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // useReplayButton
            // 
            this.useReplayButton.FlatAppearance.BorderSize = 0;
            this.useReplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useReplayButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.useReplayButton.Location = new System.Drawing.Point(0, 40);
            this.useReplayButton.Name = "useReplayButton";
            this.useReplayButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.useReplayButton.Size = new System.Drawing.Size(250, 40);
            this.useReplayButton.TabIndex = 1;
            this.useReplayButton.Text = "Use selected replay";
            this.useReplayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.useReplayButton.UseVisualStyleBackColor = true;
            this.useReplayButton.Click += new System.EventHandler(this.useReplayButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.FlatAppearance.BorderSize = 0;
            this.locationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.locationButton.Location = new System.Drawing.Point(0, 0);
            this.locationButton.Name = "locationButton";
            this.locationButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.locationButton.Size = new System.Drawing.Size(250, 40);
            this.locationButton.TabIndex = 0;
            this.locationButton.Text = "Select Dolphin location";
            this.locationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // toolsButton
            // 
            this.toolsButton.FlatAppearance.BorderSize = 0;
            this.toolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolsButton.Location = new System.Drawing.Point(0, 109);
            this.toolsButton.Name = "toolsButton";
            this.toolsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolsButton.Size = new System.Drawing.Size(250, 45);
            this.toolsButton.TabIndex = 1;
            this.toolsButton.Text = "Tools";
            this.toolsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolsButton.UseVisualStyleBackColor = true;
            this.toolsButton.Click += new System.EventHandler(this.toolsButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.titleBarPanel.Controls.Add(this.maximizeButton);
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.closeButton);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(250, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(684, 34);
            this.titleBarPanel.TabIndex = 1;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.maximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.maximizeButton.Image = global::Bird_s_Replay_Manager.Properties.Resources.maximize;
            this.maximizeButton.Location = new System.Drawing.Point(590, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(47, 34);
            this.maximizeButton.TabIndex = 0;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.minimizeButton.Image = global::Bird_s_Replay_Manager.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(544, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(47, 34);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.closeButton.Image = global::Bird_s_Replay_Manager.Properties.Resources.x;
            this.closeButton.Location = new System.Drawing.Point(637, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 34);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelToolBar.Controls.Add(this.textBox2);
            this.panelToolBar.Controls.Add(this.textBox1);
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToolBar.Location = new System.Drawing.Point(250, 432);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(684, 129);
            this.panelToolBar.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(4, 8);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 16);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Instructions:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(4, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(676, 97);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.listBox2);
            this.panelChildForm.Controls.Add(this.listBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 34);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 398);
            this.panelChildForm.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(227, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 398);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 398);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.titleBarPanel2.ResumeLayout(false);
            this.titleBarPanel2.PerformLayout();
            this.panelReplaySubmenu.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelReplaySubmenu;
        private System.Windows.Forms.Button moveReplaysButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button useReplayButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button toolsButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private Panel panelToolBar;
        private Panel titleBarPanel2;
        private Panel panelChildForm;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Panel panel1;
        private Button refreshButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button deleteButton;
    }
}

