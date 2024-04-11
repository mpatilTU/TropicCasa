using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Xml.Linq;
using System.Web.Configuration;
using Newtonsoft.Json;

namespace tropicasa
{
    public partial class Home : System.Web.UI.Page
    {
        string email;
        string roles;
        
        string MyString = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAuthenticated())
            {
                Response.Redirect("Login.aspx");
            }

            Label1.Visible = false;
            //Reset the gridview
            GridView1.DataSource = null;
            GridView1.DataBind();

            email = Request.QueryString["email"];
            roles = Request.QueryString["role"];
            WebClient MyClient = new WebClient();

            try
            {
                MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes");
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

            if (roles == "buyers")
            {
                homeListing.Visible = false;
                bidsfeedbacks.Visible = false;
            }
            else
            {
                homeListing.Visible = true;
            }

        }


        private bool IsAuthenticated()
        {
            return Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"];
        }

        protected void homeListing_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeListing.aspx?email=" + email+"&role="+roles);
        }

        protected void viewFullHome_Click(object sender, EventArgs e)
        {
            string[] ar = (sender as LinkButton).CommandArgument.ToString().Split(',');
            string homeID = ar[0];
            Response.Redirect("HomeDetail.aspx?email=" + email+"&role="+roles+"&Id="+homeID + "&owner=" + ar[1]);
        }

        protected void search1_Click(object sender, EventArgs e)
        {
            if(locationText1.Text !="" && priceText1.Text != "")
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?location=" + locationText1.Text +"&price="+ priceText1.Text);
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
            }
            locationText1.Text = "";
            priceText1.Text = "";
        }

        protected void search2_Click(object sender, EventArgs e)
        {
            if (locationText2.Text != "" && priceText2.Text != "" && typeText2.Text !="")
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?location=" + locationText2.Text + "&price=" + priceText2.Text+"&type="+typeText2.Text);
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
            }

            locationText2.Text = "";
            priceText2.Text = "";
            typeText2.Text = "";
        }

        protected void search3_Click(object sender, EventArgs e)
        {
            if (locationText3.Text != "" && priceText3.Text != "" && typeText3.Text != "" && bedroomText3.Text !="" && bathroomText3.Text !="")
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?location=" + locationText3.Text + "&price=" + priceText3.Text + "&type=" + typeText3.Text + "&bedrooms="+bedroomText3.Text+"&bathroom="+bathroomText3.Text);
                }
                catch (System.Net.WebException ex)
                {
                    MyString = "Error: " + ex.Message;
                }
                Label1.Text = MyString;

                //Using DataTable, here you have to import System.Data  
                try
                {
                    DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(MyString);
                    //Binding GridView to dataTable object   
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                }
                catch(System.Net.WebException ex) {
                    Label1.Text = "NO DATA FOUND!!";
                    Label1.Visible = true;
                }

                
            }
            locationText3.Text = "";
            priceText3.Text = "";
            typeText3.Text = "";
            bedroomText3.Text = "";
            bathroomText3.Text = "";

        }

        protected void search4_Click(object sender, EventArgs e)
        {
            if (locationText4.Text != "" && priceText4.Text != "" && typeText4.Text != "" && bedroomText4.Text != "" && bathroomText4.Text != "" && amenitiesText4.Text !="" )
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?location=" + locationText4.Text + "&price=" + priceText4.Text + "&type=" + typeText4.Text + "&bedrooms=" + bedroomText4.Text + "&bathroom=" + bathroomText4.Text+"&amenities="+amenitiesText4.Text);
                }
                catch (System.Net.WebException ex)
                {
                    MyString = "Error: " + ex.Message;
                }
                Label1.Text = MyString;

                //Using DataTable, here you have to import System.Data  
                try
                {
                    DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(MyString);
                    //Binding GridView to dataTable object   
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                }
                catch (System.Net.WebException ex)
                {
                    Label1.Text = "NO DATA FOUND!!";
                    Label1.Visible = true;
                }


            }


            locationText4.Text = "";
            priceText4.Text = ""; 
            typeText4.Text = "";
            bedroomText4.Text = ""; 
            bathroomText4.Text = "";
            amenitiesText4.Text = "";

        }

        protected void bidsfeedbacks_Click(object sender, EventArgs e)
        {
            Response.Redirect("BidsFeedbacks.aspx?email=" + email + "&role=" + roles);
        }

        protected void st_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleTour.aspx?email=" + email + "&role=" + roles);

        }

        protected void search5_Click(object sender, EventArgs e)
        {
            if (priceText5.Text != "" && typeText5.Text != "")
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?price=" + priceText5.Text + "&type=" +typeText5.Text);
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
            }
            typeText5.Text = "";
            priceText5.Text = "";
        }

        protected void search6_Click(object sender, EventArgs e)
        {
            if (typeText6.Text != "")
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                WebClient MyClient = new WebClient();

                try
                {
                    MyString = MyClient.DownloadString("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes?type=" + typeText6.Text);
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
            }
            typeText6.Text = "";
        }
    }
}