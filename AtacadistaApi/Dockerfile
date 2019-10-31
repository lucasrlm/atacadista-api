FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["AtacadistaApi.csproj", ""]
RUN dotnet restore "./AtacadistaApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AtacadistaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AtacadistaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AtacadistaApi.dll"]