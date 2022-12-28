using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Abstractions
{
    public interface IEditorialRepository
    {
        Task<Editorial> Create(Editorial endity);
        Task<Editorial?> Edit(int id, Editorial entity);
        Task<Editorial?> EnableOrDisable(int id);
        Task<Editorial?> Find(int id);
        Task<IList<Editorial>> FindAll();

    }
}
