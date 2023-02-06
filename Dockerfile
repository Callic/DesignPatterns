#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

######### PARTE 1 ########

#CRIOU UMA IMAGEM A PARTIR DA IMAGEM RUNTIME QUE ESTÁ NO HUB OFICIAL DO DOCKER E A NOMEOU DE base
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base

#CRIOU UMA PASTA CHAMADA APP E ENTROU NELA
WORKDIR /app


####### PARTE 2 #########

#CRIOU UMA IMAGEM A PARTIR DA IMAGEM SDK QUE ESTÁ NO HUB OFICIAL DO DOCKER E A NOMEOU DE base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

#CRIOU UMA PASTA CHAMADA APP E ENTROU NELA
WORKDIR /src

#COPIOU TODOS OS ARQUIVOS DO HOST E ENVIOU PARA A PASTA SRC
COPY . .

#AQUI ELE NÃO PRECISOU CRIAR AS PASTAS, APENAS ENTROU NESTE CAMINHO, ISTO JÁ NA IMAGEM DOCKER
WORKDIR "/src/src/DP.App.Console"

#AQUI FEZ O BUILD DA NOSSA APLICAÇÃO E SALVOU NA PASTA RAIZ APP/BUILD
RUN dotnet build "DP.App.Console.csproj" -c Release -o /app/build


########## PARTE 3 ##########

#UTILIZANDO A IMAGEM build E RENOMEANDO-A PARA publish
FROM build AS publish

#FEZ O PUBLISH DA NOSSA APLICAÇÃO NA PASTA RAIZ APP/PUBLISH
RUN dotnet publish "DP.App.Console.csproj" -c Release -o /app/publish /p:UseAppHost=false


######### PARTE 4 ########

#A PARTIR DA IMAGEM RUNTIME base CRIOU ESTA CHAMADA final
FROM base AS final

#ENTROU NA PASTA APP
WORKDIR /app

#COPIOU DA IMAGEM publish OS ARQUIVOS CONTIDOS NO DIRETÓRIO /app/publish PARA A PASTA app NA IMAGEM final
COPY --from=publish /app/publish .

#ESTUDAR O QUE ESTE ENTRYPOINT FAZ AMANHÃ
ENTRYPOINT ["dotnet", "DP.App.Console.dll"]