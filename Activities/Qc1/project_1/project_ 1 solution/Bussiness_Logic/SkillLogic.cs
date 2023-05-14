

using Models;
using FluentApi.Entities;
using Microsoft.EntityFrameworkCore;
using FluentApi;

namespace Bussiness_Logic
{
    public class SkillLogic:ISkillLogic
    {
        Validation v=new Validation();
        private static Project1Context context = new Project1Context();
        ISkill<FluentApi.Entities.Skill> repo;
        public SkillLogic()
        {
            repo = new FluentApi.Entities.SkillRepo();
        }

        public IEnumerable<Models.Skill> GetSkills(Models.Trainer trainer)
        {
            int id = v.TrainerIdByEmail(trainer);
            return Mapper.Map(repo.GetSkills(id));
            //return Mapper.Map(repo.GetSkills(Mapper.Map(id)));
        }

        public void AddSkills(Models.Trainer trainer, Models.Skill s)
        {
            //epo.AddTrainerSignup(Mapper.Map(t));
            //epo.AddSkills(Mapper.Map(trainer, s));
            repo.AddSkills(Mapper.Map(trainer), Mapper.Map(s));

        }
    }
}

