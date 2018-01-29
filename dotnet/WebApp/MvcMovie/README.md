# MvcMovie

## Routing in the Startup.cs file
- http://server:port/[Controller]/[ActionName]/[Parameters]?[query-strings] => "{controller=HelloWorld}/{action=Welcome}/77?[name=Pedro&city=Oslo]"

## MvcMovie - HelloWorldController
> http://localhost:51038/HelloWorld/Index

> http://localhost:51038/HelloWorld/Welcome

> http://localhost:51038/HelloWorld/Welcome?name=Rick&numtimes=4

> http://localhost:51038/HelloWorld/Welcome/77?name=Pedro Alves&numtimes=4

## MvcMovie - HomeController
> http://localhost:51038/Home/Index

> http://localhost:51038/Home/About

> http://localhost:51038/Home/Contact

## MvcMovie - MoviesController
> http://localhost:51038/Movies/Index

> http://localhost:51038/Movies/Details/1

> http://localhost:51038/Movies/Edit/1

> http://localhost:51038/Movies/Delete/1

> http://localhost:51038/Movies/Create
