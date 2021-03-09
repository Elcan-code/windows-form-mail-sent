using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace mail_sent
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }


        private void MailForm_Load(object sender, EventArgs e)
        {

        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                MailMessage message = new MailMessage();
                SmtpClient cilent = new SmtpClient();
                cilent.Credentials = new System.Net.NetworkCredential(fromtextBox.Text, passwordtextBox.Text);
                cilent.Port = 587;
                cilent.Host = "smtp.live.com";
                cilent.EnableSsl = true;
                message.To.Add(totextBox.Text);
                message.From = new MailAddress(fromtextBox.Text, fromtextBox.Text);
                message.Subject = SubjecttextBox.Text; ;
                message.Body = BodytextBox.Text;
                cilent.Send(message);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Mail or Password invalid");
            }
        }
    }
}
