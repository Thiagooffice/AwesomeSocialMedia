using AwesomeSocialMedia.Users.Application.Models;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<BaseResult>
    {
        public Guid UserId { get; set; }

        public DeleteUserCommand(Guid userId)
        {
            UserId = userId;
        }
    }
}
