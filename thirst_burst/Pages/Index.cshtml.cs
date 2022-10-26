using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thirst_burst.Model;
using thirst_burst.Services;

namespace thirst_burst.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Drink> Drinks { get; private set; }
        public JsonFileDrinkService DrinkService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileDrinkService drinkService)
        {
            _logger = logger;
            DrinkService = drinkService;
        }

        public void OnGet()
        {
            Drinks = DrinkService.getDrinkRecords();
        }
    }
}
