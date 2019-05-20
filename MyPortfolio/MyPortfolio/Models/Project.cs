using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Project
    {
        private int projectId { get; set; }

        private string projectName { get; set; }
        private string projectDescription { get; set; }
        private List<string> projectTags { get; set; }
        private List<Author> projectAuthors { get; set; }
        //private State _projectState {get;set;}
        private string projectPathToGithub { get; set; }
        private List<Document> projectDocuments { get; set; }
        //Open Project
        public Project()
        {
            projectId = Properties.Settings.Default.currentMaxId + 1;
            Properties.Settings.Default.currentMaxId = projectId;
            projectName = "";
            projectDescription = "";
            projectTags = new List<string>();
            projectAuthors = new List<Author>();
            projectPathToGithub = "";
            projectDocuments = new List<Document>();
        }
        public Project(string _name, string _description, List<string> _projectTags, List<Author> _projectAuthors, string _projectPathToGithub, List<Document> _projectDocuments)
        {
            projectId = Properties.Settings.Default.currentMaxId + 1;
            Properties.Settings.Default.currentMaxId = projectId;
            projectName = _name;
            projectDescription = _description;
            projectTags = _projectTags;
            projectAuthors = _projectAuthors;
            projectPathToGithub = _projectPathToGithub;
            projectDocuments = _projectDocuments;
        }
        public int GetProjectId() { return projectId; }
        public string GetProjectName() { return projectName; }
        public string GetDescription() { return projectDescription; }
        public string GetGithubUrl() { return projectPathToGithub; }
        public List<string> GetTags() { return projectTags; }
        public List<Author> GetAuthors() { return projectAuthors; }
        

    }
}
