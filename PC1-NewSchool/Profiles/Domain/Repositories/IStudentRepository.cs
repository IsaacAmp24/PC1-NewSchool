using PC1_NewSchool.Profiles.Domain.Models;

namespace PC1_NewSchool.Profiles.Domain.Repositories;

public interface IStudentRepository
{
    Task AddAsync(Student student);
    
    
    /* No se permite que se registre un student con el mismo DNI*/
    Task<Student> FindByDniAsync(long dni);
    
    /* No se permite que se registre 2 student con el mismo StreetAddress*/
    Task<Student> FindByStreetAddressAsync(string streetAddress);
    
}