## История изменений документа :id=changes {docsify-ignore}

* Сентябрь 2020
  * В ответ метода [`get_discount`](/methods/get_discount.md) добавлено поле `program_name` с наименованием программы (помимо уже имеющегося поля `program` с кодом программы)
* Август 2020
  * Документация реструктурирована, старые ссылки могут не работать
  * Добавлено поле `qr_code` в вызов метода [`get_discount`](/methods/get_discount.md)
  * Добавлено описание методов [`update_prices`](/methods/update_prices.md) и [`sellout`](/methods/sellout.md)
  * Внесены изменения на [тестовый сервер](/test-server.md) - расширены критерии "узнаваемых карт"
  * Расширен состав [тестов](/test-cases.md) - добавлены тесты на `update-prices` и `sellout`
  * Исправлено описание тестового сервера - на ШК 1111111111116 дается не 30%, а 20% скидка
* 21 июля 2020
  * Актуализировано описание методов [`confirm_purchase`](/methods/confirm_purchase.md) и [`cancel_purchase`](/methods/cancel_purchase.md)
  * Добавлен [Типовой сценарий тестирования](/test-cases.md)
* 11 июня 2020
  * Добавлено описание всех методов (за исключением confirm_purchase и cancel_purchase)
* 20 апреля 2020
  * Добавлена [версия v1.1](/connect.md#api-versions)
* 13 апреля 2020
  * Документация реструктурирована, старые ссылки могут не работать;
  * Добавлено [упоминание "выключенности" методов регистрации карты](/like_changes.md#register);
  * Добавлены разделы:
      * [Последовательность работ при интеграции](/howto.md);
      * [Тестовый сервер](/test-server.md);
* Февраль 2020:
  * Добавлено отличие [Указание `program` в ответе на `get_discount`](/like_changes#program-in-get-discount);
  * Исправлена ошибка: метод `update_drugstores` это неверное имя метода, верное имя  [`update_pharmacies`](/like_changes#update_pharmacies);
* Январь 2020:
  * Первоначальная версия документа.
