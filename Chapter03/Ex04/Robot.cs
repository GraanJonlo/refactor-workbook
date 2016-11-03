namespace Chapter03.Ex04
{
    public class Robot
    {
        private Machine _location;
        private string _bin;

        public Machine Location()
        {
            return _location;
        }

        public void MoveTo(Machine location)
        {
            _location = location;
        }

        public void Pick()
        {
            _bin = _location.Take();
        }

        public string Bin()
        {
            return _bin;
        }

        public void Release()
        {
            _location.Put(_bin);
            _bin = null;
        }
    }
}