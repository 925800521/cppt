using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Office.Core; //必选
using PowerPoint;//必选
using System.IO;


namespace CPPT
{
    public partial class Proced : Form
    {
        public Proced()
        {
            InitializeComponent();
        }


        public Proced(Form1 frmTmp)
        {
            InitializeComponent();
            frmForm1 = frmTmp;
        }

        Form1 frmForm1;
        Thread thdTh1;
        bool bolMouseDown = false;
        Point mousePoint, formPoint;
        public ApplicationClass ac;



        private void Proced_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            thdTh1 = new Thread(new ThreadStart(ListCon));
            thdTh1.Start();
            notifyIcon1.Icon = frmForm1.Icon;
            notifyIcon1.Visible = true;
           

        }
        private void ListCon()
        {


            allProgress.Maximum = frmForm1.listView1.Items.Count;//总进度条长度
            ac = new ApplicationClass();

             #region   遍历item
            foreach (ListViewItem tmpA in frmForm1.listView1.Items)
            {

                if (tmpA.SubItems[1].Text!="完成")//判断是否转换完成的文件
                {
                    try
                    {
                         #region 变量准备
                        // string tmpBack = PPTCon(tmpA.SubItems[0].Text, tmpA.SubItems[1].Text, tmpA.SubItems[2].Text, tmpA.SubItems[3].Text, tmpA.SubItems[4].Text, tmpA.SubItems[5].Text, tmpA.SubItems[6].Text);
                        // PPTCon(string pptFileN,string oFormat, string oWid, string oHei, string oForeN, string oFolder, string pptFileFN)
                        string pptFileN = tmpA.SubItems[0].Text;
                        string oFormat = tmpA.SubItems[5].Text;
                        int oWid=100, oHei=100;
                        try
                        {
                            //如果只输出文本,这两项则为空,所以用try
                           oWid = Convert.ToInt32(tmpA.SubItems[6].Text);
                            oHei = Convert.ToInt32(tmpA.SubItems[7].Text);
                        }
                        catch
                        {
                            if (tmpA.SubItems[3].Text == "√") continue;
                        }          //在这里应当增加一个判断跳转的语句,若输出图片又转换失败,则continue迭代

                        string oForeN = tmpA.SubItems[8].Text;//前缀
                        string oFolder = tmpA.SubItems[9].Text;
                        string pptFileFN = tmpA.SubItems[11].Text;

                        FileInfo tmpfInfo = new FileInfo(pptFileFN);//获取FileInfo

                       

                        if (oFolder == "[源目录]")
                        {
                            //该代码的变量范围已测试OK
                            oFolder = tmpfInfo.Directory.FullName;
                        }
                        else
                            if (Directory.Exists(oFolder) != true)
                            {
                                // return "输出目录不存在";
                                continue;

                            }

                        string strBaseName;//下面获取扩展名

                        try
                        {

                            strBaseName = tmpfInfo.Name.Remove(tmpfInfo.Name.Length - tmpfInfo.Extension.Length);//这里有可能出错,例如无扩展名的文件名在这里处理会出错
                        }

                        catch (Exception tErr1)
                        {
                            tmpA.SubItems[1].Text = tErr1.Message;   //输出错误信息
                            tmpA.ImageIndex = 2;
                           continue ;//出错就开始循环新的迭代
                        }





                        allLabel.Text = "正在转换: " + pptFileN;
                        

                        Presentation p = ac.Presentations.Open(pptFileFN, MsoTriState.msoCTrue, MsoTriState.msoCTrue, MsoTriState.msoFalse);

                        sglProgress.Maximum = p.Slides.Count;     //单个文件进度条长度

                        string newOFolder = Path.Combine(oFolder, strBaseName);//合并生成新的输出目录

                        

                        int intConutLen = p.Slides.Count.ToString().Length;//用来智能命名
#endregion  
                        //如果文本与图片同时输出,则合并转换过程
                       
                        if (tmpA.SubItems[2].Text == "√")//文本条件
                        {

                            if (tmpA.SubItems[3].Text == "√")//图片条件
                            {
                                 #region       同时输出图片与文本

                                Directory.CreateDirectory(newOFolder);//若存在也不会出错的


                                string strPpTxt=null;
                                for (int i = 1; i <= p.Slides.Count; i++)
                                {
                                    sglLabel.Text = "正在转换第" + i.ToString() + "页," + "共" + p.Slides.Count.ToString() + "页";                                                                                  
                                      p.Slides[i].Export(newOFolder + "\\" + oForeN + i.ToString().PadLeft(intConutLen, '0') + "." + oFormat, oFormat, oWid, oHei);

                                    //  for 读取文本
                                   
                                     for (int shapeC = 1; shapeC <= p.Slides[i].Shapes.Count; shapeC++)
                                            {
                                                try
                                                {
                                                    strPpTxt += p.Slides[i].Shapes[shapeC].TextFrame.TextRange.Text +  "\r\n";
                                                }
                                                catch
                                                {
                                                    continue;
                                                }

                                            }
                                     strPpTxt += "\r\n" + "===================P:" + i.ToString() + "\r\n" + "\r\n";

                                      //单个文件的进度     
                                    sglProgress.Value = i;
                                }

                                //根据位置写入文本
                                if (tmpA.SubItems[10].Text == "√")
                                {
                                    //将文本放在 newOFolder

                                    using (StreamWriter sw = new StreamWriter(newOFolder + "\\" + strBaseName + ".txt"))//newOFolder绝对不会是根目录
                                    {
                                        sw.Write(strPpTxt);
                                       
                                    }


                                }
                                else
                                {
                                    //将文本放在图片目录OFolder

                                    using (StreamWriter sw = new StreamWriter(Path.Combine(oFolder, strBaseName + ".txt")))//Path.Combine(oFolder, strBaseName + ".txt")
                                    {
                                        sw.Write(strPpTxt);

                                    }



                                }

                                #endregion       
                            }
                            else
                            {
                                  #region 只输出文本

                                 string strPpTxt=null;
                                for (int i = 1; i <= p.Slides.Count; i++)
                                {
                                            sglLabel.Text = "正在转换第" + i.ToString() + "页," + "共" + p.Slides.Count.ToString() + "页";                                                                                  
                                           

                                            //  for 读取文本
                                           
                                             for (int shapeC = 1; shapeC <= p.Slides[i].Shapes.Count; shapeC++)
                                                    { 
                                                        

                                                         try
                                                         {
                                                             strPpTxt += p.Slides[i].Shapes[shapeC].TextFrame.TextRange.Text + "\r\n";
                                                         }
                                                         catch
                                                         {
                                                             continue;
                                                         }



                                                    }
                                             strPpTxt += "\r\n" + "===================P:" + i.ToString() + "\r\n" + "\r\n";


                                              //单个文件的进度     
                                            sglProgress.Value = i;






                            }
                                //根据位置写入文本,文本位置是OFolder
                                using (StreamWriter sw = new StreamWriter(Path.Combine(oFolder, strBaseName + ".txt")))//Path.Combine(oFolder, strBaseName + ".txt")
                                {

                                    sw.Write(strPpTxt);
                                }
                               

                                #endregion       
                            }
                        }
                        else 
                        {
                           #region 只输出图片
                            
                            Directory.CreateDirectory(newOFolder);//若存在也不会出错的

                            for (int i = 1; i <= p.Slides.Count; i++)
                            {
                                sglLabel.Text = "正在转换第" + i.ToString() + "页," + "共" + p.Slides.Count.ToString() + "页";
                                p.Slides[i].Export(newOFolder + "\\" + oForeN + i.ToString().PadLeft(intConutLen, '0') + "." + oFormat, oFormat, oWid, oHei);


                                //单个文件的进度     
                                sglProgress.Value = i;
                            }

                             #endregion   
                        }

                        p.Close();

                       
                        tmpA.SubItems[1].Text = "完成";
                        tmpA.ImageIndex = 1;

                    }
                    catch (Exception tErr)
                    {
                        //MessageBox.Show(tErr.Message);
                        //输出错误信息
                        tmpA.ImageIndex = 2;
                         tmpA.SubItems[1].Text=tErr.Message;   //输出错误信息
                         continue;
                    }


                }
                allProgress.Value +=  1;
                //总文件进度条的进度
                  

            }
             #endregion 
            ac.Quit();//退出PowerPoint进程,貌似始终都系退唔出


            this.DialogResult = DialogResult.OK;




        }




        private void btnShowHideMain_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
          
           


            if (DialogResult.Yes == MessageBox.Show("真的取消?", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2))
            {
                try
                {
                   // frmForm1.Visible = true;
                    while (thdTh1.IsAlive)//如果暂停了再按取消,线程是挂起的,这有效吗?
                    {

                        ac.Quit();
                        thdTh1.Abort(); //这个操作不是同步的,不是即时的

                        Thread.Sleep(1200);
                    }

                }
                catch { }
                finally
                {
                    //等待结束使用循环!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    this.DialogResult = DialogResult.Cancel;

                }
            }










        }

        #region 移动窗体的设置
        private void Proced_MouseDown(object sender, MouseEventArgs e)
        {
            bolMouseDown = true;
            mousePoint = Control.MousePosition;
            formPoint = this.Location;

        }

        private void Proced_MouseUp(object sender, MouseEventArgs e)
        {
            bolMouseDown = false;

        }

        private void Proced_MouseMove(object sender, MouseEventArgs e)
        {
            if (bolMouseDown)
            {

                if (e.Button == MouseButtons.Left)
                {
                    Point mousePos = Control.MousePosition;

                    this.Location = new Point(mousePos.X - mousePoint.X + formPoint.X, mousePos.Y - mousePoint.Y + formPoint.Y);
                }
            }
        }
        #endregion



        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
           
             if( this.WindowState ==FormWindowState.Normal)
               this.WindowState = FormWindowState.Minimized;
            else
               this.WindowState = FormWindowState.Normal;

            //notifyIcon1.Visible = false;
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {

           
          
            this.WindowState = FormWindowState.Minimized;
           
            




        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.Text = allLabel.Text; 
        }



    }
}
