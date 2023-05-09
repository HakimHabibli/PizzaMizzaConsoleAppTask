namespace TaskOrm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Sisteme ne elave olunacaqsa bu arada elave olunacaq

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "AB201");
            //App.Userouting routing sistemini yaratsinv 
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}"
                    );
            });
            app.Run();
        }
    }
}