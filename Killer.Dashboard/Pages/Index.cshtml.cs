using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Killer.Dashboard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Killer.Dashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string ConnectionString { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void OnGet()
        {

        }
    }
}
