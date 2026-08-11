using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment03
{
    public sealed class CompletedShipment : Shipment
    {
        //public DateTime CompletionDate { get; set; }

        //public CompletedShipment(string trackingCode, string description, double weight,
        //                          double deliveryFee, DeliveryAddress address, DateTime completionDate)
        //    : base(trackingCode, description, weight, deliveryFee, address)
        //{
        //    CompletionDate = completionDate;
        //}

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Completed Shipment");
        //    base.PrintShipment();
        //    Console.WriteLine($"Completion Date : {CompletionDate:yyyy-MM-dd}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //}
    }
}
