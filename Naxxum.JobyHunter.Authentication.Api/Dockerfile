#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Naxxum.JobyHunter.Authentication.Api/Naxxum.JobyHunter.Authentication.Api.csproj", "Naxxum.JobyHunter.Authentication.Api/"]
COPY ["Naxxum.JobyHunter.Authentication.Application/Naxxum.JobyHunter.Authentication.Application.csproj", "Naxxum.JobyHunter.Authentication.Application/"]
COPY ["Naxxum.JobyHunter.Authentication.Domain/Naxxum.JobyHunter.Authentication.Domain.csproj", "Naxxum.JobyHunter.Authentication.Domain/"]
COPY ["Naxxum.JobyHunter.Authentication.Infrastructure/Naxxum.JobyHunter.Authentication.Infrastructure.csproj", "Naxxum.JobyHunter.Authentication.Infrastructure/"]
RUN dotnet restore "./Naxxum.JobyHunter.Authentication.Api/./Naxxum.JobyHunter.Authentication.Api.csproj"
COPY . .
WORKDIR "/src/Naxxum.JobyHunter.Authentication.Api"
RUN dotnet build "./Naxxum.JobyHunter.Authentication.Api.csproj" -c %BUILD_CONFIGURATION% -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Naxxum.JobyHunter.Authentication.Api.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Naxxum.JobyHunter.Authentication.Api.dll"]