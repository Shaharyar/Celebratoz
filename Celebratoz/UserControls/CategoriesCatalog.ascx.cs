using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_CategoriesCatalog : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve DepartmentID from the query string    
        // string departmentId = Request.QueryString["DepartmentID"];    
        // Retrieve CategoryID from the query string    
        // string categoryId = Request.QueryString["CategoryID"];    
        // Retrieve Page from the query string    
        string page = Request.QueryString["Page"];
        if (page == null) 
            page = "1";
        // How many pages of products?    
        int howManyPages = 1;
        // pager links format    
      
        // If browsing a category...    
        /*if (categoryId != null)    {      
            // Retrieve list of products in a category      
            List.DataSource = CatalogAccess.GetProductsInCategory(categoryId, page, out howManyPages);      
            List.DataBind();      
            // get first page url and pager format      
            firstPageUrl = Link.ToCategory(departmentId, categoryId, "1");      
            pagerFormat = Link.ToCategory(departmentId, categoryId, "{0}");    
        }    
        else if (departmentId != null)    {      
            // Retrieve list of products on department promotion      
            list.DataSource = CatalogAccess.GetProductsOnDeptPromo (departmentId, page, out howManyPages);      
            list.DataBind();      
            // get first page url and pager format      
            firstPageUrl = Link.ToDepartment(departmentId, "1");      
            pagerFormat = Link.ToDepartment(departmentId, "{0}");    
        }*/
        string cat_id = Request.QueryString["category_id"];
        // Retrieve list of products on catalog promotion      
        list.DataSource = CatalogAccess.GetProductsOnCatPromo(cat_id, page, out howManyPages);
        list.DataBind();
        // have the current page as integer      
        int currentPage = Int32.Parse(page);

        // Display pager controls       
        
    }
}