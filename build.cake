var restore = Argument("restore", "Restore");
var build = Argument("build", "Build");
var test =  Argument("test", "Test");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////
Task("Restore")
    .Does(() =>
{
    DotNetBuild("./SearchFoodForPet.sln", new DotNetBuildSettings
    {
        Configuration = configuration,
    });
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetBuild("./SearchFoodForPet.sln", new DotNetBuildSettings
    {
        Configuration = configuration
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("../SearchFoodForPet.Tests/SearchFoodForPet.Tests.csproj", new DotNetTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
    });
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(test);
