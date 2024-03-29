using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_66_NguyenHuuToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_cong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation_66_NguyenHuuToan c = new Caculation_66_NguyenHuuToan(a, b);
            ketqua = c.Execute("+");
            txt_kq.Text = ketqua.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation_66_NguyenHuuToan c = new Caculation_66_NguyenHuuToan(a, b);
            ketqua = c.Execute("-");
            txt_kq.Text = ketqua.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation_66_NguyenHuuToan c = new Caculation_66_NguyenHuuToan(a, b);
            ketqua = c.Execute("*");
            txt_kq.Text = ketqua.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation_66_NguyenHuuToan c = new Caculation_66_NguyenHuuToan(a, b);
            ketqua = c.Execute("/");
            txt_kq.Text = ketqua.ToString();
        }
    }
}
