# Stage 1

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

ENV ASPNETCORE_ENVIRONMENT=Development

WORKDIR /src

COPY ./*.sln .
COPY ./nuget.config .
COPY ./Nora.Bff.Api/Nora.Bff.Api.csproj/ Nora.Bff.Api/

RUN dotnet restore
COPY . .

WORKDIR /src
RUN dotnet publish -c Release -o /app

# Stage 2

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine

WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 8080

ENTRYPOINT ["dotnet", "Nora.Bff.Api.dll"]