<Query Kind="Expression">
  <Connection>
    <ID>8f5cb5ef-609e-434b-a777-20d0279a1f4f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//groupby

from food in Items
group food by food.MenuCategory.Description

//this creates a key with a value and the row collection for that key value

//more than one field
from food in Items
group food by new{food.MenuCategory.Description, food.CurrentPrice}