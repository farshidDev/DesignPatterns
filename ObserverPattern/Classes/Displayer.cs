using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Classes
{
    public class Displayer: IObserver
    {
        private WeatherStation _station;

        public Displayer(WeatherStation station)
        {
            _station = station;
        }

        public void Update()
        {
            Console.WriteLine("State Updated: "+ _station.GetTemprature());
        }
    }
}
