using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class Issues
    {
        public int Id { get; set; }
        public string JiraStory { get; set; }
        public string Description { get; set; }
        public string WikiLink { get; set; }
        public string VideoLink { get; set; }
        public string TechNowLink { get; set; }
        public string Notes { get; set; }
        public Issues()
        {

        }
    }
}
