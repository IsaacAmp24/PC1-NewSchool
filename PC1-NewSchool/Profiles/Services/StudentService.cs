using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Domain.Repositories;
using PC1_NewSchool.Profiles.Domain.Services;
using PC1_NewSchool.Profiles.Domain.Services.Communication;
using PC1_NewSchool.Shared.Domain.Repositories;

namespace PC1_NewSchool.Profiles.Services;

public class StudentService: IStudentService
{
    /*Aqui se definen las reglas o logicas de negocio*/

    private readonly IStudentRepository _studentRepository;
    private readonly IUnitOfWork _unitOfWork; /* estrecha la mano a la bd*/

    public StudentService (IStudentRepository studentRepository, IUnitOfWork unitOfWork)
    {
        _studentRepository = studentRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<StudentResponse> SaveAsync(Student student)
    {
        // validate DNI
        var existingDni = await _studentRepository.FindByDniAsync(student.DNI);
        
        if (existingDni != null)
            return new StudentResponse("There is already a student registered with this DNI");
        
        
        /*validamos q un student no sea menor de edad*/
        
        if (student.birthDate > DateTime.Now.AddYears(-18))
            return new StudentResponse("Student is not of legal age");
        
        // Validate streetAddress
        
        var existingStreetAddress = await _studentRepository.FindByStreetAddressAsync(student.streetAddress);

        if (existingStreetAddress != null)
            return new StudentResponse("Este estudiante ya tiene esta direccion");
        
        // validate gender
        if (student.gender is not ("Male" or "Female"))
            return new StudentResponse("Ingrese un genero valido");
        
        try
        {
            await _studentRepository.AddAsync(student);
            
            await _unitOfWork.CompleteAsync();
            
            return await Task.FromResult(new StudentResponse(student));
        }
        catch (Exception e)
        {
            return await Task.FromResult(new StudentResponse($"An error ocurred while saving the student: {e.Message}"));
        }
        
        
    }
}