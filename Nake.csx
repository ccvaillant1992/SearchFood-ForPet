#r "System.Net.WebClient"
#r "nuget: Nake.Meta, 3.0.0-beta-01"
#r "nuget: Nake.Utility, 3.0.0-beta-01"

using System.IO;
using System.Text;
using System.Net;
using System.Linq;
using System.Diagnostics;

using Nake;
using static Nake.FS;
using static Nake.Log;
using static Nake.Env;

var TargetFramework = "netcoreapp6.0";
var Version = "3.0.0-dev";

/// Restores packages and builds sources in Debug mode
[Nake] async Task Restore() => await $@"dotnet restore ./SearchFoodForPet.csproj";

/// Builds sources using specified configuration
[Nake] async Task Build() => await $@"dotnet build ./SearchFoodForPet.csproj";

/// Runs unit tests
[Nake] async Task Test() => await $@"dotnet test ../SearchFoodForPet.Tests/SearchFoodForPet.Tests.csproj";
