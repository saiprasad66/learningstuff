using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Models
{
    public interface ISkill<Skill>
    {
         List<Skill> GetSkills(int id);
        void AddSkills(FluentApi.Entities.Trainer trainer, Skill s);
    }
}
