using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;

namespace Faith
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
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Documents");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Digital");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Desktop");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Apps");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Other");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Other = new System.Windows.Forms.Button();
            this.apps = new System.Windows.Forms.Button();
            this.Digital = new System.Windows.Forms.Button();
            this.desktop = new System.Windows.Forms.Button();
            this.Documents = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.navigationTextBox = new System.Windows.Forms.TextBox();
            this.Forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.recent = new System.Windows.Forms.Button();
            this.popular = new System.Windows.Forms.Button();
            this.bookMark = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(this.Other);
            this.splitContainer1.Panel1.Controls.Add(this.apps);
            this.splitContainer1.Panel1.Controls.Add(this.Digital);
            this.splitContainer1.Panel1.Controls.Add(this.desktop);
            this.splitContainer1.Panel1.Controls.Add(this.Documents);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.navigationTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.Forward);
            this.splitContainer1.Panel1.Controls.Add(this.back);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(773, 445);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(611, 72);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(100, 27);
            this.Other.TabIndex = 10;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.other_Click);
            // 
            // apps
            // 
            this.apps.Location = new System.Drawing.Point(466, 72);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(100, 27);
            this.apps.TabIndex = 9;
            this.apps.Text = "Apps";
            this.apps.UseVisualStyleBackColor = true;
            this.apps.Click += new System.EventHandler(this.apps_Click);
            // 
            // Digital
            // 
            this.Digital.Location = new System.Drawing.Point(196, 72);
            this.Digital.Name = "Digital";
            this.Digital.Size = new System.Drawing.Size(100, 27);
            this.Digital.TabIndex = 8;
            this.Digital.Text = "Digital";
            this.Digital.UseVisualStyleBackColor = true;
            this.Digital.Click += new System.EventHandler(this.digital_Click);
            // 
            // desktop
            // 
            this.desktop.Location = new System.Drawing.Point(331, 72);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(100, 27);
            this.desktop.TabIndex = 7;
            this.desktop.Text = "Desktop";
            this.desktop.UseVisualStyleBackColor = true;
            this.desktop.Click += new System.EventHandler(this.desktop_Click);
            // 
            // Documents
            // 
            this.Documents.Location = new System.Drawing.Point(61, 72);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(100, 27);
            this.Documents.TabIndex = 5;
            this.Documents.Text = "Documents";
            this.Documents.UseVisualStyleBackColor = true;
            this.Documents.Click += new System.EventHandler(this.document_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(564, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(167, 21);
            this.searchTextBox.TabIndex = 3;
            // 
            // navigationTextBox
            // 
            this.navigationTextBox.Location = new System.Drawing.Point(122, 27);
            this.navigationTextBox.Name = "navigationTextBox";
            this.navigationTextBox.Size = new System.Drawing.Size(337, 21);
            this.navigationTextBox.TabIndex = 2;
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.SystemColors.Menu;
            this.Forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Forward.BackgroundImage")));
            this.Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Forward.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Forward.Location = new System.Drawing.Point(63, 27);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(41, 26);
            this.Forward.TabIndex = 0;
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Menu;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.back.Location = new System.Drawing.Point(16, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(41, 26);
            this.back.TabIndex = 0;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel1.Controls.Add(this.tree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(773, 336);
            this.splitContainer2.SplitterDistance = 273;
            this.splitContainer2.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.Color.DarkRed;
            this.tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            treeNode1.Name = "Documents";
            treeNode1.Text = "Documents";
            treeNode2.Name = "Digital";
            treeNode2.Text = "Digital";
            treeNode3.Name = "Desktop";
            treeNode3.Text = "Desktop";
            treeNode4.Name = "Apps";
            treeNode4.Text = "Apps";
            treeNode5.Name = "Other";
            treeNode5.Text = "Other";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            foreach (TreeNode s in this.tree.Nodes)
            {
                treeHelp(@"C: \Users\turtle\Desktop\" +s.Text, s);
            }
            this.tree.Size = new System.Drawing.Size(161, 336);
            this.tree.TabIndex = 0;
            this.tree.MouseLeave += new System.EventHandler(this.treePanel_Leave);
            this.tree.MouseHover += new System.EventHandler(this.treePanel_Hover);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer3.Panel1.Controls.Add(this.recent);
            this.splitContainer3.Panel1.Controls.Add(this.popular);
            this.splitContainer3.Panel1.Controls.Add(this.bookMark);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.mainmenu);
            this.splitContainer3.Size = new System.Drawing.Size(496, 336);
            this.splitContainer3.SplitterDistance = 74;
            this.splitContainer3.TabIndex = 0;
            // 
            // recent
            // 
            this.recent.Location = new System.Drawing.Point(26, 23);
            this.recent.Name = "recent";
            this.recent.Size = new System.Drawing.Size(81, 36);
            this.recent.TabIndex = 2;
            this.recent.Text = "Recent";
            this.recent.UseVisualStyleBackColor = true;
            // 
            // popular
            // 
            this.popular.Location = new System.Drawing.Point(262, 23);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(81, 36);
            this.popular.TabIndex = 1;
            this.popular.Text = "Popular";
            this.popular.UseVisualStyleBackColor = true;
            // 
            // bookMark
            // 
            this.bookMark.Location = new System.Drawing.Point(146, 23);
            this.bookMark.Name = "bookMark";
            this.bookMark.Size = new System.Drawing.Size(81, 36);
            this.bookMark.TabIndex = 0;
            this.bookMark.Text = "Bookmark";
            this.bookMark.UseVisualStyleBackColor = true;
            // 
            // mainmenu
            // 
            this.mainmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainmenu.Controls.Add(this.tableLayoutPanel1);
            this.mainmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainmenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(496, 258);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.TabStop = false;
            this.mainmenu.Text = "Bookmark";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 465);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeftLayout = true;
            this.Text = "Hope";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.mainmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void treeHelp(string start, TreeNode parent)
        {
            string[] s = Directory.GetFileSystemEntries(start);
            foreach (string p  in s)
            {
               string name =  p.Substring(p.LastIndexOf(@"\") + 1);
               if (System.IO.File.Exists(p))
                {
                    TreeNode temp = new TreeNode(name);
                    temp.Name = name;
                    temp.Text = name;
                    parent.Nodes.Add(temp);
                }else if (System.IO.Directory.Exists(p))
                {
                   TreeNode temp = new TreeNode(name);
                    temp.Name = name;
                    temp.Text = name;
                
                    parent.Nodes.Add(temp);
                    treeHelp(p, temp);
                }
            }
        }



       /* private void treeEstablish()
        {
            Boolean finished = false;    
        }*/

        private void createcheckbox(string name )
        {

            this.tableLayoutPanel1.SuspendLayout();
            
            //TableLayoutPanel view2 = new TableLayoutPanel();
           // view2.SuspendLayout();
           // DirectoryInfo d = new DirectoryInfo(name);
           // System.Windows.Forms.CheckBox temp = new System.Windows.Forms.CheckBox();
           // temp.CheckAlign = ContentAlignment.MiddleCenter;
           // temp.Name = d.Name.ToString();
           // temp.Size = new System.Drawing.Size(87, 37);
           // temp.TabIndex = 0;

           // view2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
           // view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
           // //view2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
           //view2.Controls.Add(new Label() {Text = d.Name.ToString(), AutoSize = true, /*Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold)*/ }, 0, 0);
           // view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
           // view2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));

           
           // view2.Controls.Add(new Label() {Text= d.LastAccessTime.ToString(), AutoSize =true}, 0 ,1);
           // if (d.Attributes.Equals(File))
           // {
           //     FileInfo info = new FileInfo(name);
           //     view2.Controls.Add(new Label() {Text = info.Length.ToString(), AutoSize = true}, 0 ,2);
           // }
           // Image folder =
           //    Image.FromFile(@"C: \Users\turtle\Desktop\Documents\Software Projects\Progress\Faith\Images\folder\folder.png");
            
           // Label label = new Label();
           // label.Image = folder;
           // //label.Padding = new Padding(30);
           // label.AutoSize = false;
           // label.Dock = DockStyle.Fill;
           // label.ImageAlign = ContentAlignment.MiddleCenter;
           // temp.Dock = DockStyle.Fill;
           MyPanel panel = new MyPanel(name);
            panellist.Add(panel);
           panel.Dock = DockStyle.Fill;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(panel , 0, tableLayoutPanel1.RowCount);
           

           // Panel front = new Panel();
           // tableLayoutPanel1.Controls.Add(front, 0, tableLayoutPanel1.RowCount);
           // this.tableLayoutPanel1.SetColumnSpan(front, 3);
           // front.Location = temp.Location;
           // front.Size = new Size(tableLayoutPanel1.Width, 60);
           //front.Visible = false;
            //front.BackColor = Color.Black;
       
            tableLayoutPanel1.RowCount++;
            Label black = new Label();
            black.BackColor = Color.Black;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5));
           // this.tableLayoutPanel1.SetColumnSpan(black, 3);
            this.tableLayoutPanel1.Controls.Add(black);
            black.Dock = DockStyle.Top;
            this.tableLayoutPanel1.RowCount++;





            //panel.front.MouseEnter += new EventHandler(tableRow_Hover);
            //front.MouseLeave +=new EventHandler(tableRow_Leave);
            //view2.Dock = DockStyle.Fill;
            panel.view2.MouseEnter += new EventHandler(tableRow_Hover);
            panel.view2.MouseLeave += new EventHandler(tableRow_Leave);
            panel.view2.Click += new EventHandler(panel_Click);
            panel.view2.MouseDoubleClick += new MouseEventHandler(panel_MouseDoubleClick);

            panel.label.MouseEnter += new EventHandler(tableRow_Hover);
            panel.label.MouseLeave += new EventHandler(tableRow_Leave);
            panel.label.Click += new EventHandler(panel_Click);
            panel.label.MouseDoubleClick += new MouseEventHandler(panel_MouseDoubleClick);


            panel.temp.MouseEnter += new EventHandler(tableRow_Hover);
            panel.temp.MouseLeave += new EventHandler(tableRow_Leave);
            panel.temp.MouseDoubleClick += new MouseEventHandler(panel_MouseDoubleClick);


            panel.MouseEnter += new EventHandler(tableRow_Hover);
            panel.MouseLeave += new EventHandler(tableRow_Leave);
            panel.Click += new EventHandler(panel_Click);
            panel.MouseDoubleClick += new MouseEventHandler(panel_MouseDoubleClick);


            this.tableLayoutPanel1.ResumeLayout();
        }


        private void SearchView()
        {

            char[] alphebelt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Panel alphaPanel = new System.Windows.Forms.Panel();
            alphaPanel.SuspendLayout();

            SplitContainer splitContainer4 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer4)).BeginInit();
            splitContainer4.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer2.Panel2.Controls.Remove(splitContainer3);
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer4.Dock = DockStyle.Fill;
           // splitContainer4.BackColor = Color.White;
           // splitContainer4.Panel1.SuspendLayout();
            
            splitContainer4.Location = new System.Drawing.Point(0, 0);
            splitContainer4.Dock = DockStyle.Fill;
            double result = ((double)445 / 510) * splitContainer4.Width;

            splitContainer4.SplitterDistance =(int) Math.Round(result,0);
            System.Console.Write(result);
            splitContainer4.Size = new System.Drawing.Size(splitContainer2.Panel2.Width - 10, splitContainer2.Panel2.Height -10);
            
            // 
            

          
        



            //this.splitContainer3.Location = new System.Drawing.Point(0,0);
            //bookMark.Hide();
            //popular.Hide();
            //recent.Hide();
            //this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 326);
            //this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            //this.tableLayoutPanel1.HorizontalScroll.Visible = false;
            //this.mainmenu.Size = new System.Drawing.Size(450, 352);
            //this.mainmenu.Location = new System.Drawing.Point(3, 3);


            // 
            // alphapanel
            // 

            alphaPanel.Location = new System.Drawing.Point(456, 0);
            alphaPanel.Name = "alphapanel";
            alphaPanel.TabIndex = 4;
            alphaPanel.ResumeLayout(false);
            //alphaPanel.AutoSize = true;
            alphaPanel.AutoScroll = true;

            alphaPanel.VerticalScroll.Maximum = 400;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            alphaPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);

            alphaPanel.HorizontalScroll.Visible = false;

            splitContainer4.Panel1.Controls.Add(mainmenu);
            splitContainer4.Panel2.Controls.Add(alphaPanel);

            mainmenu.Dock = DockStyle.Fill;
            alphaPanel.Dock = DockStyle.Fill;
            for (int i = 0; i < alphebelt.Length; i++)
            {
                StringBuilder buttonName = new StringBuilder(alphebelt[i]).Append("button");
                string temp = buttonName.ToString();
                Button Alpha = new System.Windows.Forms.Button();
                // 
                // Alpha
                // 
                alphaPanel.Controls.Add(Alpha);
                Alpha.Location = new System.Drawing.Point(0, 18*i + 3);
                Alpha.Name = "Alpha";
                Alpha.Size = new System.Drawing.Size(40, 18);
                Alpha.TabIndex = 0;
                Alpha.Text = alphebelt[i].ToString();
                Alpha.UseVisualStyleBackColor = true;
                searchView = true;
                
            }
            alphaPanel.ResumeLayout();
            splitContainer4.ResumeLayout();
            splitContainer4.Panel1.ResumeLayout();
            splitContainer4.Panel2.ResumeLayout();
        }

#region
        
        private bool searchView { get; set; } = false;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox navigationTextBox;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button apps;
        private System.Windows.Forms.Button Digital;
        private System.Windows.Forms.Button desktop;
        private System.Windows.Forms.Button Documents;
        private System.Windows.Forms.Button recent;
        private System.Windows.Forms.Button popular;
        private System.Windows.Forms.Button bookMark;
        private System.Windows.Forms.GroupBox mainmenu;
        private SplitContainer splitContainer3;
        private Button Other;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private ArrayList panellist = new ArrayList();

        public object F { get; private set; }
#endregion
    }

 
}

