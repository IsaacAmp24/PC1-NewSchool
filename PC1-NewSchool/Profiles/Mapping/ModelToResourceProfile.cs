using AutoMapper;
using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Resources;

namespace PC1_NewSchool.Profiles.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Student, StudentResource>();
    }
}