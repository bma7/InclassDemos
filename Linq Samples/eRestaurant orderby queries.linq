<Query Kind="Expression">
  <Connection>
    <ID>8f5cb5ef-609e-434b-a777-20d0279a1f4f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default is ascending
from food in Items
orderby food.Description
select food

//also available descending
from food in Items
orderby food.CurrentPrice descending
select food

//can use both ascending and descending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

//you can use where and orderby together
from x in Items
orderby x.CurrentPrice descending, food.Calories ascending
where x.MenuCategory.Description.Equals("Entree")
select x