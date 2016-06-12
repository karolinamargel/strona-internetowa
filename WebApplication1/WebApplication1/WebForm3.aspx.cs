using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List<ListItem> imagesList3 = new List<ListItem>();
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] images3 = Directory.GetFiles(Server.MapPath("~/img_animals/"));


            foreach (string image3 in images3)
            {
                imagesList3.Add(new ListItem(Path.GetFileName(image3), image3));
            }

            Image1.ImageUrl = "img_animals/" + imagesList3[i];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (i > 0) i--;

            Image1.ImageUrl = "img_animals/" + imagesList3[i];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (i < imagesList3.Count-1) i++;

            Image1.ImageUrl = "img_animals/" + imagesList3[i];
        }
    }
}