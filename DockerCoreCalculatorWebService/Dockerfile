FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["DockerCoreCalculatorWebService/DockerCoreCalculatorWebService.csproj", "DockerCoreCalculatorWebService/"]
RUN dotnet restore "DockerCoreCalculatorWebService/DockerCoreCalculatorWebService.csproj"
COPY . .
WORKDIR "/src/DockerCoreCalculatorWebService"
RUN dotnet build "DockerCoreCalculatorWebService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DockerCoreCalculatorWebService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerCoreCalculatorWebService.dll"]