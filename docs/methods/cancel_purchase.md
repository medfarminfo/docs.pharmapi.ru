# Метод `cancel_purchase`

Отмена ранее выполненного подверждения транзакции (аннулирует вызов `confirm_purchase`). 

После вызова `cancel_purchase` транзакция может быть повторно подтверждена повторным вызовом `confirm_purchase`, и так произвольное количество раз. Последний успешно сделанный вызов (confirm или cancel) имеет приоритет.

!> Вызов методов `cancel_purchase` и `confirm_purchase` возможен в течение 30 минут с момента первоначльаного вызова `get_discount` (а не с момента предыдущего вызова cancel_purchase?confirm_purchase). После этого времени сервер будет возвращать сообщение об ошибке, и изменение статуса такой продажи необходимо производить через техподдержку, при этом в запросе может быть отказано если данная карта относится к лимитным тарифам и держатель карты уже "выбрал" лимит обратившись в другую аптеку.

## Запрос :id=request

Запрос полностью идентичен запросу для метода `confirm_purchase`.

```json
{
    "pos_id": "<pos_id>",
    "pharmacy_id": "<pharmacy_id>"
    "card_number": "<card_number>",
    "phone_number": "<phone_number>",
    "transactions": [
        "<transaction_1>",
        "<transaction_2>",
        ...
    ]
}
```

В большинстве дисконтных программ отменять надо сразу все строки (коды `transaction`) которые были подтверждены. "Частичная" отмена не допускается.

## Ответ :id=response

Ответ полностью идентичен ответу для метода `confirm_purchase`.

```json
{
    "status": "<status>",
    "error_code": <error_code>,
    "message": "<message>"
}
```
