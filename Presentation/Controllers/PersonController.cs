using Domain.DomainModel.Persons.DTO;
using Domain.DomainModel.Persons.Entities;
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

    [HttpGet("GetAll")]
    public List<Person> Person()
    {
        return _personService.Person();
    }


    [HttpGet("{id:int}")]
    public Person GetPersonById(int id)
    {
        return _personService.GetPersonById(id);
    }

    [HttpPost]
    public void CreatePerson(CreatePersonDTO person) 
    {
        _personService.CreatePerson(person);
    }

    [HttpPut("{id:int}")]
    public void UpdatePerson(int id,UpdatePersonDTO person)
    {
        _personService.UpdatePerson(id,person);
    }

    [HttpDelete("{id:int}")]
    public void DeletePerson(int id)
    {
        _personService.DeletePerson(id);
    }
}