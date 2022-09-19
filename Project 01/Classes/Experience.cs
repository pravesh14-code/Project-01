using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class Experience : CurriculumVitae
    {
        public override void displayDetail()
        {
            while (true)
            {
                logger.LogLine("\n********* Experience/Job History *********\n");
                logger.LogLine("1. Ceridian Mauritius (2022 - Current) ");
                logger.LogLine("2. UOM Oracle Club (2020 - Current) ");

                logger.Log("\nOveriew Choice => Enter a choice to overiew or press 0 to go back: ");
                int overview = int.Parse(Console.ReadLine());

                if (overview == 0)
                {
                    break;
                }
                else
                {
                    ExperienceOverview experienceOverview = new ExperienceOverview();
                    experienceOverview.displayExperience(overview);
                }
            }
        }
    }
}
