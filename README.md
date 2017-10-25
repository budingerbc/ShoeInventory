Automatically build user authentication AFTER building new solution via VisualStudios:

 `dotnet new mvc --auth Individual`

Add to Startup:

`below services.AddMvc();
services.AddEntityFrameworkMySql()
                    .AddDbContext<ApplicationDbContext>(options =>
                                              options
                                                   .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));`

 .csproj add dependencies:

`<PackageReference Include="Microsoft.EntityFrameworkCore" Version="1.1.2" />
 <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="1.1.2" />`  

 Remove/Delete:

`Data folder and Migrations folder BEFORE running migration`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 

