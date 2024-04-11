using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class HomeDetail : System.Web.UI.Page
    {
        string email;
        string roles;
        string homeID;
        string owner;
        string MyString = null;
        string userString = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAuthenticated())
            {
                Response.Redirect("Login.aspx");
            }

            Label1.Visible = false;
            Label2.Visible = false;

            updateHome.Visible = false;
            bidboxText.Visible = false;
            feedbackText.Visible = false;
            bidAndFeed.Visible = false;
            scheduleTour.Visible = false;

            //Reset the gridview
            GridView1.DataSource = null;
            GridView1.DataBind();

            email = Request.QueryString["email"];
            roles = Request.QueryString["role"];
            homeID = Request.QueryString["Id"];
            owner = Request.QueryString["owner"];


            if (email == owner)
            {
                updateHome.Visible = true;
            }
            else
            {
                updateHome.Visible = false;
                bidboxText.Visible = true;
                feedbackText.Visible = true;
                bidAndFeed.Visible = true;
                scheduleTour.Visible = true;

            }

            WebClient MyClient = new WebClient();

            try
            {
                MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes/" + homeID);
            }
            catch (System.Net.WebException ex)
            {
                MyString = "Error: " + ex.Message;
            }
            Label1.Text = MyString;

            //Using DataTable, here you have to import System.Data  

            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(MyString);

            //Binding GridView to dataTable object   
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            //calling user details
            loadUserDetails(owner);


            if (roles == "buyers")
            {
                homeListing.Visible = false;
            }
            else
            {
                homeListing.Visible = true;

                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;

                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;


                bidAndFeed.Visible = false;
                bidboxText.Visible = false;
                feedbackText.Visible = false;
            }



        }

        public void loadUserDetails(string uemail)
        {
            //Reset the gridview
            // GridView2.DataSource = null;
            // GridView2.DataBind();


            ListView1.DataSource = null;
            ListView1.DataBind();

            WebClient MyClient = new WebClient();

            try
            {
                userString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/User/" + uemail);
            }
            catch (System.Net.WebException ex)
            {
                userString = "Error: " + ex.Message;
            }
            Label1.Text = userString;

            //Using DataTable, here you have to import System.Data  

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(userString);

            //Binding GridView to dataTable object   
            // GridView2.DataSource = dt;
            // GridView2.DataBind();

            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        private bool IsAuthenticated()
        {
            return Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"];
        }

        protected void homeListing_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeListing.aspx?email=" + email + "&role=" + roles);

        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?email=" + email + "&role=" + roles);
        }

        protected void updateHome_Click(object sender, EventArgs e)
        {

            
            Console.WriteLine("Person viwing the home is the owner");
            
            Response.Redirect("UpdateHome.aspx?email=" + email + "&role=" + roles + "&Id=" + homeID );

            
            
        }

        protected void bidAndFeed_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            if (bidboxText.Text != "" && feedbackText.Text !="")
            {

                int userRegister = conn.spBidAndFeedback("sp_insert_feedback", email, owner, bidboxText.Text, feedbackText.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
                if (userRegister != -1)
                {
                    Label2.Text = "SUCCESS";
                    Label2.Visible = true;
                    Label2.ForeColor = Color.White;

                }
                else
                {
                    Label2.Text = "ERROR";
                    Label2.Visible = true;
                }

            }
        }

        protected void bidsfeedbacks_Click(object sender, EventArgs e)
        {

        }

        protected void scheduleTour_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            int userRegister = conn.spScheduleTour("sp_ScheduleTour", email, owner);
        }
    }
}