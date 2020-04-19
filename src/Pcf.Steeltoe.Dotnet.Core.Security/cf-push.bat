cf target -s pcf-steeltoe
pause
@cls

cf unbind-service pcf-steeltoe-dotnet-core-security pcf-steeltoe-sso
pause
@cls

cf delete pcf-steeltoe-dotnet-core-security -r -f
pause
@cls

cf push
pause
@cls