using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(BenchmarkGenericList));
            BenchmarkRunner.Run(typeof(BenchmarkStringBuilder));
        }
    }
}