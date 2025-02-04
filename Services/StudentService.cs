using jwt.data;
using jwt.models;

namespace jwt.Services{

    public class StudentService : IStudentService{

        private readonly AppDbContext _context = new();

        public async Task AddStudent(Student student){

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }
    }
}