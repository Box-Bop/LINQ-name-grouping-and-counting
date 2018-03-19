using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lesson code examples
            //int[] myNums = new int[5];
            //myNums[0] = 10;
            //myNums[1] = 12;
            //myNums[2] = 14;
            //myNums[3] = 16;
            //myNums[4] = 18;

            //var myNumsInLIst = new List<int>();
            //myNumsInLIst.Add(2);
            //myNumsInLIst.Add(4);
            //myNumsInLIst.Add(6);
            //myNumsInLIst.Add(8);

            //List<int> myNumsInList = new List<int>(
            //    new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            //List<string> myText = new List<string>(
            //    new string[] {"abc", "bca", "cba" });

            //Human firstHuman = new Human();
            //firstHuman.Name = "Xd";
            //firstHuman.Age = 420;

            //List<Human> myHumanList = new List<Human>();
            //myHumanList.Add(firstHuman);

            //foreach (Human item in myHumanList)
            //{
            //    Console.WriteLine(item.Name + "" + item.Age);
            //}



            //int newInt = 6;

            //myNumsInList.Insert(3, newInt);

            //foreach (var item in myNumsInList)
            //{
            //    Console.WriteLine(item);
            //}


            //Grouping:

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 420 },
            //    new Human(){Name = "Malle", Age = 36 },
            //    new Human(){Name = "Talle", Age = 420 }
            //};

            ////var groups = from human in humans1
            ////             group human by human.Age == 420;

            //int[] myNumsList2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 5 };

            //var humGroup = from human in humans1
            //                group human by human.Age into newGroup
            //                select newGroup;




            //foreach (var group in humGroup)
            //{
            //    Console.WriteLine("New Group: " + group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item.Age + " " + item.Name);
            //    }
            //}
            //Console.WriteLine("\n\n");

            //var firstLetterGroup = from human in humans1
            //                       group human by human.Name[0];

            //foreach (var humanGroup in firstLetterGroup)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Key: " + humanGroup.Key);
            //    foreach (var item in humanGroup)
            //    {
            //        Console.WriteLine(item.Name + " " + item.Age);
            //    }
            //}
            #endregion Lesson code examples

            //Exercise

            var humans2 = new List<string>
            {
                "Bobert",
                "Malle",
                "Mari",
                "Allen",
                "Aleksander",
                "Kalle",
                "Madis",
                "Robert",
                "Kari",
                "Alex"
            };

            var nameLenght = from name in humans2
                             group name by name.ToString().Length;

            foreach (var name in nameLenght)
            {
                #region Showing first of each key
                //bool firstPairName = true;
                //Console.WriteLine();
                //Console.WriteLine("Key: " + name.Key);
                //foreach (var item in name)
                //{
                //    if (item.Length % 2 == 0 && firstPairName == true)
                //    {
                //        Console.WriteLine("First with lenght dividable by 2: " + item);
                //        firstPairName = false;
                //    }
                //    else
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
                #endregion Showing first of each key

                Console.WriteLine();
                Console.WriteLine("There are " + name.Count() + " names that are " + name.Key + " letters long:");
                foreach (var item in name)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
