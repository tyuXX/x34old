using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x34
{
    public partial class x34 : Form
    {
        public x34()
        {
            InitializeComponent();
        }

        private void x34_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x34Generator x34Generator = new x34Generator();
            x34Generator.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderbrowse.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderbrowse.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                x34Editor x34Editor = new x34Editor();
                x34Editor.dir = textBox1.Text;
                x34Editor.Show();
            }
        }
    }
}
