using System;
using Xunit;

namespace TwoCityFlyingCost.Tests
{
    public class Tests
    {
        [Fact]
        public void TestTwoCitySchedCost1()
        {
           // arrange
            int expected = 110;
            int[][] Input1 = { new int[] { 10, 20 }, new int[] { 30, 200 },new int[]{400,50 },new int[]{30,20 } };

            // act
            var SchedCost = new SchedCost();
            int actual = SchedCost.TwoCitySchedCost(Input1);

             // assert
            Assert.Equal(expected, actual);

        }

         [Fact]
        public void TestTwoCitySchedCost2()
        {
            // arrange
            int expected = 1859;
            int[][] Input2 = new int[][]
            {
                new int[] { 259, 770 },
                new int[] { 448, 54 },
                new int[] { 926, 667 },
                new int[] { 184, 139 },
                new int[] { 840, 118 },
                new int[] { 577, 469 }
            };

            // act
            var SchedCost = new SchedCost();
            int actual = SchedCost.TwoCitySchedCost(Input2);

             // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestTwoCitySchedCost3()
        {
            // arrange
            int expected = 3086;
            int[][] Input3 = new int[][]
            {
                new int[] { 515,563 },
                new int[] { 451,713 },
                new int[] { 537,709 },
                new int[] { 343,819 },
                new int[] { 855,779 },
                new int[] { 457, 60 },
                new int[] { 650, 359 },
                new int[] { 631, 42 }
            };

            // act
            var SchedCost = new SchedCost();
            int actual = SchedCost.TwoCitySchedCost(Input3);

             // assert
            Assert.Equal(expected, actual);

        }


    }
}
