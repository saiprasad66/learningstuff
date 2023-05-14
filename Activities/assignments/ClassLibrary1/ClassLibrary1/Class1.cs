using ClassLibrary1;

namespace ClassLibrary1
{



    public interface Iservice
    {
        void serve();
    }
    public class Class1 : Iservice
    {
        public void serve()
        {
            Console.WriteLine("service1 is called");
        }
    }

    public class Client
    {
        private Iservice _service;
        public Client(Iservice service)
        {
            _service = service;
        }


    }
}

