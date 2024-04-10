using System.Collections.Generic;
using System.Linq;

namespace Intex_Group3_6.Models
{
    public interface IDataRepo
    {
        IQueryable<Object> GetTop10ReviewedSets();
    }
}