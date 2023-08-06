using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;

namespace StringBuilderPerformance
{
    [SimpleJob(RuntimeMoniker.Net80)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class StringBuilderVsString
    {
        [Params(1_000, 10_000, 100_000)]
        public int N;

        [Benchmark]
        public string AppendWithStringBuilder() => Util.LongStringAppendWithStringBuilder(N);
        [Benchmark]
        public string AppendWithString() => Util.LongStringAppendWithString(N);
        [Benchmark]
        public string PrependWithStringBuilder() => Util.LongStringPrependWithStringBuilder(N);
        [Benchmark]
        public string PrependWithString() => Util.LongStringPrependWithString(N);
    }
}
