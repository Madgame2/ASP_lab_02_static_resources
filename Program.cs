internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.UseDefaultFiles();

        // ��������� ������ � ����������� ������ �� ����� wwwroot
        app.UseStaticFiles();

        app.UseWelcomePage("/aspnetcore");
        app.MapGet("/aspnetcore", () => "hello world");

        app.Run();
    }
}
