using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SiteCanaisTecnologia.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public IndexModel(ILogger<IndexModel> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            _logger.LogInformation(
                $"Acesso ao site em: {DateTime.UtcNow.AddHours(-3):dd/MM/yyyy HH:mm:ss}");
            TempData["Saudacao"] = _configuration["Saudacao"];
        }
    }
}