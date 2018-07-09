using NUnit.Framework;
using System;

namespace NewGameTests
{
    [TestFixture()]
    public class NumberProviderSequentialTest
    {

        /// <summary>
        /// Tests that NumberProviderSequential can count to 100 and that the last call to Next returns true.
        /// </summary>
        [Test()]
        public void TestCountTo100GetNext()
        {
            bool expectedNext = false;
            bool actualNext = false;

            var np = new NumberGame.NumberProviders.NumberProviderSequential(1, 100, 1, NumberGame.NumberProviders.NumberProviderSequential.countDirections.up);
            for (int i = 0; i < 100; i++) {
                actualNext = np.Next();
            }

            expectedNext = true;
            Assert.AreEqual(expectedNext, actualNext, "NumberProviderSequential did not return true after 100 iterations");
        }

        /// <summary>
        /// Tests that NumberProviderSequential can count to 100 and that the 101st call to Next returns false.
        /// </summary>
        [Test()]
        public void TestCountTo101GetNext()
        {
            bool expectedNext = false;
            bool actualNext = false;

            var np = new NumberGame.NumberProviders.NumberProviderSequential(1, 100, 1, NumberGame.NumberProviders.NumberProviderSequential.countDirections.up);
            for (int i = 0; i < 101; i++)
            {
                actualNext = np.Next();
            }

            expectedNext = false;
            Assert.AreEqual(expectedNext, actualNext, "NumberProviderSequential did not return false after 101 iterations");
        }

        /// <summary>
        /// Tests that NumberProviderSequential can count upwards in the specified increments.
        /// </summary>
        [Test()]
        public void TestStepUp2()
        {
            var np = new NumberGame.NumberProviders.NumberProviderSequential(1, 100, 2, NumberGame.NumberProviders.NumberProviderSequential.countDirections.up);

            var expectedNumber = 3;

            np.Next();
            np.Next();

            var actualNumber = np.TheNumber;

            Assert.AreEqual(expectedNumber, actualNumber, "NumberProviderSequential did not count in increments of 2. Actual Value was " + actualNumber.ToString());
        }

        /// <summary>
        /// Tests that NumberProviderSequential can count downwards in the specified increments.
        /// </summary>
        [Test()]
        public void TestStepDown3()
        {
            var np = new NumberGame.NumberProviders.NumberProviderSequential(9, 1, 3, NumberGame.NumberProviders.NumberProviderSequential.countDirections.down);

            var expectedNumber = 6;

            np.Next();
            np.Next();

            var actualNumber = np.TheNumber;

            Assert.AreEqual(expectedNumber, actualNumber, "NumberProviderSequential did not down in increments of 3. Actual Value was " + actualNumber.ToString());
        }

    }
}
