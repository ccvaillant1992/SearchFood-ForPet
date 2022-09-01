# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /SearchFood-ForPetApp
# copy app
COPY . .
# Test stage
RUN dotnet new tool-manifest --force 
RUN dotnet tool install Cake.Tool --version 2.2.0
CMD ["dotnet", "cake"]
