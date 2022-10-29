using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using thirst_burst.Model;
using thirst_burst.Services;

namespace Thirst_Burst.Pages
{
    public class DrinkListModel : PageModel
    {
        public IEnumerable<Drink> Drinks { get; private set; }
        public JsonFileDrinkService DrinkService;

        public DrinkListModel(JsonFileDrinkService drinkService)
        {
            DrinkService = drinkService;
        }
        public void OnGet()
        {
            Drinks = DrinkService.getDrinkRecords();
        }
    }
}
