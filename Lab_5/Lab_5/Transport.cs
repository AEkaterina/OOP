using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Printer
    {
        public void iAmPrinting(Transport someobj)
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }
    abstract class Transport
    {

    }
}
