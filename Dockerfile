FROM microsoft/dotnet:2.1-sdk AS build

WORKDIR /app

# Copy CSPROJ and restore
COPY ./*.csproj ./
RUN dotnet restore

# Copy app and publish
COPY ./ ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine
EXPOSE 80
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Contact-Service.dll"]