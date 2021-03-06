using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Classes
{
    public class Singleton
    {
        private static Singleton _instance;
        public string Data = "some data";

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
