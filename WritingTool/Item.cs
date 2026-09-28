using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WritingTool
{
    public class Item
    {
        private string _name;
        private string _description;
        private List<string> _tags;

        protected DateTime Date
        {
            get; set;
        }   
        public virtual void CreateNew()
        {
           
        }

        // Can't figure out files yet
        private void LoadExisting(string filePath)
        {
        
        }

        // I can't figure out how to manipulate files yet
        private void Delete(string filePath)
        {
            
        }

        public void Edit(Item item)
        {
            
        }

        public void Archive(Item item)
        {
            item._tags.Clear();
            item._tags.Add("archived");
        }


    }
}
