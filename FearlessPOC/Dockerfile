FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 3000
ENV ASPNETCORE_URLS=http://+:3000

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY FearlessPOC/FearlessPOC.csproj FearlessPOC/
RUN dotnet restore FearlessPOC/FearlessPOC.csproj
COPY . .
WORKDIR /src/FearlessPOC
RUN dotnet build FearlessPOC.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FearlessPOC.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FearlessPOC.dll"]
