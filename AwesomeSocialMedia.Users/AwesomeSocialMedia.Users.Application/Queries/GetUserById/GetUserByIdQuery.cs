using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Application.Queries.GetUserById;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Queries
{
    public class GetUserByIdQuery : IRequest<BaseResult<GetUserByIdViewModel>>
    {
        public GetUserByIdQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}