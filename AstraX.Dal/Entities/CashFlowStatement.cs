namespace AstraX.Dal.Entities;

public class CashFlowStatement
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; } // FK

    public decimal OperatingCashFlow { get; set; }
    public decimal CapitalExpenditures { get; set; }
    public decimal DividendPayout { get; set; }
    public decimal FreeCashFlow => OperatingCashFlow - CapitalExpenditures;

    // Navigation properties
    public CompanyProfile CompanyProfile { get; set; }
}