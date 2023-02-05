using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class NewPostCommand : BaseComand
    {
        public string Author { get; set; }
        public string Message { get; set; }
    }
}