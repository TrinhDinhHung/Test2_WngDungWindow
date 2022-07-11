using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2_winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            lvwDB.Visible = true;
            lvwACC.Visible = false;
        }

        private void btnACC_Click(object sender, EventArgs e)
        {
            lvwACC.Visible = true;
            lvwDB.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDB.PerformClick();
            Khoi_tao_du_lieu();
        }

        private void Khoi_tao_du_lieu()
        {
            ListViewItem lvDB = new ListViewItem("1");
            lvDB.SubItems.Add("Cam");
            lvDB.SubItems.Add("Xoài");
            lvDB.SubItems.Add("Ổi");
            lvDB.SubItems.Add("1000/1000");
            lvDB.SubItems.Add("Táo");
            lvDB.SubItems.Add("Run/Stop");
            lvwDB.Items.Add(lvDB);
            ListViewItem lvDB2 = new ListViewItem("2");
            lvDB2.SubItems.Add("Mít");
            lvDB2.SubItems.Add("Mận");
            lvDB2.SubItems.Add("Chanh");
            lvDB2.SubItems.Add("1000/1000");
            lvDB2.SubItems.Add("Hồng");
            lvDB2.SubItems.Add("Run/Stop");
            lvwDB.Items.Add(lvDB2);
            ListViewItem lvDB3 = new ListViewItem("3");
            lvDB3.SubItems.Add("Lê");
            lvDB3.SubItems.Add("Bòn Bon");
            lvDB3.SubItems.Add("Cóc");
            lvDB3.SubItems.Add("1000/1000");
            lvDB3.SubItems.Add("Táo");
            lvDB3.SubItems.Add("Run/Stop");
            lvwDB.Items.Add(lvDB3);
            ListViewItem lvAC = new ListViewItem("1");
            lvAC.SubItems.Add("Nội thất");
            lvAC.SubItems.Add("Thú Cưng");
            lvAC.SubItems.Add("Xây dựng");
            lvAC.SubItems.Add("Pet");
            lvAC.SubItems.Add("Táo");
            lvAC.SubItems.Add("1000/1000");
            lvAC.SubItems.Add("Run/Stop");
            lvwACC.Items.Add(lvAC);
            ListViewItem lvAC2 = new ListViewItem("2");
            lvAC2.SubItems.Add("Ngoại thất");
            lvAC2.SubItems.Add("Thú Cưng");
            lvAC2.SubItems.Add("Thiết kế");
            lvAC2.SubItems.Add("Pet");
            lvAC2.SubItems.Add("Đa dụng");
            lvAC2.SubItems.Add("1000/1000");
            lvAC2.SubItems.Add("Run/Stop");
            lvwACC.Items.Add(lvAC2);
            ListViewItem lvAC3 = new ListViewItem("3");
            lvAC3.SubItems.Add("Kinh tế");
            lvAC3.SubItems.Add("Maketing");
            lvAC3.SubItems.Add("sale");
            lvAC3.SubItems.Add("User");
            lvAC3.SubItems.Add("Sad");
            lvAC3.SubItems.Add("1000/1000");
            lvAC3.SubItems.Add("Run/Stop");
            lvwACC.Items.Add(lvAC3);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Thoát Không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == thoat)
                e.Cancel = true;
        }
    }
}
