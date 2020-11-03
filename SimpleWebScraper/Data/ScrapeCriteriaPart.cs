using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        /*public List<ScrapeCriteriaPart> Parts { get; set; }

        public ScrapeCriteriaPart()
        {
            Parts = new List<ScrapeCriteriaPart>();
        }*/
    }
}
