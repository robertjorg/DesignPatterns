using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + this.temperature
                          + "F degrees and " + this.humidity + "% humidity");
        }
    }
}
