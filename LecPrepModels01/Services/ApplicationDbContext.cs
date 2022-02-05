using LecPrepModels01.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LecPrepModels01.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> People => Set<Person>();
}


