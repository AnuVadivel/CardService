# MicroService-Template

## Install Talisman
     export SEARCH_ROOT=$HOME/Documents **
     bash -c "$(curl --silent https://thoughtworks.github.io/talisman/scripts/install.bash)"

To view the html report  install tailsman-html-report library

    curl https://github.com/jaydeepc/talisman-html-report/archive/v1.3.zip -o ~/.talisman/talisman_html_report.zip -J -L && cd ~/.talisman && unzip talisman_html_report.zip -d . && mv talisman-html-report-1.3 talisman_html_report && rm talisman_html_report.zip

**Run** talisman --scanWithHtml

For more reference: https://github.com/jaydeepc/talisman-html-report