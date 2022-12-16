using System;
using System.Collections.Generic;
using System.IO;

namespace x34
{
    static public class Generate
    {
        static public void newuser(string dir = "C:",string passcode = "1234",string name = "NewUser")
        {
            
        }
        static public void x34(string dir = "C:", int workspaces = 4, int testspaces = 4, int tests = 4, bool regen = false,bool direct = false)
        {
            if (!direct)
            {
                dir += @"\x34-Files";
            }
            if (regen)
            {
                if (!Directory.Exists( dir ))
                {
                    Directory.CreateDirectory( dir );
                }if (!Directory.Exists( dir + @"\x34-Core\per" ))
                {
                    Directory.CreateDirectory( dir + @"\x34-Core\per" );
                }if (!Directory.Exists( dir + @"\x34-Core\users" ))
                {
                    Directory.CreateDirectory( dir + @"\x34-Core\users" );
                }if (!Directory.Exists( dir + @"\x34-Core\users" ))
                {
                    Directory.CreateDirectory( dir + @"\x34-Core\users" );
                }if (!Directory.Exists( dir + @"\Workspaces" ))
                {
                    Directory.CreateDirectory( dir + @"\Workspaces" );
                }if (!Directory.Exists( dir + @"\Workspaces" ))
                {
                    Directory.CreateDirectory( dir + @"\Workspaces" );
                }if (!Directory.Exists( dir + @"\Programs" ))
                {
                    Directory.CreateDirectory( dir + @"\Programs" );
                }if (!Directory.Exists( dir + @"\Extra" ))
                {
                    Directory.CreateDirectory( dir + @"\Extra" );
                }if (!Directory.Exists( dir + @"\Programs\Qr" ))
                {
                    Directory.CreateDirectory( dir + @"\Programs\Qr" );
                }if (!Directory.Exists( dir + @"\Programs\Qr\Scanner" ))
                {
                    Directory.CreateDirectory( dir + @"\Programs\Qr\Scanner" );
                }if (!Directory.Exists( dir + @"\Programs\Qr\Reader" ))
                {
                    Directory.CreateDirectory( dir + @"\Programs\Qr\Reader" );
                }
                for (int i = workspaces; i > 0; i--)
                {
                    workspace( dir + @"\Workspaces\", i, testspaces, tests ,true);
                }
                options( dir + @"\x34-Core\per", true, workspaces, testspaces, tests );
                File.WriteAllLines( dir + @"\x34-Core\per\dir", gettree( dir ) );
            }
            else
            {
                Directory.CreateDirectory(dir);
                Directory.CreateDirectory(dir + @"\x34-Core\per");
                Directory.CreateDirectory(dir + @"\x34-Core\users");
                Directory.CreateDirectory(dir + @"\Workspaces");
                Directory.CreateDirectory(dir + @"\Programs");
                Directory.CreateDirectory(dir + @"\Extra");
                Directory.CreateDirectory(dir + @"\Programs\Qr");
                Directory.CreateDirectory(dir + @"\Programs\Qr\Scanner");
                Directory.CreateDirectory(dir + @"\Programs\Qr\Reader");
                for (int i = workspaces; i > 0; i--)
                {
                    workspace(dir + @"\Workspaces\", i, testspaces, tests);
                }
                options(dir + @"\x34-Core\per", true, workspaces, testspaces, tests);
                File.WriteAllLines(dir + @"\x34-Core\per\dir", gettree(dir));
            }
        }
        static public void workspace(string dir = @"C:\x34-Files\Workspaces\",int num = 1,int testspaces = 4, int tests = 4,bool regen = false)
        {
            if (regen)
            {
                if (!Directory.Exists( dir + "Workspace" + num ))
                {
                    Directory.CreateDirectory( dir + "Workspace" + num );
                }
                for (int i = testspaces; i > 0; i--)
                {
                    testspace( dir + "Workspace" + num, i, tests,true);
                }
            }
            else
            {
                Directory.CreateDirectory( dir + "Workspace" + num );
                for (int i = testspaces; i > 0; i--)
                {
                    testspace( dir + "Workspace" + num, i, tests );
                }
            }
        }
        static public void testspace(string dir = @"C:\x34-Files\Workspaces\Workspace",int num = 1, int tests = 4,bool regen = false)
        {
            if (regen)
            {
                string dirn = dir + @"\Testspace" + num + @"\";
                if (!Directory.Exists(dirn))
                {
                    Directory.CreateDirectory( dirn );
                }
                if (!File.Exists( dirn + "readme.txt" ))
                {
                    File.WriteAllText( dirn + "readme.txt", "This is the testspace " + num + " of the x34 system please do not touch the automaticly generated files if you do not know what you are doing." );
                }
                if (!File.Exists( dirn + "lock" ))
                {
                    File.WriteAllText( dirn + "lock", "false" );
                }
                for (int i = tests; i > 0; i--)
                {
                    string dirnt = dirn + "Test" + i + @"\";
                    if (!Directory.Exists( dirnt ))
                    {
                        Directory.CreateDirectory( dirnt );
                    }
                    if (!Directory.Exists( dirnt + "Files" ))
                    {
                        Directory.CreateDirectory( dirnt + "Files" );
                    }
                    if (!Directory.Exists( dirnt + @"Files\P1" ))
                    {
                        Directory.CreateDirectory( dirnt + @"Files\P1" );
                    }
                    if (!Directory.Exists( dirnt + @"Files\P2" ))
                    {
                        Directory.CreateDirectory( dirnt + @"Files\P2" );
                    }
                    if (!File.Exists( dirnt + "result" ))
                    {
                        File.WriteAllText( dirnt + "result", "ongoing\nPossible results for manual use:ongoing,fail,success,todo" );
                    }
                    if (!File.Exists( dirnt + @"Files\test.cmd" ))
                    {
                        File.WriteAllText( dirnt + @"Files\test.cmd", "@rem test file" );
                    }
                }
            }
            else
            {
                string dirn = dir + @"\Testspace" + num + @"\";
                Directory.CreateDirectory( dirn );
                File.WriteAllText( dirn + "readme.txt", "This is the testspace " + num + " of the x34 system please do not touch the automaticly generated filen if you do not know what you are doing." );
                File.WriteAllText( dirn + "lock", "false" );
                for (int i = tests; i > 0; i--)
                {
                    string dirnt = dirn + "Test" + i + @"\";
                    Directory.CreateDirectory( dirnt );
                    Directory.CreateDirectory( dirnt + "Files" );
                    Directory.CreateDirectory( dirnt + @"Files\P1" );
                    Directory.CreateDirectory( dirnt + @"Files\P2" );
                    File.WriteAllText( dirnt + "result", "ongoing\nPossible results for manual use:ongoing,fail,success,todo" );
                    File.WriteAllText( dirnt + @"Files\test.cmd", "@rem test file" );
                }
            }
        }
        static public string[] options(string dir = @"C:\x34-Files\x34-Core\per", bool write = true, int workspaces = 4, int testspaces = 4, int tests = 4)
        {
            if (write)
            {
                string[] wrt = new string[3] { workspaces.ToString(), testspaces.ToString(), tests.ToString() };
                File.WriteAllLines(dir + @"\options.per",wrt);
                return null;
            }
            else
            {
                return File.ReadAllLines(dir + @"\x34-Core\per\options.per");
            }
        }
        static public List<string> gettree(string dir = @"C:\x34-Files\")
        {
            List<string> strlist = new List<string> {"Starts:" };
            DirectoryInfo dirinfo = new DirectoryInfo(dir);
            foreach (DirectoryInfo din in dirinfo.GetDirectories("*", SearchOption.AllDirectories))
            {
                strlist.Add(din.FullName);
            }
            return strlist;
        }
    }
}
