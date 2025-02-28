using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_giaithua_luythua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int so3=Convert.ToInt32(txtso1.Text);
            int so4=Convert.ToInt32(txtso2.Text);
            int luythua=so3;
            for (int i = 1; i <= so4; i++)
            {
                
                luythua *= so3;
               
            }
            txtkq.Text = luythua.ToString();
        }

        private void txb1_Scroll(object sender, EventArgs e)
        {
            txt1.Text = txb1.Value.ToString();
            int so1 = Convert.ToInt32(txt1.Text);
            int tong = 1;

            for (int i = 1; i <= so1; i++)
            {
                tong = tong * i;

            }
            txt2.Text = tong.ToString();

        }
    }
}
