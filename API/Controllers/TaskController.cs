using Application.Commands;
using Application.Commands.DeleteTaskCommand;
using Application.Queries.GetAllTasksQuery;
using Application.Queries.GetTaskByUserQuery;
using CQR.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TaskFlow.CQRS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController: ControllerBase
{
    private readonly ICqr _cqr;

    public TaskController(ICqr cqr)
    {
        _cqr = cqr;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskCommand request)
    {
        await _cqr.SendRequest(request);
        return Ok("Created a Task");
    }

    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var result = await _cqr.SendRequest(new GetAllTaskQuery());
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        await _cqr.SendRequest(new DeleteTaskCommand() { Id = id });
        return Ok("Task deleted");
    }

    [HttpGet("get-by-user/{user}")]
    public async Task<IActionResult> GetTasksByUser(string user)
    {
        var result = await _cqr.SendRequest(new GetTaskByUserQuery(user));
        return Ok(result);
    }
}