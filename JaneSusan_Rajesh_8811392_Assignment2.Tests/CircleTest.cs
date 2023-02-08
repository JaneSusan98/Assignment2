namespace JaneSusan_Rajesh_8811392_Assignment2.Tests
{
       
        public class CircleTest
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void GetRadius_DefaulConstructorInstance_RadiusIs1()
            {
                Circle circle = new Circle();
                int radius = circle.GetRadius(userRadius: 1);
                Assert.AreEqual(1, radius);
            }

        [Test]
        public void GetRadius_DefaulConstructorInstance_RadiusIs1()
        {
            Circle circle = new Circle();
            int radius = circle.GetRadius(userRadius: 1);
            Assert.AreEqual(1, radius);
        }
    }
       

       
    }
}