using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        String ProdID = Request.QueryString["ProductID"];
        CatalogAccess.ProductDetails pd = CatalogAccess.GetProductDetails(ProdID);
        // Does the product exist?    
        if (pd.Name != null)    
        {      
            PopulateControls(pd);    
        }  
    }
        // Fill the control with data  
    private void PopulateControls(CatalogAccess.ProductDetails pd)  
    {    
        // Display product details    
        titleLabel.Text = pd.Name;    
        descriptionLabel.Text = pd.Description;    
        priceLabel.Text = String.Format("{0:c}", pd.Price);
        productImage.AlternateText = pd.Thumbnail.ToString();
        productImage.ImageUrl = pd.Thumbnail.ToString();
        
        // Set the title of the page 
       // this.Title = Celebratoz.SiteName + pd.Name;  
    } 
    
}