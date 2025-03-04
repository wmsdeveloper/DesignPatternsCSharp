using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dto;

namespace WebApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route(nameof(GetEmployessBySalaryAsync))]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEmployessBySalaryAsync([FromQuery] double from, double to) {
            var result = await _unitOfWork.Employee.GetBySalaryAsync(from, to);
            return Ok(result);
        }

        [HttpPost]
        [Route(nameof(AddEmployeeAsync))]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddEmployeeAsync(EmployeeDto employee) {
            var entity = new Employee {
                Name = employee.Name,
                Email = employee.Email,
                Phone = employee.Phone,
                Salary = employee.Salary
            };
            await _unitOfWork.Employee.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return Ok();

        }
    }
}