using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace x34
{
    public partial class x34Editor : Form
    {
        public string dir = "C:";
        internal string[] info;
        public x34Editor()
        {
            InitializeComponent();
        }

        private void x34Editor_Load(object sender, EventArgs e)
        {
            info = Generate.options(dir,false);
            workspacesToolStripMenuItem.Text += info[0];
            testbasesToolStripMenuItem.Text += info[1];
            testsToolStripMenuItem.Text += info[2];
            richTextBox1.Lines = Generate.gettree(dir).ToArray();
            loadfolder(dir);
        }
        #region Treeview
        public void loadfolder(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            fileload(Dir, tds);
            childloadfolder(Dir, tds);
        }

        private void childloadfolder(string dir, TreeNode td)
        {

            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                fileload(subdirectory, tds);
                childloadfolder(subdirectory, tds);
            }
        }

        private void fileload(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {

            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);
            //if (theNode != null & theNode.Tag != null)
            //{
            //    if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
            //        this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
            //}
            //else
            //{
            //    this.toolTip1.SetToolTip(this.treeView1, "");
            //}
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox1.Text = e.Node.Tag.ToString();
        }
        #endregion Treeview
    }
}
