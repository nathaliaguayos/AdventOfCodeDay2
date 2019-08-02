using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMgmtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryChecksum warehouseInventory = new InventoryChecksum();
            PrototypeFinder prototypeFinder = new PrototypeFinder();
            String[] boxIDs = Properties.Resources.Input.Split('\n');
            var idRep = warehouseInventory.Checksum(boxIDs);

            Console.WriteLine("====== Day 2: Inventory Management System ======\n\nPart 1");
            Console.WriteLine("The checksum is: " + idRep.idWithTwo + " X " + idRep.idWithThree + " = " + (idRep.idWithTwo * idRep.idWithThree));
            Console.WriteLine("\n\nPart 2");
            Console.WriteLine(prototypeFinder.GetBoxesWithSimilarId(boxIDs));
            Console.Read();
        }
    }
}
