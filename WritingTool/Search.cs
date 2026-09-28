using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace WritingTool
{
    public class Search
    {
        private string _searchTerm;

        public string SearchTerm
        {
            get; set;
        }


        public void DoSearch(string SearchTerm)
        {
            WriteLine("Search by latest (1), characters (2), projects (3), or archived (4)?");

            // Will implement a date property to sort by latest later. For now, entering 1 will just search all items.

            string userSearchPref = ReadLine();
            if (userSearchPref == "1")
            {
                foreach(Character character in Character.characterList)
                {
                    if (character.Tags.Contains(SearchTerm) || character.Name.Contains(SearchTerm) || character.Description.Contains(SearchTerm))
                    {
                        WriteLine("Character found: " + character.Name + " - " + character.Description);
                    }
                }
                foreach(Project project in Project.projectList)
                {
                    if (project.Tags.Contains(SearchTerm) || project.Name.Contains(SearchTerm) || project.Description.Contains(SearchTerm))
                    {
                        WriteLine("Project found: " + project.Name + " - " + project.Description);
                    }
                }
            }
            else if (userSearchPref == "2")
            {
                foreach (Character character in Character.characterList)
                {
                    if (character.Tags.Contains(SearchTerm) || character.Name.Contains(SearchTerm) || character.Description.Contains(SearchTerm))
                    {
                        WriteLine("Character found: " + character.Name + " - " + character.Description);
                    }
                }
            }
            else if (userSearchPref == "3")

            {
                foreach (Project project in Project.projectList)
                {
                    if (project.Tags.Contains(SearchTerm) || project.Name.Contains(SearchTerm) || project.Description.Contains(SearchTerm))
                    {
                        WriteLine("Project found: " + project.Name + " - " + project.Description);
                    }
                }

            }
            else if (userSearchPref == "4")
            {

                foreach (Character character in Character.characterList)
                {
                    if (character.Tags.Contains("archived"))
                    {
                        WriteLine("Character found: " + character.Name + " - " + character.Description);
                    }
                }
                foreach (Project project in Project.projectList)
                {
                    if (project.Tags.Contains("archived"))
                    {
                        WriteLine("Project found: " + project.Name + " - " + project.Description);
                    }
                }
            }


            WriteLine("Search complete. If there are no results, no results were found.");

        }


    }
}
