using System;
using System.Collections.Generic;

namespace DictionaryAndSession.Models
{
    public class CountsViewModel
    {
       public Dictionary<char, int> Counts { get; set; }
       public string Text { get; set; }
    }
}
