using CQRSPractice.Application.DTOs;
using CQRSPractice.Infrastructure;
using CQRSPractice.Infrastructure.Commands;
using MediatR;

namespace CQRSPractice.Application.Handlers
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateTaskHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellation )
        {
            throw new NotImplementedException();
        }
    }
}
