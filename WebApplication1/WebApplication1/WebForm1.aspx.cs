using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    FileUpload1.SaveAs("C:\\Users\\Karola\\Desktop\\studia\\semestr 4\\OJP\\StronaInternetowa\\WebApplication1\\WebApplication1\\" + DropDownList1.SelectedValue + "\\" + FileUpload1.FileName);
                    Response.Write("<script>alert('successful');</script>");
                    
                }
                catch(Exception ex)
                {
                    Response.Write("<script>alert('"+ ex.Message.ToString() + " ');</script>");
                }
            }
        }
    }
}