using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    /// <summary>
    /// Represents a member of the team behind a project
    /// </summary>
    public class Author
    {
        #region Private variables
        private string _name { get; set; }
        private string _githubLink { get; set; }
        private string _linkedInUrl { get; set; }
        #endregion
        public Author(string name, string githubUrl, string linkinUrl)
        {
            _name = name;
            _githubLink = githubUrl;
            _linkedInUrl = linkinUrl;
        }
        #region Getters
        public string GetName() { return _name; }
        public string GetGitHub() { return _githubLink; }
        public string GetLinkedIn() { return _linkedInUrl; }
        #endregion
    }
}
