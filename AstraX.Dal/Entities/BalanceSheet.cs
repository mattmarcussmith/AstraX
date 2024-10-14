namespace AstraX.Dal.Entities;

public class BalanceSheet
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; } // FK

    public decimal TotalAssets { get; set; }
    public decimal TotalLiabilities { get; set; }
    public decimal LongTermDebt { get; set; }
    public decimal ShareholderEquity { get; set; }

    // Navigation properties 
    public CompanyProfile CompanyProfile { get; set; }
}