FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["UsersMicroservices.Api/UsersMicroservices.Api.csproj", "UsersMicroservices.Api/"]
COPY ["UsersMicroservices.Application/UsersMicroservices.Application.csproj", "UsersMicroservices.Application/"]
COPY ["UsersMicroservices.Domain/UsersMicroservices.Domain.csproj", "UsersMicroservices.Domain/"]
COPY ["UsersMicroservices.Infrastructure/UsersMicroservices.Infrastructure.csproj", "UsersMicroservices.Infrastructure/"]
RUN dotnet restore "UsersMicroservices.Api/UsersMicroservices.Api.csproj"
COPY . .
WORKDIR "/src/UsersMicroservices.Api"
RUN dotnet build "./UsersMicroservices.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./UsersMicroservices.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UsersMicroservices.Api.dll"]
