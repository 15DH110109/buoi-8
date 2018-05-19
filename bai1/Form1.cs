using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 465);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(txtSender.Text,txtPass.Text);
            MailMessage message = new MailMessage(txtSender.Text, txtTo.Text,txtSub.Text,txtBody.Text);            
            mailclient.Send(message);
            MessageBox.Show("Mail send!", "Success", MessageBoxButtons.OK);
        }
    }
}
