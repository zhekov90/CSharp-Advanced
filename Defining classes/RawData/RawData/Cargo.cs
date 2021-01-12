

namespace RawData
{
    public class Cargo
    {
        public string type;
        public int weight;

        public Cargo(string type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

    }
}