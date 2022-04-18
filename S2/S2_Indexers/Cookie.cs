namespace Course_OOP.S2.S2_Indexers
{
    public class Cookie
    {
        // keys and value are sting
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public Cookie()
        {
            this._dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return this._dictionary[key]; }
            set { this._dictionary[key] = value;}
        }
    }
}
