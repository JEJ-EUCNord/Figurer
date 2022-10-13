namespace Figurer
{
    public class Trekant : Figur
    {
        double _a;
        double _b;
        double _c;
        double _vA;
        double _vB;
        double _vC;

        public Trekant(double a, double b, double vC)
        {
            _a = a;
            _b = b;
            _vC = vC;

            _c = CosRelationSide(_a, _b, Grad2Rad(_vC));
        }

        public override double Areal()
        {
            return 0.5 * _a * _b * Math.Sin(Grad2Rad(_vC));
        }

        public override double Omkreds()
        {
            return _a + _b + _c;
        }

        public override string Info(string indryk)
        {
            throw new NotImplementedException();
        }

        static double Grad2Rad(double grader)
        {
            double radianer;

            radianer = grader * Math.PI / 180;
            return radianer;
        }

        static double Rad2Grad(double radianer)
        {
            double grader;

            grader = radianer * 180 / Math.PI;
            return grader;
        }

        static double CosRelationVinkel(double a, double b, double c)
        {
            return Math.Acos(((b * b) + (c * c) - (a * a)) / (2 * b * c));
        }

        static double CosRelationSide(double b, double c, double vinkel)
        {
            return Math.Sqrt((b * b) + (c * c) - (2 * b * c * Math.Cos(vinkel)));
        }
    }

    public class RetvinkletTrekant : Trekant
    {
        double _katete1;
        double _katete2;

        public RetvinkletTrekant(double katete1, double katete2) : base(katete1, katete2, 90)
        {
            _katete1 = katete1;
            _katete2 = katete2;
        }
    }

    public class LigebenetTrekant : Trekant
    {
        double _ben;
        double _vinkel;

        public LigebenetTrekant(double ben, double vinkel) : base(ben, ben, vinkel)
        {
            _ben = ben;
            _vinkel = vinkel;
        }
    }

    public class LigesidetTrekant : LigebenetTrekant
    {
        double _side;
 
        public LigesidetTrekant(double side) : base(side, 60)
        {
            _side = side;
        }
    }
}