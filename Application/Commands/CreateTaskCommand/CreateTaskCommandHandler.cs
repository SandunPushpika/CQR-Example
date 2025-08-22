using AutoMapper;
using CQR.Abstractions;
using Domain.DTOs.Requests;
using Infrastructure.Repository;

namespace Application.Commands;

public class CreateTaskCommandHandler(ITaskRepository repository, IMapper mapper) : IRequestHandler<CreateTaskCommand>
{
    public async Task HandleRequestAsync(CreateTaskCommand request)
    {
        await repository.AddTask(mapper.Map<TaskCreateRequest>(request));
    }
}