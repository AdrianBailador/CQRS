using CQRSPractice.Application.DTOs;
using MediatR;

namespace CQRSPractice.Infrastructure.Commands
{
    public record CreateTaskCommand(string Title, string Description) : IRequest<TaskItemDto>;
}
