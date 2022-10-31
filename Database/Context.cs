using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=localhost,1433;Database=UNIVERSIDADE;User=root;Password=;");
    }

    public DbSet<Aluno> Alunos { get; set; }
}


