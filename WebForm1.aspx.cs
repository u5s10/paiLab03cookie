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

            lblresult.Text = result.ToString();
        }
    }
}