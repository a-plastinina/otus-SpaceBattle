Feature: Создание объектов через IoC

    Feature Description: Создание объектов через IoC
  
    @негативный
    Scenario: регистрация ''
        Then регистрация ''

    @позитивный
    Scenario: Создать класс Vector
        Given зарегистрован Vector
        When получить объект Vector
        Then объект Vector не пустой

    @негативный
    Scenario: Нет зависимости Vector2
        When получить объект Vector2
        Then не зарегистрован Vector2
    
    @негативный
    Scenario: не завершена регистрация
        Given не завершена регистрация Vector2
        When получить объект Vector2
        Then не зарегистрован Vector2

    @позитивный
    Scenario: Создать класс корабль 1
        Given зарегистрирован корабль
        Then создан объект корабль 1

    @позитивный
    Scenario: Создать команду MacroMoveCommand
        Then создали команду MacroMoveCommand

    @позитивный
    Scenario: Создать команду движение вперед
        Then создали команду движение вперед
