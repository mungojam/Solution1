#r "nuget: APackage, 1.0.6"

using System.Reflection;

var executionLocation = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory;

Console.WriteLine(executionLocation);

foreach(var file in executionLocation.EnumerateFiles()) {
    Console.WriteLine(file);
}