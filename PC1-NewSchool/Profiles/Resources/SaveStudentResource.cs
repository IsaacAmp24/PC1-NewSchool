using System.ComponentModel.DataAnnotations;

namespace PC1_NewSchool.Profiles.Resources;

public class SaveStudentResource
{
    // Es lo que se muestra en el Swagger
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public long DNI { get; set; }
    
    [Required]
    public string gender   { get; set; }
    
    [Required]
    public string streetAddress { get; set; }
    
    [Required]
    public DateTime birthDate { get; set; }
    
    [Required]
    public string speciality { get; set; }
}