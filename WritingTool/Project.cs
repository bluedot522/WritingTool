using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using static System.Console;

namespace WritingTool
{
    public class Project : Item
    {
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public List<string> Tags
        {
            get; set;
        }

        public static List<Project> projectList = new List<Project>();

        public override void CreateNew()
        {
            WriteLine("Enter title >>");
            Name = ReadLine();
            WriteLine("Enter project description >>");
            Description = ReadLine();
            WriteLine("Enter project tags (comma separated) >>");
            var tagInput = ReadLine();
            Tags = new List<string>(tagInput.Split(','));

            AddProject(Name, Description, Tags);
            
        }

        public void AddProject(string Name, string Description, List<string> Tags)
        {
            projectList.Add(new Project() { Name = Name, Description = Description, Tags = Tags });

            WriteLine("Project added: " + projectList.LastOrDefault()?.Name + " - " + projectList.LastOrDefault()?.Description);
            WriteLine("All projects: ");
            ListProjects();
        }

        public void ArchiveProject(Project project)
        {
            project.Tags.Clear();
            project.Tags.Add("archived");
        }

        public static void ListProjects()
        {
            foreach (Project project in projectList)
            {
                WriteLine(project);
            }
        }

        public override string ToString()
        {
            return Name + " - " + Description + " - Tags: " + string.Join(", ", Tags);
        }

    }
}
