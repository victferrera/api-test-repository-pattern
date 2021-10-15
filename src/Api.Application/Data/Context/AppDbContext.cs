using Api.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Application.Data.Context
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions opt) : base(opt)
       {
           
       }
        public DbSet<Person> Persons { get; set; }
    }
}