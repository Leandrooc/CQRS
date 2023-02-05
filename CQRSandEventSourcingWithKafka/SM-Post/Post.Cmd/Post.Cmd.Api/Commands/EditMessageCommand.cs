using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class EditMessageCommand : BaseComand
    {
        public string Message { get; set; }
    }
}