using Microsoft.EntityFrameworkCore;
using Models;
using FluentApi.Entities;

namespace FluentApi.Entities
{
    public class SkillRepo : ISkill<Skill>

    {

        Project1Context context = new Project1Context();

        public void AddSkills(Entities.Trainer trainer, Entities.Skill skill)
        {
            context.Skills.Add(
                new Skill()
                {
                    SkillName=skill.SkillName,
                    Proficiency=skill.Proficiency,
                   
                }

                );
            context.SaveChanges();
        }

        public void AddSkills(Models.Trainer trainer, Models.Skill skill)
        {
            throw new NotImplementedException();
        }

        List<Skill> ISkill<Skill>.GetSkills(int id)
        {
            return context.Skills.Where(s => s.TrainerId == id).ToList();
        }

    }
}
