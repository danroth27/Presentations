using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentTagHelper
{
    public class DanViewComponent : ViewComponent  
    {
        private readonly string _asciiTextString;

        public DanViewComponent(IHostingEnvironment environment)
        {
            _asciiTextString = Path.Combine(environment.WebRootPath, "DanRoth.txt");
        }

        public IViewComponentResult Invoke(string jacketColor)
        {
            // mark all as star
            IEnumerable<char> jacketColors = new List<char> { 'N', 'D', '8', '0', 'M' };
            string[] ascii_text = System.IO.File.ReadAllLines(_asciiTextString);
            // jacket
            for (int i = 100; i < ascii_text.Length; i++)
            {
                foreach (char c in ascii_text[i])
                {
                    if (jacketColors.Contains(c))
                    {
                        ascii_text[i] = ascii_text[i].Replace(c, '#');
                    }
                }
            }

            // replace all stars
            string replacement = getSpan(jacketColor);
            for (int i = 0; i < ascii_text.Length; i++)
            {
                ascii_text[i] = ascii_text[i].Replace("#", replacement);
            }

            dynamic obj = new ExpandoObject();
            obj.List = ascii_text.ToList();
            return View(obj);
        }

        private string getSpan(string color)
        {
            string before = "<span style='color:" + color + "'>";
            string middle = "#";
            string end = "</span>";

            string all = before + middle + end;
            return all;
        }
    }
}
