//Oratile Seloro 35834609
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBV_Seminar
{
    public partial class frmGBV : Form
    {
        private string sTitle = "Gender Based Violence Seminar Ticket Purchase";
        public frmGBV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Gender Based Violence Seminar Ticket Purchase!");
            lblTitle.Text = sTitle;
            pnlInfo.BackColor = Color.Black;
            pnlTitle.BackColor = Col or.Red;
            lblInfo.ForeColor = Color.White;
   
            txtName.TabIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            const double TicketPrice = 200;
            const decimal Transport = 75.50m;
            string sName, sSurname;
            int iTickets;
            bool bYes, bNo, bYesTransport, bNoTransport;
            decimal dPrice = 0, dTotal = 0, dTransport = 0, dDiscount = 0;

            try
            {
                sName = txtName.Text;
                sSurname = txtSurname.Text;
                iTickets = int.Parse(txtTicket.Text);
                bYes = rdbYes.Checked;
                bNo = rdbNo.Checked;
                bYesTransport = rdbYesTransport.Checked;
                bNoTransport = rdbNoTransport.Checked;
                dDiscount = (decimal)Math.Pow(10, 2);

                if ((bYes == false) && (bNo == false))
                    MessageBox.Show("Please indicate if you're a member or not.");
                if ((bYesTransport == false) && (bNoTransport == false))
                    MessageBox.Show("Please indicate if you need transport");

                if (bYes == true)
                    dPrice = dDiscount * (decimal)iTickets;
                else
                    if (bNo == true)
                    dPrice = (decimal)iTickets * (decimal)TicketPrice;

                if (bYesTransport == true)
                    dTransport = Transport;
                else
                if (bNoTransport == true)
                    dTransport = 0;

                dTotal = Math.Round(dTransport + dPrice, 2);
                if (((bYes == true) || (bNo == true)) && ((bYesTransport == true) || (bNoTransport == true)))
                {
                    lblOutput.Text = "Ticket Details:" + "\r\n" + "Ticket holder: " + sName + " " + sSurname + "\r\n" + "Number of tickets purchased: " + iTickets.ToString() + "\r\n" + "Transport Price: " + dTransport.ToString("C") + "\r\n" + "Ticket(s): " + dPrice.ToString("C") + "\r\n" + "--------------------------" + "\r\n" + "Total: " + dTotal.ToString("C");
                    pnlTitle.BackColor = Color.Black;
                    pnlInfo.BackColor = Color.Red;
                    lblOutput.BackColor = Color.White;
                    lblTitle.ForeColor = Color.White;
                    lblInfo.ForeColor = Color.Black;
                }
            }
            catch
            {
                MessageBox.Show("Please fill in all the everything");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtTicket.Clear();
            rdbNo.Checked = false;
            rdbYes.Checked = false;

            lblOutput.Text = "";

            pnlInfo.BackColor = Color.Black;
            pnlTitle.BackColor = Color.Red;
            lblInfo.ForeColor = Color.White;
            lblTitle.ForeColor = Color.Black;

            txtName.TabIndex = 0;
        }
    }
}
