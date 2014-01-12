using System;
using System.Data;
using System.Data.Common;
/// <summary> 
/// Product catalog business tier component 
/// </summary> 
public static class CatalogAccess 
{  
    static CatalogAccess()  
    {    
        //    
        // TODO: Add constructor logic here    
        //  
    }
// Retrieve the list of departments   
    public static DataTable GetCategory()  
    {    
        // get a configured DbCommand object    
        DbCommand comm = GenericDataAccess.CreateCommand();    
        // set the stored procedure name    
        comm.CommandText = "get_Category";
        
        // execute the stored procedure and return the results    
        return GenericDataAccess.ExecuteSelectCommand(comm);  
    }
    public static DataTable GetOccasion()
    {
        // get a configured DbCommand object    
        DbCommand comm = GenericDataAccess.CreateCommand();
        // set the stored procedure name    
        comm.CommandText = "get_Occasion";
        // execute the stored procedure and return the results    
        return GenericDataAccess.ExecuteSelectCommand(comm);
    } 
    /// <summary> 
    /// Wraps product details data 
    /// </summary> 
    public struct ProductDetails {  
        public int ProductID;  
        public string Name;  
        public string Description;
        public string Price;  
        public string Thumbnail;  
        public string Image;  
        public bool PromoFront;
        public bool PromoCat; 
    }
    // Add the GetProductDetails method to the CatalogAccess class:
    // Get product details 
    public static ProductDetails GetProductDetails(string productId) {  
        // get a configured DbCommand object  
        DbCommand comm = GenericDataAccess.CreateCommand();  
        // set the stored procedure name  
        comm.CommandText = "GetProductDetail";  
        // create a new parameter  
        DbParameter param = comm.CreateParameter();  
        param.ParameterName = "@ProductID";  
        param.Value = productId;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);
        // execute the stored procedure  
        DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);  
        // wrap retrieved data into a ProductDetails object  
        ProductDetails details = new ProductDetails();  
        if (table.Rows.Count > 0)  {    
            // get the first table row    
            DataRow dr = table.Rows[0];    
            // get product details    
            details.ProductID = int.Parse(productId);    
            details.Name = dr["Name"].ToString();    
            details.Description = dr["Description"].ToString();    
            details.Price = dr["Price"].ToString();    
            details.Thumbnail = dr["Thumbnail"].ToString();    
            details.Image = dr["Image"].ToString();
            details.PromoFront = bool.Parse(dr["PromoFront"].ToString());
            details.PromoCat = bool.Parse(dr["PromoCat"].ToString());  
        }  
        // return department details  
        return details; 
    }
    // Retrieve the list of products on catalog promotion 
    public static DataTable GetProductsOnFrontPromo(string pageNumber, out int howManyPages) {  
        // get a configured DbCommand object  
        DbCommand comm = GenericDataAccess.CreateCommand();  
        // set the stored procedure name  
        comm.CommandText = "CatalogGetProductsOnFrontPromo";  
        // create a new parameter  
        DbParameter param = comm.CreateParameter();  
        param.ParameterName = "@DescriptionLength";  
        param.Value = CelebratozConfiguration.ProductDescriptionLength;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@PageNumber";  
        param.Value = pageNumber;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@ProductsPerPage";  
        param.Value = CelebratozConfiguration.ProductsPerPage;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@HowManyProducts";  
        param.Direction = ParameterDirection.Output;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);
        // execute the stored procedure and save the results in a DataTable  
        DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
        // calculate how many pages of products and set the out parameter  
        int howManyProducts = Int32.Parse(comm.Parameters ["@HowManyProducts"].Value.ToString());  
        howManyPages = (int)Math.Ceiling((double)howManyProducts /(double)CelebratozConfiguration.ProductsPerPage);  
        // return the page of products  
        return table; 
    }

    // retrieve the list of products featured for a Category 
   public static DataTable GetProductsOnCatPromo (string Category_Id, string pageNumber, out int howManyPages) {  
        // get a configured DbCommand object  
        DbCommand comm = GenericDataAccess.CreateCommand();  
        // set the stored procedure name  
        comm.CommandText = "CatalogGetProductsOnCatPromo";  
        // create a new parameter  
       DbParameter param = comm.CreateParameter();
       param.ParameterName = "@CategoryID";
        param.Value = Category_Id;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);
       
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@DescriptionLength";  
        param.Value = CelebratozConfiguration.ProductDescriptionLength;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@PageNumber";  
        param.Value = pageNumber;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@ProductsPerPage";
        param.Value = CelebratozConfiguration.ProductsPerPage;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // create a new parameter  
        param = comm.CreateParameter();  
        param.ParameterName = "@HowManyProducts";  
        param.Direction = ParameterDirection.Output;  
        param.DbType = DbType.Int32;  
        comm.Parameters.Add(param);  
        // execute the stored procedure and save the results in a DataTable  
        DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);  
        // calculate how many pages of products and set the out parameter  
        int howManyProducts = Int32.Parse(comm.Parameters["@HowManyProducts"].Value.ToString());
        howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)CelebratozConfiguration.ProductsPerPage);  
        // return the page of products  
        return table; 
    }

   public static DataTable GetProductsOnOccPromo(string Occasion_Id, string pageNumber, out int howManyPages)
   {
       // get a configured DbCommand object  
       DbCommand comm = GenericDataAccess.CreateCommand();
       // set the stored procedure name  
       comm.CommandText = "CatalogGetProductsOnOccPromo";
       // create a new parameter  
       DbParameter param = comm.CreateParameter();
       param.ParameterName = "@OccasionID";
       param.Value = Occasion_Id;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);

       // create a new parameter  
       param = comm.CreateParameter();
       param.ParameterName = "@DescriptionLength";
       param.Value = CelebratozConfiguration.ProductDescriptionLength;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       // create a new parameter  
       param = comm.CreateParameter();
       param.ParameterName = "@PageNumber";
       param.Value = pageNumber;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       // create a new parameter  
       param = comm.CreateParameter();
       param.ParameterName = "@ProductsPerPage";
       param.Value = CelebratozConfiguration.ProductsPerPage;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       // create a new parameter  
       param = comm.CreateParameter();
       param.ParameterName = "@HowManyProducts";
       param.Direction = ParameterDirection.Output;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       // execute the stored procedure and save the results in a DataTable  
       DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
       // calculate how many pages of products and set the out parameter  
       int howManyProducts = Int32.Parse(comm.Parameters["@HowManyProducts"].Value.ToString());
       howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)CelebratozConfiguration.ProductsPerPage);
       // return the page of products  
       return table;
   }
   public static String GetCategoryTitle(string Category_Id,out String name)
   {
       // get a configured DbCommand object    
       DbCommand comm = GenericDataAccess.CreateCommand();
       // set the stored procedure name    
       comm.CommandText = "GetCategoryTitle";
       DbParameter param = comm.CreateParameter();
       param.ParameterName = "@CategoryID";
       param.Value = Category_Id;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       param = comm.CreateParameter();
       param.ParameterName = "@Name";
       param.Size = 20;
       param.Direction = ParameterDirection.Output;
       param.DbType = DbType.String;
       comm.Parameters.Add(param);  
       // execute the stored procedure and return the results    
       GenericDataAccess.ExecuteSelectCommand(comm);

       name=comm.Parameters["@Name"].Value.ToString();
        return name;
   }

   public static String GetOccasionTitle(string Occasion_Id, out String name)
   {
       // get a configured DbCommand object    
       DbCommand comm = GenericDataAccess.CreateCommand();
       // set the stored procedure name    
       comm.CommandText = "GetOccasionTitle";
       DbParameter param = comm.CreateParameter();
       param.ParameterName = "@OccasionID";
       param.Value = Occasion_Id;
       param.DbType = DbType.Int32;
       comm.Parameters.Add(param);
       param = comm.CreateParameter();
       param.ParameterName = "@Name";
       param.Size = 20;
       param.Direction = ParameterDirection.Output;
       param.DbType = DbType.String;
       comm.Parameters.Add(param);
       // execute the stored procedure and return the results    
       GenericDataAccess.ExecuteSelectCommand(comm);

       name = comm.Parameters["@Name"].Value.ToString();
       return name;
   }

   
 }