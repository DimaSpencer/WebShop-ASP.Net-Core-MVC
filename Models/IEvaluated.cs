using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace XESShop.Models
{
    public interface IEvaluated
    {
        public double AverageRating { get; }
        public List<Comment> Сomments { get; set; }
    }
}
