using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Genclass<T>
    {
        private T[] inputArr;
        public Genclass(T[] inputArr3)
        {
            inputArr = inputArr3;
        }
        public void PrintArray()
        {
            foreach ( T item in inputArr )
            {
                Console.WriteLine(item);
            }
        }
    }
}
