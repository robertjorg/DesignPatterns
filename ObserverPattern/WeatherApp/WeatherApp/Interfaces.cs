using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObserver();
    }

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }
}
