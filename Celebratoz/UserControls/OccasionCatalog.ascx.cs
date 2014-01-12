using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_OccasionCatalog : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string page = Request.QueryString["Page"];
        if (page == null)
            page = "1";
        // How many pages of products?    
        int howManyPages = 1;
        
        string occ_id = Request.QueryString["Occasion_id"];
        // Retrieve list of products on catalog promotion      
        list.DataSource = CatalogAccess.GetProductsOnOccPromo(occ_id, page, out howManyPages);
        list.DataBind();
        // have the current page as integer      
        int currentPage = Int32.Parse(page);

        // Display pager controls    
    }
}