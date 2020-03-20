FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base

LABEL version="1.0" maintainer="Winke"

WORKDIR /app

COPY ["/bin/Release/netcoreapp2.2/publish", "/app"]

ENTRYPOINT ["dotnet", "Microservice.Order.dll"]
