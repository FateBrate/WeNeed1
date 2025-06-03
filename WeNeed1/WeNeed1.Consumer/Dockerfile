FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WeNeed1.Consumer/WeNeed1.Consumer.csproj", "WeNeed1.Consumer/"]
RUN dotnet restore "WeNeed1.Consumer/WeNeed1.Consumer.csproj"
COPY . .
WORKDIR "/src/WeNeed1.Consumer"
RUN dotnet build "WeNeed1.Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeNeed1.Consumer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeNeed1.Consumer.dll"]
