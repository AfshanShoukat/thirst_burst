using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Thirst_Burst.Services
{
    public class StylesheetService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public StylesheetService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }


        public string filePaath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "StyleSheet1.css");
            }
        }

        public string getSheetRecords()
        {
            using (var file = File.OpenText(filePaath))
            {
                return file.ReadToEnd();
            }
        }
    }
}
