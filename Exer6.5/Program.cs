using System;

namespace Exer6._5
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double TotalCost() => unitCount * unitCost;

            public string OrderInformation() => $"Order Information: {unitCount} {itemName} items at ${unitCost} each, total cost ${TotalCost()}";
            //{
            //    return $"Order Information: {unitCount} {itemName} items at ${unitCost} each, total cost ${TotalCost()}";
            //}
        }

        static void Main(string[] args)
        {
            order MyOrder = new order() { itemName = "Book", unitCost=3.99, unitCount=5 };

            Console.WriteLine(MyOrder.OrderInformation());
        }
    }
}
