

add sqlite packages
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef database update

dotnet add package Microsoft.AspNetCore.Localization

ustawienie jezyka polskiego w walidacji: https://github.com/aspnet/Docs/issues/4076 

W pliku: _ValidationScriptsPartial.cshtml 
Dodac linki do wymaganych skryptow (poniżej jQuery): 
<!-- globalize scripts -->
<script src="~/lib/globalize/dist/globalize.js"></script>
<script src="~/lib/globalize/dist/globalize/number.js"></script>
<script src="~/lib/globalize/dist/globalize/date.js"></script>

<script src="~/lib/jquery-validation-globalize/jquery.validate.globalize.js"></script>

