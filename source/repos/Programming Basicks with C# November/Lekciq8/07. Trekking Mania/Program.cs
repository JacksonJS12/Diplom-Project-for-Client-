using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            double m1 = 0;
            double m2 = 0;
            double m3= 0;
            double m4 = 0;
            double m5 = 0;

             int totalPeopleCount = 0;

            for (int i = 1; i < groupCount; i++)
            {
                int peopleInGtoupCount = int.Parse(Console.ReadLine());


                if (peopleInGtoupCount <= 5)
                {
                    m1 = peopleInGtoupCount;
                }
                else if (peopleInGtoupCount <= 12)
                {
                    m2 = peopleInGtoupCount;
                }
                else if (peopleInGtoupCount <= 25)
                {
                    m3 = peopleInGtoupCount;
                }
                else if (peopleInGtoupCount <= 40)
                {
                    m4 = peopleInGtoupCount;
                }
                else if (peopleInGtoupCount >= 41)
                {
                    m5 = peopleInGtoupCount;
                }
                totalPeopleCount = m1 + m2 + m3 + m4 + m5;
            }
        }
    }
}
