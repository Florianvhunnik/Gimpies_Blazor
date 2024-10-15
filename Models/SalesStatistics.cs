using System;

namespace Gimpies_Blazor.Models;

public class SalesStatistics
{
    public int SaleId { get; set; }
    public int StockId { get; set; }
    public int NumberSold { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalSalePrice { get; set; }
}
