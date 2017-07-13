namespace LearningSystem.Data
{
    using LearningSystem.Models.EntityModels;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LearningSystemContext : IdentityDbContext<ApplicationUser>
    {
        // Your context has been configured to use a 'LearningSystemContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LearningSystem.Data.LearningSystemContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LearningSystemContext' 
        // connection string in the application configuration file.
        public LearningSystemContext()
            : base("LearningSystem", throwIfV1Schema: false)
        {
        }
        public static LearningSystemContext Create()
        {
            return new LearningSystemContext();
        }
    }

   
}