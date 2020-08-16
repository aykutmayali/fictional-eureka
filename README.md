# "fictional-eureka" a project for React CRUD with .netcore 

- install nuget package:  Microsoft.EntityFrameworkCore 3.1.0(because of dependencies - frameworks - .net core app version = 3.1.0)
- install nuget package:     Microsoft.EntityFrameworkCore.SqlServer
- install nuget package:      Microsoft.EntityFrameworkCore.Tools   
- install nuget package:	Microsoft.AspNetCore.Cors (add startup.cs--> public void ConfigureServices(IServiceCollection services)-->
				 services.AddCors();
				 public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
				 
)


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

- Add API Controller with actions using EF --> BeaconsController (with DBContext & Model Class)

-----------------------Postman ----------------------

- Post -->raw body json 
	{
    "Type":"Beacon",
    "Name":"Aykut",
    "Location":"Ofis-1",
    "Mac":40102500
	} 
	Send
-First data in db

-----------------------------------------------------

---------------------Create a React App--------------
- \beacons\WebApi_1>npx create-react-app react-app
- \beacons\WebApi_1>cd react-app
- \beacons\WebApi_1\react-app> code .
- in index.css @import url('https://fonts.googleapis.com/css2?family=Roboto:wght@300;400&display=swap'); (google font)
- \beacons\WebApi_1\react-app>npm i -s redux react-redux redux-thunk

- \beacons\WebApi_1\react-app> npm i -s axios
- \beacons\WebApi_1\react-app> npm i -s @material-ui/core @material-ui/icons
- \beacons\WebApi_1\react-app> npm -i -s react-toast-notifications

-----------------------------------------------------


 