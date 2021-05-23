# Fearless POC 

This is a proof of concept for an application called 'Project Purple Cow'

## Description

A Web API built in .NET Core 2.1. Uses InMemoryCache as a database that stores items.

## Getting Started

### Installing

* You must have Docker installed on your machine
* Download the Zip folder or checkout the project

### Executing program

* Open Powershell
* cd into the project folder in the same directory as the .sln file.
```
docker-compose up
```
* Go to https://localhost:3000/api/items
* The database will be seeded with data

## Endpoints
GET /api/items - Returns all items from the DB
GET /api/items/{id} - Returns a single item
POST /api/items - Stores a list of items into the DB
PUT /api/items/{id} - Updates an item's name by Id
DELETE /api/items - Deletes all item's from the DB
DELETE /api/items/{id} - Deletes a single item

## Help

Change port by going to docker-compose.yml

## Future Updates
* Persist the data in a database on a server
* Add a primary key to the DB that auto increments, currently you have to provide an Id in the POST body.
* Add unit tests to test the logic in the repository layer
* Add exception handling

## Authors

Contributors names and contact info

ex. George Koutroumpis
