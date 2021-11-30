using System;

namespace task4_15
{
    class Car : Auto
    {
        private int p;
        public int T = Convert.ToInt32(DateTime.Now.Year);
        public Car(string Name, int EnginePower, int NumberOfSeats, int P) : base(Name, EnginePower, NumberOfSeats)
        {
            p = P;
            countQ();
        }
        public int P 
        { 
            get=>p; set 
            {
                p = value;
                countQ();
            } 
        }
        protected override void countQ()
        {
            q = 0.1*enginePower* numberOfSeats-1.5*(T-P);
        }

        public override string ToString()
        {
            return "Название: " + name + "\nМощность двигателя: " + enginePower + "\nКоличество мест: " + numberOfSeats + "\nQ = " + q + "\nГод выпуска: " +P+"\n";
        }
    } 
}