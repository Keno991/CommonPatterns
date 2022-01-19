using Patterns;
using Patterns.Builder;
using Patterns.Mediator;
using System;

namespace PatternsTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Pattern To Execute: \n(available patterns: builder, mediator)");

            string pattern = Console.ReadLine();

            IPattern selectedPattern = null;
            switch (pattern)
            {
                case "builder":
                    selectedPattern = new BuilderPatternExecutor();
                    break;
                case "mediator":
                    selectedPattern = new MediatorPatternExecutor();
                    break;
                default:
                    throw new NotImplementedException("Pattern not implemented, program will exit");
            }

            selectedPattern.run();
        }
    }
}
