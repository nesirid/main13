using Practice_Interface_Services.Models;

namespace Practice_Interface_Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        Employee GetById(Employee[] employees, int? id);
    }
}
