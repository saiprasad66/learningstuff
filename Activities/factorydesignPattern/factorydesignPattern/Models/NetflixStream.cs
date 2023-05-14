namespace factorydesignPattern.Models
{
    public class NetflixStream : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "Avatar",
            "Dhamaka",
            };
            
        }
    }
}
