using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersions
{
    public class MyClass(int sayi)
    {
        public string Sayi
        {
            get
            {
                return sayi.ToString();
            }
        }




    }


    public enum ShapeTypes
    {
        Kare = 1,
        Daire = 2,
        Ucgen = 3
    }
}
