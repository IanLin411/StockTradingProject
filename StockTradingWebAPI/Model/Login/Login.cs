using System.ComponentModel.DataAnnotations;

namespace StockTradingWebAPI.Model.Login;

public class LoginRequest
{
    [Required(ErrorMessage = "Email 為必填")]
    [EmailAddress(ErrorMessage = "Email 格式不正確")]
    public string Email { get; set; } = string.Empty;
        
    [Required(ErrorMessage = "密碼為必填")]
    [MinLength(6, ErrorMessage = "密碼至少需要 6 個字元")]
    public string Password { get; set; } = string.Empty;
}
