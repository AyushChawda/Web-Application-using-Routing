var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//Converstion based Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

//app.UseRouting();

//app.UseEndpoints(endpoint  =>
//{
//    endpoint.MapGet("/", async (context) =>
//    {
//        await context.Response.WriteAsync("<h1>This is home page Get Api</h1>");
//    });
//    endpoint.MapGet("/about", async (context) =>
//    {
//        await context.Response.WriteAsync("<h1>This is about page Get Api</h1>");
//    });

//    endpoint.MapGet("/contact", async (context) =>
//    {
//        await context.Response.WriteAsync("<h1>This is Contact page Get Api</h1>");
//    });

//});

app.Run();
