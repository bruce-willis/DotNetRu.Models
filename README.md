# DotNetRu.Models
DotNetRu nuget package with models

***

# Содержание

* [Build status](#build-status)
* [Nuget packages](#nuget-packages)
* [TODO](#todo)
* [Причины](#причины)

***

# Build status
TBD

***

# Nuget packages
Type  |      Package name       |                                                                     Nuget
----- | ----------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------
Realm | `DotNetRu.Models.Realm` | [![NuGet](https://img.shields.io/nuget/v/DotNetRu.Models.Realm.svg?style=flat-square)](https://www.nuget.org/packages/DotNetRu.Models.Realm/)
UI    | `DotNetRu.Models.UI`    | [![NuGet](https://img.shields.io/nuget/v/DotNetRu.Models.UI.svg?style=flat-square)](https://www.nuget.org/packages/DotNetRu.Models.UI/)
Xml   | `DotNetRu.Models.Xml`   | [![NuGet](https://img.shields.io/nuget/v/DotNetRu.Models.Xml.svg?style=flat-square)](https://www.nuget.org/packages/DotNetRu.Models.Xml/)

# TODO

* [x] Create nuget packages
* [ ] Setup CI
* [ ] Setup CD
* [x] Update [RealmGenerator](https://github.com/pfedotovsky/DotNetRu.RealmGenerator)
* [ ] Update [mobile app](https://github.com/DotNetRu/App)
* [ ] Create metapackage
* [ ] Create converters
* [ ] Tests
* [ ] Determine appropriate naming
* [ ] Sync with backend

***

# Причины

Следуя [Принципу единственной ответственности](https://ru.wikipedia.org/wiki/Принцип_единственной_ответственности) все модели внутри [мобильного приложения DotNetRu](https://github.com/DotNetRu/App) были разбиты на следующие категории, выполняющие только **одну и только одну** задачу:
* `RealmModels` - для работы с базой данных в мобильном приложении (используем Realm)
* `XmlEntities` - в настоящий момент для получения обновлений
* `Models` - для отображения UI

Чтобы не нужно было копипастить эти модели всюду, где они используются (как сейчас в [RealmGenerator](https://github.com/pfedotovsky/DotNetRu.RealmGenerator/tree/3ce36c50dfa70dced7d556d15673a9cc9d07e990/RealmGenerator) и в [App](https://github.com/DotNetRu/App/tree/9a9c3a963c15d0746f695a2c24a3027126eaca34/DotNetRu.DataStore.Audit)), было принято решение вынести их в отдельный `nuget` пакет, который можно подключить всюду, где необходимо.