﻿using System;
// В группе спортсменов лыжников в 2 раза больше, чем бегунов, а бегунов в 3 раза больше, чем велосипедистов. Вероятность выполнить норму для лыжника 0,9, для бегуна 0,75, для велосипедиста - 0,8. Промоделировать выбор наугад двух спортсменов и включить в программу уведомление о событии при выполнении нормы обоими спортсменами, с выводом информации об их видах спорта.
namespace EventJob
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[200];
            for (int i = 0; i < 200; i++)
            {
                if (i < 16)
                {
                    arr[i] = "велосипедист_да";
                }
                if (i >= 16 && i < 20)
                {
                    arr[i] = "велосипедист_нет";
                }
                if (i >= 20 && i < 65)
                {
                    arr[i] = "бегун_да";
                }
                if (i >= 65 && i < 80)
                {
                    arr[i] = "бегун_нет";
                }
                if (i >= 80 && i < 188)
                {
                    arr[i] = "лыжник_да";
                }
                if (i >= 188)
                {
                    arr[i] = "лыжник_нет";
                }
            }
            Random rnd = new Random();
            int j1 = rnd.Next(0, 200);
            int j2 = j1;
            string[] vybor1 = arr[j1].Split('_');
            while (j2 == j1)
            {
                j2 = rnd.Next(0, 200);
            }
            string[] vybor2 = arr[j2].Split('_');
            if (vybor1[1] == "да" && vybor2[1] == "да")
            {
                Console.Write("Норматив выполнили {0} и {1}", vybor1[0], vybor2[0]);
            }
            else
            {
                Console.Write("Двое выполнить норматив не смогли");
            }
            Console.Read();
        }
    }
}