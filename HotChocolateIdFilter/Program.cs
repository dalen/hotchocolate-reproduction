using HotChocolate.Execution;

var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddFiltering().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
