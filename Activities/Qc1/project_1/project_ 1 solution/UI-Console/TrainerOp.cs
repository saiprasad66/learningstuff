using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic;
using Models;

namespace UI_Console
{
    public class TrainerOp
    {
        
        Trainer t = new Trainer();
        ILogic l = new Logic();
        Validation v= new Validation();
        int id;
       

        
       public Trainer AddMoreTrainer( Trainer t)
        {
             t.TrainerId = v.TrainerIdByEmail(t);

            //Trainers t = new Trainers();
            // Console.WriteLine("\n==========Welcome===========\n");
            Console.WriteLine("Enter your Age : ");
            t.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your gender: ");
            t.Gender = Console.ReadLine();
            Console.WriteLine("Enter your PhoneNumber : ");
            t.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your City : ");
            t.City = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode : ");
            t.Zipcode = Console.ReadLine();
            l.AddTrainer(t);
           
            // l.AddTrainerSignup(t);

            return t;
        }

        public void  removeTrainer(Trainer t)
        {
            l.RemoveTrainerByName(t);

        }
    }
}
