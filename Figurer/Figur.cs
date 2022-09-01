using System.Text;

namespace Figurer
{
    public abstract class Figur
    {
        public abstract double Omkreds();
        public abstract double Areal();

        public abstract string Info(string indryk);
        public static string Info(string indryk, string type, string navn1, double val1)
        {
            StringBuilder sb = new();
            sb.Append(indryk + type + "\n");
            sb.Append(indryk + "- " + navn1 + " : " + val1.ToString() + "\n");
            return sb.ToString();
        }
        public static string Info(string indryk, string type, string navn1, double val1, string navn2, double val2)
        {
            StringBuilder sb = new();
            sb.Append(indryk + type + "\n");
            sb.Append(indryk + "- " + navn1 + " : " + val1.ToString() + "\n");
            sb.Append(indryk + "- " + navn2 + " : " + val2.ToString() + "\n");
            return sb.ToString();
        }
    }
}