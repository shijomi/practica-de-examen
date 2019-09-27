

namespace webEval.Models
{
    using System.Data.Entity;

    public class DataContext: DbContext
    {
        public DataContext():base ("DefaultConnection  ")
        {

        }

        public System.Data.Entity.DbSet<webEval.Models.Score> Scores { get; set; }
    }
}