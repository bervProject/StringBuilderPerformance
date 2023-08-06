using BenchmarkDotNet.Running;
using StringBuilderPerformance;

var summary = BenchmarkRunner.Run<StringBuilderVsString>();
