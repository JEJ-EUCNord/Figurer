namespace Figurer
{
    public class Rektangel : Figur
    {
        double _hojde;
        double _bredde;

        public Rektangel(double hojde, double bredde)
        {
            _hojde = hojde;
            _bredde = bredde;
        }

        public override double Omkreds()
        {
            return 2 * (_hojde + _bredde);
        }

        public override double Areal()
        {
            return _hojde * _bredde;
        }

        public override string Info(string indryk)
        {
            return Info(indryk, "Rektangel", "højde ", _hojde, "bredde", _bredde);
        }
    }
}