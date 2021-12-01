using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Classes
{
    public class WeatherStation: IObservable
    {
        private List<IObserver> Observers = new List<IObserver>();
        private int _temprature = 0;
        private Random _rnd = new Random();


        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }


        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var item in Observers)
            {
                item.Update();
            }
        }

        public int GetTemprature() => this._temprature;

        public void UpdateTemprature()
        {
            var nTemprature = _rnd.Next(0, 2);
            if(nTemprature != _temprature)
            {
                _temprature = nTemprature;
                Notify();
            }
        }

        
    }
}
