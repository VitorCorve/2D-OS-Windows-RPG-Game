namespace GraphicRender
{
    public class Observe
    {
        public delegate void ChangeOrientation();
        public event ChangeOrientation NotifyOrientationChanged;
        private int _Orientation;
        public int Orientation { get => _Orientation; set => ValidateOrientation(value); }
        private void ValidateOrientation(int value)
        {
            if (value > 360)
                _Orientation = 0;
            if (value < 0)
                _Orientation = 360;
            _Orientation = value;

            NotifyOrientationChanged();
        }
    }
}
