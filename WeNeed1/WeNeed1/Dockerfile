#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WeNeed1/WeNeed1.csproj", "WeNeed1/"]
RUN dotnet restore "WeNeed1/WeNeed1.csproj"
COPY . .
WORKDIR "/src/WeNeed1"
RUN dotnet build "WeNeed1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeNeed1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeNeed1.dll"]