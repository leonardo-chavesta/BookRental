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

        public async Task<Editorial> Create(Editorial endity)
        {
            _context.Editoriales.Add(endity);
            await _context.SaveChangesAsync();
            return endity;
        }

        public async Task<Editorial?> Edit(int id, Editorial entity)
        {
            var model = await _context.Editoriales.FindAsync(id);
            if (model == null)
            {
                model.Codigo = entity.Codigo;
                model.Nombre = entity.Nombre;

                _context.Editoriales.Update(model);
                await _context.SaveChangesAsync();
            }

            return model;

        }

        public async Task<Editorial?> EnableOrDisable(int id)
        {
            var model = await _context.Editoriales.FindAsync(id);
            if (model == null)
            {
                model.Estado = (model.Estado == 0) ? 1 : 0 ;

                _context.Editoriales.Update(model);
                await _context.SaveChangesAsync();
            }

            return model;
        }

        public async Task<Editorial?> Find(int id)
            => await _context.Editoriales.FindAsync(id);

        /* con funcion flecha y ordendo que el ultimo regitro se muestre primero */

        public async Task<IList<Editorial>> FindAll() => await _context.Editoriales.OrderByDescending(e => e.Id).ToListAsync();


        //public async Task<IList<Editorial>> findAll()
        //{
        //    var responce = await _context.Editoriales.ToListAsync();

        //    return responce;

        //}


    }
}
