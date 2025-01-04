using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.Entities;
using AwesomeSocialMedia.Users.Core.Repository;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Commands.GetAllUser
{
    public class GetAllUsersCommandHandler : IRequestHandler<GetAllUsersCommand, BaseResult>
    {
        private readonly IUserRepository _repository;
        public GetAllUsersCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<BaseResult> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllAsync();

             return new BaseResult<List<User>>(users, success: true, "Usuários recuperados com sucesso");
        }
    }
}