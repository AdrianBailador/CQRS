using CQRSPractice.Application.DTOs;
using MediatR;

namespace CQRSPractice.Infrastructure.Commands
{
    public record DeleteTaskCommand(int Id) : IRequest<bool>;
}
