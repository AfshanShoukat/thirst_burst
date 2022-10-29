using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using thirst_burst.Services;
using thirst_burst.Model;

namespace Thirst_Burst.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        JsonFileDrinkService DrinkService { get; }
        public DrinksController(JsonFileDrinkService drinkService)
        {
            this.DrinkService = drinkService;
        }
        [HttpGet]
        public IEnumerable<Drink> Get()
        {
            return DrinkService.getDrinkRecords();
        }

    }
}
