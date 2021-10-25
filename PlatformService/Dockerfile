FROM mcr.microsoft.com/dotnet/aspnet:5.0 As base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:5.0 As build
WORKDIR /src
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /publish


FROM base As final
COPY --from=build /publish .
ENTRYPOINT [ "dotnet", "PlatformService.dll" ]
