namespace Figurer
{
    public class Ellipse : Figur
    {
        double _halveStorakse;
        double _halveLilleAkse;

        public Ellipse(double halveStorakse, double halveLilleakse)
        {
            _halveStorakse = halveStorakse;
            _halveLilleAkse = halveLilleakse;
        }

        public override double Omkreds()
        {
            return 2 * Math.PI * Math.Sqrt((_halveStorakse * _halveStorakse + _halveLilleAkse * _halveLilleAkse) / 2);
        }

        public override double Areal()
        {
            return Math.PI * _halveStorakse * _halveLilleAkse;
        }

        public override string Info(string indryk)
        {
            return Info(indryk, "Ellipse", "halv storakse ", _halveStorakse, "halv lilleakse", _halveLilleAkse);
        }
    }

    public class Cirkel : Ellipse
    {
        double _radius;

        public Cirkel(double radius) : base(radius, radius)
        {
            _radius = radius;
        }

        public override string Info(string indryk)
        {
            return Info(indryk, "Cirkel", "Radius", _radius) + base.Info(indryk + "    ");
        }
    }
}