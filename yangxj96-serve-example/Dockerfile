FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["yangxj96-serve-example/yangxj96-serve-example.csproj", "yangxj96-serve-example/"]
RUN dotnet restore "yangxj96-serve-example/yangxj96-serve-example.csproj"
COPY . .
WORKDIR "/src/yangxj96-serve-example"
RUN dotnet build "yangxj96-serve-example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "yangxj96-serve-example.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "yangxj96-serve-example.dll"]
