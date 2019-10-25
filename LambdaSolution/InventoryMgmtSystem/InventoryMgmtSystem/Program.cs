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
            List<String> boxIDs = Properties.Resources.Input.Split('\n').ToList();

            Console.WriteLine("Cheksum: " + warehouseInventory.Checksum(boxIDs));

            Console.WriteLine("Common Letters: "+prototypeFinder.GetBoxesWithSimilarId(boxIDs));
            Console.Read();
        }
    }
}
