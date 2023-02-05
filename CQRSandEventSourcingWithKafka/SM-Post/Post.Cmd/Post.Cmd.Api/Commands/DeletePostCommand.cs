using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class DeletePostCommand : BaseComand
    {
        public string Username { get; set; }
    }
}