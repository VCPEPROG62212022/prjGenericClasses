using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_of_Generic_Classes
{
    public partial class Form1 : Form
    {
        ProductItems<string> pi;// Construtor (Instantiate)
                                // to generic Class
        SealedTotal st = new SealedTotal();

        public Form1()
        {
            InitializeComponent();

            pi = new ProductItems<string>(5);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            object strID = this.txtID.Text;
            object strName = this.txtName.Text;
            object dblPrice = this.txtPrice.Text;
            pi.Push(strID, strName, dblPrice);
            st.setTotal(dblPrice);
            MessageBox.Show(" New item product captured", "Data Captured");
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.txtPrice.Text="";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            object strDisplay = pi.Display();
            MessageBox.Show("The following items have been captured :\n\n" +
                strDisplay, "Report");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void btnVat_Click(object sender, EventArgs e)
        {
            Calc(15);
        }

        private void Calc()
        {
            MessageBox.Show("The total Product amount is R" + st.getTotal()
                , "Product total");
        }
        private void Calc(int num)
        {
            MessageBox.Show("The total Product amount is R" + (st.getTotal()*num/100)
                , "Vat amount");
        }
    }
}
