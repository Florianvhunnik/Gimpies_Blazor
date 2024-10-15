using System;

namespace Gimpies_Blazor.Models;

public class Stock
{
    public int Id { get; set; }
    public string? Brand { get; set; }
    public string? Type { get; set; }
    public int Size { get; set; }
    public string? Color { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public bool Active { get; set; }
}
