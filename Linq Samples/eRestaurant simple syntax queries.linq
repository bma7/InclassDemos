<Query Kind="Statements">
  <Connection>
    <ID>8f5cb5ef-609e-434b-a777-20d0279a1f4f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//simple list for humping an entity
Waiters

//simple query syntax
from person in Waiters
select person

//simple method syntax
Waiters.Select(person => person)

//inside our project we will be writting c# statement
var results = from person in Waiters
				select person;

//to display the contents of a variable in LinqPad
//use the .Dump() method
results.Dump();

//implemented inside a VS project's class library BLL method
[DataObjectMethod(DataObjectMethodType.Select,false)]
public List<Waiters> SomeMethodName()
{
	//youwill need to connect to your DAL object
	//this will be done using a new xxxx() constructor
	//assume your connection variable is called contextvariable
	
	//do your quary
	var results = from person in contextvariable.Waiters
				select person;
	//return you results
	return results.ToList();
	
}