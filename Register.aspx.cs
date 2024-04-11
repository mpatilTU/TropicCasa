using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class Register : System.Web.UI.Page
    {
        DatabaseConnection conn = new DatabaseConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            registerSuccess.Visible = false;
        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            if (usernameText.Text != "" && emailText.Text != "" && passwordText.Text != "" && fullnameText.Text != "" & roles.Text != "") {

                int userRegister = conn.spRegister("sp_register", usernameText.Text, fullnameText.Text, emailText.Text, passwordText.Text, phoneText.Text, addressText.Text, roles.Text, questiononeText.Text, questiontwoText.Text, questionthreeText.Text, "false");
                if (userRegister != -1)
                {
                    Session["IsAuthenticated"] = true;

                    registerSuccess.Text = "USER SUCCESSFULL REGISTERED";
                    
                    string fromEmail = "tropicasa3342@gmail.com";
                    string toEmail = emailText.Text;
                    string subject = "Tropicasa | Two-step verification link";
                    string body = $"Please click the link below to complete the verification process: <a href='https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/TermProjectTest/Verify.aspx'>Verify Email</a>";

                    using (MailMessage message = new MailMessage(fromEmail, toEmail, subject, body))
                    {
                        message.IsBodyHtml = true;
                        using (SmtpClient client = new SmtpClient("smtp.gmail.com",587))
                        {
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("tropicasa3342@gmail.com", "vrmacqikoobnrkbm");
                            client.EnableSsl = true;
                            client.Send(message);
                        }
                    }

                    registerSuccess.Visible = true;

                }
                else
                {
                    registerSuccess.Text = "ERROR";
                    registerSuccess.Visible = true;
                }
            
            }
        }
    }
}