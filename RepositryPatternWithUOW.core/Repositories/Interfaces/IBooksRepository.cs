using RepositryPatternWithUOW.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositryPatternWithUOW.core.Repositories.Interfaces
{
    public interface IBooksRepository : IBaseRepository<Book>
    {
        public interface IBooksRepository : IBaseRepository<Book>
        {
            IEnumerable<Book> SpecialMethod();
        }

    }
}
