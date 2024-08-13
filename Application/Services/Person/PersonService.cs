using Domain.DomainModel.Person.Repositorys;
using Domain.DomainModel.Person.Service;
namespace Application.Services.Person;
public class PersonService : IPersonService
{
    public IPersonRepository _PersonRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _PersonRepository = personRepository;
    }
}