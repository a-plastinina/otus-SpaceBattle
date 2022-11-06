Feature: Обработка исключений

    Feature Description: Обработка исключений при выполнении команд

    @позитивный
    Scenario: При появлении исключения писать в лог
        Given есть команда MoveCommand
        And стратегия логировать исключения во время MoveCommand
        Then поставить команду LogCommand в очередь

    @позитивный
    Scenario: При появлении исключения повторить команду
        Given есть команда MoveCommand
        And стратегия повторять команду после исключения
        Then поставить команду OneCommand в очередь
        
    @позитивный
    Scenario: При появлении исключения повторить команду и записать в лог
        Given есть команда MoveCommand
        And стратегия повторять команду после исключения
        And стратегия логировать исключения после исключения
        Then поставить в очередь команду OneCommand и лог

    @позитивный
    Scenario: При появлении повторного исключения писать в лог
        Given есть команда MoveCommand
        And стратегия повторять команду после исключения
        And стратегия повторять MoveCommand еще раз
        And стратегия логировать исключения после повторного исключения
        Then поставить команду TwoCommand в очередь
