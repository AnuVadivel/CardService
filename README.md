# MicroService-Template

## Install Talisman
     export SEARCH_ROOT=$HOME/Documents **
     bash -c "$(curl --silent https://thoughtworks.github.io/talisman/scripts/install.bash)"

To view the html report  install tailsman-html-report library

    curl https://github.com/jaydeepc/talisman-html-report/archive/v1.3.zip -o ~/.talisman/talisman_html_report.zip -J -L && cd ~/.talisman && unzip talisman_html_report.zip -d . && mv talisman-html-report-1.3 talisman_html_report && rm talisman_html_report.zip

**Run** talisman --scanWithHtml

For more reference: https://github.com/jaydeepc/talisman-html-report

## Setup SonarQube

Download SonarQube server https://www.sonarqube.org/downloads/
Start the server

    <Path to SonarScannerpath>/bin/macosx-universal-64/sonar.sh start

Download dotnet-SonarScanner:

    dotnet tool install --global dotnet-sonarscanner

Generate the sonar-scanner Token 
run the following command to scan

        dotnet <path to SonarScanner.MSBuild.dll> begin /k:"project-key" /d:sonar.login="<token>"
        dotnet build <path to solution.sln>
        dotnet <path to SonarScanner.MSBuild.dll> end /d:sonar.login="<token>" 

For more reference: https://docs.sonarqube.org/latest/analyzing-source-code/scanners/sonarscanner/
    