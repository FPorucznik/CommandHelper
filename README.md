# Command Helper - REST API 
### About the project
The main purpose of the project was to be a handy helper when it comes to getting quick access to different sorts of commands used in various command prompts/terminals which we can add and then easily get when needed so even if we don't remember how to use a command we can quickly fetch it from our api.
The api provides necessary endpoints for managing commands with their description and available platforms.
Example of stored data:
 ```json
 {
	 "id": "20b2683b-6df9-4f7f-b40b-08d9d1b8efcd",
	 "action": "move to directory",
	 "line": "cd <path>",
	 "platform": "windows/linux"
 }
 ```

# Used technologies
- C#
- .NET 6
- ASP.NET Core web API
- Entity Framework Core
- MS SQL Server
- AutoMapper

## Endpoints and DTOs

The api provides 5 endpoints as seen below, also the data is mapped into specific DTOs depending on used endpoint.
<img width="942" alt="demo1" src="https://user-images.githubusercontent.com/56200864/149641047-f811b976-468b-4f31-bde5-a9df3c374217.PNG">
<img width="937" alt="demo2" src="https://user-images.githubusercontent.com/56200864/149641058-0faa37ac-a559-4fce-ae00-d7916f5b2784.PNG">
