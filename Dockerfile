# .NET Core SDK aşaması
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Proje dosyalarını kopyala
COPY *.csproj ./
RUN dotnet restore

# Geri kalan proje dosyalarını kopyala ve build et
COPY . ./
RUN dotnet publish -c Release -o out

# .NET Core çalıştırma zamanı aşaması
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out ./

# Uygulamayı çalıştır
ENTRYPOINT ["dotnet", "BlogApp.dll"]
