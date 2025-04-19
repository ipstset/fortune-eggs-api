FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["FortuneEggs.Api/FortuneEggs.Api.csproj", "FortuneEggs.Api/"]
COPY ["FortuneEggs.Infrastructure/FortuneEggs.Infrastructure.csproj", "FortuneEggs.Infrastructure/"]
COPY ["FortuneEggs.Application/FortuneEggs.Application.csproj", "FortuneEggs.Application/"]
RUN dotnet restore "FortuneEggs.Api/FortuneEggs.Api.csproj"
COPY . .
WORKDIR "/src/FortuneEggs.Api"
RUN dotnet build "FortuneEggs.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FortuneEggs.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FortuneEggs.Api.dll"]
