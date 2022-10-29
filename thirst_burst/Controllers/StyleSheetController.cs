using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thirst_Burst.Services;

namespace Thirst_Burst.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class StyleSheetController : ControllerBase
    {
        StylesheetService SheetService { get; }
        public StyleSheetController(StylesheetService sheetService)
        {
            this.SheetService = sheetService;
        }
        [HttpGet]
        public string Get()
        {
            return SheetService.getSheetRecords();
        }

    }
}
