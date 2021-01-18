# book-ordering-web-form

This Visual Studio solution produces a web form that can perform the CRUD operations for a book ordering system. There are 4 buttons: Submit, Update, Delete and Insert.

The submit button is to search for an order placed using its order number. If the order number is within the database, the customer number, order date, shipping address, city, province and postal code will be displayed. After searching for an order, one can either update or delete this order. 

To update the order information, one would change their postal code for example and press the update button. This will modify their postal code pertaining to that customer. To delete the order information, one would just press the delete button, and it would delete their order from the database.

For the insert button, all fields must be filled appropriately such that the order number and customer number entered are not already within the database.

I personally designed this database to implement a book ordering system that is able to store order, customer and book information in a MySQL database (not attached in this repository). Four tables and a many to many relationship was used to store all the approriate information.
