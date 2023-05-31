# nugetPackTest
nuget 打包记录
```shell
#打包
dotnet pack
#添加nuget配置文件
dotnet new nugetconfig
#查看源
dotnet nuget list source
#添加源
dotnet nuget add source "./src/DemoPack/bin/Debug/" -n local
#移除源
dotnet nuget remove source local
```