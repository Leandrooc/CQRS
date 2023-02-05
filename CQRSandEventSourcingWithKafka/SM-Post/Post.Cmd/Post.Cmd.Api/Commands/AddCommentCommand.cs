using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentCommand : BaseComand
    {
        public string Comment { get; set; }
        public string Username { get; set; }
    }
}