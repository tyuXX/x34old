using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace x34
{
    public partial class x34Editor : Form
    {
        #region Vars
        public string dir = "C:";
        public string username = "user";
        public string userrole = "Default";
        internal string[ ] info;
        internal bool tooltips = true;
        internal bool theme = false;
        internal bool newopen = false;
        internal string openfile = "";
        #endregion Vars
        public x34Editor( )
        {
            InitializeComponent ( );
        }

        private void x34Editor_Load( object sender , EventArgs e )
        {
            try
            {
                info = Generate.options ( dir , false );
                workspacesToolStripMenuItem.Text += info[ 0 ];
                testbasesToolStripMenuItem.Text += info[ 1 ];
                testsToolStripMenuItem.Text += info[ 2 ];
                userToolStripMenuItem.Text += username;
                userRoleToolStripMenuItem.Text += userrole;
                loadfolder ( dir );
                if (userrole == "Admin")
                {

                }
            }
            catch (Exception)
            {
                Close ( );
            }
        }
        #region Treeview
        public void loadfolder( string Dir )
        {
            DirectoryInfo di = new DirectoryInfo ( Dir );
            TreeNode tds = treeView1.Nodes.Add ( di.Name );
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            fileload ( Dir , tds );
            childloadfolder ( Dir , tds );
        }

        private void childloadfolder( string dir , TreeNode td )
        {

            string[ ] subdirectoryEntries = Directory.GetDirectories ( dir );

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo ( subdirectory );
                TreeNode tds = td.Nodes.Add ( di.Name );
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                fileload ( subdirectory , tds );
                childloadfolder ( subdirectory , tds );
            }
        }

        private void fileload( string dir , TreeNode td )
        {
            string[ ] Files = Directory.GetFiles ( dir , "*.*" );
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo ( file );
                TreeNode tds = td.Nodes.Add ( fi.Name );
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }

        private void treeView1_MouseMove( object sender , MouseEventArgs e )
        {

            if (tooltips)
            {
                TreeNode theNode = treeView1.GetNodeAt ( e.X , e.Y );
                if (theNode != null && theNode.Tag != null)
                {
                    if (theNode.Tag.ToString ( ) != toolTip1.GetToolTip ( treeView1 ))
                    {
                        toolTip1.SetToolTip ( treeView1 , theNode.Tag.ToString ( ) );
                    }

                }
                else
                {
                    toolTip1.SetToolTip ( treeView1 , "" );
                }
            }
            else
            {
                toolTip1.SetToolTip ( treeView1 , "" );
            }
        }
        private void treeView1_NodeMouseDoubleClick( object sender , TreeNodeMouseClickEventArgs e )
        {
            if (File.Exists ( e.Node.Tag.ToString ( ) ))
            {
                label1.Text = "File:" + e.Node.Tag.ToString ( );
                openfile = e.Node.Tag.ToString ( );
                richTextBox1.Text = File.ReadAllText ( e.Node.Tag.ToString ( ) );
                newopen = true;
            }
        }
        private void reftree( )
        {
            treeView1.Nodes.Clear ( );
            loadfolder ( dir );
        }
        #endregion Treeview
        #region Menustrip
        private void refreshTreeViewToolStripMenuItem_Click( object sender , EventArgs e )
        {
            reftree ( );
        }
        private void toolTipsONToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (tooltips)
            {
                tooltips = false;
                toolTipsONToolStripMenuItem.Text = "Tool Tips OFF";
            }
            else
            {
                tooltips = true;
                toolTipsONToolStripMenuItem.Text = "Tool Tips ON";
            }
        }

        private void saveFileToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (!string.IsNullOrEmpty ( openfile ))
            {
                File.WriteAllText ( openfile , richTextBox1.Text );
                label1.Text = "File:" + openfile;
            }
        }

        private void regenerateX34ToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Generate.x34 ( dir , Convert.ToInt32 ( info[ 0 ] ) , Convert.ToInt32 ( info[ 1 ] ) , Convert.ToInt32 ( info[ 2 ] ) , true , true );
            reftree ( );
        }
        private void runcmdFileToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (!string.IsNullOrEmpty ( openfile ))
            {
                if (File.Exists ( openfile ))
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo ( );
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/c " + openfile;
                    Process.Start ( processStartInfo );
                }
            }
        }
        private void themeLightToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (theme)
            {
                theme = false;
                themeLightToolStripMenuItem.Text = "Theme [Light]";
                this.BackColor = System.Drawing.Color.White;
                richTextBox1.BackColor = System.Drawing.Color.White;
                richTextBox1.ForeColor = System.Drawing.Color.Black;
                treeView1.BackColor = System.Drawing.Color.White;
                treeView1.ForeColor = System.Drawing.Color.Black;
                menuStrip1.BackColor = System.Drawing.Color.White;
                menuStrip1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                theme = true;
                themeLightToolStripMenuItem.Text = "Theme [Dark]";
                this.BackColor = System.Drawing.Color.Black;
                richTextBox1.BackColor = System.Drawing.Color.Black;
                richTextBox1.ForeColor = System.Drawing.Color.White;
                treeView1.BackColor = System.Drawing.Color.Black;
                treeView1.ForeColor = System.Drawing.Color.White;
                menuStrip1.BackColor = System.Drawing.Color.Gray;
                menuStrip1.ForeColor = System.Drawing.Color.White;
            }
        }

        private void deleteSelectedFileFolderToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (File.Exists ( treeView1.SelectedNode.Tag.ToString ( ) ))
            {
                File.Delete ( treeView1.SelectedNode.Tag.ToString ( ) );
                reftree ( );
            }
            if (Directory.Exists ( treeView1.SelectedNode.Tag.ToString ( ) ))
            {
                Directory.Delete ( treeView1.SelectedNode.Tag.ToString ( ) , true );
                reftree ( );
            }
        }

        private void userToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Login login = new Login ( );
            login.dir = dir;
            login.Show ( );
            this.Close ( );
        }

        private void openUserManagementMenuToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (userrole == "Admin")
            {
                x34AdminMenu x34AdminMenu = new x34AdminMenu ( );
                x34AdminMenu.dir = dir;
                x34AdminMenu.username = username;
                x34AdminMenu.userrole = userrole;
                x34AdminMenu.Show ( );
            }
        }
        #endregion Menustrip
        private void richTextBox1_TextChanged( object sender , EventArgs e )
        {
            if (!string.IsNullOrEmpty ( openfile ))
            {
                if (newopen)
                {
                    newopen = false;
                }
                else
                {
                    label1.Text = "File:*" + openfile;
                }
            }
        }
    }
}
