using app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

public class ApplicationDbContextMySQl : DbContext
{
     public ApplicationDbContextMySQl(DbContextOptions<ApplicationDbContextMySQl> options): base(options)
    {
    }
    // public virtual DbSet<User> Users{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            
        }
    }
}