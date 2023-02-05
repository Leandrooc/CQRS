using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class RemoveCommentCommand : BaseComand
    {

        public Guid CommentId { get; set; }
        public string Username { get; set; }
    }
}