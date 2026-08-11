using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment03
{
    public class InternationalShipment : Shipment
    {
        //public string DestinationCountry { get; set; }
        //public double CustomsFee { get; set; }

        //public InternationalShipment(string trackingCode, string description, double weight,
        //                              double deliveryFee, string destinationCountry, double customsFee,
        //                              DeliveryAddress address)
        //    : base(trackingCode, description, weight, deliveryFee, address)
        //{
        //    DestinationCountry = destinationCountry;
        //    CustomsFee = customsFee;
        //}

      
        //public override double EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;


        //public virtual void GenerateCustomsReport()
        //{
        //    Console.WriteLine($"Customs report for {TrackingCode}: standard customs processing.");
        //}

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("International Shipment");
        //    base.PrintShipment();
        //    Console.WriteLine($"Destination Country : {DestinationCountry}");
        //    Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
        //    Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        //}
    }
}
