    using System;
    using System.Linq;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public int[] PairAndSquared(int[] myArray){
                    var res = myArray.Where(x => x % 2 == 0).Select(y => y * y).ToArray();
                return res;
            }
      
        }
    }