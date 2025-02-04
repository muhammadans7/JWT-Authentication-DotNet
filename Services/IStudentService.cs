using jwt.models;

namespace jwt.Services{

    public interface IStudentService{

        Task AddStudent(Student student);

        // Task<List<Student>> GetStudents();

        
    }
}