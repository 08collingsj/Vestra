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
        private string _name { get; set; }
        private DateTime _creationDate { get; set; }
        private List<string> _tagsList { get; set; }
        public Document(string name)
        {
            _name = name;
        }
        public Document(string name, DateTime creationDate, List<string> tagsList)
        {
            _name = name;
            _creationDate = creationDate;
            _tagsList = tagsList;
        }

        public string GetName() { return _name; }
        public DateTime GetDate() { return _creationDate; }
    }
}
