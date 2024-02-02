using Domain.Repositories;
using Domain.Services;
using Domain.Services.InterfacesServicos;
using Infra.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adicione os repositórios
builder.Services.AddScoped<IIataRepository, IataRepository>();
builder.Services.AddScoped<IAeroportoRepository, AeroportoRepository>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();
builder.Services.AddScoped<IVooRepository, VooRepository>();
builder.Services.AddScoped<IClasseRepository, ClasseRepository>();
builder.Services.AddScoped<IPassageiroRepository, PassageiroRepository>();
builder.Services.AddScoped<IPassagemRepository, PassagemRepository>();
builder.Services.AddScoped<ICompraRepository, CompraRepository>();
builder.Services.AddScoped<IBagagemRepository, BagagemRepository>();

// Adicione os serviços
builder.Services.AddScoped<IIataService, IIataService>();
builder.Services.AddScoped<IAeroportoService, AeroportoService>();
builder.Services.AddScoped<ICidadeService, CidadeService>();
builder.Services.AddScoped<IVooService, VooService>();
builder.Services.AddScoped<IClasseService, ClasseService>();
builder.Services.AddScoped<IPassageiroService, PassageiroService>();
builder.Services.AddScoped<IPassagemService, PassagemService>();
builder.Services.AddScoped<ICompraService, CompraService>();
builder.Services.AddScoped<IBagagemService, BagagemService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
