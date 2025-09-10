using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTradingWebAPI.Model.Entities;

public class Portfolio
{
    public int Id { get; set; }
        
    public int UserId { get; set; }
        
    [Required]
    [MaxLength(10)]
    public string Code { get; set; } = string.Empty;
        
    public int Quantity { get; set; } 
        
    [Column(TypeName = "decimal(18,4)")]
    public decimal AveragePrice { get; set; }
        
    [Column(TypeName = "decimal(18,4)")]
    public decimal CurrentPrice { get; set; }
        
    public DateTime CreateTime { get; set; } = DateTime.UtcNow;
        
    public DateTime LastUpdateTime { get; set; } = DateTime.UtcNow;
    
    public virtual User User { get; set; } = null!;
}