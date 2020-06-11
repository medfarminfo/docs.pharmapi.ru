# Метод `pl`

Используется для передачи сведений об аптеках в XML-формате (для передачи "новым" способом в JSON используйте метод [`update_pharmacies`](update_pharmacies.md)).

## Запрос  :id=request

Файл может быть отправлен двумя способами:

  * как отправка (submit) html-формы с приложенным файлом: с указанием стандартных `multipart/form-data` и `boundary=...` в http-заголовке `Content-Type`;
  * в теле (body) запроса, как и остальные методы протокола, в этом случае http-заголовок `Content-Type` должен содержать значение `application/xml` или `text/xml`.
  
!> **Важно!** В случае работы по endpoint c urlencode (/v1.0-encoded/) при отправке аптек "как приложенного файла" urlencode не используется!

Пример файла с данными:

```xml
<?xml version="1.0" encoding="utf-8"?> 
<PHARMACIES>
    <VERSION>1.1</VERSION>
    <CHAINCODE>12345</CHAINCODE>
    <COUNT>2</COUNT>
    <PHARMACY> <!-- минимальный набор данных об аптеке -->
        <CODE>121</CODE>
        <ADDRESS>Москва, Центральная улица, дом 1</ADDRESS>
        <POSES>
            <POS> <CODE>121-1</CODE> </POS>
            <POS> <CODE>121-2</CODE> </POS>
            <POS> <CODE>121-11</CODE> </POS>
        </POSES>
    </PHARMACY>
    <PHARMACY> <!-- полный набор данных об аптеке -->
        <CODE>123</CODE>
        <BRAND>Супер-аптека</BRAND>
        <LEGALENTITY>ООО "Супер-аптека"</LEGALENTITY>
        <INN>7700000000</INN>
        <REGION>Москва</REGION>
        <CITY>Москва</CITY>
        <ADDRESS>Москва, Центральный переулок, дом 11</ADDRESS>
        <GPS>55.55, 37.37</GPS>
        <WORKTIME>пт-сб 08-20</WORKTIME>
        <PHONES>8 (800) 000-00-00</PHONES>
        <POSES>
            <POS> <CODE>123-1</CODE> </POS>
            <POS> <CODE>123-2</CODE> </POS>
            <POS> <CODE>123-11</CODE> </POS>
        </POSES>
        <DISABLED>false</DISABLED>
    </PHARMACY>
  </PHARMACIES>
```

Описание полей, а также правила разрешения конфликтов в значениях POSES/POS см. в описании метода [`update_pharmacies`](update_pharmacies.md)

При получении данного файла информация обо всех аптеках, которые были переданы ранее (но не переданы в текущем файле) будет аннулирована, т.е. передача PL-файла выполняется в режиме `update_mode="replace"` (в терминах метода `update_drugstores`).

## Ответ :id=response

Ответ возвращается в виде `text/plain`, необходимо проверять HTTP Status Code ответа (200 означает успех, другие значения - ошибка).
```
Список из 42 аптек успешно принят
```
