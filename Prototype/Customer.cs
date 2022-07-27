namespace DemoCanalDotNetDesignPatterns
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; } = new Address();


    }

    [Serializable]
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
