using System.Collections.Generic;

namespace NumWords.Model
{
    public class DefaultNumberProcessorFactory : INumberProcessorFactory
    {
        public IReadOnlyList<NumberProcessor> CreateAll()
        {
            return new List<NumberProcessor>
            {
                new NumberProcessor(40, "for tea"),
                new NumberProcessor(1, "won", "wan"),
                new NumberProcessor(2, "too", "to"),
                new NumberProcessor(4, "for", "fore"),
                new NumberProcessor(8, "ate", "freight", "elevator", "abate", "straight", "prorate"),
            };
        }
    }
}
