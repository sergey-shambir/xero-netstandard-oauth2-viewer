# Утилита для просмотра сущностей, доступных через Xero Accounting API

_Сделано на основе Xero NetStandard OAuth 2.0 Starter App_

Отображает сущности, доступные через Xero Accounting API, в виде JSON

- Для большинства типов сущностей показывается 100 только последних по дате изменения

## Регистрация приложения в Xero

You will need your Xero app credentials created to run this demo app. 
To obtain your API keys, follow these steps:

* Create a [free Xero user account](https://www.xero.com/us/signup/api/) (if you don't have one)
* Login to [Xero developer center](https://developer.xero.com/myapps)
* Click "New App" link
* Enter your App name, company url, privacy policy url.
* Enter the redirect URI (your callback url - i.e. `http://localhost:5000/Authorization/Callback`)
* Agree to terms and condition and click "Create App".
* Click "Generate a secret" button.
* Copy your client id and client secret and save for use later.
* Click the "Save" button. You secret is now hidden.

## Настройка приложения

Создать файл `XeroNetStandardApp/appsettings.local.json` со следующим содержимым: 

```json
{
  "XeroConfiguration": {
    "ClientId": "YOUR_XERO_APP_CLIENT_ID",
    "ClientSecret": "YOUR_XERO_APP_CLIENT_SECRET",
  }
}
```

## Запуск

Собрать и запустить:

```bash
dotnet run --project XeroNetStandardApp/
```

После чего открыть в браузере: http://localhost:5000/
