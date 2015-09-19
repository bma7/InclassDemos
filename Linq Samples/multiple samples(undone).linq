<Query Kind="Expression" />

(from theBill in BillItems
where theBill.BillID == 
select theBill.SalePrice )

(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Sum(theBill => theBill.SalePrice * theBill.Quantity)).Max()

//the average paid bill
(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Sum(theBill => theBill.SalePrice * theBill.Quantity)).Average()

//take an average of the list
(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems).Count()
