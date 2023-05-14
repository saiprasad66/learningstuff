namespace factorydesignPattern.Models
{
    public class NoStreaming : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "No movies found",
            };
        }
    }
}
