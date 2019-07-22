using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMgmtSystem
{
    public class InventoryChecksum
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This program was created to solve the "Day 2: Inventory Management System" challenge.
        /// You just need to click on "Start" button and see how it works! 
        /// </summary>
        /// <param name="boxIDs"></param>
        /// <returns>Repetitions</returns>
        public Repetitions Checksum(String[] boxIDs)
        {
            Repetitions repetitions = new Repetitions();
            Boolean flagForRepWith2 = false;
            Boolean flagForRepWith3 = false;

            for (int boxId = 0; boxId < boxIDs.Length; boxId++)
            {
                var idSummary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

                for (int id = 0; id < boxIDs[boxId].Length; id++)
                {
                    var character = boxIDs[boxId][id].ToString();
                    if (idSummary.ContainsKey(character))
                    {
                        idSummary[character]++;
                    }
                    else
                    {
                        idSummary.Add(character, 1);
                    }
                }
                foreach (var entry in idSummary)
                {
                    switch (entry.Value)
                    {
                        case 2:
                            if (!flagForRepWith2)
                            {
                                repetitions.idWithTwo += 1;
                            }
                            flagForRepWith2 = true;
                            break;
                        case 3:
                            if (!flagForRepWith3)
                            {
                                repetitions.idWithThree += 1;
                            }
                            flagForRepWith3 = true;
                            break;
                        default:
                            break;
                    }
                }
                flagForRepWith2 = false;
                flagForRepWith3 = false;
            }
            return repetitions;
        }
        public struct Repetitions
        {
            public int idWithTwo;
            public int idWithThree;
        }
    }
}
