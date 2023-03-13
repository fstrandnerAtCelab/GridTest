namespace GridTest
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DataSub Description { get; set; }
        public string Description { get; set; }
    }

    public class DataSub
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}