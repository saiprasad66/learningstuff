using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi;
using FluentApi.Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Bussiness_Logic
{
    public class Mapper
    {
         private static Project1Context context=new Project1Context();
        public static Models.Trainer Map(FluentApi.Entities.Trainer t)
        {
            return new Models.Trainer()
            {
               TrainerId= t.TrainerId,
                Email = t.Email,
                Password=t.Password,
                Name = t.Name,
                Age = t.Age,
                Gender = t.Gender,
                PhoneNumber=t.PhoneNumber,
                City = t.City,
               Zipcode= t.Zipcode

            };
        }

        public static IEnumerable<Models.Trainer> Map(IEnumerable<FluentApi.Entities.Trainer> trainers)
        {
            return trainers.Select(Map);
        }


        public static FluentApi.Entities.Trainer Map(Models.Trainer t)
        {
            return new FluentApi.Entities.Trainer()
            {
                TrainerId= t.TrainerId,
                Email = t.Email,
                Password = t.Password,
                Name = t.Name,
                Age = t.Age,
                Gender = t.Gender,
                PhoneNumber = t.PhoneNumber,
                City = t.City,
                Zipcode = t.Zipcode

            };
        }
        
        public static Models.Skill Map(FluentApi.Entities.Skill s)
        {
            return new Models.Skill()
            {
                SkillId= s.SkillId,
                TrainerId= s.TrainerId,
                SkillName= s.SkillName,
                Proficiency=s.Proficiency

            };
        }
        public static FluentApi.Entities.Skill Map(Models.Skill s)
        {
            return new FluentApi.Entities.Skill()
            {
                SkillId= s.SkillId,
                TrainerId= s.TrainerId,
                SkillName = s.SkillName,
                Proficiency = s.Proficiency

            };
        }
        public static IEnumerable<Models.Skill> Map(IEnumerable<FluentApi.Entities.Skill> skills)
        {
            return skills.Select(Map);
        }
    }
    
}
