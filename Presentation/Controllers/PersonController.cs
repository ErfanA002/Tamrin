using Domain.DomainModel.Persons.Service;
using Microsoft.AspNetCore.Mvc;
namespace Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    public IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }



}