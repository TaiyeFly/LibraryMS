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
    public partial class manaread : Form
    {
        public manaread()
        {
            InitializeComponent();
        }

        private void manaread_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cqimoDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.cqimoDataSet.student);
            LoadData();
        }
        void LoadData()
        {
            var sql = "select * from student ";
            var dt = SqlHelper.ExecuteDataTable(sql, null);
           // dataGridView1.DataSource = dt;
        }




    }
}
