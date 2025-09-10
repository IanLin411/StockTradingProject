using System.ComponentModel.DataAnnotations;

namespace StockTradingWebAPI.Model.Entities;

public class User
{
    public int ID { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(255)]
    public string Password { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; } = string.Empty;
       
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; } = string.Empty;
    
    public int PremiumLevel { get; set; }
    
    public DateTime CreateTime { get; set; } = DateTime.Now;
    
    public DateTime LastUpdateTime { get; set; } = DateTime.Now;
    
    public bool IsActive { get; set; } = true;
    
    public bool IsRepeal  { get; set; } = false;
    
    public bool EmailVerified { get; set; } = false;

    public virtual ICollection<Portfolio> Portfolio { get; set; } = new List<Portfolio>();
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}