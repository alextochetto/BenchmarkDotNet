using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkDotNet_GenericList
{
    [MemoryDiagnoser]
    public class BenchmarkStringBuilder
    {
        [Params(10)]
        public int Capacity { get; set; }

        [Benchmark]
        public void FixedStringBuilderCapacity()
        {
            StringBuilder stringBuilder = new StringBuilder(this.Capacity);
            for (int i = 0; i < this.Capacity; i++)
            {
                stringBuilder.Append(i);
            }
        }

        [Benchmark]
        public void NoStringBuilderCapacity()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Capacity; i++)
            {
                stringBuilder.Append(i);
            }
        }
    }
}