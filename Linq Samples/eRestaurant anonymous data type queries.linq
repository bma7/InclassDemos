<Query Kind="Expression">
  <Connection>
    <ID>8f5cb5ef-609e-434b-a777-20d0279a1f4f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous data type queries
from food in Items
where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
orderby food.CurrentPrice descending
select new //POCOObjectName
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		Profit = food.CurrentPrice - food.CurrentCost
	}
	
from food in Items
where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
orderby food.CurrentPrice descending
select new
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		//Profit = food.CurrentPrice - food.CurrentCost
	}
	

	
