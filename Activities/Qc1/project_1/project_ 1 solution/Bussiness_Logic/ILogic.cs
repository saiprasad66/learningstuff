﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.Entities;
using Models;

namespace Bussiness_Logic
{
    public interface ILogic
    {
        IEnumerable<Models.Trainer> DisplayTrainer();
        // void TrainerSignUp(FluentApi.Entities.Trainer t);
        void AddTrainerSignup(Models.Trainer t);
        void  AddTrainer(Models.Trainer id);
       public  Models.Trainer RemoveTrainerByName(Models.Trainer t);
      // public  Models.Trainer UpdateTrainer(Models.Trainer t);
    }
}
