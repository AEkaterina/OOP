using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        public static void LoadFromFile(ref CollectionType<Playground> objCollectionType)
        {
            string text = "";

            using (StreamReader sr = new StreamReader(@"D:\studing\OOP\labs\Lab_8\Lab_8\file.txt"))
            {
                while (sr.ReadLine() != null)
                {
                    text = sr.ReadLine();
                    switch (text)
                    {
                        case "Beams":
                            objCollectionType.Add(new Beams(20));
                            break;
                        case "Mats":
                            objCollectionType.Add(new Mats());
                            break;
                        case "Tennis":
                            objCollectionType.Add(new Tennis());
                            break;
                        case "Bench":
                            objCollectionType.Add(new Bench());
                            break;
                        case "Basketball":
                            objCollectionType.Add(new Basketball());
                            break;
                    }
                }
            }
        }
    }

    partial class CollectionType<T>
    {
        public void SaveInFile()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\studing\OOP\labs\Lab_8\Lab_8\file1.txt", false))
            {
                Node<T> i = GetHead;
                sw.WriteLine($"{DateTime.Now}-----------------------------------");
                while (i != null)
                {
                    sw.WriteLine(i.Date);
                    i = i.NextNode;
                }
            }
        }
    }
}

