namespace Shared
{
    public class SingleResponse<T> : Response
    {
        public T Item { get; private set; }

        public SingleResponse(string message, bool hasSuccess, T item) : base(message, hasSuccess)
        {
            this.Item = item;
        }
    }
}
