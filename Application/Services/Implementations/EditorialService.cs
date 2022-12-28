using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using AutoMapper;
using Domain;
using Infrastructure.Repositories.Abstractions;

namespace Application.Services.Implementations
{
    public class EditorialService : IEditorialService
    {
        private readonly IMapper _mapper;
        private readonly IEditorialRepository _editorialRepository;

        public EditorialService(IMapper mapper ,IEditorialRepository editorialRepository) 
        {
            _mapper = mapper;
            _editorialRepository = editorialRepository;
        }

        public async Task<IList<EditorialDto>> FindAll()
        {   
            // Con List 
            //IList<Editorial> editorials = await _editorialRepository.findAll();
            //return _mapper.Map<IList<EditorialDto>>(editorials);
             
           var responser = await _editorialRepository.FindAll();
           return _mapper.Map<IList<EditorialDto>>(responser);
        }
    }
}
