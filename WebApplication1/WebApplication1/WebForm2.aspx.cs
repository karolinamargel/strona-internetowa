using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{

    public partial class WebForm2 : System.Web.UI.Page
    {
        List<ListItem> imagesList = new List<ListItem>();
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/img_views/"));
            

            foreach(string image in images)
            {
                imagesList.Add(new ListItem(Path.GetFileName(image), image));
            }        

            Image1.ImageUrl = "img_views/" + imagesList[i];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (i > 0) i--;

            Image1.ImageUrl = "img_views/" + imagesList[i];
        }

        protected void Button2_Click(object sender, EventArgs e)          
        {
            if (i < imagesList.Count - 1) i++;

            Image1.ImageUrl = "img_views/" + imagesList[i];
        }
    }
}