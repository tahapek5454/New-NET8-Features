
using System.Runtime.CompilerServices;

namespace NewVersions
{
    public static class Interception
    {
        // [InterceptsLocation(filePath: "C:\\Users\\taha.pek\\net\\New-NET\\NewVersions\\Program.cs", line: 138, column: 3)]
        public static void InterceptMethod1(this Example example)
        {
            Console.WriteLine("Intecept Method 1");
        }
    }
}
