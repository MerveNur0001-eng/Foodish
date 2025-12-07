using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Foodish.EntityLayer.Concrete
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string CoverImageUrl { get; set; }
        public string CreatedDate { get; set; }

    }
}
