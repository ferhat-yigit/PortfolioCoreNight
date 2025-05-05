namespace PortfolioCore.Entities
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string ImageUrl{ get; set; }
        public string CardImageUrl { get; set; }
        public string GithubUrl { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
