cf target -s pcf-steeltoe
pause
@cls

cf unbind-service pcf-steeltoe-dotnet-core-eureka-api pcf-steeltoe-service-registry
pause
@cls

cf delete pcf-steeltoe-dotnet-core-eureka-api -r -f
pause
@cls

cf push
pause
@cls