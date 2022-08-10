namespace VehicleClassExample
{
    public class Vehicle
    {
        //attributes
        public string make;
        public string headquarterAddress;
        public string ceo;
        public string tickerSymbol;

        //constructors

        public Vehicle()
        {
            make = "Telsa";
            headquarterAddress = "1 Tesla Road. Austin, TX 78725";
            ceo = "Elon Musk";
            tickerSymbol = "TSLA";
        }

        public Vehicle(string make, string headquarterAdress, string ceo, string tickerSymbol)
        {
            this.make = make;
            this.headquarterAddress = headquarterAddress;
            this.ceo = ceo;
            this.tickerSymbol = tickerSymbol;
        }

        //behaviors

        public override string ToString()
        {
            return (String.Format("Make: {0}\nAddress: {1}\nCEO: {2}\nTicker:{3}", this.make, this.headquarterAddress, this.ceo, this.tickerSymbol));
        }

        //properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string HeadquarterAddress
        {
            get { return headquarterAddress; }
            set { headquarterAddress = value; }
        }

        public string CEO
        {
            get { return ceo; }
            set { ceo = value; }
        }

        public string TickerSymbol
        {
            get { return tickerSymbol; }
            set { tickerSymbol = value; }
        }

    }

    public class Car : Vehicle
    {
        //attributes
        public string model;
        public int year;
        public int baseMSRP;

        //constructors
        public Car()
        {
            model = "3";
            year = 2022;
            baseMSRP = 46990;
        }

        public Car(string model, int year, int baseMSRP)
        {
            this.model = model;
            this.year = year;
            this.baseMSRP = baseMSRP;
        }

        //behaviors
        public override string ToString()
        {
            return (String.Format("Make: {0}\nAddress: {1}\nCEO: {2}\nTicker:{3}\nModel: {4}\nYear: {5}\nBase cost: {6}", this.make, this.headquarterAddress, this.ceo, this.tickerSymbol, this.model, this.year, this.baseMSRP));
        }

        //properties
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

        public int BaseMSRP
        {
            get { return baseMSRP; }
            set { baseMSRP = value; }
        }
    }
    public class Truck : Vehicle
    {
        //attributes
        public string model;
        public int year;
        public int baseMSRP;

        //constructors
        public Truck()
        {
            model = "Cybertruck";
            year = 2023;
            baseMSRP = 39900;
        }

        public Truck(string model, int year, int baseMSRP)
        {
            this.model = model;
            this.year = year;
            this.baseMSRP = baseMSRP;
        }

        //behaviors
        public override string ToString()
        {
            return (String.Format("Make: {0}\nAddress: {1}\nCEO: {2}\nTicker:{3}\nModel: {4}\nYear: {5}\nBase cost: {6}", this.make, this.headquarterAddress, this.ceo, this.tickerSymbol, this.model, this.year, this.baseMSRP));
        }

        //properties
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

        public int BaseMSRP
        {
            get { return baseMSRP; }
            set { baseMSRP = value; }
        }
    }

    public class SUV : Vehicle
    {
        //attributes
        public string model;
        public int year;
        public int baseMSRP;

        //constructors
        public SUV()
        {
            model = "X";
            year = 2022;
            baseMSRP = 120990;
        }

        public SUV(string model, int year, int baseMSRP)
        {
            this.model = model;
            this.year = year;
            this.baseMSRP = baseMSRP;
        }

        //behaviors
        public override string ToString()
        {
            return (String.Format("Make: {0}\nAddress: {1}\nCEO: {2}\nTicker:{3}\nModel: {4}\nYear: {5}\nBase cost: {6}", this.make, this.headquarterAddress, this.ceo, this.tickerSymbol, this.model, this.year, this.baseMSRP));
        }

        //properties
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

        public int BaseMSRP
        {
            get { return baseMSRP; }
            set { baseMSRP = value; }
        }
    }
    internal static class Program
    {
        static void Main()
        {
            Vehicle newVehicle = new Vehicle();
            Console.WriteLine(newVehicle.ToString());
            Console.WriteLine("***---***---***");
            Car newCar = new Car();
            Console.WriteLine(newCar.ToString());
            Console.WriteLine("***---***---***");
            Truck newTruck = new Truck();
            Console.WriteLine(newTruck.ToString());
            SUV newSuv = new SUV();
            Console.WriteLine(newSuv.ToString());
            Console.WriteLine("***---***---***");
        }
    }
}
