using System;

namespace GraphicRender
{
    public class Program
    {
        static MovementManager Manager = new MovementManager();
        static DrawSpace SpaceDrawer = new DrawSpace();
        static void Main(string[] args)
        {
            Manager._Observe.NotifyOrientationChanged += LogPosition;
            Manager._Space.Notify += LogPosition;
            LogPosition();
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        Manager.MoveFoward();
                        break;
                    case ConsoleKey.S:
                        Manager.MoveBackward();
                        break;
                    case ConsoleKey.A:
                        Manager.MoveLeft();
                        break;
                    case ConsoleKey.D:
                        Manager.MoveRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        Manager.TurnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        Manager.TurnRight();
                        break;
                    default:
                        break;
                }
            }
        }
        static void LogPosition()
        {
            Console.Clear();
            Console.WriteLine("x:" + Manager._Space.XPosition);
            Console.WriteLine("Y:" + Manager._Space.YPosition);

            Console.WriteLine("Rotation:" + Manager._Observe.Orientation);

            SpaceDrawer.Draw(Manager._Space);

        }
    }

}
