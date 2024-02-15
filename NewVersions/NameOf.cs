using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersions
{
    internal class NameOf
    {
        public string S { get; } = "as";
        public static int StaticField;
        public string NameOfLength { get; } = nameof(S.Length);

        public static void NameOfExamples()
        {
            Console.WriteLine(nameof(S.Length));
            Console.WriteLine(nameof(StaticField.MinValue));
        }

        [Description($"String {nameof(S.Length)}")]
        public int StringLength(string s)
        {
            return s.Length;
        }
    }
}
