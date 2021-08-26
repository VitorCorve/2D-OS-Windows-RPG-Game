namespace GraphicRender
{
    public class Space
    {
        public delegate void ChangePosition();
        public event ChangePosition Notify;
        private int _XPosition = 0;
        private int _YPosition = 0;
        public int XMaxValue = 25;
        public int YMaxValue = 25;
        public int ZMaxValue = 25;
        public int XMinValue = -25;
        public int YMinValue = -25;
        public int XPosition { get => _XPosition; set => XSet(value); }
        public int YPosition { get => _YPosition; set => YSet(value); }
        private void XSet(int value)
        {
            if (value > XMaxValue)
                _XPosition = XMaxValue;
            else if (value < XMinValue)
                _XPosition = XMinValue;
            else
                _XPosition = value;
            Notify?.Invoke();
        }
        private void YSet(int value)
        {
            if (value > YMaxValue)
                _YPosition = YMaxValue;
            else if (value < YMinValue)
                _YPosition = YMinValue;
            else
                _YPosition = value;

            Notify?.Invoke();
        }
        public Space()
        {
            XPosition = 0;
            YPosition = 0;
        }
    }
}
