using MindBox.ShapeArea.Model;

namespace Mindbox.Test
{
    public class AreaTests
    {
        [Test]
        public void TriangleTest()
        {
            List<IShape> shapes = new List<IShape>
            {
                new Triangle(1, 1, 1),
                new Triangle(1, 1, 1),
                new Triangle(1, 1, 1),
                new Triangle(1, 1, 1),
                new Circle(5),
                new Circle(5),
            };

            shapes.ForEach(sh => sh.CalculateArea());
            Assert.Pass();
        }
    }
}