cf target -s pcf-steeltoe
pause

cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Eureka.Api\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Eureka.Api\bin\Release\netcoreapp2.2\publish
cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Hystrix.Api\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Hystrix.Api\bin\Release\netcoreapp2.2\publish
cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Hystrix.Fallback.Api\bin\Release\netcoreapp2.2\publish
cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Management\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Management\bin\Release\netcoreapp2.2\publish
cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Security\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Security\bin\Release\netcoreapp2.2\publish
cf push -p ..\lib\Pcf.Steeltoe.Dotnet.Core.Web\bin\Release\netcoreapp2.2\publish -f ..\lib\Pcf.Steeltoe.Dotnet.Core.Web\bin\Release\netcoreapp2.2\publish
pause