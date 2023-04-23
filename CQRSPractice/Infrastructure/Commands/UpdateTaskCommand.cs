using CQRSPractice.Application.DTOs;
using MediatR;

namespace CQRSPractice.Infrastructure.Commands
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted) : IRequest<TaskItemDto>;
}
