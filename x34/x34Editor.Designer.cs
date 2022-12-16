
namespace x34
{
    partial class x34Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x34ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workspacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testbasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipsONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regenerateX34ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "File:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(417, 11);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(163, 331);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 79);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 264);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.x34ToolStripMenuItem,
            this.editorSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // x34ToolStripMenuItem
            // 
            this.x34ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workspacesToolStripMenuItem,
            this.testbasesToolStripMenuItem,
            this.testsToolStripMenuItem,
            this.regenerateX34ToolStripMenuItem});
            this.x34ToolStripMenuItem.Name = "x34ToolStripMenuItem";
            this.x34ToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.x34ToolStripMenuItem.Text = "x34";
            // 
            // workspacesToolStripMenuItem
            // 
            this.workspacesToolStripMenuItem.Name = "workspacesToolStripMenuItem";
            this.workspacesToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.workspacesToolStripMenuItem.Text = "Workspaces:";
            // 
            // testbasesToolStripMenuItem
            // 
            this.testbasesToolStripMenuItem.Name = "testbasesToolStripMenuItem";
            this.testbasesToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.testbasesToolStripMenuItem.Text = "Testbases Per Workspace:";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.testsToolStripMenuItem.Text = "Tests Per Testspace:";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // editorSettingsToolStripMenuItem
            // 
            this.editorSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTipsONToolStripMenuItem});
            this.editorSettingsToolStripMenuItem.Name = "editorSettingsToolStripMenuItem";
            this.editorSettingsToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.editorSettingsToolStripMenuItem.Text = "Editor Settings";
            // 
            // toolTipsONToolStripMenuItem
            // 
            this.toolTipsONToolStripMenuItem.Name = "toolTipsONToolStripMenuItem";
            this.toolTipsONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toolTipsONToolStripMenuItem.Text = "Tool Tips ON";
            this.toolTipsONToolStripMenuItem.Click += new System.EventHandler(this.toolTipsONToolStripMenuItem_Click);
            // 
            // regenerateX34ToolStripMenuItem
            // 
            this.regenerateX34ToolStripMenuItem.Name = "regenerateX34ToolStripMenuItem";
            this.regenerateX34ToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.regenerateX34ToolStripMenuItem.Text = "Regenerate x34";
            this.regenerateX34ToolStripMenuItem.Click += new System.EventHandler(this.regenerateX34ToolStripMenuItem_Click);
            // 
            // x34Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 358);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "x34Editor";
            this.Text = "x34Editor";
            this.Load += new System.EventHandler(this.x34Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x34ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workspacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testbasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolTipsONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regenerateX34ToolStripMenuItem;
    }
}