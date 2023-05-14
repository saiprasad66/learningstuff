namespace factorydesignPattern.Models
{
    public class AmazonStreamcs : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "FamilyMan",
                "Mirzapur",
            };
        }
    }
}
