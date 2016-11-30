using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faith
{
    public partial class Form1 : Form
    {
        private FileOrganization File;
        private int numPanel = 0;
        private bool isReadyPanel = true;
        private bool canbeUpdate = true;
        public Form1()
        {
            File = new FileOrganization();
            InitializeComponent();

            Console.WriteLine(File.Header);
            File.InitializeHeader();
        }

        private void document_Click(object sender, EventArgs e)
        {
            MainButton_Click(sender);
        }

        private void digital_Click(object sender, EventArgs e)
        {
            MainButton_Click(sender);
        }

        private void MainButton_Click(object sender)
        {
            if (sender is Button)
            {
                Button clicked = (Button) sender;
                if (searchView == false)
                {
                    SearchView();
                }
                mainmenu.Text = clicked.Text;
                    File.currentpath = @"C:\Users\turtle\Desktop";
                    string[] temp = File.LookFile(clicked.Text);
                currentPath_TextChanged();

                this.tableLayoutPanel1.SuspendLayout();
                    this.tableLayoutPanel1.Controls.Clear();
                    this.tableLayoutPanel1.RowStyles.Clear();
                    this.tableLayoutPanel1.RowCount = 0;
                    numPanel = 0;
                    foreach (var check in temp)
                    {
                        if (check.Length > check.LastIndexOf(@"\") + 1)
                        {
                            
                            
                            createcheckbox(check);
                       }

                    }
                    this.tableLayoutPanel1.ResumeLayout();
               // }

            }
        }

        private void desktop_Click(object sender, EventArgs e)
        {
            MainButton_Click(sender);
        }

        private void apps_Click(object sender, EventArgs e)
        {
            MainButton_Click(sender);
        }

        private void other_Click(object sender, EventArgs e)
        {
            MainButton_Click(sender);
        }

        private void tableRow_Hover(object sender, EventArgs e)
        {
            if (isReadyPanel == true)
            {
                tableLayoutPanel1.SuspendLayout();
                int Rownum = 0;
                MyPanel sub = findsender(sender);
                Rownum = tableLayoutPanel1.GetRow(sub);
                
                

                tableLayoutPanel1.RowStyles[Rownum] = new RowStyle(SizeType.Absolute, 100F);
                isReadyPanel = false;
                tableLayoutPanel1.ResumeLayout();

            }
        }

        private MyPanel findsender(object sender)
        {
            MyPanel sub = null;
            if (sender is TableLayoutPanel)
            {
                TableLayoutPanel clicked = (TableLayoutPanel)sender;
                if (clicked.Parent.Parent is MyPanel)
                {
                    sub = (MyPanel)clicked.Parent.Parent;
                }
            }
            else if (sender is CheckBox)
            {
                CheckBox clicked = (CheckBox)sender;

                if (clicked.Parent.Parent is MyPanel)
                {
                    sub = (MyPanel)clicked.Parent.Parent;
                }
            }
            else if (sender is MyPanel)
            {
                MyPanel clicked = (MyPanel)sender;
                sub = clicked;
            }
            else
            {
                Label clicked = (Label)sender;

                if (clicked.Parent.Parent is MyPanel)
                {
                    sub = (MyPanel)clicked.Parent.Parent;
                }
                
            }
            return sub;
        }

        private void tableRow_Leave(object sender, EventArgs args)
        {
            if (isReadyPanel == false)
            {
                canbeUpdate = true;
                tableLayoutPanel1.SuspendLayout();
                int Rownum = 0;
                Point rec = new Point(0, 0);
                
                MyPanel sub = findsender(sender);
                Rownum = tableLayoutPanel1.GetRow(sub);
                if (sub != null)
                {


                    int Top = sub.PointToScreen(Point.Empty).Y;
                    int Bottom = sub.PointToScreen(Point.Empty).Y + sub.Size.Height;
                    int left = sub.PointToScreen(Point.Empty).X;
                    int right = sub.PointToScreen(Point.Empty).X + sub.Size.Width;

                    //for (int i = 0; i < 10000; i++)
                    //{
                    System.Threading.Thread.Sleep(100);
                        if ((right) <= MousePosition.X
                            || left >= MousePosition.X
                            || Top >= MousePosition.Y
                            || Bottom <= MousePosition.Y)

                        {
                            //Console.WriteLine("\n" + Top + ", " + Bottom + ", " + left + ", " + right + ", " +
                            //                  Form1.MousePosition.Y +
                            //                  ", " + Form1.MousePosition.X);
                            //Console.WriteLine(tableLayoutPanel1.RowStyles.Count);
                            if (tableLayoutPanel1.RowStyles.Count> Rownum )
                            {
                                tableLayoutPanel1.RowStyles[Rownum] = new RowStyle(SizeType.Absolute, 60F);
                            }
                            // break;
                        }

                        //Console.WriteLine(tableLayoutPanel1.RowCount + ",  " + Rownum);
                    isReadyPanel = true;
                    tableLayoutPanel1.ResumeLayout();


                   // }
                }
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            MyPanel currentPanel = findsender(sender);
            currentPanel.temp.Checked = !currentPanel.temp.Checked;
        }

        private void panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           

           
            //isReadyPanel = false;
           MyPanel doubleClickMyPanel = findsender(sender);
          string dive = doubleClickMyPanel.view2.GetControlFromPosition(0, 0).Text;

            if (Directory.Exists(File.currentpath +"/"+ dive))
            {
                Console.Write(dive);
                String[] look = File.LookFile(dive);
                currentPath_TextChanged();
                Console.WriteLine(File.currentpath);

                //FileInfo f = new FileInfo(@"C: \Users\turtle\Desktop\Documents\Resume and Cover Letter\Hao Luo.docx");
                //if (f.Exists)
                //{
                //    Console.WriteLine("check12");
                //    using (FileStream c = f.Open(FileMode.Open))
                //    {

                //        byte[] b = new byte[1024];
                //        UTF8Encoding temp = new UTF8Encoding(true);

                //    }
                //}


                if (look != null)
                {


                    this.tableLayoutPanel1.SuspendLayout();
                    this.tableLayoutPanel1.Controls.Clear();
                    this.tableLayoutPanel1.RowStyles.Clear();

                    this.tableLayoutPanel1.RowCount = 0;
                    numPanel = 0;
                    foreach (var check in look)
                    {
                        if (check.Length > check.LastIndexOf(@"\") + 1)
                        {


                            createcheckbox(check);
                        }

                    }
                    this.tableLayoutPanel1.AutoScroll = true;
                    this.tableLayoutPanel1.VerticalScroll.Value = 0;
                    this.tableLayoutPanel1.ResumeLayout();
                }

            }
           
            
           else {
                Console.WriteLine(File.currentpath);
                dive = File.currentpath +"/"+ dive;
                if ((System.IO.File.Exists(dive)))
                {
                    System.Diagnostics.Process.Start(dive);
                }
            }
        }



    private void treePanel_Hover(object send, EventArgs e)
        {

           // Console.Write("check");
            tree.Show();
          //  splitContainer4.Panel2.BackgroundImage = Image.FromFile(@"Images\basic images\arrow_close.png");
            for (int num = tree.Width; num < 500; num++)
            {
              tree.Size = new Size(num, tree.Height);
               
                   // Console.WriteLine(0.14*num);
              //  System.Threading.Thread.Sleep();
               // Console.WriteLine("check");
            }
        }

        private void treePanel_Leave(object send, EventArgs e)
        {
            //tree.Hide();

            for (int num =500; num > 10; num--)
            {
                tree.Size = new Size(num, tree.Height);



                //  System.Threading.Thread.Sleep(10);
            }
            //Console.WriteLine("check22");
        }

        private string searchSubString(string s)
        {
            if (s.Length <50)
            {
                return s;
               
            }
            
                return searchSubString(s.Substring(s.IndexOf(@"\")+1));
            

        }


        public void currentPath_TextChanged()
        {
            navigationTextBox.Text = searchSubString(File.currentpath);
        }

        private Boolean checkBackEnable()
        {
            if (File.back.Count == 1)
            {
                this.back.Enabled = false;
                this.back.BackColor = Color.LightSlateGray;
                return false;
            }
            else
            {
                this.back.Enabled = true;
                this.back.BackColor = Color.WhiteSmoke;
                return true;
            }
        }

        private Boolean checkForwardEnable()
        {
            if (File.forward.Count == 0)
            {
                this.Forward.Enabled = false;
                this.Forward.BackColor = Color.LightSlateGray;
                return false;
            }
            else
            {
                this.Forward.Enabled = true;
                this.Forward.BackColor = Color.WhiteSmoke;
                return true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Console.Write(checkBackEnable());
            if (checkBackEnable())
            {
                this.Forward.Enabled = true;
                File.Back();
                string temp = File.currentpath.Substring(File.currentpath.LastIndexOf(@"\") + 1);
                File.currentpath = File.currentpath.Substring(0, File.currentpath.LastIndexOf(@"\"));

                string[] look = File.LookFile(temp);
                currentPath_TextChanged();
                Console.WriteLine(look!=null);
               if (look != null)
                {
                    
                   // this.tableLayoutPanel1.SuspendLayout();
                    this.tableLayoutPanel1.Controls.Clear();
                    this.tableLayoutPanel1.RowStyles.Clear();
                    this.tableLayoutPanel1.RowCount = 0;
                    numPanel = 0;
                    foreach (var check in look)
                    {
                        if (check.Length > check.LastIndexOf(@"\") + 1)
                        {
                            createcheckbox(check);
                        }

                    }
                    this.tableLayoutPanel1.ResumeLayout();
                }
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            Console.Write(checkForwardEnable());
            if (checkForwardEnable())
            {
                
                File.Foward();
                string temp = File.currentpath.Substring(File.currentpath.LastIndexOf(@"\") + 1);
                File.currentpath = File.currentpath.Substring(0, File.currentpath.LastIndexOf(@"\"));

                string[] look = File.LookFile(temp);
                currentPath_TextChanged();
                Console.WriteLine(look != null);
                if (look != null)
                {

                    // this.tableLayoutPanel1.SuspendLayout();
                    this.tableLayoutPanel1.Controls.Clear();
                    this.tableLayoutPanel1.RowStyles.Clear();
                    this.tableLayoutPanel1.RowCount = 0;
                    numPanel = 0;
                    foreach (var check in look)
                    {
                        if (check.Length > check.LastIndexOf(@"\") + 1)
                        {
                            createcheckbox(check);
                        }

                    }
                    this.tableLayoutPanel1.ResumeLayout();
                }
            }
        }
    }
}
