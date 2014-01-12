using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_CategoryTitle : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cat_id = Request.QueryString["category_id"];
        String name=null;
        CategoryTitle.Text = CatalogAccess.GetCategoryTitle(cat_id,out name).ToString();
    }
}