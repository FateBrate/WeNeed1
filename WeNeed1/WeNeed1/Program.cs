using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WeNeed1.Auth;
using WeNeed1.Service;
using WeNeed1.Service.Database;
using WeNeed1.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ITeamService,TeamService>();
builder.Services.AddTransient<ISquadService,SquadService>();
builder.Services.AddTransient<ISportsCenterService, SportsCenterService>();
builder.Services.AddTransient<IReviewService, ReviewService>();
builder.Services.AddTransient<ISportsFieldService, SportsFieldService>();
builder.Services.AddTransient<IMatchService, MatchService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<IReservationService, ReservationService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WeNeed1Context>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(IUserService));

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
