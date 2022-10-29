using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using thirst_burst.Model;
using thirst_burst.Services;

namespace Thirst_Burst.Controllers
{
    [Route("/[controller]")]
    public class FormHandlerController : Controller
    {
        JsonFileDrinkService DrinkService;
        public FormHandlerController(JsonFileDrinkService drinkService)
        {
            this.DrinkService = drinkService;
        }
        [HttpGet]

        public string Get(int id, string name, string image)
        {
            Drink obj = new Drink();
            obj.drink_id = id;
            obj.name = name;
            obj.image = image;

            IEnumerable<Drink> drinksData=DrinkService.getDrinkRecords();
            List<Drink> listOfDrinks=drinksData.ToList();
            listOfDrinks.Add(obj);
            
           
            string FinalData=JsonSerializer.Serialize<List<Drink>>(listOfDrinks);
            DrinkService.setDrinkRecords(FinalData);
            return FinalData;

        }
    }
}
