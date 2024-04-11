using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tropicasa
{
    public partial class UpdateHome : System.Web.UI.Page
    {
        string homeID;
        string email;
        string roles;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAuthenticated())
            {
                Response.Redirect("Login.aspx");
            }

            listSuccess.Visible = false;
            homeID = Request.QueryString["Id"];
            email = Request.QueryString["email"];
            roles = Request.QueryString["role"];
        }

        private bool IsAuthenticated()
        {
            return Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"];
        }

        protected async void updateHomeBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            ClassHomes ch = new ClassHomes();
            string url = "https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes/" + homeID;

            ch.useremail = emailText.Text;
            ch.address = addressText.Text;
            ch.type = types.Text;
            ch.size = sizeText.Text;
            ch.bedrooms = bedroomsText.Text;
            ch.bathroom = bathroomsText.Text;
            ch.amenities = amenitiesText.Text;
            ch.heatingandcooling = hsText.Text;
            ch.year = yearText.Text;
            ch.garage = garageDropDownList.Text;
            ch.utilities = utilitiesText.Text;
            ch.description = descriptionText.Text;
            ch.price = priceText.Text;
            if (FileUpload1.HasFile)
            {
                ch.imageurl = FileUpload1.FileName;
            }
            else
            {
                ch.imageurl = "https://picsum.photos/200";
            }

            ch.imagecaption = imagecaptionText.Text;


            var jsonData = JsonConvert.SerializeObject(ch);
            var requestContent = new StringContent(jsonData, Encoding.Unicode, "application/json");
            var response = await client.PutAsync(url, requestContent);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                listSuccess.Text = "posted";
                listSuccess.Visible = true;
            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?email=" + email + "&role=" + roles);
        }

        protected async void deleteBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response= await client.DeleteAsync("https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes/" + homeID);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Home deleted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to delete home. Status code: {0}", response.StatusCode);
            }
            Response.Redirect("Home.aspx?email=" + email + "&role=" + roles);

        }
    }
}