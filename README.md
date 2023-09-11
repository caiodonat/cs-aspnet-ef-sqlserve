## Steps

0. Create VS Solution File
```bash
dotnet new sln -o <projectName>
```

1. Create module Api
```bash
dotnet new webapi -o <projectName>.Api
```

2. Create module Domain
```bash
dotnet new classlib -o Ddd.Domain
```

3. Create module Infrastructure
```bash
dotnet new classlib -o Ddd.Infrastructure
```

4. Add modules on VS Solution File
```bash
dotnet sln add $(ls -r  **/*.csproj)
```

5. Set module references
```bash
dotnet add Ddd.Domain/ reference Ddd.Api/ Ddd.Infrastructure/
```

6. Run project
```bash
dotnet run --project Ddd.Api
```


## Target Architecture

```
ProjectName/
└── src
	├── ProjectName.Api
	│	├── bin
	│	├── Controllers
	│	├── Middlewares
	│	├── obj
	│	└── Properties
	├── ProjectName.Domain
	│	├── bin
	│	├── Common
	│	├── DTOs
	│	├── Entities
	│	├── Exceptions
	│	├── obj
	│	├── Repositories
	│	└── Services
	├── ProjectName.Infrastructure
	│	├── bin
	│	├── Database
	│	├── Extensions
	│	├── Helpers
	│	├── Mapper
	│	├── Migrations
	│	├── obj
	│	├── Repositories
	│	└── Validators
	└── ProjectName.Tests
		├── Services
		└── Validators
```
