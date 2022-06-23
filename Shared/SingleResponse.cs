namespace Shared
{
    public class SingleResponse<T> : Response
    {
        public T Item { get; set; }

        public SingleResponse()
        {
        }

        public SingleResponse(string message, bool hasSuccess, T item) : base(message, hasSuccess)
        {
            this.Item = item;
        }
    }
}
