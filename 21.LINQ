LINQ. It works for complex selections and transformations, and it works on local and remote data sources. Each selection/transformation is called a 
query, and LINQ gives us new syntax and methods to write them.
->Imagine LINQ as an add-on to C# and .NET. Once you import the LINQ features, you can write new syntax, like:
string[] names = { "Tiana", "Dwayne", "Helena" };
var filteredNames = from n in names
  where n.Contains("a")
  select n;

And you can use new methods on collections, like Where():
var shortNames = names.Where(n => n.Length < 4);

-----------------------------------------------------------------Importing LINQ---------------------------------------------------------------------
