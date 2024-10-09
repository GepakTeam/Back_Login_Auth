using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

public class EmailController : Controller
{
    private readonly IEmailSender _emailSender;

    public EmailController(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }
    
    public async Task<IActionResult> SendEmail()
    {
        await _emailSender.SendEmailAsync("user@example.com", "Subject", "Body");
        return Ok();
    }
}
