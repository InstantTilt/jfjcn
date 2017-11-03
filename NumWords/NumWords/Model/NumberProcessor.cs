using System;
using System.Text.RegularExpressions;
using Humanizer;

namespace NumWords.Model
{
    public class NumberProcessor
    {
        private readonly int _number;
        private readonly Regex _regex;

        public NumberProcessor(int number, params string[] variations)
        {
            if (variations == null)
                throw new ArgumentNullException(nameof(variations));
            _number = number;
            _regex = new Regex($@"\b({string.Join("|", variations)})\b", RegexOptions.IgnoreCase);
        }   

        public string Process(string source)
        {
            if (!_regex.IsMatch(source))
                return source;

            return _regex.Replace(source, (_number + 1).ToWords());
        }
    }
}
