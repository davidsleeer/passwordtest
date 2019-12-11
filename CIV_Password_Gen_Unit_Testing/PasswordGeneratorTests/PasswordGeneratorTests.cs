using NUnit.Framework;
using PasswordGenerator;

namespace Tests {
    
    public class Tests {
        Generator generator;
        [SetUp]
        public void Setup () 
        {
            generator = new Generator();
        }

        [Test]
        [TestCase("Albert","Hero", 23,"albertH_1996")]
        [TestCase("Mary", "Bill", 54, "maryB_1965")]
        [TestCase("Joe", "feathers", 32, "joeF_1987")]
        [TestCase("Frank", "Grasper", 66, "frankG_1953")]
        public void PasswordGenOneTest (string firstname, string lastname, int age, string ans) {


            Assert.Fail();
        }

        [Test]
        [TestCase("Albert", "Hero", 23, "Hero1996A")]
        [TestCase("Mary", "Bill", 54, "Bill1965M")]
        [TestCase("Joe", "feathers", 32, "feathers1987J")]
        [TestCase("Frank", "Grasper", 66, "Grasper1953F")]
        public void PasswordGenTwoTest (string firstname, string lastname, int age, string ans) {
            Assert.Fail();
        }

        [Test]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(11)]
        public void PasswordGenThreeTest(int length) {
            var res = generator.PasswordGenThree(length);
            int upcount = 0;
            int lowcount = 0;
            int digicount = 0;
            int specialcount = 0;
            foreach (var item in res)
            {
                if (char.IsUpper(item))
                {
                    upcount++;
                }
                else if (char.IsLower(item))
                {
                    lowcount++;
                }
                else if (char.IsDigit(item))
                {
                    digicount++;
                }
                else
                {
                    specialcount++;
                }
            }
            Assert.Greater(upcount, 1);
            Assert.Greater(lowcount, 1);
            Assert.Greater(digicount, 1);
            Assert.Greater(specialcount, 1);

        }
    }
}