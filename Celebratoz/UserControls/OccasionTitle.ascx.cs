using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_OccasionTitle : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string occ_id = Request.QueryString["occasion_id"];
        String name = null;
        OccasionTitle.Text = CatalogAccess.GetOccasionTitle(occ_id, out name).ToString();
    }
}