Feature: Переместить объект

    Feature Description: Переместить объект

    @позитивный
    Scenario: Успешное перемещение
        Given объект имеет позицию 12,5
        And скорость -7,3
        When выполнить команду движения
        Then свойство позиция будет равно 5,8

    @негативный
    Scenario: Неизвестно местоположение
        Given позиция объекта null
        And скорость -7,3
        When движение не удалось

    @негативный
    Scenario: Неизвестна скорость
        Given объект имеет позицию 12,5
        And скорость объекта null
        When движение не удалось

    @негативный
    Scenario: Не изменяется позиция
        Given объект имеет позицию 12,5
        And скорость -7,3
        When выполнить команду движения
        Then свойство позиция НЕ изменено