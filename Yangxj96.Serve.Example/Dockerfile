#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Yangxj96.Serve.Example/Yangxj96.Serve.Example.csproj", "Yangxj96.Serve.Example/"]
COPY ["Yangxj96.Serve.Common/Yangxj96.Serve.Common.csproj", "Yangxj96.Serve.Common/"]
RUN dotnet restore "Yangxj96.Serve.Example/Yangxj96.Serve.Example.csproj"
COPY . .
WORKDIR "/src/Yangxj96.Serve.Example"
RUN dotnet build "Yangxj96.Serve.Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Yangxj96.Serve.Example.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Yangxj96.Serve.Example.dll"]