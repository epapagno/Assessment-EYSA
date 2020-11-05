#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ["EYSA.Restaurant.Distributed.GraphQL/EYSA.Restaurant.Distributed.GraphQL.csproj", "EYSA.Restaurant.Distributed.GraphQL/"]
RUN dotnet restore "EYSA.Restaurant.Distributed.GraphQL/EYSA.Restaurant.Distributed.GraphQL.csproj"
COPY . .
WORKDIR "/src/EYSA.Restaurant.Distributed.GraphQL"
RUN dotnet build "EYSA.Restaurant.Distributed.GraphQL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EYSA.Restaurant.Distributed.GraphQL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EYSA.Restaurant.Distributed.GraphQL.dll"]
