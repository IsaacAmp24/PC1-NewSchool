using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Profiles.Domain.Services;
using PC1_NewSchool.Profiles.Resources;
using PC1_NewSchool.Shared.Extensions;

namespace PC1_NewSchool.Profiles.Controllers;


[ApiController]
[Route("/api/v1/[controller]")]

public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;
    
    public StudentsController(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }
    
    /*agregamos (lo que se visualiza en el Swagger)*/
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveStudentResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var student = _mapper.Map<SaveStudentResource, Student>(resource);

        var result = await _studentService.SaveAsync(student);

        if (!result.Success)
            return BadRequest(result.Message);

        var studentResource = _mapper.Map<Student, StudentResource>(result.Resource);

        return Ok(studentResource);
    }
}