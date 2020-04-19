using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["calcInfo"];
            if(cookie != null)
            {
                lblresult.Text = cookie["result"].ToString();
                DropDownList1.SelectedValue = cookie["opt"].ToString();
                txtNumber1.Text = cookie["num1"].ToString();
                txtNumber2.Text = cookie["num2"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var num1 = Convert.ToDecimal(this.txtNumber1.Text);
            var num2 = Convert.ToDecimal(this.txtNumber2.Text);
            var opt = this.DropDownList1.SelectedValue;
            HttpCookie cookie = new HttpCookie("calcInfo");

            var result = 0m;

            if (opt == "+")
            {
                result = num1 + num2;
            }
            else if(opt == "-")
            {
                result = num1 - num2;
            }
            else if (opt == "*")
            {
                result = num1 * num2;
            }
            else if (opt == "/")
            {
                result = num1 / num2;
            }

            var resultValue = result.ToString();
            lblresult.Text = result.ToString();
            cookie["num1"] = num1.ToString();
            cookie["num2"] = num2.ToString();
            cookie["opt"] = opt.ToString();
            cookie["result"] = result.ToString();
            cookie.Expires.AddMinutes(2);
            Response.Cookies.Add(cookie);
        }
    }
}