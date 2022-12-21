using System;
using System.Windows.Forms;

namespace x34
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new x34() );
        }
    }
}
