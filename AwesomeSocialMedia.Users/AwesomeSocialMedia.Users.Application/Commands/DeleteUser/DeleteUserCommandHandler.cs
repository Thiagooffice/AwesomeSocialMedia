using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.Repository;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, BaseResult>
    {
        private readonly IUserRepository _repository;

        public DeleteUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<BaseResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByIdAsync(request.UserId);

            await _repository.DeleteAsync(user);

            return new BaseResult(true, "Usuário excluído com sucesso.");
        }
    }
}