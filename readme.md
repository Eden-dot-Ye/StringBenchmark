## String operation dotnet benchmark

### Result

```
// AfterAll
// Benchmark Process 10644 has exited with code 0.

Mean = 17.776 ns, StdErr = 0.199 ns (1.12%), N = 92, StdDev = 1.908 ns
Min = 15.060 ns, Q1 = 16.252 ns, Median = 17.607 ns, Q3 = 18.858 ns, Max = 23.279 ns
IQR = 2.606 ns, LowerFence = 12.343 ns, UpperFence = 22.767 ns
ConfidenceInterval = [17.100 ns; 18.453 ns] (CI 99.9%), Margin = 0.676 ns (3.80% of Mean)
Skewness = 0.76, Kurtosis = 3.19, MValue = 2.36

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-01-23 16:00 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\StringBenchmark.StringConcatBenchmarks-report.csv
  BenchmarkDotNet.Artifacts\results\StringBenchmark.StringConcatBenchmarks-report-github.md
  BenchmarkDotNet.Artifacts\results\StringBenchmark.StringConcatBenchmarks-report.html

// * Detailed results *
StringConcatBenchmarks.ConcatOperator: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 11.606 ns, StdErr = 0.072 ns (0.62%), N = 21, StdDev = 0.332 ns
Min = 11.222 ns, Q1 = 11.307 ns, Median = 11.542 ns, Q3 = 11.701 ns, Max = 12.354 ns
IQR = 0.394 ns, LowerFence = 10.716 ns, UpperFence = 12.292 ns
ConfidenceInterval = [11.327 ns; 11.884 ns] (CI 99.9%), Margin = 0.279 ns (2.40% of Mean)
Skewness = 0.79, Kurtosis = 2.43, MValue = 2
-------------------- Histogram --------------------
[11.064 ns ; 11.592 ns) | @@@@@@@@@@@@@
[11.592 ns ; 11.930 ns) | @@@@
[11.930 ns ; 12.512 ns) | @@@@
------------------------------

StringConcatBenchmarks.InterpolatedString: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 10.428 ns, StdErr = 0.074 ns (0.71%), N = 66, StdDev = 0.605 ns
Min = 9.483 ns, Q1 = 9.983 ns, Median = 10.318 ns, Q3 = 10.858 ns, Max = 12.256 ns
IQR = 0.874 ns, LowerFence = 8.671 ns, UpperFence = 12.169 ns
ConfidenceInterval = [10.171 ns; 10.685 ns] (CI 99.9%), Margin = 0.257 ns (2.46% of Mean)
Skewness = 0.6, Kurtosis = 2.95, MValue = 3
-------------------- Histogram --------------------
[ 9.482 ns ;  9.947 ns) | @@@@@@@@@@@@@@
[ 9.947 ns ; 10.340 ns) | @@@@@@@@@@@@@@@@@@@@@
[10.340 ns ; 10.585 ns) | @@@@
[10.585 ns ; 10.978 ns) | @@@@@@@@@@@@@@@@
[10.978 ns ; 11.402 ns) | @@@@@@@@
[11.402 ns ; 11.890 ns) | @@
[11.890 ns ; 12.453 ns) | @
---------------------------

StringConcatBenchmarks.SpanConcat: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 10.712 ns, StdErr = 0.089 ns (0.83%), N = 91, StdDev = 0.847 ns
Min = 9.385 ns, Q1 = 10.097 ns, Median = 10.445 ns, Q3 = 11.212 ns, Max = 13.409 ns
IQR = 1.115 ns, LowerFence = 8.425 ns, UpperFence = 12.883 ns
ConfidenceInterval = [10.410 ns; 11.014 ns] (CI 99.9%), Margin = 0.302 ns (2.82% of Mean)
Skewness = 0.94, Kurtosis = 3.42, MValue = 2.26
-------------------- Histogram --------------------
[ 9.138 ns ;  9.456 ns) | @
[ 9.456 ns ;  9.968 ns) | @@@@@@@@@@@@@@@
[ 9.968 ns ; 10.462 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[10.462 ns ; 11.016 ns) | @@@@@@@@@@@@@@@@@
[11.016 ns ; 11.554 ns) | @@@@@@@@@@@@@
[11.554 ns ; 12.133 ns) | @@@@@@@@
[12.133 ns ; 12.514 ns) | @
[12.514 ns ; 13.162 ns) | @@@@
[13.162 ns ; 13.657 ns) | @
---------------------------

StringConcatBenchmarks.StringConcat: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 11.988 ns, StdErr = 0.215 ns (1.80%), N = 96, StdDev = 2.111 ns
Min = 9.568 ns, Q1 = 10.333 ns, Median = 11.285 ns, Q3 = 13.218 ns, Max = 18.012 ns
IQR = 2.885 ns, LowerFence = 6.005 ns, UpperFence = 17.545 ns
ConfidenceInterval = [11.256 ns; 12.719 ns] (CI 99.9%), Margin = 0.732 ns (6.10% of Mean)
Skewness = 1.08, Kurtosis = 3.3, MValue = 2.94
-------------------- Histogram --------------------
[ 8.963 ns ;  9.626 ns) | @
[ 9.626 ns ; 10.836 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[10.836 ns ; 12.150 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@
[12.150 ns ; 13.718 ns) | @@@@@@@@@@@@@@@
[13.718 ns ; 14.881 ns) | @@@@@@@@
[14.881 ns ; 16.183 ns) | @@@@
[16.183 ns ; 17.393 ns) | @@@@@
[17.393 ns ; 18.617 ns) | @@
----------------------------

StringConcatBenchmarks.Join: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 35.388 ns, StdErr = 0.223 ns (0.63%), N = 81, StdDev = 2.011 ns
Min = 31.913 ns, Q1 = 34.277 ns, Median = 35.172 ns, Q3 = 36.770 ns, Max = 39.952 ns
IQR = 2.494 ns, LowerFence = 30.536 ns, UpperFence = 40.511 ns
ConfidenceInterval = [34.624 ns; 36.151 ns] (CI 99.9%), Margin = 0.763 ns (2.16% of Mean)
Skewness = 0.41, Kurtosis = 2.61, MValue = 2.79
-------------------- Histogram --------------------
[31.303 ns ; 32.189 ns) | @
[32.189 ns ; 33.409 ns) | @@@@@@@@@@@@@@@
[33.409 ns ; 34.300 ns) | @@@@@
[34.300 ns ; 36.099 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[36.099 ns ; 37.319 ns) | @@@@@@@@@@@@@@@@
[37.319 ns ; 38.570 ns) | @@@@
[38.570 ns ; 40.184 ns) | @@@@@@@
---------------------------------

StringConcatBenchmarks.StringBuilderAppend: DefaultJob
Runtime = .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 17.776 ns, StdErr = 0.199 ns (1.12%), N = 92, StdDev = 1.908 ns
Min = 15.060 ns, Q1 = 16.252 ns, Median = 17.607 ns, Q3 = 18.858 ns, Max = 23.279 ns
IQR = 2.606 ns, LowerFence = 12.343 ns, UpperFence = 22.767 ns
ConfidenceInterval = [17.100 ns; 18.453 ns] (CI 99.9%), Margin = 0.676 ns (3.80% of Mean)
Skewness = 0.76, Kurtosis = 3.19, MValue = 2.36
-------------------- Histogram --------------------
[14.505 ns ; 15.183 ns) | @
[15.183 ns ; 16.292 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[16.292 ns ; 17.129 ns) | @@@@@@@@@@@@@
[17.129 ns ; 18.238 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[18.238 ns ; 19.704 ns) | @@@@@@@@@@@@@@@@
[19.704 ns ; 20.813 ns) | @@@@@@@@@@@
[20.813 ns ; 21.681 ns) | @
[21.681 ns ; 22.245 ns) |
[22.245 ns ; 23.355 ns) | @@@@
------------------------------

// * Summary *

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
Intel Core Ultra 9 185H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 8.0.404
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

| Method              |     Mean |    Error |   StdDev |   Median |   Gen0 | Allocated |
| ------------------- | -------: | -------: | -------: | -------: | -----: | --------: |
| ConcatOperator      | 11.61 ns | 0.279 ns | 0.332 ns | 11.54 ns | 0.0083 |     104 B |
| InterpolatedString  | 10.43 ns | 0.257 ns | 0.605 ns | 10.32 ns | 0.0083 |     104 B |
| SpanConcat          | 10.71 ns | 0.302 ns | 0.847 ns | 10.45 ns | 0.0045 |      56 B |
| StringConcat        | 11.99 ns | 0.732 ns | 2.111 ns | 11.29 ns | 0.0083 |     104 B |
| Join                | 35.39 ns | 0.763 ns | 2.011 ns | 35.17 ns | 0.0114 |     144 B |
| StringBuilderAppend | 17.78 ns | 0.676 ns | 1.908 ns | 17.61 ns | 0.0127 |     160 B |

// * Warnings *
MultimodalDistribution
  StringConcatBenchmarks.InterpolatedString: Default -> It seems that the distribution can have several modes (mValue = 3)
  StringConcatBenchmarks.StringConcat: Default       -> It seems that the distribution can have several modes (mValue = 2.94)

// * Hints *
Outliers
  StringConcatBenchmarks.ConcatOperator: Default      -> 3 outliers were removed (15.89 ns..17.66 ns)
  StringConcatBenchmarks.InterpolatedString: Default  -> 3 outliers were removed (14.92 ns..15.77 ns)
  StringConcatBenchmarks.SpanConcat: Default          -> 9 outliers were removed (15.99 ns..19.95 ns)
  StringConcatBenchmarks.StringConcat: Default        -> 4 outliers were removed (21.51 ns..22.92 ns)
  StringConcatBenchmarks.Join: Default                -> 5 outliers were removed (43.97 ns..47.27 ns)
  StringConcatBenchmarks.StringBuilderAppend: Default -> 8 outliers were removed (26.15 ns..31.50 ns)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Gen0      : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *

// ***** BenchmarkRunner: End *****
Run time: 00:08:00 (480.82 sec), executed benchmarks: 6

Global total time: 00:08:06 (486.35 sec), executed benchmarks: 6
// * Artifacts cleanup *
Artifacts cleanup is finished
BenchmarkDotNet.Reports.Summary
```