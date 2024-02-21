#region BuilderPattern


using BuilderPattern.Method1;

var eb = new EndPointBuilder("https://localhost");
eb.Append("api")
    .Append("v1")
    .Append("user")
    .AppendParams("id", "5")
    .AppendParams("username", "Teymur");

var url = eb.Build();

//Console.WriteLine(url);

EmployeeBuilderM1 empBuilder = new();
var employee= empBuilder
    .SetEmailAdress("tt@mail.com")
    .SetUsername("Tete")
    .BuildEmployee();

Console.WriteLine(employee);


#endregion