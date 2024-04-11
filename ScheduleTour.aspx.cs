using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class ScheduleTour : System.Web.UI.Page
    {
        string email;
        string roles;
        DatabaseConnection conn = new DatabaseConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAuthenticated())
            {
                Response.Redirect("Login.aspx");
            }

            Label1.Visible = false;
            email = Request.QueryString["email"];
            roles = Request.QueryString["role"];
            GridView1.DataSource = null;
            GridView1.DataBind();
            DataTable dt = conn.spSelectTours("sp_selectTours", email);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private bool IsAuthenticated()
        {
            return Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"];
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?email=" + email + "&role=" + roles);
        }
    }
}