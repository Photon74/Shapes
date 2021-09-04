using NUnit.Framework;
using Shapes.Models;

namespace Tests
{
    public class Tests
    {
        [TestCase(3, 4, 5, 6, true)]
        [TestCase(3, 4, 6, 5.33, false)]
        public void Test_Is_Triangle_Right_And_Area(double a, double b, double c, double expectedArea, bool expectedIsRight)
        {
            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.GetArea();
            var actualIsRight = triangle.IsRight();

            Assert.AreEqual(expectedIsRight, actualIsRight);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestCase(3, 28.27)]
        [TestCase(15, 706.86)]
        public void Test_Circle_Area(double a, double expectedArea)
        {
            var triangle = new Circle(a);
            var actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}