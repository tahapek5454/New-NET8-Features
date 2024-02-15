using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;



BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);


[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net60)]
public class Benchmark
{
    private List<int> _data;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _data = Enumerable.Range(0, 100000).ToList();
    }


    [Benchmark(Baseline = true)]
    public List<int> SystemLinqWhere()
    {
        return _data
            .Where(x => x > 100 && x < 999)
            .ToList();
    }
}
