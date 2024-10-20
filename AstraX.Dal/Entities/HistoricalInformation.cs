namespace AstraX.Dal.Entities;

public class HistoricalInformation
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; }
    
    public string Symbol { get; set; }
    public decimal Bid { get; set; }
    public decimal Ask { get; set; }
    public decimal ImpliedVolatility { get; set; }
    public int Volume { get; set; }
    public int OpenInterest { get; set; }
    
    public CompanyProfile CompanyProfile { get; set; }
    
}