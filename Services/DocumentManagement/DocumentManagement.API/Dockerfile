FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/DocumentManagement/DocumentManagement.API/DocumentManagement.API.csproj", "Services/DocumentManagement/DocumentManagement.API/"]
RUN dotnet restore "Services/DocumentManagement/DocumentManagement.API/DocumentManagement.API.csproj"
COPY . .
WORKDIR "/src/Services/DocumentManagement/DocumentManagement.API"
RUN dotnet build "DocumentManagement.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DocumentManagement.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DocumentManagement.API.dll"]
