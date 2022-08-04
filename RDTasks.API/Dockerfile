FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RDTasks.API/RDTasks.API.csproj", "RDTasks.API/"]
RUN dotnet restore "RDTasks.API/RDTasks.API.csproj"
COPY . .
WORKDIR "/src/RDTasks.API"
RUN dotnet build "RDTasks.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RDTasks.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RDTasks.API.dll"]
