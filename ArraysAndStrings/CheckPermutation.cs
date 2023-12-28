using System.Collections;

namespace ArraysAndStrings
{
    public class CheckPermutation
    {
        /// <summary>
        /// This would check if b is a permutation of a
        /// Permutation is if all symbols in b, match symbols in a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True if permutation, false if not</returns>
        public bool IsPermutation(string a, string b)
        {
            //abab == abba 
            //if they are different in length, it means one is not permutation of the other, so no point in checking further
            if (a.Length != b.Length) return false;
            //Assumung ASCII we create an array with size 128
            int[] leters = new int[128];
            for (int i = 0; i < a.Length; i++)
            {
                //we iterate over the initial string increment the value of the chars (i.e for "a" we will increment value 97 as per the ascii table)
                leters[a[i]]++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                //we iterate over the second string and we decrement the value of the chars at their respective position
                leters[b[i]]--;
                if (leters[b[i]] < 0)
                {
                    //if a value ever becomes negative, that means it exists more times in the second string. In other terms it is different from the first,so we return false
                    return false;
                }
            }
            return true;
        }
    }
}
