using Domain;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class EditorialRepository : IEditorialRepository
    {
        private readonly ApplicationDbContext _context;
        

        public EditorialRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<IList<Editorial>> findAll()
        //{
        //    var responce = await _context.Editoriales.ToListAsync();

        //    return responce;

        //}
        /* con funcion flecha y ordendo que el ultimo regitro se muestre primero */

        public async Task<IList<Editorial>> findAll() => await _context.Editoriales.OrderByDescending(e => e.Id).ToListAsync();
       



    }
}
