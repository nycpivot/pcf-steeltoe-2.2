cf target -s pcf-steeltoe
pause
@cls

cf create-service p-config-server standard pcf-steeltoe-config-server -c config.json
cf create-service p-service-registry standard pcf-steeltoe-service-registry
cf create-service p-circuit-breaker-dashboard standard pcf-steeltoe-circuit-breaker-dashboard
cf create-service p-redis shared-vm pcf-steeltoe-redis
cf create-service p-identity pivot-mjames pcf-steeltoe-sso

cf cups pcf-steeltoe-cups-sqlserver-products -p '{\"uid\":\"nycpivot\",\"pw\":\"P@$$w0rd#01\",\"uri\":\"sqlserver://saffron.arvixe.com:1433;databaseName=PivotalProducts\"}'
cf cups pcf-steeltoe-cups-database -p '{\"provider\":\"CustomProvider\",\"server\":\"CustomServer\",\"port\":\"1433\",\"database\":\"CustomDatabase\",\"userid\":\"jdoe\",\"password\":\"password\"}'
pause