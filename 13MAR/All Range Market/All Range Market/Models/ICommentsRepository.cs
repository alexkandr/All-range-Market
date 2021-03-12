using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Range_Market.Models
{
    public class ICommentsRepository
    {
        public IQueryable<Comment> Comments { get; set; }
        void CreateComment(Comment c) { }
    }
}
