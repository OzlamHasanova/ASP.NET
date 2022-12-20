var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();


// handle http request
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    ) ;   //MIDDLEWEARler (yeni yoxlnis ve ya merhele kimi)

app.Run();    //Middlewearleri sonlandirir
