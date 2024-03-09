using Microsoft.EntityFrameworkCore;
using PrenotaPompa.Models;

public class dbContext : DbContext
{
    private readonly DbContextOptions? _options;
    public dbContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=MioDataBase.db");
    public DbSet<Utente> Utenti {get; set;}


}