using System;

namespace inheritanceExample
{

    class SoftDrinkBrand
    {
        public string? brand { get; set; }

        public void displayDetails()
        {
            Console.WriteLine("{0} is the brand", this.brand);
        }
    }
    class ProductLine : SoftDrinkBrand
    {
        public string? line { get; set; }
        public void displayDetails()
        {
            Console.WriteLine("{0} is made by {1}", this.line, this.brand);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SoftDrinkBrand CocaCola = new SoftDrinkBrand { brand = "Coca-Cola" };
            CocaCola.displayDetails();

            ProductLine Fanta = new ProductLine
            {
                brand = "Coca-Cola",
                line = "Fanta"
            };
            Fanta.displayDetails();
        }
    }
}
