using System;

namespace task4_15
{
    class Auto
    {
        protected String name;
        protected int enginePower;
        protected int numberOfSeats;
        protected double q;
        public Auto(string Name, int EnginePower, int NumberOfSeats)
            {
                name = Name;
                enginePower = EnginePower;
                numberOfSeats = NumberOfSeats;
                q = (double)enginePower - numberOfSeats;
            }
            public int EnginePower
        {
            get => enginePower; set
            {
                enginePower = value;
                countQ();
            }
        }
            public int NumberOfSeats 
        { 
            get => numberOfSeats; set
            { 
                numberOfSeats = value;
                countQ();
            } 
           
    }
        public double Q
        {
            get => q;
        }

        protected virtual void countQ()
            {
              q= 0.1*enginePower * numberOfSeats;
            }

        public override string ToString()
        {
            return "Название: " + name + "\nМощность двигателя: " + enginePower + "\nКоличество мест: " + numberOfSeats + "\nQ = " + q+ "\n";
            }
    }
    }