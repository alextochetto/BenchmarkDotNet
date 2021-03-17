using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkDotNet_GenericList
{
    [MemoryDiagnoser]
    public class BenchmarkGenericList
    {
        [Params(10)]
        public int Capacity { get; set; }

        [Benchmark]
        public void FixedGenericListCapacity()
        {
            List<int> list = new List<int>(this.Capacity);
            for (int i = 0; i < this.Capacity; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void NoGenericListCapacity()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < this.Capacity; i++)
            {
                list.Add(i);
            }
        }
    }
}