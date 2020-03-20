FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Base/Base.csproj", "Base/"]
RUN dotnet restore "Base/Base.csproj"
COPY . .
WORKDIR "/src/Base"
RUN dotnet build "Base.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Base.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Base.dll"]