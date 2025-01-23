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
    }
}