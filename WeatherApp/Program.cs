﻿using System;
using System.Security.Cryptography.X509Certificates;
using WeatherApp.Displays;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeadIndexDisplay headIndexDisplay = new HeadIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.ReadKey();
        }
    }
}
