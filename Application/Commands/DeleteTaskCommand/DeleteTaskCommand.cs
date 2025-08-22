using CQR.Abstractions;

namespace Application.Commands.DeleteTaskCommand;

public class DeleteTaskCommand : IRequest
{
    public int Id { get; set; }
}