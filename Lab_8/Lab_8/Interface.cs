using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    interface IGeneric<T>
    {
        void Add(T dt);
        void Delete(T dt);
        void Show();
    }
}
