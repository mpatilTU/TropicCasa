using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class BidsFeedbacks : System.Web.UI.Page
    {
        string email;
        string roles;
        DatabaseConnection conn = new DatabaseConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            email = Request.QueryString["email"];
            roles = Request.QueryString["role"];
            GridView1.DataSource = null;
            GridView1.DataBind();
            DataTable dt = conn.spSelectFeedback("sp_select_feedback",email);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?email=" + email + "&role=" + roles);
        }
    }
}