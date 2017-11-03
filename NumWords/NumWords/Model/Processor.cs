using System.Collections.Generic;

namespace NumWords.Model
{
    public class Processor
    {
        private readonly IReadOnlyList<NumberProcessor> _numberProcessors;

        public Processor(INumberProcessorFactory factory)
        {
            _numberProcessors = factory.CreateAll();
        }

        public string Process(string input)
        {
            foreach (var processor in _numberProcessors)
            {
                input = processor.Process(input);
            }

            return input;
        }
    }
}
