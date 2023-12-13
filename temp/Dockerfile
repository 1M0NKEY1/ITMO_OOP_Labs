FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["temp/temp.csproj", "temp/"]
RUN dotnet restore "temp/temp.csproj"
COPY . .
WORKDIR "/src/temp"
RUN dotnet build "temp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "temp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "temp.dll"]
