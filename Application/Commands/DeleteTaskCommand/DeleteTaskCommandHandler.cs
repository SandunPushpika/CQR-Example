using CQR.Abstractions;
using Infrastructure.Repository;

namespace Application.Commands.DeleteTaskCommand;

public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
{
    private readonly ITaskRepository _repository;

    public DeleteTaskCommandHandler(ITaskRepository repository)
    {
        _repository = repository;
    }
    public async Task HandleRequestAsync(DeleteTaskCommand request)
    {
        await _repository.DeleteTask(request.Id);
    }
}