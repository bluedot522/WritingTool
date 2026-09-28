using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WritingTool
{
    public class Character : Item

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


        public static List<Character> characterList = new List<Character>();

        public override void CreateNew()
        {
            WriteLine("Enter character name >>");
            Name = ReadLine();

            WriteLine("Enter character description >>");
            Description = ReadLine();

            WriteLine("Enter character tags (comma separated) >>");
            var tagInput = ReadLine();
            var Tags = new List<string>(tagInput.Split(','));

            AddCharacter(Name, Description, Tags);
        }

        public void AddCharacter(string name, string description, List<string>tags)
        {
            characterList.Add(new Character{ Name = name, Description = description, Tags = tags });
            WriteLine("Character added: " + characterList.LastOrDefault()?.Name + " - " + characterList.LastOrDefault()?.Description);
            WriteLine("All characters: ");
            ListCharacters();
        }

        //Need to figure out how to pass in a particular object from a list.
        public void ArchiveCharacter(Character character)
        {
            character.Tags.Clear();
            character.Tags.Add("archived");
        }
        public static void ListCharacters()
        {
            foreach (Character character in characterList)
            {
                WriteLine(character);
            }
        }

        public override string ToString()
        {
            return Name + " - " + Description + " - Tags: " + string.Join(", ", Tags);
        }   

        public void Edit(Character character)
        {
            WriteLine("Enter new name >>");
            Name = ReadLine();
            WriteLine("Enter new description >>");
            Description = ReadLine();
            WriteLine("Enter new tags (comma separated) >>");
            var tagInput = ReadLine();
            Tags = new List<string>(tagInput.Split(','));

        }
    }
}
