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
            if(Session["resultValue"] != null)
            {
                lblresult.Text = Session["resultValue"].ToString();
            }
            if (Session["opt"] != null)
            {
                DropDownList1.SelectedValue = Session["opt"].ToString();
            }
            if (Session["num1"] != null)
            {
                txtNumber1.Text = Session["num1"].ToString();
            }
            if (Session["num2"] != null)
            {
                txtNumber2.Text = Session["num2"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var num1 = Convert.ToDecimal(this.txtNumber1.Text);
            var num2 = Convert.ToDecimal(this.txtNumber2.Text);
            var opt = this.DropDownList1.SelectedValue;

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
            Session["resultValue"] = resultValue;
            Session["opt"] = opt;
            Session["num1"] = num1;
            Session["num2"] = num2;
            lblresult.Text = result.ToString();
        }
    }
}