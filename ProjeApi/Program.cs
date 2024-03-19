using ProjeApi.Business.Abstract;
using ProjeApi.Business.Concrete;
using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.EntityFreamwork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();

builder.Services.AddSingleton<IStockService, StockManager>();
builder.Services.AddSingleton<IStockDal, EfStockDal>();

builder.Services.AddSingleton<IReportService, ReportManager>();
builder.Services.AddSingleton<IReportDal, EfReportDal>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
