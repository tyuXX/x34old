using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace x34
{
    public partial class Login : Form
    {
        public string dir = "C:";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(dir + @"\x34-Core\users\" + textBox1.Text))
            {
                string[] str = File.ReadAllLines(dir + @"\x34-Core\users\" + textBox1.Text);
                if (str[0] == maskedTextBox1.Text)
                {
                    x34Editor x34Editor = new x34Editor();
                    x34Editor.dir = dir;
                    x34Editor.username = textBox1.Text;
                    x34Editor.userrole = str[2];
                    x34Editor.Show();
                    this.Close();
                }
                else
                {
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                }
            }
            else
            {
                textBox1.Clear();
                maskedTextBox1.Clear();
            }
        }
    }
}
