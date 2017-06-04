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

namespace PRPJECT4NEW
{
    class SendMail
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public void Send(string sendTo, string Subject, string message)
        {
            login = new NetworkCredential("matanplus", "mazalmazal");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("matanplus" + "@gmail.com", "Mazal Plus", Encoding.UTF8) };
            msg.To.Add(new MailAddress(sendTo));        //email send to
            msg.Subject = Subject;          //subject
            msg.Body = message;             //msg
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(sendcompletedcallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        private static void sendcompletedcallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} Send Cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Message Has been successfully Sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string Getmail(string name)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Person)
                    if (s.F_name + " " + s.L_name == name)
                        return s.Email;
            }
            return "NULL";
        }

        public string GetmailByID(string ID)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Person)
                    if (s.ID == ID)
                        return s.Email;
            }
            return "NULL";
        }
    }
}
