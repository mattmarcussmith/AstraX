namespace AstraX.Dal.Entities;

public class UserPortfolio
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; }
    
    public string Symbol { get; set; }
    public string Description { get; set; }
    public int Shares { get; set; }
    public CompanyProfile CompanyProfile { get; set; }
    
    public decimal InvestmentValue => Shares * CompanyProfile.CurrentPrice;
    public decimal AnnualDividendValue => Shares * CompanyProfile.AnnualDividendValue;
    


}