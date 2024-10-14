namespace AstraX.Dal.Entities;

public class CompanyProfile
{
    public int Id { get; set; }

    // Basic Information 
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Exchange { get; set; }
    public string Currency { get; set; }
    public string Country { get; set; }
    public string Industry { get; set; }

    // Dividend-Related Properties 
    public decimal DividendPerShare { get; set; }
    public decimal DividendYield { get; set; }
    public DateTime DividendDate { get; set; }
    public DateTime ExDividendDate { get; set; }

    // Financial Metrics
    public decimal PERatio { get; set; }
    public decimal EPS { get; set; }
    public decimal Beta { get; set; }

    // Stock Price
    public decimal CurrentPrice { get; set; }
    public decimal FiftyTwoWeekHigh { get; set; }
    public decimal FiftyTwoWeekLow { get; set; }

    // User-Specific Data (Not from Alpha Vantage API)
    public int Shares { get; set; }
    public decimal InvestmentValue => Shares * CurrentPrice;
    public decimal AnnualDividendValue => Shares * DividendPerShare;

    // Navigation properties for related financial data
    public IncomeStatement IncomeStatement { get; set; }
    public BalanceSheet BalanceSheet { get; set; }
    public CashFlowStatement CashFlowStatement { get; set; }
}