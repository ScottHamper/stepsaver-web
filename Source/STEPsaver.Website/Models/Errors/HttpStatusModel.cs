namespace STEPsaver.Website.Models.Errors
{
    public class HttpStatusModel
    {
        public HttpStatusModel(int code)
        {
            Code = code;
            Name = code == 404 ? "Page Not Found"
                : code == 500 ? "Internal Server Error"
                : "Error";
        }

        public int Code { get; }
        public string Name { get; }
    }
}
