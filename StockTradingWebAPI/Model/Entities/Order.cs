using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTradingWebAPI.Model.Entities;

public enum OrderType
{
    Buy = 1,
    Sell = 2
}
    
public enum OrderStatus
{
    Pending = 1,
    Executed = 2,
    Cancelled = 3,
    PartiallyExecuted = 4
}

public class Order
{
    public int Id { get; set; }
        
    public int UserId { get; set; }
        
    [Required]
    [MaxLength(10)]
    public string Symbol { get; set; } = string.Empty;
        
    public OrderType Type { get; set; }
        
    public int Quantity { get; set; }
        
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
        
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
        
    public DateTime CreateTime { get; set; } = DateTime.UtcNow;
        
    public DateTime? ExecuteTime { get; set; }
        
    public virtual User User { get; set; } = null!;
}