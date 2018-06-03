using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Durstenfeld_Algoritm;

namespace Durstenfeld_Algoritm.TEST
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void ShuffleTest()
        {



            // Arrange

            List<int> ints = new List<int>(100);
            Random rando = new Random(DateTime.Now.Millisecond);




            // Act
            for (int i = 0; i < 100; i++)
            {
                ints.Add(rando.Next());
            }

            for (int i = 0; i < 10000000; i++)
            {
                ints = Shuffle(ints);
            }


            // Assert
            Assert.AreEqual(100, ints.Count);








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
