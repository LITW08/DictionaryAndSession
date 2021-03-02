using DictionaryAndSession.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryAndSession.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WordCount(string text)
        {
            var counts = GetCounts(text);
            var vm = new CountsViewModel {Counts = counts, Text = text};
            return View(vm);
        }
        
        private Dictionary<char, int> GetCounts(string text)
        {
            Dictionary<char, int> counts = new();
            foreach(char character in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            {
                counts.Add(character, 0);
            }

            foreach (var character in text.ToUpper())
            {
                if (counts.ContainsKey(character))
                {
                    counts[character]++;
                }
                else
                {
                    counts[character] = 1;
                }
            }

            return counts;
        }
    }
}
