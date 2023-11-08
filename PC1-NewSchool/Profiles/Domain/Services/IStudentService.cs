using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Domain.Services.Communication;

namespace PC1_NewSchool.Profiles.Domain.Services;

public interface IStudentService
{
    // SaveAsync (POST) - guardar en la base de datos
    Task<StudentResponse> SaveAsync(Student student);
}