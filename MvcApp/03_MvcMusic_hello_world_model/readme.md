
Instalacja narzedzia dla scaffold
dotnet tool install --global dotnet-aspnet-codegenerator

Dodanie referencji do nuget package
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.2.2

Utworzenie rusztowania dla Album model
dotnet aspnet-codegenerator controller -name AlbumsController -m Album -dc MvcMusicContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet ef migrations add InitialCreate
dotnet ef database update

display format for numbers:
https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

dodanie culture info w startup.cs - CultureInfo


add sqlite packages
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design


dla windows connection string:
"MvcMusicContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMusicContext-2e1a5959-1dbb-483f-a15c-0ce65a41edc8;Trusted_Connection=True;MultipleActiveResultSets=true"

dla linux connection string:
"MvcMusicContext": "Data Source=MvcMusic.db"