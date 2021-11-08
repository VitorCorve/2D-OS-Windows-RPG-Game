using System.Windows.Input;

namespace GameOfFrameworks.Models.Services
{
    public class KeyCodeConverter
    {
        public static string Convert(Key key)
        {
            switch (key)
            {
                case Key.Enter:
                    return "Enter";
                case Key.Pause:
                    return "Pause";
                case Key.A:
                    return "A";
                case Key.B:
                    return "B";
                case Key.C:
                    return "C";
                case Key.D:
                    return "D";
                case Key.E:
                    return "E";
                case Key.F:
                    return "F";
                case Key.G:
                    return "G";
                case Key.H:
                    return "H";
                case Key.I:
                    return "I";
                case Key.J:
                    return "J";
                case Key.K:
                    return "K";
                case Key.L:
                    return "L"; ;
                case Key.M:
                    return "M"; ;
                case Key.N:
                    return "N"; ;
                case Key.O:
                    return "O"; ;
                case Key.P:
                    return "P"; ;
                case Key.Q:
                    return "Q"; ;
                case Key.R:
                    return "R"; ;
                case Key.S:
                    return "S"; ;
                case Key.T:
                    return "T"; ;
                case Key.U:
                    return "U"; ;
                case Key.V:
                    return "V"; ;
                case Key.W:
                    return "W"; ;
                case Key.X:
                    return "X"; ;
                case Key.Y:
                    return "Y"; ;
                case Key.Z:
                    return "Z"; ;
                default:
                    break;
            }
            return null;
        }
        public static Key Convert(string str)
        {
            switch (str)
            {
                case "Enter":
                    return Key.Enter;
                case "Pause":
                    return Key.Pause;
                case "A":
                    return Key.A;
                case "B":
                    return Key.B;
                case "C":
                    return Key.C;
                case "D":
                    return Key.D;
                case "E":
                    return Key.E;
                case "F":
                    return Key.F;
                case "G":
                    return Key.G;
                case "H":
                    return Key.H;
                case "I":
                    return Key.I;
                case "J":
                    return Key.J;
                case "K":
                    return Key.K;
                case "L":
                    return Key.L;
                case "M":
                    return Key.M;
                case "N":
                    return Key.N;
                case "O":
                    return Key.O;
                case "P":
                    return Key.P;
                case "Q":
                    return Key.Q;
                case "R":
                    return Key.R;
                case "S":
                    return Key.S;
                case "T":
                    return Key.T;
                case "U":
                    return Key.U;
                case "V":
                    return Key.V;
                case "W":
                    return Key.W;
                case "X":
                    return Key.X;
                case "Y":
                    return Key.Y;
                case "Z":
                    return Key.Z;
                default:
                    break;
            }
            return Key.None;
        }
    }
}
