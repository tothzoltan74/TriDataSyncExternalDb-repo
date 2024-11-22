using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;

var logger = LoggerFactory.Create(builder => builder.AddNLog()).CreateLogger<Program>();
var config = new ConfigurationBuilder()
         .SetBasePath(System.IO.Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .AddEnvironmentVariables()
         .AddUserSecrets<Program>()
       
         .Build();


Console.WriteLine("DB2_INST1_PWD="+Environment.GetEnvironmentVariable("DB2_INST1_PWD"));
Console.WriteLine("MSSQL_SA_PWD="+Environment.GetEnvironmentVariable("MSSQL_SA_PWD"));




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
