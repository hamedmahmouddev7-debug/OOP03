using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment03
{
    public class DeliveryCenter
    {
        //public Driver Driver { get; set; }

        //private Shipment[] shipments;
        //private int count;

        //public DeliveryCenter(int capacity = 10)
        //{
        //    shipments = new Shipment[capacity];
        //    count = 0;
        //}

        //public void AddShipment(Shipment shipment)
        //{
        //    if (count == shipments.Length)
        //        Array.Resize(ref shipments, shipments.Length * 2);
        //    shipments[count] = shipment;
        //    count++;
        //}

        //public void RemoveShipment(string trackingCode)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (shipments[i].TrackingCode == trackingCode)
        //        {
        //            for (int j = i; j < count - 1; j++)
        //                shipments[j] = shipments[j + 1];
        //            shipments[count - 1] = null;
        //            count--;
        //            return;
        //        }
        //    }
        //}

      
        //public Shipment this[int index]
        //{
        //    get => (index >= 0 && index < count) ? shipments[index] : null;
        //}

        //public Shipment this[string trackingCode]
        //{
        //    get
        //    {
        //        for (int i = 0; i < count; i++)
        //            if (shipments[i].TrackingCode == trackingCode)
        //                return shipments[i];
        //        return null;
        //    }
        //}

        //public int Count => count;

      
        //public void PrintAllShipments()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        shipments[i].PrintShipment();
        //        Console.WriteLine("--------------------------------------------");
        //    }
        //}
    }
}
