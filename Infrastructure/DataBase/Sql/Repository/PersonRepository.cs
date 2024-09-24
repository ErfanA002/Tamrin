using Domain.Models.Persons.Entities;
using Domain.Models.Persons.Repositorys;

namespace Infrastructure.DataBase.Sql.Repository;

public class PersonRepository : IPersonRepository
{
    public TamrinDbContext _tamrinDbContext;

    public PersonRepository(TamrinDbContext tamrinDbContext)
    {
        _tamrinDbContext = tamrinDbContext;
    }

    public IEnumerable<Person> Person()
    {
        return _tamrinDbContext.Persons.ToList() as IEnumerable<Person>;
    }

    public Person GetById(int id)
    {
        return _tamrinDbContext.Persons.SingleOrDefault(x => x.Id == id);
    }

    public void Update(int id, Person person)
    {
        var getPerson = GetById(id);

        getPerson.Name = person.Name;
        getPerson.LastName = person.LastName;
        getPerson.Address = person.Address;
        getPerson.Phone = person.Phone;
        getPerson.IsActive = person.IsActive;
        getPerson.IsDelete = person.IsDelete;
    }

    public void Delete(int id)
    {
        var targetperson = GetById(id);

        _tamrinDbContext.Remove(targetperson);
    }

    public void DeleteLogical(int id)
    {
        var targerperson = GetById(id);

        targerperson.IsDelete = true;
    }

    public void Create(Person person)
    {
        _tamrinDbContext.Persons.Add(person);
    }

    public void ActivePerson(int personId)
    {
        var targetperson = GetById(personId);

        targetperson.IsActive = true;
    }

    public void DisenablePerson(int personid)
    {
        var targetperson = GetById(personid);

        targetperson.IsActive = false;
    }

    public void AddPersonAddress(int id, string addess)
    {
        var targetperson = GetById(id);

        targetperson.Address.Add(new Address(){Name = addess});
    }


    public void Save()
    {
        _tamrinDbContext.SaveChanges();
    }

    public void UpdatePersonAddress(int addessid, Address address)
    {
        throw new NotImplementedException();
    }

    public void UpdatePersonPhone(int id, Phone phone)
    {
        throw new NotImplementedException();
    }
}