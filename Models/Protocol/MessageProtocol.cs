namespace BasicLibrary.Models.Protocol
{
    public class MessageProtocol
    {
        public virtual ErrorType Code { get; set; }
        public virtual string Message { get; set; }
    }
}