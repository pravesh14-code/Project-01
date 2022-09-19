using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    internal class ExperienceOverview
    {
        ConsoleLogger logger = new ConsoleLogger();
        public void displayExperience(int overview)
        {
            switch (overview)
            {
                case 1:
                    logger.LogLine("\n-------- Ceridian Mauritius --------");
                    logger.LogLine("Technology Training: Ramp up on the following technology stack training [C#, FrontEnd, SQL, Automation]" +
                        "\nDomain Knowledge: Ramp up on Dayforce Product." +
                        "\nGet acquainted with scrum practices and participate in scrum events.");
                    logger.LogLine("------------------------------------\n");
                    break;
                case 2:
                    logger.LogLine("\n--------- UOM Oracle Club ---------");
                    logger.LogLine("Develope my technical skills alongside my personal skills. Got the opportunity to learn about Oracle Cloub Platfrom." +
                        "\nImprove my leadership skills and communication skills by delegating works and communicate with teams.");
                    logger.LogLine("------------------------------------\n");
                    break;
                default:
                    logger.LogLine("Error!! Please select appropriate choice!!");
                    break;
            }
        }
    }
}
