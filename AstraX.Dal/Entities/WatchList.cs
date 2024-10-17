namespace AstraX.Dal.Entities;

public class WatchList
{
    public int Id { get; set; }
    public int CompanyProfileId { get; set; }
    
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal PreviousPrice { get; set; }

    public decimal DailyChangePercent =>
        PreviousPrice != 0 ? (CurrentPrice - PreviousPrice) / PreviousPrice * 100 : 0;
    
    public bool IsPriceIncreased => CurrentPrice > PreviousPrice;
}