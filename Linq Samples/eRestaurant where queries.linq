<Query Kind="Expression">
  <Connection>
    <ID>8f5cb5ef-609e-434b-a777-20d0279a1f4f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//where clause

//list all tables that hold more than 3 people
//quary syntax
from row in Tables
where row.Capacity > 3
select row

//method syntax
Tables.Where(row => row.Capacity > 3)

//list all items with more than 500 calories
from food in Items
where food.Calories > 500
select food

Items.Where(food => food.Calories > 500)

//list all items with more than 500 calories and selling for more than $10.00
from food in Items
where food.Calories > 500 &&
	  food.CurrentPrice > 10.00m
select food

//list all items with more than 500 calories and are Entrees on the menu
//HINT: navigational properties of the database are knoewn by LinqPad
from food in Items
where food.Calories > 500 &&
	  food.MenuCategory.Description.Equals("Entree")
select food