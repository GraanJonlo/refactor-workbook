namespace Chapter03.Ex04
{
    public class Machine
    {
        private readonly string _name;
        private string _location;
        private string _bin;

        public Machine(string name, string location)
        {
            _name = name;
            _location = location;
        }

        public string Take()
        {
            string result = _bin;
            _bin = null;
            return result;
        }

        public string Bin()
        {
            return _bin;
        }

        public void Put(string bin)
        {
            _bin = bin;
        }

        public string Name()
        {
            return _name;
        }
    }
}
