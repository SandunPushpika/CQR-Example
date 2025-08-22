using CQR.Abstractions;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Queries.GetTaskByUserQuery;

public class GetTaskByUserQueryHandler : IRequestHandler<GetTaskByUserQuery, TaskModel[]>
{
    private readonly ITaskRepository _repository;

    public GetTaskByUserQueryHandler(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<TaskModel[]> HandleRequestAsync(GetTaskByUserQuery request)
    {
        var result = await _repository.GetTasksByUser(request.User);
        return result;
    }
}