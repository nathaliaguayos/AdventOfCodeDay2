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
            InventoryChecksum inventoryChecksum = new InventoryChecksum();
            String[] boxIDs = new string[7]{ "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };            
            var idRep = inventoryChecksum.Checksum(boxIDs);
            Console.WriteLine("The checksum is: " + idRep.idWithTwo + " X " + idRep.idWithThree + " = " + (idRep.idWithTwo * idRep.idWithThree));

            Console.Read();
        }
    }
}
