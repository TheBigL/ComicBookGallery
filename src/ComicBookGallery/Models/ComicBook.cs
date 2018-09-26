using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artists { get; set; }
        public bool favorite { get; set; }

        public string displayText
        {
            //To make an method in an object read-only create a getter, but not a setter
            get
            {
                return SeriesTitle + "  #" + IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + '-' + IssueNumber + ".jpg"; 
            }
        }
    }
}