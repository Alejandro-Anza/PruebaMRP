FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Api/PruebaMRP.csproj", "Api/"]
RUN dotnet restore "Api/PruebaMRP.csproj"
COPY src/Api/ Api/
WORKDIR "/src/Api"
RUN dotnet build "PruebaMRP.csproj" -c Release -o /app/build
RUN dotnet publish "PruebaMRP.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PruebaMRP.dll"]