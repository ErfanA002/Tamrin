﻿using Domain.DomainModel.Persons.Entities;
using Domain.DomainModel.Persons.Repositorys;
namespace Infrastructure.DataBase.Sql.Repository;
public class PersonRepository : IPersonRepository
{
    public TamrinDbContext _tamrinDbContext;

    public PersonRepository(TamrinDbContext tamrinDbContext)
    {
        _tamrinDbContext = tamrinDbContext;
    }

    public void Create(Person person)
    {
        _tamrinDbContext.Persons.Add(person);
    }

    public void Delete(int id)
    {
        var targetPerson =  _tamrinDbContext.Persons.SingleOrDefault(x => x.Id == id);
        
        _tamrinDbContext.Persons.Remove(targetPerson);
    }

    public Person GetById(int id)
    {
        var targetPerson = _tamrinDbContext.Persons.SingleOrDefault(x => x.Id == id);
        
        return targetPerson;
    }

    public List<Person> Person()
    {
        return _tamrinDbContext.Persons.ToList();
    }

    public void Update(int id, Person person)
    {
        var targetPerson = _tamrinDbContext.Persons.SingleOrDefault(x => x.Id == id);
        
        _tamrinDbContext.Persons.Update(targetPerson);
    }
}