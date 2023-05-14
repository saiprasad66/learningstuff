using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.Entities;

namespace Bussiness_Logic
{
    public interface ISkillLogic
    {
        IEnumerable<Models.Skill> GetSkills(Models.Trainer trainer);
        

        //id AddSkills( rainer trainer, Skill s);
        void AddSkills(Models.Trainer trainer, Models.Skill s);
    }
}
