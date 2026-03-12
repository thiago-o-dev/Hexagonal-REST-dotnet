using School.Application.ViewModels;

namespace School.Application.Ports;

public interface IStudentService
{
    Task EnrollAsync(CreateStudentViewModel viewModel);
    Task<IEnumerable<StudentViewModel>> GetAllAsync();
    Task DeactivateAsync(Guid id);
}