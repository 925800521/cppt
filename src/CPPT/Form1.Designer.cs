namespace CPPT
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFile = new System.Windows.Forms.ToolStripButton();
            this.btnAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProced = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelCur = new System.Windows.Forms.ToolStripButton();
            this.btnDelAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSeePpt = new System.Windows.Forms.ToolStripButton();
            this.btnSeeOFolder = new System.Windows.Forms.ToolStripSplitButton();
            this.定位输出的文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定位输出的图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.chkAddCon = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUseOtherFolder = new System.Windows.Forms.Button();
            this.btnUseSameFolder = new System.Windows.Forms.Button();
            this.tbxOFolder = new System.Windows.Forms.TextBox();
            this.btnUseDefault = new System.Windows.Forms.Button();
            this.btnSaveCon = new System.Windows.Forms.Button();
            this.btnUse2All = new System.Windows.Forms.Button();
            this.btnUse2Cur = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxOForeN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPlaceTxt = new System.Windows.Forms.CheckBox();
            this.tbxWid = new System.Windows.Forms.TextBox();
            this.tbxHei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOutTxt = new System.Windows.Forms.CheckBox();
            this.chkOutPic = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFile,
            this.btnAddFolder,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnProced,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnDelCur,
            this.btnDelAll,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnSeePpt,
            this.btnSeeOFolder,
            this.btnAbout,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1246, 66);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFile
            // 
            this.btnAddFile.AutoSize = false;
            this.btnAddFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFile.Image")));
            this.btnAddFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(60, 60);
            this.btnAddFile.Text = "添加文件";
            this.btnAddFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.AutoSize = false;
            this.btnAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFolder.Image")));
            this.btnAddFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(60, 60);
            this.btnAddFolder.Text = "添加目录";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 66);
            // 
            // btnProced
            // 
            this.btnProced.AutoSize = false;
            this.btnProced.Image = ((System.Drawing.Image)(resources.GetObject("btnProced.Image")));
            this.btnProced.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProced.Name = "btnProced";
            this.btnProced.Size = new System.Drawing.Size(60, 60);
            this.btnProced.Text = "开始转换";
            this.btnProced.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProced.Click += new System.EventHandler(this.btnProced_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 66);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 66);
            // 
            // btnDelCur
            // 
            this.btnDelCur.AutoSize = false;
            this.btnDelCur.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCur.Image")));
            this.btnDelCur.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelCur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelCur.Name = "btnDelCur";
            this.btnDelCur.Size = new System.Drawing.Size(60, 60);
            this.btnDelCur.Text = "移除所选";
            this.btnDelCur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelCur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelCur.Click += new System.EventHandler(this.btnDelCur_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.AutoSize = false;
            this.btnDelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAll.Image")));
            this.btnDelAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(60, 60);
            this.btnDelAll.Text = "移除全部";
            this.btnDelAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 66);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 66);
            // 
            // btnSeePpt
            // 
            this.btnSeePpt.AutoSize = false;
            this.btnSeePpt.Image = ((System.Drawing.Image)(resources.GetObject("btnSeePpt.Image")));
            this.btnSeePpt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSeePpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeePpt.Name = "btnSeePpt";
            this.btnSeePpt.Size = new System.Drawing.Size(60, 60);
            this.btnSeePpt.Text = "看源文件";
            this.btnSeePpt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeePpt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeePpt.Click += new System.EventHandler(this.btnSeePpt_Click);
            // 
            // btnSeeOFolder
            // 
            this.btnSeeOFolder.AutoSize = false;
            this.btnSeeOFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.定位输出的文本ToolStripMenuItem,
            this.定位输出的图片ToolStripMenuItem});
            this.btnSeeOFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeOFolder.Image")));
            this.btnSeeOFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSeeOFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeeOFolder.Name = "btnSeeOFolder";
            this.btnSeeOFolder.Size = new System.Drawing.Size(65, 60);
            this.btnSeeOFolder.Text = "输出目录";
            this.btnSeeOFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeeOFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeeOFolder.ButtonClick += new System.EventHandler(this.btnSeeOFolder_ButtonClick);
            // 
            // 定位输出的文本ToolStripMenuItem
            // 
            this.定位输出的文本ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("定位输出的文本ToolStripMenuItem.Image")));
            this.定位输出的文本ToolStripMenuItem.Name = "定位输出的文本ToolStripMenuItem";
            this.定位输出的文本ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.定位输出的文本ToolStripMenuItem.Text = "定位输出的文本";
            this.定位输出的文本ToolStripMenuItem.Click += new System.EventHandler(this.定位输出的文本ToolStripMenuItem_Click);
            // 
            // 定位输出的图片ToolStripMenuItem
            // 
            this.定位输出的图片ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("定位输出的图片ToolStripMenuItem.Image")));
            this.定位输出的图片ToolStripMenuItem.Name = "定位输出的图片ToolStripMenuItem";
            this.定位输出的图片ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.定位输出的图片ToolStripMenuItem.Text = "定位输出的图片";
            this.定位输出的图片ToolStripMenuItem.Click += new System.EventHandler(this.定位输出的图片ToolStripMenuItem_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.AutoSize = false;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 60);
            this.btnAbout.Text = " 关于";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHelp.AutoSize = false;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 60);
            this.btnHelp.Text = " 帮助 ";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.chkSubfolders);
            this.panel1.Controls.Add(this.chkAddCon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnUseOtherFolder);
            this.panel1.Controls.Add(this.btnUseSameFolder);
            this.panel1.Controls.Add(this.tbxOFolder);
            this.panel1.Controls.Add(this.btnUseDefault);
            this.panel1.Controls.Add(this.btnSaveCon);
            this.panel1.Controls.Add(this.btnUse2All);
            this.panel1.Controls.Add(this.btnUse2Cur);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 102);
            this.panel1.TabIndex = 1;
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Checked = true;
            this.chkSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubfolders.Location = new System.Drawing.Point(869, 52);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(144, 16);
            this.chkSubfolders.TabIndex = 10;
            this.chkSubfolders.Text = "添加目录时包括子目录";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // chkAddCon
            // 
            this.chkAddCon.AutoSize = true;
            this.chkAddCon.Location = new System.Drawing.Point(869, 74);
            this.chkAddCon.Name = "chkAddCon";
            this.chkAddCon.Size = new System.Drawing.Size(96, 16);
            this.chkAddCon.TabIndex = 7;
            this.chkAddCon.Text = "添加右键菜单";
            this.chkAddCon.UseVisualStyleBackColor = true;
            this.chkAddCon.Visible = false;
            this.chkAddCon.CheckedChanged += new System.EventHandler(this.chkAddCon_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "输出目录:";
            // 
            // btnUseOtherFolder
            // 
            this.btnUseOtherFolder.Location = new System.Drawing.Point(952, 12);
            this.btnUseOtherFolder.Name = "btnUseOtherFolder";
            this.btnUseOtherFolder.Size = new System.Drawing.Size(105, 28);
            this.btnUseOtherFolder.TabIndex = 4;
            this.btnUseOtherFolder.Text = "使用其他目录";
            this.btnUseOtherFolder.UseVisualStyleBackColor = true;
            this.btnUseOtherFolder.Click += new System.EventHandler(this.btnUseOtherFolder_Click);
            // 
            // btnUseSameFolder
            // 
            this.btnUseSameFolder.Location = new System.Drawing.Point(869, 12);
            this.btnUseSameFolder.Name = "btnUseSameFolder";
            this.btnUseSameFolder.Size = new System.Drawing.Size(77, 28);
            this.btnUseSameFolder.TabIndex = 3;
            this.btnUseSameFolder.Text = "使用源目录";
            this.btnUseSameFolder.UseVisualStyleBackColor = true;
            this.btnUseSameFolder.Click += new System.EventHandler(this.btnUseSameFolder_Click);
            // 
            // tbxOFolder
            // 
            this.tbxOFolder.Location = new System.Drawing.Point(559, 16);
            this.tbxOFolder.Name = "tbxOFolder";
            this.tbxOFolder.Size = new System.Drawing.Size(304, 21);
            this.tbxOFolder.TabIndex = 2;
            this.tbxOFolder.Text = "[源目录]";
            // 
            // btnUseDefault
            // 
            this.btnUseDefault.Location = new System.Drawing.Point(1157, 11);
            this.btnUseDefault.Name = "btnUseDefault";
            this.btnUseDefault.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUseDefault.Size = new System.Drawing.Size(77, 38);
            this.btnUseDefault.TabIndex = 8;
            this.btnUseDefault.Text = "默认参数";
            this.btnUseDefault.UseVisualStyleBackColor = true;
            this.btnUseDefault.Click += new System.EventHandler(this.btnUseDefault_Click);
            // 
            // btnSaveCon
            // 
            this.btnSaveCon.Location = new System.Drawing.Point(1157, 55);
            this.btnSaveCon.Name = "btnSaveCon";
            this.btnSaveCon.Size = new System.Drawing.Size(77, 38);
            this.btnSaveCon.TabIndex = 9;
            this.btnSaveCon.Text = "保存参数";
            this.btnSaveCon.UseVisualStyleBackColor = true;
            this.btnSaveCon.Click += new System.EventHandler(this.btnSaveCon_Click);
            // 
            // btnUse2All
            // 
            this.btnUse2All.Location = new System.Drawing.Point(746, 52);
            this.btnUse2All.Name = "btnUse2All";
            this.btnUse2All.Size = new System.Drawing.Size(117, 38);
            this.btnUse2All.TabIndex = 6;
            this.btnUse2All.Text = "应用参数到所有";
            this.btnUse2All.UseVisualStyleBackColor = true;
            this.btnUse2All.Click += new System.EventHandler(this.btnUse2All_Click);
            // 
            // btnUse2Cur
            // 
            this.btnUse2Cur.Location = new System.Drawing.Point(559, 52);
            this.btnUse2Cur.Name = "btnUse2Cur";
            this.btnUse2Cur.Size = new System.Drawing.Size(117, 38);
            this.btnUse2Cur.TabIndex = 5;
            this.btnUse2Cur.Text = "应用参数到所选";
            this.btnUse2Cur.UseVisualStyleBackColor = true;
            this.btnUse2Cur.Click += new System.EventHandler(this.btnUse2Cur_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxOForeN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.chkPlaceTxt);
            this.panel2.Controls.Add(this.tbxWid);
            this.panel2.Controls.Add(this.tbxHei);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxFormat);
            this.panel2.Location = new System.Drawing.Point(91, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 77);
            this.panel2.TabIndex = 1;
            // 
            // tbxOForeN
            // 
            this.tbxOForeN.Location = new System.Drawing.Point(73, 47);
            this.tbxOForeN.Name = "tbxOForeN";
            this.tbxOForeN.Size = new System.Drawing.Size(304, 21);
            this.tbxOForeN.TabIndex = 8;
            this.tbxOForeN.Text = "CPPT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "添加前缀:";
            // 
            // chkPlaceTxt
            // 
            this.chkPlaceTxt.AutoSize = true;
            this.chkPlaceTxt.Checked = true;
            this.chkPlaceTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaceTxt.Location = new System.Drawing.Point(269, 17);
            this.chkPlaceTxt.Name = "chkPlaceTxt";
            this.chkPlaceTxt.Size = new System.Drawing.Size(120, 16);
            this.chkPlaceTxt.TabIndex = 6;
            this.chkPlaceTxt.Text = "文本放在图片目录";
            this.chkPlaceTxt.UseVisualStyleBackColor = true;
            // 
            // tbxWid
            // 
            this.tbxWid.Location = new System.Drawing.Point(134, 15);
            this.tbxWid.Name = "tbxWid";
            this.tbxWid.Size = new System.Drawing.Size(44, 21);
            this.tbxWid.TabIndex = 3;
            this.tbxWid.Text = "1024";
            // 
            // tbxHei
            // 
            this.tbxHei.Location = new System.Drawing.Point(217, 15);
            this.tbxHei.Name = "tbxHei";
            this.tbxHei.Size = new System.Drawing.Size(44, 21);
            this.tbxHei.TabIndex = 5;
            this.tbxHei.Text = "768";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "宽:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "高:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "格式:";
            // 
            // cbxFormat
            // 
            this.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP",
            "GIF"});
            this.cbxFormat.Location = new System.Drawing.Point(50, 15);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(45, 20);
            this.cbxFormat.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOutTxt);
            this.groupBox1.Controls.Add(this.chkOutPic);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出选项";
            // 
            // chkOutTxt
            // 
            this.chkOutTxt.AutoSize = true;
            this.chkOutTxt.Checked = true;
            this.chkOutTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutTxt.Location = new System.Drawing.Point(6, 42);
            this.chkOutTxt.Name = "chkOutTxt";
            this.chkOutTxt.Size = new System.Drawing.Size(72, 16);
            this.chkOutTxt.TabIndex = 1;
            this.chkOutTxt.Text = "输出文本";
            this.chkOutTxt.UseVisualStyleBackColor = true;
            this.chkOutTxt.CheckedChanged += new System.EventHandler(this.cbkOutTxt_CheckedChanged);
            // 
            // chkOutPic
            // 
            this.chkOutPic.AutoSize = true;
            this.chkOutPic.Checked = true;
            this.chkOutPic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutPic.Location = new System.Drawing.Point(6, 20);
            this.chkOutPic.Name = "chkOutPic";
            this.chkOutPic.Size = new System.Drawing.Size(72, 16);
            this.chkOutPic.TabIndex = 0;
            this.chkOutPic.Text = "输出图片";
            this.chkOutPic.UseVisualStyleBackColor = true;
            this.chkOutPic.CheckedChanged += new System.EventHandler(this.cbkOutPic_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 477);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1246, 477);
            this.listView1.TabIndex = 1;
            this.listView1.Tag = "9999";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "状态";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文本";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "图片";
            this.columnHeader4.Width = 41;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "文件大小";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "输出格式";
            this.columnHeader6.Width = 64;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "宽";
            this.columnHeader7.Width = 39;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "高";
            this.columnHeader8.Width = 41;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "添加前缀";
            this.columnHeader9.Width = 72;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "输出目录";
            this.columnHeader10.Width = 249;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "文本放在图片目录";
            this.columnHeader11.Width = 40;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "源文件全名";
            this.columnHeader12.Width = 366;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hourglass_调整大小.png");
            this.imageList1.Images.SetKeyName(1, "clean_调整大小.png");
            this.imageList1.Images.SetKeyName(2, "error (2)_调整大小.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPPT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOutTxt;
        private System.Windows.Forms.CheckBox chkOutPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.CheckBox chkPlaceTxt;
        private System.Windows.Forms.TextBox tbxOForeN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxWid;
        private System.Windows.Forms.TextBox tbxHei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOFolder;
        private System.Windows.Forms.Button btnUseDefault;
        private System.Windows.Forms.Button btnSaveCon;
        private System.Windows.Forms.Button btnUse2All;
        private System.Windows.Forms.Button btnUse2Cur;
        private System.Windows.Forms.Button btnUseOtherFolder;
        private System.Windows.Forms.Button btnUseSameFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAddCon;
        private System.Windows.Forms.ToolStripButton btnAddFile;
        private System.Windows.Forms.ToolStripButton btnAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDelCur;
        private System.Windows.Forms.ToolStripButton btnDelAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton btnSeeOFolder;
        private System.Windows.Forms.ToolStripMenuItem 定位输出的文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定位输出的图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSeePpt;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnProced;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

