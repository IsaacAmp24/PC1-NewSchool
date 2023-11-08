using Microsoft.EntityFrameworkCore;
using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Domain.Repositories;
using PC1_NewSchool.Shared.Persistence.Contexts;
using PC1_NewSchool.Shared.Persistence.Repositories;

namespace PC1_NewSchool.Profiles.Persistence.Repositories;

public class StudentRepository : BaseRepository, IStudentRepository
{
    public StudentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task AddAsync(Student student)
    {
        await _context.Students.AddAsync(student);
    }

    public async Task<Student> FindByDniAsync(long dni)
    {
        /*logica de negocio*/
        /*No se permite que se registre un student con el mismo DNI*/
        return await _context.Students.FirstOrDefaultAsync(p => p.DNI == dni);
    }

    public async Task<Student> FindByStreetAddressAsync(string streetAddress)
    {
        /*No se permite que se registre 2 student con el mismo StringAddress*/
        return await _context.Students.FirstOrDefaultAsync();
    }
}