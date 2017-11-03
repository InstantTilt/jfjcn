using System.Collections.Generic;

namespace NumWords.Model
{
    public interface INumberProcessorFactory
    {
        IReadOnlyList<NumberProcessor> CreateAll();
    }
}
