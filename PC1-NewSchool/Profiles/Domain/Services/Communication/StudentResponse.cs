using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Shared.Domain.Services.Comunication;

namespace PC1_NewSchool.Profiles.Domain.Services.Communication;

public class StudentResponse : BaseResponse<Student>
{
    public StudentResponse(string message) : base(message)
    {
    }
    
    public StudentResponse(Student resource) : base(resource)
    {
    }
}