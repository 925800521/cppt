using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace CPPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string[] args)
        {
            // 检测是否是第一个实例
            if (SingletonController.IamFirst(new SingletonController.ReceiveDelegate(this.mReceive)))
            {

                // 如果是，则可以运行你所想要运行的程序

                InitializeComponent();
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("计时 " + i.ToString() + "秒");
                //    System.Threading.Thread.Sleep(1000);
                //}
            }
            else
            {

                // 发送命令行 args 到运行中的应用程序，然后结束第二个实例
                SingletonController.Send(args);
                Close();
                //Application.Exit();
            }











           
        }
        ~Form1()
        {
            SingletonController.Cleanup();
        }
 
        void mReceive(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                          mPassDrag(args[i]);

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //防止没有配置文件时的参数配置
            cbxFormat.SelectedIndex = 0;
            #region 读取参数文件,初始化参数

            if (System.IO.File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "CPPT.ini"))
            {
                cbxFormat.SelectedIndex = 0;
                using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "CPPT.ini"))
                {
                    String line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] tmpStr = line.Split('=');
                        if (tmpStr.Length == 2)
                        {//
                            if (tmpStr[0].ToLower() == "width") tbxWid.Text = tmpStr[1];
                            if (tmpStr[0].ToLower() == "height") tbxHei.Text = tmpStr[1];
                            if (tmpStr[0].ToLower() == "outputfolder") tbxOFolder.Text = tmpStr[1];
                            if (tmpStr[0].ToLower() == "outputforename") tbxOForeN.Text = tmpStr[1];
                            if (tmpStr[0].ToLower() == "outputpic" && tmpStr[1].ToLower() == "false") chkOutPic.Checked = false;
                            if (tmpStr[0].ToLower() == "outputtxt" && tmpStr[1].ToLower() == "false") chkOutTxt.Checked = false;
                            if (tmpStr[0].ToLower() == "placetxtwithpic" && tmpStr[1].ToLower() == "false") chkPlaceTxt.Checked = false;
                            if (tmpStr[0].ToLower() == "includingsubfolders" && tmpStr[1].ToLower() == "false") chkSubfolders.Checked = false;
                            if (tmpStr[0].ToLower() == "addcontextmenu" && tmpStr[1].ToLower() == "true") chkAddCon.Checked = true;
                            if (tmpStr[0].ToLower() == "outputformat" && cbxFormat.Items.Contains(tmpStr[1].ToUpper())) cbxFormat.SelectedItem = tmpStr[1].ToUpper();


                        }
                    }
                }



            }


            #endregion

            #region 初始化listview
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Scrollable = true;
            listView1.MultiSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Clickable;


             listView1.SmallImageList = imageList1;
            //cBxFormat.SelectedItem = "JPG";





            #endregion

            #region 添加事件处理

            this.listView1.GotFocus += new System.EventHandler(this.listView1_GotFocus);
            this.listView1.LostFocus += new System.EventHandler(this.listView1_LostFocus);




            //拖放

            foreach (Control ctlTmp in this.Controls)
            {
                ctlTmp.AllowDrop = true;
                ctlTmp.DragEnter += new System.Windows.Forms.DragEventHandler(this.mDoDragEnter);
                ctlTmp.DragDrop += new System.Windows.Forms.DragEventHandler(this.mDoDragDrop);
                //控件上的子控件
                foreach (Control ctlTmp1 in ctlTmp.Controls)
                {
                    ctlTmp1.AllowDrop = true;
                    ctlTmp1.DragEnter += new System.Windows.Forms.DragEventHandler(this.mDoDragEnter);
                    ctlTmp1.DragDrop += new System.Windows.Forms.DragEventHandler(this.mDoDragDrop);
                    

                }
            }


            #endregion

        }

        private void cbkOutPic_CheckedChanged(object sender, EventArgs e)
        {

         
            if (!chkOutPic.Checked)
            {
                panel2.Enabled = false;
                if (!chkOutTxt.Checked) chkOutTxt.Checked = true;
            }
            else panel2.Enabled = true ;

        }

        private void cbkOutTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkOutTxt.Checked && !chkOutPic.Checked) chkOutPic.Checked = true;
        }

        private void 定位输出的文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)  //只能选择一个文件的时候才能继续!!!
            {
                MessageBox.Show("请选择一个文件!");
                return;
            }




         
            foreach (ListViewItem a in listView1.SelectedItems)
            {

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "explorer.exe";//需要启动的程序名  
                FileInfo tmpfInfo = new FileInfo(a.SubItems[11].Text);

                string oFolder = null;
                #region                  获取输出目录
                if (a.SubItems[9].Text == "[源目录]")
                {
                    //该代码的变量范围已测试OK
                    oFolder = (new FileInfo(a.SubItems[11].Text)).Directory.FullName;
                }
                else
                    if (Directory.Exists(a.SubItems[9].Text) != true)
                    {
                        // return "输出目录不存在";
                        return;

                    }
                    else oFolder = a.SubItems[9].Text;
                #endregion


                string strBaseName;
                try
                {

                    strBaseName = tmpfInfo.Name.Remove(tmpfInfo.Name.Length - tmpfInfo.Extension.Length);// baseName需要
                }

                catch
                {
                    return;
                }
                if (a.SubItems[10].Text == "√")
                {
                    //文本与图片同目录
                    //输出目录a.SubItems[9].Text  
                    //tmpfInfo.Extension.Length带点后缀
                    if (File.Exists(oFolder + " \\" + strBaseName + " \\" + strBaseName + ".txt"))
                    {
                        p.StartInfo.Arguments = "/n, /select," + oFolder + " \\" + strBaseName + "\\" + strBaseName + ".txt";//启动参数        
                        p.Start();
                   }
                }
                else
                {
                  
                        //文本与图片不同目录
                    if(File.Exists(oFolder + " \\" + strBaseName + ".txt"))
                    {
                        p.StartInfo.Arguments = "/n, /select," + oFolder + " \\" + strBaseName + ".txt";//启动参数        
                        p.Start();
                    }
                }


            }
        }

        private void chkAddCon_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAddCon.Checked)
            //{
            //    //添加右键
            //    RegistryKey rk = Registry.ClassesRoot.OpenSubKey(".ppt", true);
            //    String s = (String)rk.GetValue("");//返回了默认值
            //    rk.Close();
            //    Registry.ClassesRoot.OpenSubKey(s + "\\shell", true).CreateSubKey("cppt").SetValue("", "CPPT");
            //    Registry.ClassesRoot.OpenSubKey(s + "\\shell\\cppt", true).CreateSubKey("command").SetValue("", "\"" + Application.ExecutablePath + "\" \"%l\"");






            //}
            //else
            //{
            //    //删除右键



            //    RegistryKey rk = Registry.ClassesRoot.OpenSubKey(".ppt", true);
            //    String s = (String)rk.GetValue("");//返回了默认值
            //    rk.Close();
            //    Registry.ClassesRoot.DeleteSubKeyTree(s + "\\shell\\cppt");



            //}
        }

        private void btnUseDefault_Click(object sender, EventArgs e)
        {
            tbxOForeN.Text = "CPPT";
            tbxWid.Text = "1024";
            tbxHei.Text = "768";
            tbxOFolder.Text = "[源目录]";
            cbxFormat.SelectedIndex = 0;
            chkAddCon.Checked = false;
            chkOutPic.Checked = true;
            chkOutTxt.Checked = true;
            chkPlaceTxt.Checked = true;
            chkSubfolders.Checked = true;
            chkSubfolders.Checked = true;
        }

        private void btnSaveCon_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "CPPT.ini"))
            {

                sw.WriteLine("Width=" + tbxWid.Text);
                sw.WriteLine("height=" + tbxHei.Text);
                sw.WriteLine("outputfolder=" + tbxOFolder.Text);
                sw.WriteLine("outputforename=" + tbxOForeN.Text);
                sw.WriteLine("outputformat=" + cbxFormat.SelectedItem);

                sw.WriteLine("placetxtwithpic=" + chkPlaceTxt.Checked);
                sw.WriteLine("addcontextmenu=" + chkAddCon.Checked);
                sw.WriteLine("outputpic=" + chkOutPic.Checked);
                sw.WriteLine("outputtxt=" + chkOutTxt.Checked);
                sw.WriteLine("includingsubfolders=" + chkSubfolders.Checked);


            }
        }

        private void btnUseOtherFolder_Click(object sender, EventArgs e)
        {
            //选择输出文件夹
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "请选择输出文件夹";
            dlg.ShowNewFolderButton = true;
            if (dlg.ShowDialog() == DialogResult.OK)
                tbxOFolder.Text = dlg.SelectedPath;
        }

        private void btnUseSameFolder_Click(object sender, EventArgs e)
        {
            tbxOFolder.Text = "[源目录]";
        }

        private void btnUse2Cur_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem a in listView1.SelectedItems)
            {


                if (chkOutTxt.Checked) a.SubItems[2].Text = "√"; else a.SubItems[2].Text = "×";
                if (chkOutPic.Checked) a.SubItems[3].Text = "√"; else a.SubItems[3].Text = "×";
                if (panel2.Enabled)
                {
                    a.SubItems[5].Text = cbxFormat.SelectedItem.ToString();//格式*
                    a.SubItems[6].Text = tbxWid.Text;//宽*
                    a.SubItems[7].Text = tbxHei.Text;//高*
                    a.SubItems[8].Text = tbxOForeN.Text;//前缀*
                    a.SubItems[9].Text = tbxOFolder.Text;//输出目录
                    if (chkPlaceTxt.Checked) a.SubItems[10].Text = "√"; else a.SubItems[10].Text = "×";//*
                }
                else
                {
                    a.SubItems[5].Text = "";//格式*
                    a.SubItems[6].Text = "";//宽*
                    a.SubItems[7].Text = "";//高*
                    a.SubItems[8].Text = "";//前缀*
                    a.SubItems[9].Text = tbxOFolder.Text;//输出目录
                    a.SubItems[10].Text = "×";//*

                }


            }




        }

        private void btnUse2All_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem a in listView1.Items)
            {


                if (chkOutTxt.Checked) a.SubItems[2].Text = "√"; else a.SubItems[2].Text = "×";
                if (chkOutPic.Checked) a.SubItems[3].Text = "√"; else a.SubItems[3].Text = "×";
                if (panel2.Enabled)
                {
                    a.SubItems[5].Text = cbxFormat.SelectedItem.ToString();//格式*
                    a.SubItems[6].Text = tbxWid.Text;//宽*
                    a.SubItems[7].Text = tbxHei.Text;//高*
                    a.SubItems[8].Text = tbxOForeN.Text;//前缀*
                    a.SubItems[9].Text = tbxOFolder.Text;//输出目录
                    if (chkPlaceTxt.Checked) a.SubItems[10].Text = "√"; else a.SubItems[10].Text = "×";//*
                }
                else
                {
                    a.SubItems[5].Text = "";//格式*
                    a.SubItems[6].Text = "";//宽*
                    a.SubItems[7].Text = "";//高*
                    a.SubItems[8].Text = "";//前缀*
                    a.SubItems[9].Text = tbxOFolder.Text;//输出目录
                    a.SubItems[10].Text = "×";//*chkPlaceTxt

                }


            }
        }

        private void mAddFile(string pptN)
        {
            if (tbxWid.Text == "") { tbxWid.Text = "1024"; }
            if (tbxHei.Text == "") { tbxHei.Text = "768"; }
            if (tbxOFolder.Text == "") { tbxOFolder.Text = "[源目录]"; }
            if (cbxFormat.SelectedItem == "") cbxFormat.SelectedIndex = 0;
            ListViewItem a;
            a = new ListViewItem();
            a.SubItems.Clear();
            FileInfo tmpfInfo = new FileInfo(pptN);
              a.ImageIndex = 0;

            a.SubItems[0].Text = tmpfInfo.Name;
            // tmpfInfo.Directory.Name 父目录
            //a.ImageIndex = 1;
            // a.SubItems.Add("等待");
            a.SubItems.Add("等待");//1状态
            if (chkOutTxt.Checked) a.SubItems.Add("√"); else a.SubItems.Add("×");
            if (chkOutPic.Checked)
            {
                a.SubItems.Add("√");               
                a.SubItems.Add(tmpfInfo.Length.ToString());//文件大小
                a.SubItems.Add(cbxFormat.SelectedItem.ToString());
                a.SubItems.Add(tbxWid.Text);
                a.SubItems.Add(tbxHei.Text);
                a.SubItems.Add(tbxOForeN.Text);
                a.SubItems.Add(tbxOFolder.Text);

                if (chkPlaceTxt.Checked) a.SubItems.Add("√"); else a.SubItems.Add("×");

            }
            else
            {
                a.SubItems.Add("×");
               
                a.SubItems.Add(tmpfInfo.Length.ToString());//文件大小
                a.SubItems.Add("");//cbxFormat.SelectedItem.ToString()
                a.SubItems.Add("");//wid
                a.SubItems.Add("");//tbxHei.Text
                a.SubItems.Add("");//tbxOForeN.Text
                a.SubItems.Add(tbxOFolder.Text);

                a.SubItems.Add("×");

            }


            a.SubItems.Add(tmpfInfo.FullName);

            listView1.Items.Add(a);


        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "幻灯片文件|*.ppt;*.pot";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                foreach (string s in dlg.FileNames)
                {
                    mAddFile(s);
                }
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "请选择幻灯片文件所在文件夹";
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;//请确认这样当真可行
            //DialogResult resDlg = MessageBox.Show("包括 " + dlg.SelectedPath + " 的子文件夹吗",
            //    "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);


            if (chkSubfolders.Checked)
            {
                mAddFolder(dlg.SelectedPath, SearchOption.AllDirectories);

            }
            else
            {
                mAddFolder(dlg.SelectedPath, SearchOption.TopDirectoryOnly);
            }


        }
        private void mAddFolder(string folderN, SearchOption opt)
        {

            try
            {
                string[] pptFiles = Directory.GetFiles(folderN, "*.ppt", opt);//一般在这里出错,这里已经开始搜索文件了

                foreach (string tmp in pptFiles)
                {
                    mAddFile(tmp);
                }
            }
            catch (Exception tErr)
            {
                //throw tErr;
                MessageBox.Show(tErr.Message);
            }

        }

        private void btnDelCur_Click(object sender, EventArgs e)
        {
            //listView1.SelectedItems

            foreach (ListViewItem a in listView1.SelectedItems)
            {
                a.Remove();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "help.chm"))
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "hh.exe";//需要启动的程序名       
                p.StartInfo.Arguments = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "help.chm";
                p.Start();

            }
            else
                MessageBox.Show("帮助文件丢失,请下载完整版本",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnSeePpt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)  //只能选择一个文件的时候才能继续!!!
            {
                MessageBox.Show("请选择一个文件!");
                return;
            }

            foreach (ListViewItem a in listView1.SelectedItems)
            {

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "explorer.exe";//需要启动的程序名       
                p.StartInfo.Arguments = "/n, /select," + a.SubItems[11].Text;//启动参数        
                p.Start();



            }
        }

        private void btnSeeOFolder_ButtonClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)  //只能选择一个文件的时候才能继续!!!
            {
                MessageBox.Show("请选择一个文件!");
                return;
            }


            foreach (ListViewItem a in listView1.SelectedItems)
            {


                if (a.SubItems[9].Text == "[源目录]")
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "explorer.exe";//需要启动的程序名       
                    p.StartInfo.Arguments = (new FileInfo(a.SubItems[11].Text)).Directory.FullName;//启动参数     /n, /select,   
                    p.Start();

                }

                else if (Directory.Exists(a.SubItems[9].Text) == true)
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "explorer.exe";//需要启动的程序名       
                    p.StartInfo.Arguments = a.SubItems[9].Text;//启动参数     /n, /select,   
                    p.Start();

                }

            }
        }



        #region 拖放方法
        private void mDoDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void mDoDragDrop(object sender, DragEventArgs e)
        {
            try
            {

                for (int i = 0; i < ((System.Array)e.Data.GetData(DataFormats.FileDrop)).Length; i++)
                {
                    mPassDrag(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(i).ToString());

                }


            }
            catch { }
        }

        private void mPassDrag(string Fname)
        {

            if (Directory.Exists(Fname))
                if (chkSubfolders.Checked)
                    mAddFolder(Fname, SearchOption.AllDirectories);//添加文件夹函数
                else

                    mAddFolder(Fname, SearchOption.TopDirectoryOnly);
            else
                if (File.Exists(Fname)) mAddFile(Fname);//添加文件函数


        }
        #endregion


        private void listView1_GotFocus(object sender, EventArgs e)
        {
            //颜色恢复
            //gotfocus指"listview"失去焦点后,某项重获焦点,SelectedIndexChanged之前
            foreach (ListViewItem a in listView1.SelectedItems)
            {
                //  MessageBox.Show (a.SubItems[0].Text );

                a.BackColor = Color.White;
                //a.SubItems[1].Text = "ggg";

            }


        }
        private void listView1_LostFocus(object sender, EventArgs e)
        {
            //颜色凸显
            foreach (ListViewItem a in listView1.SelectedItems)
            {
                //a.Tag = a.BackColor;
                a.BackColor = Color.Yellow;
            }
            // MessageBox.Show("LostFocus");


        }

        private void 定位输出的图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             if (listView1.SelectedItems.Count != 1)  //只能选择一个文件的时候才能继续!!!
             {
                 MessageBox.Show("请选择一个文件!");
                 return;
             }


            foreach (ListViewItem a in listView1.SelectedItems)
            {

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "explorer.exe";//需要启动的程序名  
                FileInfo tmpfInfo = new FileInfo(a.SubItems[11].Text);

                string oFolder = null;
                #region                  获取输出目录
                if (a.SubItems[9].Text == "[源目录]")
                {
                    //该代码的变量范围已测试OK
                    oFolder = (new FileInfo(a.SubItems[11].Text)).Directory.FullName;
                }
                else
                    if (Directory.Exists(a.SubItems[9].Text) != true)
                    {
                        // return "输出目录不存在";
                        return;

                    }
                    else oFolder = a.SubItems[9].Text;
                #endregion


                string strBaseName;
                try
                {

                    strBaseName = tmpfInfo.Name.Remove(tmpfInfo.Name.Length - tmpfInfo.Extension.Length);// baseName需要
                }

                catch
                {
                    return;
                }

                if(Directory.Exists(oFolder + " \\" + strBaseName ))
                    {
                        p.StartInfo.Arguments = "/n, /select," + oFolder + " \\" + strBaseName  ;//启动参数        
                        p.Start();
                   }

            }
        }

        private void btnProced_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("你还没添加文件!");
                return;
            }


            //新建窗口,传递listview过去以被访问
            Proced  frmPro = new Proced (this);
            try
            {
                this.Visible = false;
                 
                if (DialogResult.OK == frmPro.ShowDialog(this)) 
                {
                    this.Visible=true;
                    MessageBox.Show("转换完成");
                }
               

            }
            finally
            {

                frmPro.Dispose();
                this.Visible = true;
                
                

            }




        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about frmAbout = new about ();
            try
            {
                
                frmAbout.ShowDialog(this);


            }
            finally
            {

                frmAbout.Dispose();
                

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            //MessageBox.Show("SelectedIndexChanged");
            //当失去焦点后,再获得焦点,且是相同的项,同样会触发该事件
            // if (listView1.SelectedItems.Count != 1) return;

            foreach (ListViewItem a in listView1.SelectedItems)
            {
               
               
                if (a.SubItems[2].Text == "√") chkOutTxt.Checked = true; else chkOutTxt.Checked = false;
                if (a.SubItems[3].Text == "√") chkOutPic.Checked = true; else chkOutPic.Checked = false;
                cbxFormat.SelectedItem = a.SubItems[5].Text;
                tbxWid.Text = a.SubItems[6].Text;
                tbxHei .Text = a.SubItems[7].Text;
                tbxOForeN.Text = a.SubItems[8].Text;
                tbxOFolder.Text = a.SubItems[9].Text;
                if (a.SubItems[10].Text == "√") chkPlaceTxt.Checked = true; else chkPlaceTxt.Checked = false;


            }

        }



    }
}
