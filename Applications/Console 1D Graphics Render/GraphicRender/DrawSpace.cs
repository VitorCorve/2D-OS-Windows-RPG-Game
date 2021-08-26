using System;

namespace GraphicRender
{
    public class DrawSpace
    {
        public void Draw(Space space)
        {
            Console.WriteLine();
            for (int y = space.YMaxValue + 1; y > space.YMinValue - 2; y--)
            {
                for (int x = space.XMinValue - 1; x < space.XMaxValue + 2; x++)
                {
                    if (y == space.YMaxValue + 1 && x < space.XMaxValue + 1)
                        Console.Write("U ");
                    if (y < space.YMaxValue + 1 && x == space.XMinValue - 1)
                        Console.Write("L");
                    if (x == space.XMaxValue + 1)
                    {
                        Console.Write("R");
                        Console.WriteLine();
                        break;
                    }
                    if (y < space.YMaxValue + 1 && y > space.YMinValue - 1 && x >= space.XMinValue && x < space.XMaxValue + 1)
                    {
                        if (x == space.XPosition && y == space.YPosition)
                            Console.Write("@ ");
                        else
                            Console.Write("  ");
                    }
                    if (y == space.YMinValue - 1 && x > space.XMinValue - 1)
                        Console.Write("D ");
                }
            }
            Console.CursorVisible = false;
        }
    }
}
