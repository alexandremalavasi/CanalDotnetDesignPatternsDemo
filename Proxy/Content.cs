namespace DemoCanalDotNetDesignPatterns.Proxy
{
    public class Content
    {
        public Content()
        {
            this.Advertisements = new List<Advertisement>();
        }
        public int Id { get; set; }
        public News News { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public CategoryEnum Category { get; set; }
    }

    public enum CategoryEnum
    {
        Sports = 1,
        Technology = 2,
        Health = 3,
        Lifestyle = 4,
        Education = 5
    }
}
