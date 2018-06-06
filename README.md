# EntityFrameworkInDepth

## Memorable Steps:

### Setting Up:
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- think of adding 
   ```xml
   <ItemGroup>
     <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
   </ItemGroup>
   ```
  in .csproj
  
### Create Migration 
- `dotnet ef migrations add <MigrationName>`

### Install Migration into DB
- `dotnet ef database update`

### Create SQL Script of all Migrations
- `dotnet ef migrations script`
