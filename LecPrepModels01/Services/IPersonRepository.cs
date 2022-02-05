using LecPrepModels01.Models.Entities;

namespace LecPrepModels01.Services;

public interface IPersonRepository
{
    ICollection<Person> ReadAll();
    Person Create(Person newPerson);
    Person? Read(int id);
    void Update(int oldId, Person person);
    void Delete(int id);
}

