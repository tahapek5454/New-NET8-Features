

namespace NewVersions
{
    public readonly struct MyStruct
    {
        public readonly double Height { get; }
        public readonly double Width { get; }
        // public int MyProperty { get; set; }
        public double Area => (Height * Width);
        public MyStruct(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override string ToString()
        {
            return $"(Toplam alan Yükseklik: {Height}cm, Genişlik: {Width}cm) için {Area}'dır";
        }
    }
}
