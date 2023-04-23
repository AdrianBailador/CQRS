using CQRSPractice.Application.DTOs;
using MediatR;

namespace CQRSPractice.Infrastructure.Queries
{
    public record GetAllTaskQuery : IRequest<IEnumerable<TaskItemDto>>;
}
