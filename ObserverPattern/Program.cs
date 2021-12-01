using ObserverPattern.Classes;
using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation observable = new WeatherStation();
            IObserver observer = new Displayer(observable);
            observable.Add(observer);

            for(var i=0; i< 100; i++)
            {
                observable.UpdateTemprature();
                Console.WriteLine("Current Temprature: " + observable.GetTemprature());
            }


        }
    }
}
