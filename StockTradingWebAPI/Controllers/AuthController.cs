using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace StockTradingWebAPI.Controllers;

public class AuthController : Controller
{
     public AuthController()
     {
     }
     public async Task<IActionResult> Login()
     {
          return Ok();
     }
}