namespace Shared
{
    public class Response
    {
        public Response()
        {
        }

        public Response(string message, bool hasSuccess)
        {
            Message = message;
            HasSuccess = hasSuccess;
        }

        public string Message { get; set; }
        public bool HasSuccess { get; set; }
    }
}
