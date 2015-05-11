using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Count_ShouldReturn1_WhenInputIs1()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("1", FizzBuzz.Count(1));
        }

        [Test]
        public void Count_ShouldReturn2_WhenInputIs2()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("2", FizzBuzz.Count(2));
        }

        [Test]
        public void Count_ShouldReturnFizz_WhenInputIs3()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Fizz", FizzBuzz.Count(3));
        }

        [Test]
        public void Count_ShouldReturnBuzz_WhenInputIs5()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Buzz", FizzBuzz.Count(5));
        }

        [Test]
        public void Count_ShouldReturnBuzz_WhenInputIs20()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Buzz", FizzBuzz.Count(20));
        }

        [Test]
        public void Count_ShouldReturnFizz_WhenInputIs6()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Fizz", FizzBuzz.Count(6));
        }

        [Test]
        public void Count_ShouldReturn7_WhenInputIs7()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("7", FizzBuzz.Count(7));
        }

        [Test]
        public void Count_ShouldReturnFizz_WhenInputIs9()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Fizz", FizzBuzz.Count(9));
        }

        [Test]
        public void Count_ShouldReturnBuzz_WhenInputIs10()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("Buzz", FizzBuzz.Count(10));
        }

        [Test]
        public void Count_ShouldReturnFizzBuzz_WhenInputIs15()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("FizzBuzz", FizzBuzz.Count(15));
        }

        [Test]
        public void Count_ShouldReturnFizzBuzz_WhenInputIs30()
        {
            FizzBuzzLib FizzBuzz = new FizzBuzzLib();
            Assert.AreEqual("FizzBuzz", FizzBuzz.Count(30));
        }





    }
}
