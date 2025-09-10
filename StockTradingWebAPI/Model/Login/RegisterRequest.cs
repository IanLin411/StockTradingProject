using System.ComponentModel.DataAnnotations;

namespace StockTradingWebAPI.Model.Login;

public class RegisterRequest
{
    [Required(ErrorMessage = "Email 為必填")]
    [EmailAddress(ErrorMessage = "Email 格式不正確")]
    public string Email { get; set; } = string.Empty;
        
    [Required(ErrorMessage = "密碼為必填")]
    [MinLength(6, ErrorMessage = "密碼至少需要 6 個字元")]
    public string Password { get; set; } = string.Empty;
        
    [Required(ErrorMessage = "確認密碼為必填")]
    [Compare("Password", ErrorMessage = "密碼與確認密碼不符")]
    public string ConfirmPassword { get; set; } = string.Empty;
        
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
        
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
}