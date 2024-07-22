# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the solution file and the NuGet.config file
COPY ["NuGet.config", "VendmanagerWebNew.sln", "./"]

# Copy csproj and restore as distinct layers
COPY VMWeb.csproj .
RUN dotnet restore

# Copy everything else and build the application
COPY . .
RUN dotnet publish -c Release -o out

# Use the ASP.NET Core runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80 for the application
EXPOSE 8080

# Define the entry point for the application
ENTRYPOINT ["dotnet", "VMWeb.dll"]
