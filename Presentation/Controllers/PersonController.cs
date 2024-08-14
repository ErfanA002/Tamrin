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


    [HttpGet]
    public Person GetPersonById(int id)
    {
        return _personService.GetPersonById(id);
    }

    [HttpPost]
    public void CreatePerson(Person person) 
    {
        _personService.CreatePerson(person);
    }

    [HttpPut("{id}")]
    public void UpdatePerson(int id,Person person)
    {
        _personService.UpdatePerson(id,person);
    }

    [HttpDelete("{id}")]
    public void DeletePerson(int id)
    {
        _personService.DeletePerson(id);
    }
}