cf target -s pcf-steeltoe
pause
@cls

cf unbind-service pcf-steeltoe-dotnet-core-web pcf-steeltoe-config-server
cf unbind-service pcf-steeltoe-dotnet-core-eureka-api pcf-steeltoe-service-registry
cf unbind-service pcf-steeltoe-dotnet-core-hystrix-api pcf-steeltoe-service-registry
cf unbind-service pcf-steeltoe-dotnet-core-hystrix-fallback-api pcf-steeltoe-service-registry
cf unbind-service pcf-steeltoe-dotnet-core-web pcf-steeltoe-service-registry
cf unbind-service pcf-steeltoe-dotnet-core-web pcf-steeltoe-circuit-breaker-dashboard
cf unbind-service pcf-steeltoe-dotnet-core-hystrix-api pcf-steeltoe-redis
cf unbind-service pcf-steeltoe-dotnet-core-security pcf-steeltoe-sso
cf unbind-service pcf-steeltoe-dotnet-core-hystrix-fallback-api pcf-steeltoe-cups-sqlserver-products
cf unbind-service pcf-steeltoe-dotnet-core-web pcf-steeltoe-cups-database
pause
@cls

cf delete-service pcf-steeltoe-config-server -f
cf delete-service pcf-steeltoe-service-registry -f
cf delete-service pcf-steeltoe-circuit-breaker-dashboard -f
cf delete-service pcf-steeltoe-redis -f
cf delete-service pcf-steeltoe-sso -f
cf delete-service pcf-steeltoe-cups-sqlserver-products -f
cf delete-service pcf-steeltoe-cups-database -f
pause
@cls

cf delete pcf-steeltoe-dotnet-core-eureka-api -r -f
cf delete pcf-steeltoe-dotnet-core-hystrix-api -r -f
cf delete pcf-steeltoe-dotnet-core-hystrix-fallback-api -r -f
cf delete pcf-steeltoe-dotnet-core-management -r -f
cf delete pcf-steeltoe-dotnet-core-security -r -f
cf delete pcf-steeltoe-dotnet-core-web -r -f
pause
@cls