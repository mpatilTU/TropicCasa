using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class Verify : System.Web.UI.Page
    {
        DatabaseConnection conn = new DatabaseConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAuthenticated())
            {
                Response.Redirect("Login.aspx");
            }

            Label1.Visible = false;
        }

        private bool IsAuthenticated()
        {
            return Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"];
        }

        protected void buttonVerify_Click(object sender, EventArgs e)
        {
            if(emailText.Text != "")
            {
              int rowsAffected = conn.spVerify("sp_verify", emailText.Text);
                if(rowsAffected != 0)
                {
                    Label1.Text = "EMAIL SUCCESSFULLY VERIFIED!!!";
                    Label1.Visible = true;
                    Label1.ForeColor = Color.Green;
                }
                else
                {
                    Label1.Text = "EMAIL INCORRECT";
                    Label1.Visible = true;
                    Label1.ForeColor = Color.Red;
                }
            }
        }
    }
}