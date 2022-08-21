using RepositryPatternWithUOW.core.Models;
using RepositryPatternWithUOW.core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositryPatternWithUOW.core
{
    public interface IUnitOfWork
    {
        IBaseRepository<Author> Authors { get; }
        IBooksRepository Books { get; }

        int Complete();

    }
}
