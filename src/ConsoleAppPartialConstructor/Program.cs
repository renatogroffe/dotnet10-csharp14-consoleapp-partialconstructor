using Bogus;
using ConsoleAppPartialConstructor.Models;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 14 + .NET 10 | Partial Constructors *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

var faker = new Faker("pt_BR");
var veiculos = Enumerable.Range(0, 3)
    .Select(_ => new Veiculo(
        descritivo: faker.Vehicle.Model(),
        ano: Random.Shared.Next(2020, 2025)
    ))
    .ToList();
Console.WriteLine("Alguns modelos de carros...");
foreach (var v in veiculos)
    Console.WriteLine($"{v.Descritivo} - {v.Ano}");
