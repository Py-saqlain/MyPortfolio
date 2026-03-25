# Use the official .NET runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Use the .NET SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["MyPortfolio.csproj", "./"]
RUN dotnet restore "MyPortfolio.csproj"

# Copy the rest of the code and build
COPY . .
RUN dotnet build "MyPortfolio.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "MyPortfolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPortfolio.dll"]

# Create a non-root user for Hugging Face security
RUN useradd -m -u 1000 user
USER user
ENV HOME=/home/user \
    PATH=/home/user/.local/bin:$PATH
WORKDIR $HOME/app

# Copy the published app to the new user's home
COPY --from=publish --chown=user /app/publish .

# Hugging Face expects port 7860 by default
EXPOSE 7860
ENV ASPNETCORE_URLS=http://+:7860

ENTRYPOINT ["dotnet", "MyPortfolio.dll"]