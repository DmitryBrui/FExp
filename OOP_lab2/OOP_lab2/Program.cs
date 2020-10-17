using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Linq;


namespace OOP_lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            {/*
                Console.Write("bl(bool): ");
                bool bl = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine($"bl = {bl}\n");

                Console.Write("bt(byte): ");
                byte bt = Convert.ToByte(Console.ReadLine());
                Console.WriteLine($"bt= {bt}\n");

                Console.Write("sbt(sbyte): ");
                sbyte sbt = Convert.ToSByte(Console.ReadLine());
                Console.WriteLine($"sbt= {sbt}\n");

                Console.Write("ch(char): ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"ch= {ch}\n");

                Console.Write("dec(decimal): ");
                decimal dec = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"dec= {dec}\n");

                Console.Write("db(double): ");
                double db = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"db = {db}\n");

                Console.Write("fl(float): ");
                float fl = float.Parse(Console.ReadLine());
                Console.WriteLine($"fl = {fl}\n");

                Console.Write("it(int): ");
                int it = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"it = {it}\n");

                Console.Write("uit(uint): ");
                uint uit = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"uit = {uit}\n");

                Console.Write("lng(long): ");
                long lng = long.Parse(Console.ReadLine());
                Console.WriteLine($"lng = {lng}\n");

                Console.Write("ulng(ulong): ");
                ulong ulng = ulong.Parse(Console.ReadLine());
                Console.WriteLine($"ulng = {ulng}\n");

                Console.Write("sht(short): ");
                short sht = short.Parse(Console.ReadLine());
                Console.WriteLine($"sht = {sht}\n");

                Console.Write("usht(ushort): ");
                ushort usht = ushort.Parse(Console.ReadLine());
                Console.WriteLine($"usht = {usht}\n");

                Console.WriteLine("-----------------------------------\n");
            */
            } 
        
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                int iVar = 5;
                double dVar = iVar;
                long lVar = iVar;
                float  fVar = iVar;
                decimal decVar = iVar;


                byte btVar = Convert.ToByte(iVar);
                short shVar = (short)iVar;
                uint uiVar = (uint)iVar;
                ulong ul = (ulong)iVar;
                ushort ushVar = Convert.ToChar(iVar);

            object oi = iVar;
            object od = dVar;
            object ol = lVar;
            int ioVar = (int)oi;
            double odVar = (double)od;
            long olVar = (long)ol;
            Console.WriteLine($"oi = {ioVar}\n, od= {odVar}\n, ol = {olVar} ");

            var i = 5;
            Console.WriteLine(i);


            //Продемонстрируйте работу с Nullable-переменной.

            int? x1 = null;
            if (x1.HasValue)
                Console.WriteLine(x1.Value);
            else
                Console.WriteLine("x1 is equal to null");

            int? x2 = 4;
            if (x2.HasValue)
                Console.WriteLine(x2.Value);
            else
                Console.WriteLine("x2 is equal to null");


            var testEr = 15;
            //testEr = "Ошибка?";


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

          
            string root = "Дмитрий";
            string root2 = "Бруй";

            bool result = root.Equals(root2);
            Console.WriteLine($"Сравнение: <{root}> и <{root2}>  {(result ? "equal." : "not equal.")}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string str1 = "Слияние";
            string str2 = "Деление";
            string str3 = "Сравнение";

            string concatStr = String.Concat(str1, str2, str3); //сцепливание
            string copyStr = String.Copy(str2);
            string subStr = str1.Substring(3);
            string insStr = str2.Insert(3, subStr);
            //Удаление подстроки
            str3 = str3.Substring(3);
            str3 = str3.Substring(0, str3.Length - 1);

            //Интерполяция
            string name = "John Doe";
            int age = 42;

            Console.WriteLine(name + " is " + age + " years old");
            Console.WriteLine($"{name} is {age} years old");


            string s1 = null;
            string s2 = "";
            Console.WriteLine(String.IsNullOrWhiteSpace(s1));
            Console.WriteLine(String.IsNullOrWhiteSpace(s2));

            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Insert(0, "!");
            Console.WriteLine(sb);

            sb.Remove(7, 3);
            sb.AppendFormat("!");

            Console.WriteLine(sb);

            //Массивы 
            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            int rows = nums2.GetUpperBound(0) + 1;
            int columns = nums2.Length / rows;
            for (int il = 0; il < rows; il++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nums2[il, j]} \t");
                }
                Console.WriteLine();
            }

            string[] strArray = { "Mam", "LAN", "ZAR", "Kala", "Mana" };
            Console.WriteLine($" Длина массива - {strArray.Length}");
            for(int v = 0; v < strArray.Length; v++)
            {
                Console.WriteLine($"Элемент {v} - {strArray[v]}");
            }

            Console.WriteLine($"Введите позицию и значение");
            int vi = Int32.Parse(Console.ReadLine());
            string strChange = Console.ReadLine();
            strArray[vi - 1] = strChange;

            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            int[] str_index = { 2, 3, 4 };
            Console.WriteLine("Введите значение в массив \n");
            int ind = 0;
            for (int str_ar = 0; str_ar < 3; str_ar++)
            {
                for (int col_ar = 0; col_ar < str_index[ind]; col_ar++)
                {
                    myArr[str_ar][col_ar] = Int32.Parse(Console.ReadLine());
                }
                ind ++;
            }

            (int, string, char, string, ulong) corteg = (5, "Null", 'a', "Lan", 12345);
            Console.WriteLine(corteg);
            Console.WriteLine($"\n" + corteg.Item1 + corteg.Item3 + corteg.Item5);
            (int, string, char) CreateCortage(string Name)
            {
                int len = name.Length;
                string s = "My first name is" + name;
                char ch = (char)(name[0]);
                return (len, s, ch);
            }
            (int, int, int) A1 = (1, 3, 5);
            (int, int, int) A2 = (2, 4, 6);
            bool ans = A1 == A2;


            Func<int[], string, Tuple<int, int, int, char>> fun = (arr, str) => arr.Aggregate(Tuple.Create(Int32.MinValue, Int32.MaxValue, 0, str[0]), (y, x) => Tuple.Create(Math.Max(y.Item1, x), Math.Min(y.Item2, x), y.Item3 + x, y.Item4));
            Console.WriteLine(fun(new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 }, "Abracadabra"));

           int func_a ()
            {
                checked 
                {
                    int a = int.MaxValue;
                    return a;
                }
              
            }
            Console.WriteLine(func_a());
            int func_b()
            {
                unchecked
                {
                    int b = int.MaxValue;
                    return b;
                }

            }
            Console.WriteLine(func_b());
            ;
            ////////////////////////////////////с////////////////////////////////////////////////////////////////////////
        }
    }
}

