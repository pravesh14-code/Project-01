using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Classes
{
    public class PersonalSkills : CurriculumVitae
    {
        public override void displayDetail()
        {
            logger.LogLine("\n********* Personal Skills *********\n");
            logger.LogLine("Leadership Skills, Good in teamwork, Can work independently, Fast Learner, " +
                "\nCriticical Thinking, Inquistive, Interactive.");
        }
    }
}
