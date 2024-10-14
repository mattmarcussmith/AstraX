namespace AstraX.Dal.Entities;

public class IncomeStatement
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; }

    public decimal NetIncome { get; set; }
    public decimal OperatingIncome { get; set; }
    public decimal EBITDA { get; set; }

    // Navigation properties 
    public CompanyProfile CompanyProfile { get; set; }
}