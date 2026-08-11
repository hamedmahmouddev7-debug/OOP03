using System.Text;

namespace OOPAssignment03
{    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // (A) Overloading: Same method name, but different parameters in the same class.
            //      Overriding: A child class changes the method of the parent class.

            // (B) Static Binding: The method to call is decided at compile time.
            //      Dynamic Binding: The method to call is decided at runtime.
            #endregion

            #region Question02
            // (A) sealed on a class prevents any other class from inheriting from it.


            // (B) A sealed class blocks inheritance from the entire class. A sealed method only blocks that specific overridden method from being overridden again further down the hierarchy — the class itself can still be inherited


            //  (C)  No, it cannot be overridden again. Once a method is marked sealed override, it stops the override chain — no further derived class can override it.
            #endregion
            #region Question03 With AI
        //    Console.WriteLine("==========================================");
        //    Console.WriteLine("Delivery Center");
        //    Console.WriteLine("==========================================");

        //    // a. Create a Driver
        //    Driver driver = new Driver("D001", "Ahmed Mohamed", "01000000000");

        //    // b. Create a DeliveryCenter
        //    DeliveryCenter center = new DeliveryCenter();

        //    // c. Assign the Driver to the DeliveryCenter
        //    center.Driver = driver;
        //    Console.WriteLine($"Driver : {center.Driver.FullName}");

        //    // d. Create one StandardShipment
        //    var standard = new StandardShipment(
        //        "SH001", "Laptop", 3, 80,
        //        new DeliveryAddress("12 Tahrir St", "Cairo", "Egypt"));

        //    // e. Create one ExpressShipment
        //    var express = new ExpressShipment(
        //        "SH002", "Mobile Phone", 2, 60, 30,
        //        new DeliveryAddress("5 Corniche Rd", "Alexandria", "Egypt"));

        //    // f. Create one InternationalShipment
        //    var international = new InternationalShipment(
        //        "SH003", "Television", 8, 120, "Germany", 100,
        //        new DeliveryAddress("9 Berlin Ave", "Berlin", "Germany"));

        //    // g. Add all shipments to the DeliveryCenter
        //    center.AddShipment(standard);
        //    center.AddShipment(express);
        //    center.AddShipment(international);

        //    // h. Print all shipments using PrintAllShipments()
        //    Console.WriteLine("--------------------------------------------");
        //    center.PrintAllShipments();

        //    // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
        //    Console.WriteLine("==========================================");
        //    Console.WriteLine("Printing Using DeliveryHelper...");
        //    DeliveryHelper.PrintShipmentDetails(standard);
        //    DeliveryHelper.PrintShipmentDetails(express);
        //    DeliveryHelper.PrintShipmentDetails(international);

        //    // j. Demonstrate both versions of UpdateWeight()
        //    Console.WriteLine("==========================================");
        //    Console.WriteLine("Updating Weight...");
        //    Console.WriteLine($"Original Weight : {standard.Weight} KG");
        //    standard.UpdateWeight(5);
        //    Console.WriteLine($"Updated Weight : {standard.Weight} KG");
        //    standard.UpdateWeight(5, 0.5);
        //    Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

        //    // k. Build a Shipment[] holding mixed types and print all in a loop
        //    Console.WriteLine("==========================================");
        //    Console.WriteLine("Printing Using Shipment[]...");
        //    Shipment[] mixed = { standard, express, international };
        //    foreach (Shipment s in mixed)
        //        Console.WriteLine($"{s.GetType().Name}...");
        //    Console.WriteLine("==========================================");

        //    // l. Demonstrate the sealed class and sealed method
        //    var completed = new CompletedShipment(
        //        "SH004", "Books", 1, 40,
        //        new DeliveryAddress("1 Nile St", "Giza", "Egypt"), DateTime.Now);
        //    completed.PrintShipment();

        //    var priorityIntl = new PriorityInternationalShipment(
        //        "SH005", "Medical Equipment", 15, 200, "France", 150,
        //        new DeliveryAddress("2 Paris Blvd", "Paris", "France"));
        //    priorityIntl.GenerateCustomsReport();
        //}
        #endregion
    }
    }
}   