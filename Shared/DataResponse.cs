namespace Shared
{
    public class DataResponse<T> : Response
    {
        public DataResponse()
        {
        }

        public DataResponse(string message, bool hasSuccess, List<T> dados) : base(message, hasSuccess)
        {
            this.Dados = dados;
        }
        public List<T> Dados { get; set; }
    }
}
