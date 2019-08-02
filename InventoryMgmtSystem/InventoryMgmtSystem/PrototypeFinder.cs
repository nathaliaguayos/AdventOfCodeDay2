using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryMgmtSystem
{
    public class PrototypeFinder
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This method is in charge of get the boxes that contains similar IDs
        /// </summary>
        /// <param name="boxIDs"></param>
        /// <returns></returns>
        public string GetBoxesWithSimilarId(String[] boxIDs)
        {
            var listOfIDsPermutated = InventoryPermutation(boxIDs);
            var boxesWithSimilarId = listOfIDsPermutated.GroupBy(ids => ids)
                .Where(boxes => boxes.Count() > 1)
                .Select(boxId => new{ boxId.Key}).FirstOrDefault();

            // Return the selected box after removing the '*' character.
            return boxesWithSimilarId.Key.Replace("*", "");
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This method is in charge of create a new string which is a copy of the original,
        /// changing each character for an '*' in each iteration and return a list with all of those
        /// string to be evaluated and find the boxes that contains similar IDs.
        /// </summary>
        /// <param name="boxIDs"></param>
        /// <returns></returns>
        private List<string> InventoryPermutation(String[] boxIDs)
        {
            List<string> list = new List<string>();
            foreach (var item in boxIDs)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    var charArrayOfItem = item.ToCharArray();
                    charArrayOfItem[i] = '*';

                    list.Add(new string(charArrayOfItem));
                }
            }

            return list;
        }
    }
}
