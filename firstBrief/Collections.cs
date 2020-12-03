using System.Collections;
using System;

namespace firstBrief
{
    public static class Collections
    {
        static ArrayList mois = new ArrayList();

        public static ArrayList collc()
        {
            mois.Add("Monday");
            mois.Add("Tuesday");
            mois.Add("Wednesday");
            mois.Add("Thursday");
            mois.Add("Friday");
            mois.Add("Saturday");
            mois.Add("Sunday");

            return mois;
        }

        public static object returnL3()
        {
            return mois[2];
        }

        public static object indexFive()
        {
            return mois[5];
        }

        public static void browse()
        {
           foreach(string day in mois)
           {
               Console.WriteLine(day);
           }
        }

        public static void changeIn()
        {
            String read = Console.ReadLine();
            int index = mois.IndexOf("Tuesday");
            mois.Insert(index,read);

        }

        public static void clone()
        {
            ArrayList cloned = (ArrayList)mois.Clone();
            cloned.Add("SSSSS");
            foreach (var cl in cloned)
            {
                Console.WriteLine(cl);
            }
        }

        public static void insertList()
        {
            mois.Insert(0,"Item");
            foreach (var item in mois)
            {
                Console.WriteLine(item);
            }
        }

        public static void delete(int index)
        {
            mois.RemoveAt(index);
        }
        
       // public static void search(int )

    }
}