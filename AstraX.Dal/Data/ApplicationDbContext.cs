using AstraX.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace AstraX.Dal.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Entities 
    public DbSet<CompanyProfile> CompanyProfiles { get; set; }
    public DbSet<BalanceSheet> BalanceSheets { get; set; }
    public DbSet<CashFlowStatement> CashFlowStatements { get; set; }
    public DbSet<IncomeStatement> IncomeStatements { get; set; }
}