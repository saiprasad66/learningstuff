namespace factorydesignPattern.Models
{
    public class SteamFactory
    {
        public IStreamService GetStreamService(string userchoice)
        {
            if (userchoice == "netflix")
            {
                return new NetflixStream();
            }
            else if (userchoice == "amazon")
            {
                return new AmazonStreamcs();
            }
            else
            {
                return new NoStreaming();
            }
               
        }
    }
}
