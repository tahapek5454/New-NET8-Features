
namespace NewVersions.InterfaceExample
{
    public interface IBase
    {
        public int Base { get; set; }
    }
    public interface IDerived: IBase
    {
        public int Drived { get; set; }

    }
    public class DerivedImplementation : IDerived
    {
        public int Drived { get ; set ; }
        public int Base { get; set ; }
    }
}
