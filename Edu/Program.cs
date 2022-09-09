﻿using System;

namespace Edu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=> Dates and Times:"); 
            //этот конструктор принимает годб месяц и день
            DateTime dt = new DateTime (2015, 10, 17);
            //какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            //Сейчас месяц декабрь
            dt = dt.AddMonths(2); 
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            //Этот конструктор принимает часы, минуты и секунды
            TimeSpan ts = new TimeSpan(4, 30, 0) ;
            Console.WriteLine(ts);
            //Вычесть 15 минут из текущего значения TimeSpan и вывести результат
            Console.WriteLine(ts.Subtract (new TimeSpan(0, 15, 0)));
        }
    }
}