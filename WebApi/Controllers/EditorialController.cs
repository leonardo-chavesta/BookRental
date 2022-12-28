using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
   
    [Route("[controller]")]
    public class EditorialController : ControllerBase
    {
        private readonly IEditorialService _editorialService;

        public EditorialController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }

        [HttpGet]
        public async Task<IEnumerable<EditorialDto>> Get() 
            => await _editorialService.FindAll();    
    };

    
}