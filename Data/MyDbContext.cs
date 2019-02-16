using online1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//3. create db context file here
namespace online1.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> option):base(option){
        }//end constructor
        //binding table go here

        //5. add dbset meta tag 
        public DbSet<Product>  Products{ get; set; }
    }//end class
}//end namespace