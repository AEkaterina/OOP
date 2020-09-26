using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1a Определите переменные всех возможных примитивных типов С# и проинициализируйте их. 
            Осуществите ввод и вывод их значений используя консоль.*/

            bool bl = true;
            byte bt = 250;
            sbyte sb = 101;
            char ch = 'g';
            decimal dc = 2.1m;
            double dl = 95.159;
            float fl = 46.3F;
            int ii = 23;
            uint ui = 3598;
            long l = 58793;
            ulong ul = 468931687621;
            short sh = 39;
            ushort ush = 60358;
            Console.WriteLine("bool = {0}, byte = {1}, sbyte = {2}, char = {3}", bl, bt, sb, ch);
            Console.WriteLine("decimal = {0}, double = {1}, float = {2}", dc, dl, fl);
            Console.WriteLine("int = {0}, uint = {1}, long = {2}, ulong = {3}, short = {4}, ushort = {5}", ii, ui, l, ul, sh, ush);

            //1b Выполните 5 операций явного и 5 неявного приведения.
            
            //неявное
            int i = 135487;
            long il = i;
            short s = 533;
            int si = s;
            float f = 8.93F;
            double fd = f;
            int ifl = 697;
            float fli = ifl;
            long ll = 798451;
            double ld = l;

            //явное
            double dd = 896.16447;
            int id = (int)dd;
            float ff = 8.9F;
            short sf = (short)ff;
            double ddl = 648.568798;
            long dll = (long)ddl;
            float ffl = 89.34F;
            int iifl = (int)ffl;
            float fbyte = 78.45F;
            byte bfl = (byte)(fbyte);

            //1c Выполните упаковку и распаковку значимых типов. 
            Object o = ii;      //упаковка
            int x = (int)o;     //распаковка

            //1d Продемонстрируйте работу с неявно типизированной переменной
            var str = "Hello";
            Console.WriteLine(str);

            //1e Продемонстрируйте пример работы с Nullable переменной
            Nullable<int> x1 = 324;
            Console.WriteLine(x1 + "\n___________________________________________________\n\n");
        }
    }
}
