# URL Shortener

URL Shortener - это приложение, которое позволяет создавать короткие ссылки на основе длинных. Это приложение было создано с помощью C# и React.

## Архитектура

Архитектура приложения разделена на две части: серверную (C#) и клиентскую (React).

### Серверная часть

Серверная часть приложения была создана с помощью C#. Она занимается созданием коротких ссылок, хранением их в БД и редиректом на длинные ссылки.

### Клиентская часть

Клиентская часть приложения была создана с помощью React. Она занимается получением коротких ссылок от сервера, отображением их на странице, а также редиректом на длинные ссылки.

## Как работает

1. Пользователь вводит длинную ссылку.
2. Клиентская часть приложения отправляет запрос на серверную часть.
3. Серверная часть приложения создает короткую ссылку и хранит ее в БД.
4. Серверная часть приложения возвращает короткую ссылку клиентской части.
5. Клиентская часть отображает короткую ссылку на странице.
6. Если пользователь хочет перейти на длинную ссылку, он нажимает на короткую.
7. Клиентская часть приложения отправляет запрос на серверную часть.
8. Серверная часть приложения находит длинную ссылку, соответствующую короткой, и редиректит на нее.

## Как я это сделал

1. Я создал серверную часть приложения с помощью C#.
2. Я создал клиентскую часть приложения с помощью React.
3. Я настроил взаимодействие между серверной и клиентской частью при помощи запросов на сервер.
4. Я реализовал логику создания коротких ссылок, хранения их в БД и редиректа на длинные ссылки.
5. Я протестировал приложение на различных сценариях.
