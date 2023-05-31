## 1、生成nuget包

项目右键->打包或执行dotnet pack

## 2、添加本地nuget包

```shell
#根目录
#添加nuget配置文件
dotnet new nugetconfig
#查看源
dotnet nuget list source
#添加源
dotnet nuget add source "./src/DemoPack/bin/Debug/" -n local
#移除源
dotnet nuget remove source local
#test项目添加nuget包
dotnet add ./src/DemoPack.Test/ package Hello.DemoPack
```

