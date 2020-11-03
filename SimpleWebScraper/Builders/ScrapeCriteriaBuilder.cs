using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteriaBuilder
    {
        private string data;
        private string regex;
        private RegexOptions regexOption;
        private List<ScrapeCriteriaPart> parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            data = string.Empty;
            regex = string.Empty;
            regexOption = RegexOptions.None;
            parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteriaBuilder WithData(string data)
        {
            this.data = data;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            this.regex = regex;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegexOption(RegexOptions regexOption)
        {
            this.regexOption = regexOption;
            return this;
        }

        public ScrapeCriteriaBuilder WithPart(ScrapeCriteriaPart scrapeCriteriaPart)
        {
            parts.Add(scrapeCriteriaPart);
            return this;
        }

        public ScrapeCriteria Build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = data;
            scrapeCriteria.Regex = regex;
            scrapeCriteria.RegexOption = regexOption;
            scrapeCriteria.Parts = parts;
            return scrapeCriteria;
        }
    }
}
