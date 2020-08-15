# fictional-eureka" a project for React CRUD with .netcore 

- install nuget package:  Microsoft.EntityFrameworkCore 3.1.0(because of dependencies - frameworks - .net core app version = 3.1.0)
- install nuget package:     Microsoft.EntityFrameworkCore.SqlServer
- install nuget package:      Microsoft.EntityFrameworkCore.Tools   


- add [Key] , [Column(TypeName ="nvarchar(100)")] Data Annotaions to Model Classes

- add DashboardDBContext(DbContextOptions<DashboardDBContext> options):base(options) to DashboardDBContext & public DbSet<Beacon> Beacons { get; set; }
        public DbSet<Gateway> Gateways { get; set; } for Constructing these Classes Tables

- add appsettings.json : "ConnectionStrings": {
    "DevConnection": "Data Source=19668B547340;Database=DashboardDB;Persist Security Info=True;User ID=sa;Password=Password_01"
      
  }

- add Startup.cs : services.AddDbContext<DashboardDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
 * made a dependency injection for DBContext class

- After Successful Build Tools -> Nuget Package Console -> Add-Migration "Initial Create" &  Update-Database
 * you should see db created from SSMS

