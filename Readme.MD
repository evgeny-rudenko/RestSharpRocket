# Библиотека для отправки сообщений в [RocketChat](https://www.rocket.chat/ "Rocket Chat")

Можно использовать для отправки сообщений о событиях

## Реализовано:
* Логин
* Получение списка каналов
* Отправка сообщений в канал
* Десериализация ответов сервера
* Набор методов расширения для строк (будет использовано позже)


## Пример использования

```
RocketChat r = new RocketChat(user, password, uri);
var channels = r.ChannelList;
var response = r.PostMessage("Test", "servermessages");

```



***

[Докуметация RocketChat для разрабочиков](https://developer.rocket.chat/ "Rocket Chat")


![image info](RocketChat.png)