FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY /website/ ./
ENTRYPOINT [ "dotnet", "WebBookingApp.dll" ]