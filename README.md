## Steps

1. Create VS Solution File
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
