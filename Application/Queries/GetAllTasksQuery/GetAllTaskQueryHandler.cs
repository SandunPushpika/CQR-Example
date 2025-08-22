using CQR.Abstractions;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Queries.GetAllTasksQuery;

public class GetAllTaskQueryHandler : IRequestHandler<GetAllTaskQuery, TaskModel[]>
{
    
    private readonly ITaskRepository _repository;

    public GetAllTaskQueryHandler(ITaskRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<TaskModel[]> HandleRequestAsync(GetAllTaskQuery request)
    {
        var res = await _repository.GetAllTasks();
        return res.ToArray();
    }
}