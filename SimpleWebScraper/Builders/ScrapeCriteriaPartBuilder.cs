using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteriaPartBuilder
    {
        /*public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }*/
        private string regex;
        private RegexOptions regexOption;

        private void SetDefaults()
        {
            regex = string.Empty;
            regexOption = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder WithRegex(string regex)
        {
            this.regex = regex;
            return this;
        }

        public ScrapeCriteriaPartBuilder WithRegexOption(RegexOptions regexOption)
        {
            this.regexOption = regexOption;
            return this;
        }
        
        public ScrapeCriteriaPart Build()
        {
            ScrapeCriteriaPart scrapeCriteriaPart = new ScrapeCriteriaPart();

            scrapeCriteriaPart.Regex = regex;
            scrapeCriteriaPart.RegexOption = regexOption;
            return scrapeCriteriaPart;
        }
    }
}
