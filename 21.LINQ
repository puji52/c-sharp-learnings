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
->To use LINQ in a file, add this line to the top:
using System.Linq;
->Often times we use LINQ with generic collections (like lists), so you may see both namespaces imported into a file:
using System.Collections.Generic;
using System.Linq;
---------------------------------------------------------------var------------------------------------------------------------------
Every LINQ query returns either a single value or an object of type IEnumerable<T>. For now, all you need to know about that second type 
is that:
It works with foreach loops, just like arrays and lists.
You can check its length with Count().
->Since the single value type and/or the parameter type T is not always known, it’s common to store a query’s returned value in a 
variable of type var.
---------------------------------------------------------Method and Query Syntax-----------------------------------------------------
->Query syntax looks like a multi-line sentence.
var longLoudHeroes = from h in heroes
  where h.Length >= 7
  select h.ToUpper();
->Method syntax looks like plain old C#. We make method calls on the collection we are querying:
var longHeroes = heroes.Where(h => h.Length >= 7);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());Note: the capitalization of the keyword is dependent on which type of syntax 
we use. With query syntax, the query keywords must be all lowercase. For method syntax, the methods begin with a capital letter.

--------------------------------------------------------Basic Query Syntax-------------------------------------------------------
A basic LINQ query, in query syntax, has three parts:from,where,select
EX:
string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
var shortHeroes = from h in heroes
  where h.Length < 7
  select h;
->The from operator declares a variable to iterate through the sequence. In this case, h is used to iterate through heroes.
->The where operator picks elements from the sequence if they satisfy the given condition. The condition is normally written like the conditional expressions you would find in an if statement. In this case, the condition is h.Length < 7.
->The select operator determines what is returned for each element in the sequence. In this case, it’s just the element itself.
->from and select operators are required ,where is optional.

-----------------------------------------------------Basic Method Syntax: Where-------------------------------------------------------
->In method syntax, each query operator is written as a regular method call.
Ex:
we selected every element with a length under 7. Here it is in method syntax:
string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
var shortHeroes = heroes.Where(h => h.Length < 7);
--->The where operator is written as the method Where(), which takes a lambda expression as an argument. 
->Lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 7 characters long.
->Where() calls this lambda expression for every element in heroes. If it returns true, then the element is added to the resulting 
collection.
For example, the shortHeroes sequence from above would be:
[ Zoe, Liam, Taryn, Dorian ]

---------------------------------------------------Basic Method Syntax: Select----------------------------------------------------------
->In method syntax it’s written as the method Select(), which takes a lambda expression.
We can combine Select() with Where() in two ways:
------------->Use separate statements:
var longHeroes = heroes.Where(h => h.Length >= 7);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
------------->Chain the expressions:
var longLoudHeroes = heroes
  .Where(h => h.Length >= 7)
  .Select(h => h.ToUpper());

->You can tell there are two separate statements by counting the semi-colons.
-->Write a method syntax query that transforms each element in heroes to this format:
Introducing...[hero's name]!
var vi=heroes.Select(h=>$"Introducing...{h}!");

LINQ with Other Collections











