namespace GenericRepositoryAPI.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public bool IsDeleted { get; set; }
}
public class Student : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public Group Group { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int GroupId { get; set; }
}
public class Group : BaseEntity
{
    public string Name { get; set; }
    public List<Student>? Students { get; set; }
    public List<Teacher>? Teacher { get; set; }
}
public class Teacher : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime EnrollmentDate { get; set; }
}