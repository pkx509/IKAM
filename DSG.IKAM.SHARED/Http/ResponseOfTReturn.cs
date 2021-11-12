namespace DSG.IKAM.SHARED.Http
{
    public sealed class Response<TReturn> : Response
    {
        public TReturn Data { get; set; }
    }
}
