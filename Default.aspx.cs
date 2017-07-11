using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = "hello";
        if (str == "hello")
        {
            Response.Write("Yes");
        }
        else
        {
            Response.Write("No");
        }
        int n = 1;
        while (n < 15)
            Response.Write(n);

    }

}