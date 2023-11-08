namespace PC1_NewSchool.Profiles.Resources;

public class StudentResource
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long DNI { get; set; }
    public string gender   { get; set; }
    public string streetAddress { get; set; }
    public DateTime birthDate { get; set; }
    public string speciality { get; set; }
}