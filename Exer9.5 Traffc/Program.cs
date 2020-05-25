using Exer9._4_Vehicles;
using static System.Console;

namespace Exer9._5_Traffc
{
    class Program
    {
        static void Main(string[] args)
        {
            Compact compact = new Compact();
            SUV sUV = new SUV();
            PassengerTrain passengerTrain = new PassengerTrain();

            AddPassenger(compact);
            AddPassenger(sUV);
            AddPassenger(passengerTrain);
        }

        static void AddPassenger(IPassengerCarrier passengerCarrier)
        {
            WriteLine(passengerCarrier.ToString());
        }
    }
}
