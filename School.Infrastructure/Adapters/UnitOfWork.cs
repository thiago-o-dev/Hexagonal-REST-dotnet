using School.Domain.Ports;
using School.Infrastructure.Data;

namespace School.Infrastructure.Adapters;

public class UnitOfWork : IUnitOfWork
{
    private readonly SchoolDbContext _context;
    public IStudentRepository Students { get; }
    public ICourseRepository Courses { get; }
    public IEnrollmentRepository Enrollments { get; }

    public UnitOfWork(
        SchoolDbContext context,
        IStudentRepository students,
        ICourseRepository courses,
        IEnrollmentRepository enrollments)
    {
        _context = context;
        Students = students;
        Courses = courses;
        Enrollments = enrollments;
    }

    public async Task<bool> CommitAsync() => await _context.SaveChangesAsync() > 0;
    public void Dispose() => _context.Dispose();
}
