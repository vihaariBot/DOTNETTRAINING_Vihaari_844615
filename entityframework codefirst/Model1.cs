namespace entityframework_codefirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class codefirst : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'entityframework_codefirst.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public codefirst():base("dbconstr")
        {
            Database.SetInitializer<codefirst>(new DropCreateDatabaseIfModelChanges<codefirst>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<employee>employees { get; set; }
    }

    public class employee
    {
       public int id { get; set; }
        public string name { get; set; }
    }
}