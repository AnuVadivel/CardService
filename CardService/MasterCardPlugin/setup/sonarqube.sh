#!/bin/bash

dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /d:sonar.login="$sonarqube_token" /d:sonar.host.url="$sonarqube_url" /k:"$sonarqube_key"
dotnet build ../../src/Payment.Api/Payment.Api.csproj
dotnet sonarscanner end /d:sonar.login="$sonarqube_token"