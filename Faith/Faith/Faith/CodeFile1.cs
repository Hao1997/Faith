using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Faith { 


    public class FileOrganization
    {
        public string[] Header { get; set; } 
        public string currentpath { get; set; }
        public Stack<string> back { get; set; } = new Stack<string>();
        public Stack<string> forward { get; set; } = new Stack<string>();
        public List<string> Bookmarks { get; set; } = new List<string>();        
        public Form f = new Form();

        public FileOrganization()
        {
            currentpath = @"C: \Users\turtle\Desktop";
            Header = new string[]{ "Documents", "Digital", "Desktop", "Apps", "Other" };
        }

        public string[] InitializeHeader ()
        {
            
            List<string> paths = new List<string>();
            string[] temp = new string[Header.Length];
            foreach (var head in Header)
            {
                temp = Directory.GetFileSystemEntries(@"C: \Users\turtle\Desktop", head, SearchOption.TopDirectoryOnly);
                for (int i = 0; i < temp.Length; i++)
                    if (Directory.Exists(temp[i]))
                        paths.Add(temp[i]);
            }
            foreach (var t in paths)
                    {
                        Console.WriteLine(t);
                    }
            return temp;
        }

        
        public string[] LookFile(string name)
        {
            Console.WriteLine(currentpath);
            StringBuilder build = new StringBuilder(this.currentpath);
            build.Append(@"\" + name);
            Console.WriteLine(Directory.Exists(build.ToString()));
            if (Directory.Exists(build.ToString()))
            {
                currentpath = build.ToString();    
                this.back.Push(this.currentpath);
                Console.WriteLine(this.currentpath);
                string[] temp = Directory.GetFileSystemEntries(currentpath);


                foreach (var dir in temp)
                {
                    //Console.WriteLine(dir);
                }
                return temp;
            }
            else return null;
        }

        public void Back()
        {
            if (back.Count != 0)
            {
                string temp = back.Pop();
                string act = back.Pop();
                //back.Push(temp);
                forward.Push(currentpath);
                currentpath = act;
            }
        }

        public void Foward()
        {
            if (forward.Count != 0)
            {
                string temp = forward.Pop();
                back.Push(currentpath);
                currentpath = temp;
            }
        }

        public void AddBookmarks(string path)
        {
            Bookmarks.Add(path);
        }

        public void RemoveBookmarks(string path)
        {
            Bookmarks.Remove(path);
        }


    }


    public class MyPanel : Control
    {


        public TableLayoutPanel view2 = new TableLayoutPanel();
        public TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        public Label label = new Label();
        public CheckBox temp = new CheckBox();


        public MyPanel(string name)


        {
            SuspendLayout();
            tableLayoutPanel2.SuspendLayout();

            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.temp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.view2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 85);
            this.tableLayoutPanel2.TabIndex = 0;
           // this.tableLayoutPanel2.BackColor = Color.Aqua;
            DirectoryInfo d = new DirectoryInfo(name);

            temp.SuspendLayout();
            temp.CheckAlign = ContentAlignment.MiddleCenter;
            temp.Name = d.Name.ToString();
            temp.Size = new System.Drawing.Size(87, 37);
            temp.TabIndex = 0;

            view2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            //view2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            view2.Controls.Add(new Label() { Text = d.Name.ToString(), AutoSize = true, Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold) }, 0, 0);
            view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            view2.Dock = DockStyle.Fill;

            view2.Controls.Add(new Label() { Text = d.LastAccessTime.ToString(), AutoSize = true }, 0, 1);
            //if (d.)
            //{
            //    FileInfo info = new FileInfo(name);
            //    view2.Controls.Add(new Label() { Text = info.Length.ToString(), AutoSize = true }, 0, 2);
            //}
            //string imageChose = null;
            Image folder = null;
            if (temp.Name.Contains("."))
            {
                string[] excel = {"xls", "xlt", "xlm", "xlsx", "xlsm", "xltx", "xltm", "xlsb", "xll", "xlw"};
                string[] powerpoint = {"ppt", "pot", "pps", "pptx", "pptm", "ppam", "ppsx", "ppsm", "sldx", "sldm"};
                string imageChose = temp.Name.Substring(temp.Name.LastIndexOf(".") + 1);
                Console.WriteLine(imageChose);
                if (imageChose == "docx" |
                    imageChose == "docm" |
                    imageChose == "dotx" |
                    imageChose == "dotm" |
                    imageChose == "docb")
                {
                    folder =
                        Image.FromFile(
                            @"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\word.png");

                }

                else if (imageChose == "pdf")
                {
                    folder =
                        Image.FromFile(
                            @"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\pdf.png");

                }
                else if (imageChose == "mp3" |
                         imageChose == "m4p" |
                         imageChose == "msv" |
                         imageChose == "wma" |
                         imageChose == "webm" |
                         imageChose == "ra"
                    )
                {
                    folder =
    Image.FromFile(
        @"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\music.png");

                }else if (imageChose == "one")
                {
                    Image.FromFile(
    @"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\onenote.png");

                }else if (powerpoint.Contains(imageChose))
                {
                    Image.FromFile(
@"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\powerpoint.png");

                }else if (excel.Contains(imageChose))
                {
                    Image.FromFile(
@"C: \Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\excel.png");

                }
            }

            if(folder == null)
            {
                 folder =
                    Image.FromFile(
                        @"C:\Users\turtle\Desktop\Documents\Software Projects\Completed\Faith\Images\folder\folder.png");
            }

            label.Image = folder;
            //label.Padding = new Padding(30);
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.ImageAlign = ContentAlignment.MiddleCenter;
            temp.Dock = DockStyle.Fill;

            

            this.Controls.Add(tableLayoutPanel2);
            ResumeLayout();
            tableLayoutPanel2.ResumeLayout(true);
            

        }
    }





}
