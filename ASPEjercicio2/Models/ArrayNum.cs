using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPEjercicio2.Models
{
    public class ArrayNum
    {
        public List<int> ArrayNums { get; set; }
        public int Nmayor { get; set; }
        public int Nmenor { get; set; }

        public static int Omayor(IEnumerable<int> ArrayNum)
        {
            int mayor = int.MinValue;
            foreach (int num in ArrayNum)
                if (num > mayor)
                    mayor = num;
            return mayor;
        }

        public static int Omenor(IEnumerable<int> ArrayNum)
        {
            int menor = int.MaxValue;
            foreach (int num in ArrayNum)
                if (num < menor)
                    menor = num;
            return menor;
        }

    }
}
