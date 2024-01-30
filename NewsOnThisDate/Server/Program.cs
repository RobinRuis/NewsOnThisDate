using Microsoft.AspNetCore.ResponseCompression;
using MudBlazor.Services;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddMudServices();


builder.Services.AddHttpClient("NewsOnThisDate.ServerAPI", client => client.BaseAddress = new Uri("https://newsonthisdate.azurewebsites.net"));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://newsonthisdateserver.azurewebsites.net/",
                                              "https://newsonthisdate.azurewebsites.net");
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToPage("/_Host");

app.Run();
