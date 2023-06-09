﻿using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius; //현재 섭씨 온도
        public double target; //희망 온도

        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
} 