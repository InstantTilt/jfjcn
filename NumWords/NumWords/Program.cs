using System;
using NumWords.Model;

namespace NumWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            var proc = new Processor(new DefaultNumberProcessorFactory());
            Console.WriteLine("Enter sentence and press Enter or leave it blank to exit");
            while (true)
            {
                Console.Write("Your sentence: ");
                var r = Console.ReadLine();
                if (string.IsNullOrEmpty(r))
                    break;
                var processedMsg = proc.Process(r);
                Console.WriteLine($"Processed: {processedMsg}");
            }
        }
    }
}
