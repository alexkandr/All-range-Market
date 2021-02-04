using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Range_Market.Models
{
    public class EFCommentsRepository : ICommentsRepository
    {
        private StoreDbContext context;
        public EFCommentsRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        IQueryable<Comment> Comments => context.Comments;
        public void CreateComment(Comment c)
        {
            context.Add(c);
            context.SaveChanges();
        }

        public void DeleteProduct(Comment c)
        {
            context.Remove(c);
            context.SaveChanges();
        }

        public void SaveProduct(Comment c)
        {
            context.SaveChanges();
        }
    }
}
