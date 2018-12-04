using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float min = Single.MaxValue;
        private float max = Single.MinValue;
        private float total;
        private float count;
        private float avg;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(WeatherData weatherData)
        {
            this.total += weatherData.temperature;
            this.count += 1;
            if (weatherData.temperature < this.min)
            {
                this.min = temperature;
            }

            if (temperature > this.max)
            {
                this.max = temperature;
            }

            this.avg = this.total / this.count;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + this.avg + "/" + this.max + "/" + this.min);
        }
    }
}
