namespace MindBox.ShapeArea
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double halfPerim = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerim * (halfPerim - SideA) * (halfPerim - SideB) * (halfPerim - SideC));
        }

        public bool IsRightTriangle()
        {
            double aQuadro = Math.Pow(SideA, 2);
            double bQuadro = Math.Pow(SideB, 2);
            double cQuadro = Math.Pow(SideC, 2);

            return aQuadro + bQuadro == cQuadro ||
                   aQuadro + cQuadro == bQuadro ||
                   bQuadro + cQuadro == aQuadro;
        }
    }
}
