cf target -s pcf-steeltoe
pause
@cls

cf unbind-service pcf-steeltoe-dotnet-core-hystrix-api pcf-steeltoe-service-registry
cf unbind-service pcf-steeltoe-dotnet-core-hystrix-api pcf-steeltoe-redis
pause
@cls

cf delete pcf-steeltoe-dotnet-core-hystrix-api -r -f
pause
@cls

cf push
pause
@cls