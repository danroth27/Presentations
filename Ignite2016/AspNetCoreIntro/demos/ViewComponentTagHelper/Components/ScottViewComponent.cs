using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentTagHelper.Web
{
    public class ScottViewComponent : ViewComponent  
    {
        private readonly string _webRootPath;

        public ScottViewComponent(IHostingEnvironment environment)
        {
            _webRootPath = environment.WebRootPath;
        }

        public IViewComponentResult Invoke(string shirtColor)
        {
            string[] guthrieAscii = System.IO.File.ReadAllLines(Path.Combine(_webRootPath, "guthrie.txt"));
            string[] shirtData = System.IO.File.ReadAllLines(Path.Combine(_webRootPath, "guthrie_shirt.txt"));

            if (!string.IsNullOrEmpty(shirtColor))
            {
                string spanStart = $"<span style='color:{shirtColor}'>";
                string spanEnd = "</span>";

                for (int i = 0; i < shirtData.Length; i++)
                {
                    string[] lineData = shirtData[i].Split(',');
                    int line = int.Parse(lineData[0]) - 1;
                    int offset = 0;
                    for (int j = 1; j < lineData.Length; j++)
                    {
                        string[] columnData = lineData[j].Split('-');
                        int start = int.Parse(columnData[0]) + offset;
                        guthrieAscii[line] = guthrieAscii[line].Insert(start, spanStart);
                        offset += spanStart.Length;
                        int end = int.Parse(columnData[1]) + offset;
                        guthrieAscii[line] = guthrieAscii[line].Insert(end, spanEnd);
                        offset += spanEnd.Length;
                    }
                }
            }

            return View(guthrieAscii);
        }
    }
}
