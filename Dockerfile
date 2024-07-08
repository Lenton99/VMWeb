# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["VendmanagerWebNew.csproj", "VendmanagerWebNew/"]
RUN dotnet restore "VendmanagerWebNew/VendmanagerWebNew.csproj"
COPY . .
WORKDIR "/src/VendmanagerWebNew"
RUN dotnet build "BlazorServerApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorServerApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorServerApp.dll"]
