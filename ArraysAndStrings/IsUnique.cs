using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class IsUnique
    {
        /// <summary>
        /// This would be a O(n^2) solution as toVerify has " n " symbols and 
        /// we have 2 nested loops iterating over the length so we multiply n*n = n^2
        /// </summary>
        /// <param name="toVerify"></param>
        /// <returns>
        /// True if no matches, False if there is a matching simbol
        /// </returns>
        public bool UniqueCheckerBruteForce(string toVerify)
        {
            for (int i = 0; i < toVerify.Length; i++)
            {
                for (int j = 1; j <= toVerify.Length - 1; j++)
                {
                    if (toVerify[i] == toVerify[j] && i != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Because the search in a hashset is a constant operation of O(1) and we only iterate once over the whole
        /// string, it means that we have improved the algorithm significantly, reducing it to O(n)
        /// </summary>
        /// <param name="toVerify"></param>
        /// <returns></returns>
        public bool UniqueCheckerWithAdditionalStructure(string toVerify)
        {
            HashSet<int> unique = new HashSet<int>();
            for (int i = 0; i < toVerify.Length; i++)
            {
                if (!unique.Contains(toVerify[i]))
                {
                    unique.Add(toVerify[i]);
                }
                else { return false; }
            }
            return true;
        }
        /// <summary>
        /// Time complexity of this algorith is O(n) because we iterate only once over the whole string and 
        /// we don't have any additional structures.
        /// </summary>
        /// <param name="toVerify"></param>
        /// <returns></returns>
        public bool UniqueCheckWithoutAnyStructures(string toVerify)
        {
            //assuming string can have characters a-z this has 32 bits set to 0
            int checker = 0;
            for (int i = 0; i < toVerify.Length; i++)
            {
                int bitAtIndex = toVerify[i] - 'a';
                //if that bit is already set in checker return false
                if ((checker & (1 << bitAtIndex)) > 0)
                {
                    return false;
                }
                //set that bit in checker and proceed
                checker = (checker | (1 << bitAtIndex));
            }
            return true;
        }
    }
}
