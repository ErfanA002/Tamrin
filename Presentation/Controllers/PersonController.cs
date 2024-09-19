﻿using Domain.Models.Persons.DTOs;
using Domain.Models.Persons.Entities;
using Domain.Models.Persons.Services;
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

    [HttpGet("GetPerson")]
    public IEnumerable<Person> Person()
    {
        return _personService.Person();
    }

    [HttpGet("GetById/{id:int}")]
    public Person GetPersonById(int id)
    {
        return _personService.GetPersonById(id);
    }

    [HttpPost("Create")]
    public void CreatePerson(PersonDTO person)
    {
        _personService.CreatePerson(person);
    }

    [HttpPut("Update/{id:int}")]
    public void UpdatePerson(int id,PersonDTO person)
    {
        _personService.UpdatePerson(id, person);
    }

    [HttpDelete("Delete/{id}")]
    public void DeletePerson(int id)
    {
        _personService.DeletePerson(id);
    }

    [HttpDelete("DeleteLogical/{id:int}")]
    public void DeleteLogicalPerson(int id)
    {
        _personService.DeleteLogicalPerson(id);
    }

    [HttpPut("ActivePerson/{personId:int}")]
    public void ActivePerson(int personId)
    {
        _personService.ActivePerson(personId);
    }

    [HttpPut("DisenablePerson/{personId:int}")]
    public void DisenablePerson(int personId)
    {
        _personService.DisenablePerson(personId);
    }

    [HttpPut("Address/{id}")]
    public void Address(string address,int id)
    {
        _personService.Address(id,address);
    }
}