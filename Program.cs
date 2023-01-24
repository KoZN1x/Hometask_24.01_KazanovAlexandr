namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.Run(async (context) =>
            {
                var response = context.Response;
                response.ContentType = "text/html";
                await response.WriteAsync("<h2>Name:</h2><h3>Alexandr Kazanov</h3>\n" +
                    $"<h2>Date:</h2><h3>{DateTime.Now}</h3>\n" +
                    $"<h2>Environment:</h2><h3>{app.Environment.EnvironmentName}</h3>\n" +
                    $"<h2>Application:</h2><h3>{app.Environment.ApplicationName}</h3>\n" +
                    $"<h2>Host:</h2><h3>{response.HttpContext.Request.Host}</h3>\n" +
                    $"<h2>Protocol:</h2><h3>{response.HttpContext.Request.Protocol}</h3>");
            });

            app.Run();
        }
    }
}