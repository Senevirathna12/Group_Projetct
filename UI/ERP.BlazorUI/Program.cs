using ERP.Application.StaffApp.Interfaces;
 DevM
using ERP.Application.StaffApp.Interfaces.ResourceManagement;

using ERP.Application.StaffApp.Interfaces.ResultsMnagement;
 main
using ERP.Application.StaffApp.Interfaces.UsersManagement;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement;
using ERP.Application.StaffApp.ReporsitoryInterface.UsersManagement;
using ERP.Application.StaffApp.UseCases;
 DevM
using ERP.Application.StaffApp.UseCases.ResourceManagement;

using ERP.Application.StaffApp.UseCases.ResultMnagement;
 main
using ERP.Application.StaffApp.UseCases.UsersManagement;
using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.BlazorUI.Components;
using ERP.Repository.InMemory;
using ERP.Repository.PgSql;
using ERP.Repository.SQLite;
using Microsoft.EntityFrameworkCore;

using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuration of EF Core SQLite
ConfigurationManager configuration = builder.Configuration;

//builder.Services.AddDbContext<BaseDbContext>(opt => opt.UseSqlite(configuration.GetConnectionString("StudentDatabase"),
//     b => b.MigrationsAssembly("ERP.Repository.SQLite")));

//builder.Services.AddDbContext<PgSqlDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("PgSqlConnection"),
//     b => b.MigrationsAssembly("ERP.Repository.PgSql")));

builder.Services.AddDbContextFactory<PgSqlDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("PgSqlConnection"),
     b => b.MigrationsAssembly("ERP.Repository.PgSql")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();





builder.Services.AddScoped<IStudentRepository, StudentRepositoryPgSql>();
builder.Services.AddScoped<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
builder.Services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddScoped<IViewStudentById, ViewStudentById>();
builder.Services.AddScoped<IEditStudentUseCase, EditStudentUseCase>();
builder.Services.AddScoped<IDeleteStudentUseCase, DeleteStudentUseCase>();

builder.Services.AddScoped<IModuleRepository, ModuleReporsitoryPgSQL>();
builder.Services.AddScoped<IAddModuleUseCase, AddModuleUseCase>();
builder.Services.AddScoped<IViewModuleByNameUseCase, ViewModuleByNameUseCase>();
builder.Services.AddScoped<IDeleteModuleUseCase, DeleteModuleUseCase>();

builder.Services.AddScoped<ITeacherRepository, TeacherReporsitoryPgSQL>();
builder.Services.AddScoped<IAddTeacherUseCase, AddTeacherUseCase>();
builder.Services.AddScoped<IViewTeacherByNameUseCase, ViewTeacherByNameUseCase>();
builder.Services.AddScoped<IDeleteTeacherUseCase, DeleteTeacherUseCase>();
builder.Services.AddScoped<IEditTeacherUseCase,  EditTeacherUseCase>();
builder.Services.AddScoped<IViewTeacherById,  ViewTeacherById>();

 DevM
builder.Services.AddScoped<IResourceRepository, ResourceRepositoryPgSQL>();
builder.Services.AddScoped<IAddResourceUseCase, AddResourceUseCase>();
builder.Services.AddScoped<IDeleteResourceUseCase, DeleteResourceUseCase>();
builder.Services.AddScoped<IEditResourceUseCase, EditResourceUseCase>();
builder.Services.AddScoped<IViewResourceByNameUseCase, ViewResourceByNameUseCase>();

builder.Services.AddScoped<IComResultsRepository, ComResultsRepositoryPgSQL>();
builder.Services.AddScoped<IAddComResultsUseCase, AddComResultsUseCase>();
builder.Services.AddScoped<IViewComResultsByNameUseCase, ViewComResultsByNameUseCase>();
main


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
