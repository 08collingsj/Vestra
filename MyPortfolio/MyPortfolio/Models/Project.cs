using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Project
    {
        private int _projectId { get; set; }

        private string _projectName { get; set; }
        private string _projectDescription { get; set; }
        private List<string> _projectTags { get; set; }
        private List<Author> _projectAuthors { get; set; }
        //private State _projectState {get;set;}
        private string _projectPathToGithub { get; set; }
        private List<Document> _projectDocuments { get; set; }
        //Open Project
        public Project()
        {
            _projectId = Properties.Settings.Default.currentMaxId + 1;
            Properties.Settings.Default.currentMaxId = _projectId;
            _projectName = "";
            _projectDescription = "";
            _projectTags = new List<string>();
            _projectAuthors = new List<Author>();
            _projectPathToGithub = "";
            _projectDocuments = new List<Document>();
        }

        public int GetProjectId() { return _projectId; }
        public string GetProjectName() { return _projectName; }
        public string GetDescription() { return _projectDescription; }
        public string GetGithubUrl() { return _projectPathToGithub; }
        public List<string> GetTags() { return _projectTags; }
        public List<Author> GetAuthors() { return _projectAuthors; }

        //GetTags

        //GetState

        //GetProjects

    }
}
