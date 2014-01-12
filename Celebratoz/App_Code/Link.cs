using System;
using System.Web;
/// <summary> 
/// Link factory class 
/// </summary>

public class Link 
{  
    // Builds an absolute URL  
    private static string BuildAbsolute(string relativeUri)  
    {    
        // get current uri    
        Uri uri = HttpContext.Current.Request.Url;    
        // build absolute path    
        string app = HttpContext.Current.Request.ApplicationPath;    
        if (!app.EndsWith("/")) 
            app += "/";    
        relativeUri = relativeUri.TrimStart('/');    
        // return the absolute path    
        return HttpUtility.UrlPathEncode(String.Format("http://{0}:{1}{2}{3}", uri.Host, uri.Port, app, relativeUri));  
    }
  // Generate a department URL  
    public static string ToCategory(string category_id, string page)  
    {    
        if (page == "1")
            return BuildAbsolute(String.Format("Category.aspx?category_id={0}", category_id));    
        else
            return BuildAbsolute(String.Format("Category.aspx?category_id={0}&Page={1}", category_id, page));  
    }
  // Generate a department URL for the first page  
    public static string ToCategory(string category_id)  
    {
        return ToCategory(category_id, "1");  
    }

    public static string ToOccasion(string Occasion_id, string page)
    {
        if (page == "1")
            return BuildAbsolute(String.Format("Occasion.aspx?Occasion_id={0}", Occasion_id));
        else
            return BuildAbsolute(String.Format("Occasion.aspx?Occasion_id={0}&Page={1}", Occasion_id, page));
    }
    // Generate a department URL for the first page  
    public static string ToOccasion(string Occasion_id)
    {
        return ToOccasion(Occasion_id, "1");
    } 
    public static string ToProduct(string productId) {  
        return BuildAbsolute(String.Format("Product.aspx?ProductID={0}", productId)); 
    }

    public static string ToProductImage(string fileName) {  
        // build product URL 
        //fileName = "/images/Products/Thumbnail/blackforestcake.jpg";
        return (fileName); 
    }
}
