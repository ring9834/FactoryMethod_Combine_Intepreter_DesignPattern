# This stage defines the base image for the runtime environment.
# mcr.microsoft.com/dotnet/runtime:9.0 is a Microsoft-provided Docker image that includes the .NET 9.0 runtime, which is required to run .NET applications.
# AS base assigns the alias "base" to this stage, allowing it to be referenced later.
# This image is lightweight because it only contains the runtime, not the full SDK needed for building.
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
# Sets the user under which the application will run.
# $APP_UID is an environment variable or build argument that specifies a user ID (UID) for security purposes.
# By default, Docker containers run as the root user, which can be a security risk. Setting a non-root user ($APP_UID) enhances security by limiting permissions.
# Note: $APP_UID must be defined elsewhere (in a docker-compose.yml or as a build argument).
USER $APP_UID
# Sets the working directory for subsequent instructions.
# /app is the directory inside the container where the application files will be placed.
# Any commands (such as COPY, RUN) executed in this stage will operate relative to /app.
WORKDIR /app

# This stage sets up the environment to build the .NET application.
# mcr.microsoft.com/dotnet/sdk:9.0 is a larger image that includes the .NET 9.0 SDK, which contains tools for compiling and building .NET applications
# AS build assigns the alias "build" to this stage.
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
# Defines a build argument to specify the build configuration.
# BUILD_CONFIGURATION defaults to Release, which optimizes the application for production (smaller size, better performance) compared to Debug.
# This argument can be overridden when running docker build (for example, docker build --build-arg BUILD_CONFIGURATION=Debug).
ARG BUILD_CONFIGURATION=Release
# Sets the working directory for the build process.
# /src is where the source code will be copied and built.
WORKDIR /src
# Copies the .NET project file to the container. Place it in the FactoryMethod_Combine_Intepreter/ directory inside the Docker image's filesystem (relative to the working directory set by the WORKDIR instruction in the Dockerfile).
# Only the project file is copied at this point to take advantage of Docker's layer caching. 
# This means that if the .csproj file hasn’t changed, Docker can reuse the cached layer for the next step (dotnet restore), speeding up the build process.
COPY ["FactoryMethod_Combine_Intepreter.csproj", "/"]
# Restores the project’s dependencies.
# The dotnet restore command downloads and installs all NuGet packages specified in the .csproj file.
# This step is performed separately from the build to leverage Docker’s caching. If the .csproj file doesn’t change, Docker skips re-running this step.
# It runs the dotnet restore command inside the Docker container being built.
RUN dotnet restore "./FactoryMethod_Combine_Intepreter.csproj"
# Copies all files from the current directory on the host (typically the developer's local machine, a CI/CD server, or any other environment where the docker build command is run) to the /src directory in the container.
# This includes all source code files (including .cs files) and other resources needed for the build.
COPY . .
WORKDIR "/src"
RUN dotnet build "./FactoryMethod_Combine_Intepreter.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FactoryMethod_Combine_Intepreter.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FactoryMethod_Combine_Intepreter.dll"]