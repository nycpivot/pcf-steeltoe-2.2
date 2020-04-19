cf target -s pcf-steeltoe
pause
@cls

cf unbind-service pcf-steeltoe-dotnet-core-hystrix-fallback-api pcf-steeltoe-service-registry
pause
@cls

cf delete pcf-steeltoe-dotnet-core-hystrix-fallback-api -r -f
pause
@cls

cf push
pause
@cls