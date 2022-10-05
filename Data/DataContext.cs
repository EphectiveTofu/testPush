//need to create a new DataContext File in a data Folder

using dotnet_lecture.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_lecture.Data;


//then add the using statement using Microsoft.EntityFrameworkCore; with a CMD period

//adding database functionality 
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

   public DbSet<Student>Students {get; set; }
   public DbSet<User> Users { get; set; }
}