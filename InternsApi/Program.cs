
using InternsApi.Factory;
using InternsApi.Factory.Strategies;
using InternsApi.Services.Download;
using InternsApi.Services.Parsing;
using InternsApi.Services.Parsing.Csv;
using InternsApi.Services.Parsing.Json;
using InternsApi.Services.Parsing.Zip;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

namespace InternsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options => 
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IServiceProvider, ServiceProvider>();
            builder.Services.AddScoped<IDownloadService, DownloadService>();
            builder.Services.AddScoped<IParseService, ParseService>();

            builder.Services.AddScoped<JsonParserStrategy>();
            builder.Services.AddScoped<CsvParserStrategy>();
            builder.Services.AddScoped<ZipCsvParserStrategy>();

            builder.Services.AddScoped<IJsonService, JsonService>();
            builder.Services.AddScoped<ICsvService, CsvService>();
            builder.Services.AddScoped<IZipService, ZipService>();

            builder.Services.AddScoped<ParserFactory>();

            builder.Services.AddHttpClient("FileClient", client =>
            {
                client.BaseAddress = new Uri("https://piotrszymala.github.io/Interns/");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
