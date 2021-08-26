namespace GraphicRender
{
    public class MovementManager
    {
        public Space _Space { get; } = new Space();
        public Observe _Observe { get; } = new Observe();
        public void MoveLeft() => _Space.XPosition -= 1;
        public void MoveRight() => _Space.XPosition += 1;
        public void MoveFoward() => _Space.YPosition += 1;
        public void MoveBackward() => _Space.YPosition -= 1;
        public void TurnLeft() => _Observe.Orientation -= 1;
        public void TurnRight() => _Observe.Orientation += 1;
    }
}
