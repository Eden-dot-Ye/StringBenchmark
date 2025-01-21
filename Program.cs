using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace StringBenchmark
{
    [MemoryDiagnoser]
    public class StringConcatBenchmarks
    {
        private const string str1 = "Hello";
        private const string str2 = "World";
        private const string str3 = "Benchmarking";
        private const string str4 = "in C#";

        private bool condition1;
        private bool condition2;
        private bool condition3;

        [GlobalSetup]
        public void Setup()
        {
            condition1 = true;
            condition2 = false;
            condition3 = true;
        }

        [Benchmark]
        public string ConcatOperator()
        {
            string result = str1;
            if (condition1) result += str2;
            if (condition2) result += str3;
            if (condition3) result += str4;
            return result;
        }

        [Benchmark]
        public string InterpolatedString()
        {
            string result = str1;
            if (condition1) result += $"{str2}";
            if (condition2) result += $"{str3}";
            if (condition3) result += $"{str4}";
            return result;
        }

        [Benchmark]
        public string SpanConcat()
        {
            int totalLength = str1.Length;
            if (condition1) totalLength += str2.Length;
            if (condition2) totalLength += str3.Length;
            if (condition3) totalLength += str4.Length;

            Span<char> buffer = stackalloc char[totalLength];
            int offset = 0;

            str1.AsSpan().CopyTo(buffer.Slice(offset));
            offset += str1.Length;
            if (condition1)
            {
            str2.AsSpan().CopyTo(buffer.Slice(offset));
            offset += str2.Length;
            }
            if (condition2)
            {
            str3.AsSpan().CopyTo(buffer.Slice(offset));
            offset += str3.Length;
            }
            if (condition3)
            {
            str4.AsSpan().CopyTo(buffer.Slice(offset));
            offset += str4.Length;
            }

            return new string(buffer);
        }

        [Benchmark]
        public string StringConcat()
        {
            string result = str1;
            if (condition1) result = string.Concat(result, str2);
            if (condition2) result = string.Concat(result, str3);
            if (condition3) result = string.Concat(result, str4);
            return result;
        }

        [Benchmark]
        public string Join()
        {
            var parts = new List<string> { str1 };
            if (condition1) parts.Add(str2);
            if (condition2) parts.Add(str3);
            if (condition3) parts.Add(str4);
            return string.Join("", parts);
        }

        [Benchmark]
        public string StringBuilderAppend()
        {
            var sb = new StringBuilder();
            sb.Append(str1);
            if (condition1) sb.Append(str2);
            if (condition2) sb.Append(str3);
            if (condition3) sb.Append(str4);
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringConcatBenchmarks>();
            Console.WriteLine(summary);
        }
        // BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
        // Intel Core Ultra 9 185H, 1 CPU, 22 logical and 16 physical cores
        // .NET SDK 8.0.404
        //   [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
        //   DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


        // | Method              | Mean     | Error    | StdDev   | Median   | Gen0   | Allocated |
        // |-------------------- |---------:|---------:|---------:|---------:|-------:|----------:|
        // | ConcatOperator      | 10.72 ns | 0.331 ns | 0.945 ns | 10.74 ns | 0.0083 |     104 B |
        // | InterpolatedString  | 11.19 ns | 0.280 ns | 0.812 ns | 11.15 ns | 0.0083 |     104 B |
        // | SpanConcat          | 10.39 ns | 0.375 ns | 1.107 ns | 10.38 ns | 0.0045 |      56 B |
        // | StringConcat        | 11.39 ns | 0.278 ns | 0.808 ns | 11.43 ns | 0.0083 |     104 B |
        // | Join                | 36.19 ns | 0.830 ns | 2.448 ns | 36.52 ns | 0.0114 |     144 B |
        // | StringBuilderAppend | 16.01 ns | 0.371 ns | 0.957 ns | 15.69 ns | 0.0127 |     160 B |
    }
}