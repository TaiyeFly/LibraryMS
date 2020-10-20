using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cqimo
{
    public partial class manabook : Sunny.UI.UIForm
    {
        public string yhm;
        public manabook(string n)
        {
            InitializeComponent();
            yhm = n;
            
        }

        public manabook()
        {
        }

        private void 新增用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
            manaread addreader = new manaread();
            //将当前子窗体设置成非顶级控件
            addreader.TopLevel = false;
            //设置窗体最大化
            addreader.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            addreader.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            addreader.Parent = this;
            //显示窗体
            addreader.Show();


        }

        private void manabook_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uiLabel2.Text = yhm;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OpenFrom(Form objFrm)
        {
            //将当前子窗体设置成非顶级控件
            objFrm.TopLevel = false;
            //设置窗体最大化
            objFrm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            objFrm.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            objFrm.Dock = DockStyle.Fill;
            panel3.Controls.Add(objFrm);
            //显示窗体
            objFrm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFrom(new manaread());
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_SizeChanged(object sender, EventArgs e)
        {
           // OpenFrom(new manaread());
        }

        private void iconButton1_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton1.BackColor =Color.Turquoise;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void iconButton6_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton6.BackColor = Color.Turquoise;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            
            
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
