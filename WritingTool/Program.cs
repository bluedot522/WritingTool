using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace WritingTool
{
    internal class Program
    {
        static void Main(string[] args)
        {


            optionsOutput();

            string choice = ReadLine();

            while(choice != "6")
            {
                optionsProcess(choice);
                optionsOutput();
                choice = ReadLine();
            }
            WriteLine("Goodbye!");
            

        }


        static void optionsOutput()
        {
            WriteLine("Welcome. Please select an option:");
            WriteLine("1. Create Character");
            WriteLine("2. Create Project");
            WriteLine("3. Search Items");
            WriteLine("4. Edit Character/Project");
            WriteLine("5. List Characters/Projects");
            WriteLine("6: Exit");
        }

        static void optionsProcess(string choice)
        {

                switch (choice)
                {
                    case "1":

                        Character newCharacter = new Character();
                        newCharacter.CreateNew();
                        break;

                    case "2":
                        Project newProject = new Project();
                        newProject.CreateNew();
                        break;

                    case "3":
                        WriteLine("Enter search term>> ");
                        string searchTerm = ReadLine();
                        Search newSearch = new Search();
                        newSearch.DoSearch(searchTerm);
                        break;

                    case "4":
                    //I'm not sure how to implement this. So far I'm calling this method with a test character and project. How do I pass in an object from a list?
                        WriteLine("Editing a character (1) or project(2)?");
                        string outputChoice1 = ReadLine();
                         if (outputChoice1 == "1")
                            {
                             Character tempCharacter = new Character();
                                tempCharacter.Edit(tempCharacter);

                            }
                            else if (outputChoice1 == "2")
                            {
                                Project tempProject = new Project();
                                tempProject.Edit(tempProject);
                         }
                            else
                                WriteLine("Invalid entry.");

                            break;

                    case "5":
                   
                    WriteLine("See all characters (1) or projects (2)?");
                        string outputChoice2 = ReadLine();
                        if (outputChoice2 == "1")
                        {
                            Character.ListCharacters();
    
                        }
                        else if (outputChoice2 == "2")
                        {
                            Project.ListProjects();
                        }
                        else
                            WriteLine("Invalid entry.");

                        break;

                    default:
                        WriteLine("Please enter an option (1-5)");
                        break;
                }

               
                
            }
        }
    }
