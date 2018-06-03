using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Durstenfeld_Algorithm
{




    class Program
    {
        static void Main(string[] args)
        {

            //List<int> scratch = new List<int> {1, 2, 3, 4, 5, 6, 7, 8};
            //List<int> result = new List<int>(scratch.Count);

            //Random rnd = new Random(DateTime.Now.Millisecond);

            //var length = scratch.Count;

            //for (int index = 0; index < length; index++)
            //{
            //                // First loop: 1-8
            //    int random = rnd.Next(1, scratch.Count);
            //    var buffer = scratch[random - 1]; // Store picked number.

            //    // Swap the last element of the list, into the random index.
            //    scratch[random - 1] = scratch[scratch.Count - 1];
            //    // Remove the last element at list now.
            //    scratch.RemoveAt( (scratch.Count - 1) );
            //    // Now add buffered (selected) item to results.
            //    result.Add(buffer);



            //}

            /*
            #region oldcode

            var myInts = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,19,20,21,22,23,24,25,
                26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,
                51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,
                76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100
            };

            // myInts = Shuffle(myInts);

            foreach (var number in myInts)
            {
                Console.Write($"{number} ");

                if (number == myInts[myInts.Count - 1])
                {
                    Console.WriteLine("\n");
                }
            }
            #endregion
            */

            Func<int, string> someFunc = new Func<int, string>(IntArgReturningStringFunction);
            Action<int> someAction = new Action<int>(SomeVoidAction);

            Console.WriteLine(someFunc.Invoke(5));
            someAction.Invoke(1994);

            FuncTakingFunction(someFunc);



        }



        public static void FuncTakingFunction(Func<int, string> target)
        {
            //target.Invoke(100);
            Console.WriteLine(target.Invoke(100));
        }




        public static void SomeVoidAction(int arg)
        {
            Console.WriteLine(Convert.ToString(arg));
        }

        public static string IntArgReturningStringFunction(int arg)
        {

            switch (arg)
            {
                case 0:
                    return "0";
                    
                default:
                    return "1337";
                    
            }



        }




        public static List<int> Shuffle(List<int> shuflee)
        {
            var results = new List<int>(shuflee.Capacity);
            var rng = new Random(DateTime.Now.Millisecond);

            var numLoops = shuflee.Count;

            for (int index = 0; index < numLoops; index++)
            {
                // Generate random number from 1 to N (N = Number of elemenets remaining in shuflee)
                int random = rng.Next(1, shuflee.Count);

                // Allocate a buffer for our randomly chosen index.
                var buffer = shuflee[random - 1];

                // Place last element at randomly chosen index.
                shuflee[random - 1] = shuflee[shuflee.Count - 1];
                // Remove the last element at list now.
                shuflee.RemoveAt((shuflee.Count - 1));
                // Now add buffered (selected) item to results.
                results.Add(buffer);
            }

            // Return the shuffled list:
            return results;
        }






    }







}
