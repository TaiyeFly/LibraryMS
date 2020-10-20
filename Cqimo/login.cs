using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CCWin;
using Sunny.UI;

namespace Cqimo
{
    public partial class login : Sunny.UI.UIForm
    {
        
        string con = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }
        public string TextBoxValue { 
             
            set { textBox1.Text = value; }
            get
            {
                return textBox1.Text;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals("") || textBox2.Text.Trim().Equals(""))
            {
                UIMessageTip.Show("信息不能为空");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {


                    string no = textBox1.Text.Trim();
                    string name = textBox2.Text.Trim();


                    try
                    {
                        SqlConnection conn = new SqlConnection(con);
                        string sql = "select mno,mpwd from manager where mno='" + no + "'and mpwd='" + name + "'";
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        SqlDataReader sqlDataReader = comm.ExecuteReader();

                        if (sqlDataReader.HasRows)
                        {
                            UIMessageBox.Show("登陆成功");
                            
                            string n = textBox1.Text;
                            this.Hide();
                            manabook man = new manabook(n);
                            man.Show();
                        }
                        else
                        {
                            MessageBox.Show("登录失败");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                else
                {
                    string no = textBox1.Text.Trim();
                    string name = textBox2.Text.Trim();


                    try
                    {
                        SqlConnection conn = new SqlConnection(con);
                        string sql = "select sno,pwd from student where sno='" + no + "'and pwd='" + name + "'";
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        SqlDataReader sqlDataReader = comm.ExecuteReader();
                        if (sqlDataReader.HasRows)
                        {
                            MessageBox.Show("登陆成功");
                            this.Hide();
                            new readbook().Show();
                        }
                        else
                        {
                            MessageBox.Show("登录失败");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
} 
