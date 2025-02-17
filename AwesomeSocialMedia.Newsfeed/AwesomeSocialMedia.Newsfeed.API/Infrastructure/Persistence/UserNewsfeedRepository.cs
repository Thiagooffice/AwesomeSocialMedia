using System;
using AwesomeSocialMedia.Newsfeed.API.Core.Entities;
using AwesomeSocialMedia.Newsfeed.API.Core.Repositories;

namespace AwesomeSocialMedia.Newsfeed.API.Infrastructure.Persistence
{
	public class UserNewsfeedRepository : IUserNewsfeedRepository
	{
        private readonly List<UserNewsfeed> _newsfeeds;

        public UserNewsfeedRepository()
        {
            _newsfeeds = new List<UserNewsfeed>();
        }

        public Task AddPost(User user, Post post)
        {
            var newsfeed = _newsfeeds.SingleOrDefault(n => n.User.Id == user.Id);

            if (newsfeed is null)
            {
                newsfeed = new UserNewsfeed(new List<Post>(), user);
                _newsfeeds.Add(newsfeed);
            }

            newsfeed.AddPost(post);

            return Task.CompletedTask;
        }

        public Task<List<UserNewsfeed?>> GetAll()
        {
            return Task.FromResult(_newsfeeds.ToList());
        }

        public Task<UserNewsfeed?> GetByUserId(Guid userId)
        {
            return Task.FromResult(_newsfeeds.SingleOrDefault(n => n.User.Id == userId));
        }

        public Task UpdateUserNewsFeed (User user)
        {
            var userNewsfeed = GetByUserId(user.Id);

            if (userNewsfeed.Result is null) return Task.CompletedTask;

            userNewsfeed.Result.User.DisplayName = user.DisplayName;

            return Task.CompletedTask;
        }
    }
}
