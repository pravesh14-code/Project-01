using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Conditions
{
    internal class EducationOverview
    {
        ConsoleLogger logger = new ConsoleLogger();
        public void displayEducation(int overview)
        {
            switch (overview)
            {
                case 1:
                    logger.LogLine("\n-------- Software Engineering (Year 2) --------");
                    logger.LogLine("Modules covered: Web Application Development, Object Oriented Software Development, " +
                        "Interactive System Design,\nData Structure Algorithm, Software Verification & Validation" +
                        "Software Project Management. \n\nProject done: Kidemy Mobile Application, JRA ART Website, MyFitness GUI, Flood Radar.");
                    logger.LogLine("------------------------------------\n");
                    break;
                case 2:
                    logger.LogLine("\n--------- Software Engineering (Year 2) ---------");
                    logger.LogLine("Modules covered: Discrete Structure, Database Systems, Software Design Programming, Comumunication Skills," +
                        "\nSoftware Engineering Principles, Software Analysis & Modelling. \nProject done: Code Lyoko 3D World Game, MauPlant Mobile Application ");
                    logger.LogLine("------------------------------------\n");
                    break;
                case 3:
                    logger.LogLine("\n--------- Training ---------");
                    logger.LogLine("Training attended: Time Management, Flutter Festivals, Design Thinking, AI Training, IOT Training and so on...");
                    logger.LogLine("------------------------------------\n");
                    break;

                default:
                    logger.LogLine("Error!! Please select appropriate choice!!");
                    break;
            }
        }
    }
}
