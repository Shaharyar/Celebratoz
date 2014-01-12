using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_CategoryList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // CatalogAccess.GetDepartments returns a DataTable object containing  
        // department data, which is read in the ItemTemplate of the DataList  
        list.DataSource = CatalogAccess.GetCategory();  
        // Needed to bind the data bound controls to the data source  
        list.DataBind(); 
    }
}