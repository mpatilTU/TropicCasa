using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Net;

namespace tropicasa
{
    public partial class Login : System.Web.UI.Page
    {
        private DatabaseConnection conn = new DatabaseConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check for the presence of the LoginCookie
                HttpCookie loginCookie = Request.Cookies["LoginCookie"];

                if (loginCookie != null)
                {
                    String encryptedPassword = loginCookie.Values["password"];

                    byte[] decryptedPassword;
                    string decryptedPasswordString;
                    string password;

                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                    {
                        // Get the public and private key
                        string publicKey = rsa.ToXmlString(false);
                        string privateKey = rsa.ToXmlString(true);

                        password = loginCookie.Values["password"];

                        // Import the private key from the XML string
                        RSACryptoServiceProvider privateKeyProvider = new RSACryptoServiceProvider();
                        privateKeyProvider.FromXmlString(privateKey);

                        //decryptedPassword = privateKeyProvider.Decrypt(encryptedPassword, true);

                        //decryptedPasswordString = Encoding.UTF8.GetString(decryptedPassword);

                        decryptedPasswordString = password;
                    }

                    emailText.Text = loginCookie.Values["email"];
                    passwordText.Text = decryptedPasswordString;
                    CheckBox1.Checked = true;
                }
            }
            loginSuccess.Visible = false;
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            if (emailText.Text != "" && passwordText.Text != "")
            {
                try
                {
                    ArrayList loginUser = conn.spLogin("sp_TPlogin", emailText.Text, passwordText.Text);

                    if (loginUser[1].ToString() == emailText.Text && loginUser[2].ToString() == passwordText.Text)
                    {
                        String plainTextPassword = passwordText.Text;

                        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainTextPassword);
                        string encryptedPassword;

                        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                        {
                            byte[] encryptedBytes = rsa.Encrypt(plainTextBytes, true);
                            encryptedPassword = Convert.ToBase64String(encryptedBytes);
                        }

                        // passwordText.Text = encryptedPassword;

                        if (CheckBox1.Checked)
                        {
                            HttpCookie loginCookie = new HttpCookie("LoginCookie");
                            loginCookie.Values["email"] = emailText.Text;
                            loginCookie.Values["password"] = encryptedPassword;
                            loginCookie.Expires = DateTime.Now.AddDays(7); // Cookie will expire in 7 days
                            Response.Cookies.Add(loginCookie);
                        }
                        Session["IsAuthenticated"] = true;
                        // means email exists and password is same
                        //Response.Redirect("Home.aspx?username=" + loginUser[0].ToString() + "&role=" + loginUser[3].ToString() + "&email=" + loginUser[1].ToString());
                        Response.Redirect("Home.aspx?role=" + loginUser[3].ToString() + "&email=" + loginUser[1].ToString());
                    }
                    else
                    {
                        loginSuccess.Text = "YOUR EMAIL OR PASSWORD IS NOT CORRECT";
                        loginSuccess.Visible = true;
                    }
                }
                catch (Exception ex) { }
            }
        }

        protected void buttonDeleteCookie_Click(object sender, EventArgs e)
        {
            HttpCookie loginCookie = Request.Cookies["LoginCookie"];
            if (loginCookie != null)
            {
                loginCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(loginCookie);
            }
        }
    }
}