using System.Collections.Generic;
using datatablesProject.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }

    public DbSet<CariHesaplar> CariHesaplar { get; set; }
}