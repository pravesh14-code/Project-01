using Project_01.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Classes
{
    public class Education : CurriculumVitae
    {
        public override void displayDetail()
        {
            while (true)
            {
                logger.LogLine("\n********* Education/Training *********\n");
                logger.LogLine("1. Software Engineering (Year 2)");
                logger.LogLine("2. Software Engineering (Year 1)");
                logger.LogLine("3. Training");

                logger.Log("\nOveriew Choice => Enter a choice to overiew or press 0 to go back: ");
                int overview = int.Parse(Console.ReadLine());

                if (overview == 0)
                {
                    break;
                }
                else
                {
                    EducationOverview educationOverview  = new EducationOverview();
                    educationOverview.displayEducation(overview);
                }
            }
        }
    }
}
