using thirst_burst.Model;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace thirst_burst.Services
{
    public class JsonFileDrinkService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileDrinkService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }


        public string filePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "drinks.json");
            }
        }

        public IEnumerable<Drink> getDrinkRecords()
        {
            using (var file = File.OpenText(filePath))
            {
                return JsonSerializer.Deserialize<Drink[]>(file.ReadToEnd());
            }
        }

        public void setDrinkRecords(string finalData)
        {
            StreamWriter file_stream = new StreamWriter(filePath);
            file_stream.Write(finalData);
            file_stream.Flush();
            file_stream.Close();
        }
    }
}
