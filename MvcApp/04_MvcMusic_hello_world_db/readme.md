connection string dla mssql localdb

"MvcMusicContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMusicContext-2;Trusted_Connection=True;MultipleActiveResultSets=true"

add sqlite packages
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef database update