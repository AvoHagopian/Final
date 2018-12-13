# COMP 586 Avedis Hagopian Final Project 

<h2>Project Description</h2>
Pantheon
A collection of Heroes, Gods, and Countries with descriptions and details for each instance. All CRUD operations can be done on the tables in order to expand the list.

<h4>Model View Controller</h4>
The Project uses Models in the backend of heroes, countries, and gods and uses controllers to manage api calls from the frontend which displays the views of all the lists.

<h4>Object Relational Model</h4>
The database was made using the Entity Framework implemented on SQLite. The three models are Hero, God, and Country. Where a God has many Heroes and a Country has many Gods and Heroes.

<h4>Single Page Application</h4>
The frontend was developed using Angular in order to display data in a Single Page Application. All pages allow for new data to be added as well as editing and deleting existing data.

<h4>Dependency Injection</h4>
Dependency Injection was used in the frontend with the many service files injected into the Angular components. Dependency Injection was also used in the backend for the api controllers and the database context.

<h4>Authentication</h4>
Unfortunately, Authentication was not able to be implemented. Auth0, Okta, as well as manual token generation did not work correctly as the HTTP handshakes prevented the user from returning to the application. The implementation of Auth0 remains in the repo through comments.
