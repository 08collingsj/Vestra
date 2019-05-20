using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Document
    {
        /*
         * Name, creation date and tags
         */
        private string name { get; set; }
        private DateTime creationDate { get; set; }
        private List<string> tagsList { get; set; }
        private string documentLocation { get; set; }
        public Document(string name)
        {
            this.name = name;
        }
        public Document(string _name, DateTime _creationDate, List<string> _tagsList)
        {
            this.name = name;
            this.creationDate = creationDate;
            this.tagsList = tagsList;
        }

        public string GetName() { return name; }
        public DateTime GetDate() { return creationDate; }
    }
}
