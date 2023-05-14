
using Models;
using FluentApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bussiness_Logic
{
    public class Logic : ILogic
    {
        private static Project1Context context = new Project1Context();
        IRepo<FluentApi.Entities.Trainer> repo;
        public Logic()
        {
            repo = new FluentApi.Entities.EFRepo();
        }

       public void AddTrainerSignup(Models.Trainer t)
        {
           
            repo.AddTrainerSignup(Mapper.Map(t));
            
        }

        public IEnumerable<Models.Trainer> DisplayTrainer()
        {
            return Mapper.Map(repo.DisplayTrainer());

        }

        public void AddTrainer(Models.Trainer t)
        {
            var trainer = context.Trainers.Where(item => item.TrainerId == t.TrainerId).First();
            if (trainer != null)
            {

                trainer.Age = (byte?)t.Age;
                trainer.Gender = t.Gender;
                trainer.PhoneNumber = t.PhoneNumber;
                trainer.City = t.City;
                trainer.Zipcode = t.Zipcode;

                repo.AddTrainer(trainer);
             }
        }
        public Models.Trainer RemoveTrainerByName(Models.Trainer t)
        {
            var deletedTrainer = repo.RemoveTrainer(Mapper.Map(t));
           
                return Mapper.Map(deletedTrainer);
          
              
        }

       /* public Models.Trainer updateTrainer(Models.Trainer trainer)
        {
            var t = context.Trainers.Where(id => id.TrainerId == trainer.Id).First();
            t.Name = trainer.Name;
            t.Password = trainer.Password;
            t.PhoneNo = trainer.PhoneNo;
            t.Gender = trainer.Gender;
            t.City = trainer.City;
            t.State = trainer.State;
            t.Pincode = trainer.Pincode;
            t.AboutMe = trainer.AboutMe;
            return (Mapper.TrainerMapper(ef.updateTrainer(t)));
        }*/



    }
}






    
