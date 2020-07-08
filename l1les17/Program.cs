using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static List<string> Rezult = new List<string>();
        static int check;
        public static string BastShoe(string command)
        {
            int flag = 0;
            string[] parts = command.Split(' ');
            if((command[0]=='1')|| (command[0] == '2')|| (command[0] == '3')|| (command[0] == '4')|| (command[0] == '5'))   flag = Convert.ToInt32(parts[0]);
            string TempRezult = "!";

            if (flag == 1)
            {
                if (parts.Length > 2)
                {
                    for (int i = 1; i < parts.Length; i++)
                    {
                        TempRezult = TempRezult.Insert(TempRezult.Length, parts[i]);// добавляем во временную строку все нужные элементы с учетом пробелов
                        TempRezult = TempRezult.Insert(TempRezult.Length, " ");
                    }
                 
                    if (TempRezult[TempRezult.Length - 1] == ' ') TempRezult = TempRezult.Remove(TempRezult.Length - 1, 1);//удаляем пробел последний пробел
                    
                }
                if (parts.Length == 2)
                {
                    TempRezult = TempRezult.Insert(TempRezult.Length, parts[1]);
                }

                TempRezult = TempRezult.Remove(0, 1);

                if ((check < Rezult.Count) && (check > 0))
                {
                    string temp = Rezult[Rezult.Count - 1 - check];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }

                if ((check!=0)&&(check >= Rezult.Count))
                {
                    string temp = Rezult[0];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }


                if (Rezult.Count >= 1)
                {
                    Rezult.Add(Rezult[Rezult.Count - 1].Insert(Rezult[Rezult.Count - 1].Length, TempRezult));//добавляем строку к ранее записанному и добавлем ее последней в список 
                    check = 0;
                    return Rezult[Rezult.Count - 1];

                }

                if (Rezult.Count < 1)
                {
                    Rezult.Add(TempRezult);
                    check = 0;
                    return Rezult[Rezult.Count - 1];

                }
            }

            if (flag == 2)
            {
                int DelayList = Convert.ToInt32(parts[1]);
                if ((check<Rezult.Count)&&(check > 0))
                {
                    string temp = Rezult[Rezult.Count - 1 - check];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }

                if (check >=Rezult.Count)
                {
                    string temp = Rezult[0];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }


                if (Rezult[Rezult.Count - 1].Length > DelayList) // сравниваем длину последней строки списка List, она же длина последней "рабочей"строки
                {                                               // с количеством удаляемых элементов
                    string TempDelay = Rezult[Rezult.Count - 1];//добавляем переменную, ибо нужно в списке сохранить все действия и преобразования
                    char test = TempDelay[TempDelay.Length - 1];
                    TempDelay = TempDelay.Remove(TempDelay.Length-DelayList, DelayList);// удаляем из строки. которая послядняя в List, заданное число элементов
                    Rezult.Add(TempDelay);
                    check = 0;
                    return Rezult[Rezult.Count - 1];
                   
                }
                if (Rezult[Rezult.Count - 1].Length <= DelayList) // сравниваем длину последней строки списка List, она же длина последней "рабочей"строки
                {                                               // с количеством удаляемых элементов
                    string TempDelay = Rezult[Rezult.Count - 1];//добавляем переменную, ибо нужно в списке сохранить все действия и преобразования
                    TempDelay = TempDelay.Remove(0, TempDelay.Length);// удаляем из строки, которая послядняя в List, все элементы
                    Rezult.Add(TempDelay);
                    check = 0;
                    return Rezult[Rezult.Count - 1];

                }
            }


            if (flag == 3)
            {
                if ((check < Rezult.Count) && (check > 0))
                {
                    string temp = Rezult[Rezult.Count - 1 - check];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }

                if ((check != 0) && (check >= Rezult.Count))
                {
                    string temp = Rezult[0];
                    Rezult.Clear();
                    Rezult.Add(temp);
                }
                int SymbolIndex = Convert.ToInt32(parts[1]);
                string TempString = Rezult[Rezult.Count - 1];
                //char test3 = TempString[SymbolIndex];
                if (SymbolIndex >= TempString.Length) return null;
                else return Convert.ToString(TempString[SymbolIndex]);
            }




                if (flag == 4)
            {
                check++;
                if (check >= Rezult.Count)
                {
                    
                    return Rezult[0];

                }
                else return Rezult[Rezult.Count - 1 - check];
            }

            if (flag == 5)
            {
                check--;
                if (check >= Rezult.Count) check = Rezult.Count - 1;
                if (check < 0) check = 0;
                return Rezult[Rezult.Count - 1 - check];
            }


            if (Rezult.Count > 0) return Rezult[Rezult.Count - 1];
            else return null;
        }
        //static void Main(string[] args)
        //{

        //    string command = "1 Привет";
        //    //string newcommand = "1 , Мир!";

        //    string rezult;
        //    rezult = BastShoe(command);
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 , Мир!");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 ++");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("2 2");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 *");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("3 6");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("2 100");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 Привет");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 , Мир!");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("1 ++");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
                  
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("2 2");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    Console.WriteLine(rezult);
        //    //rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("4");
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);
        //    rezult = BastShoe("5");
        //    Console.WriteLine(rezult);


        //}
    }
}
