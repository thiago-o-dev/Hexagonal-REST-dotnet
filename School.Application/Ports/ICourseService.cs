using School.Application.ViewModels;

namespace School.Application.Ports;

public interface ICourseService
{
    Task<CourseViewModel> CreateAsync(CreateCourseViewModel viewModel);
    Task<IEnumerable<CourseViewModel>> GetAllAsync();
    Task DeleteAsync(Guid id);
}