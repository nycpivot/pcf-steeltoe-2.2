cf target -s pcf-steeltoe
pause
@cls

cf delete pcf-steeltoe-dotnet-core-management -r -f
pause
@cls

cf push
pause
@cls