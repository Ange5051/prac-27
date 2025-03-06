using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Car()
        {
            make = "Unknown";
            model = "Unknown";
            year = 0;
        }
        public Car(string model, int year)
        {
            this.make = "Unknown";
            this.model = model;
            this.year = year;
        }
        public void Print()
        {
            Console.WriteLine($"Автомобиль: {make} {model}, {year} года выпуска");
        }
    }
}
