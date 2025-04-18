﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Server.Launcher/Server.Launcher.csproj", "Server.Launcher/"]
COPY ["Server.Apps/Server.Apps.csproj", "Server.Apps/"]
COPY ["Server.Core/Server.Core.csproj", "Server.Core/"]
COPY ["Server.DBServer/Server.DBServer.csproj", "Server.DBServer/"]
COPY ["Server.Serialize/Server.Serialize.csproj", "Server.Serialize/"]
COPY ["Server.Utility/Server.Utility.csproj", "Server.Utility/"]
COPY ["Server.Extension/Server.Extension.csproj", "Server.Extension/"]
COPY ["Server.Setting/Server.Setting.csproj", "Server.Setting/"]
COPY ["Server.Google.ProtoBuf/Server.Google.ProtoBuf.csproj", "Server.Google.ProtoBuf/"]
COPY ["Server.NetWork/Server.NetWork.csproj", "Server.NetWork/"]
COPY ["Server.NetWork.HTTP/Server.NetWork.HTTP.csproj", "Server.NetWork.HTTP/"]
COPY ["Server.NetWork.WebSocket/Server.NetWork.WebSocket.csproj", "Server.NetWork.WebSocket/"]
COPY ["Server.NetWork.TCPSocket/Server.NetWork.TCPSocket.csproj", "Server.NetWork.TCPSocket/"]
COPY ["Server.Proto/Server.Proto.csproj", "Server.Proto/"]
COPY ["Server.Config/Server.Config.csproj", "Server.Config/"]
COPY ["Server.Log/Server.Log.csproj", "Server.Log/"]
RUN dotnet restore "Server.Launcher/Server.Launcher.csproj"
COPY . .
WORKDIR "/src/Server.Launcher"
RUN dotnet build "Server.Launcher.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Server.Launcher.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Server.Launcher.dll"]
