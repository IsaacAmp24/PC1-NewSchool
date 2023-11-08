using AutoMapper;
using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Resources;

namespace PC1_NewSchool.Profiles.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveStudentResource, Student>();
    }
}