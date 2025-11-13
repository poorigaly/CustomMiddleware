# CustomMiddleware

A custom middleware in ASP.NET Core is a component that processes HTTP requests and responses as they pass through the request pipeline.
Middleware executes in order, one after another.

Each middleware can:
1) Do something before the next middleware runs (e.g., log requests).
2) Call the next middleware using await _next(context).
3) Do something after the next middleware runs (e.g., log response time).

The core middleware pattern (constructor with RequestDelegate, InvokeAsync, registration via UseMiddleware<>() or extension methods) remains the same in ASP.NET Core

Custom middleware in ASP.NET Core can be implemented by defining a class with an Invoke or InvokeAsync method that takes HttpContext as a parameter and returns a Task. 
This class is then registered in the application’s request pipeline within the Configure method in Startup.cs using the UseMiddleware<T> extension method, where T is your custom middleware class. 
Custom middleware can perform various tasks such as logging, request/response modification, authentication, etc.
