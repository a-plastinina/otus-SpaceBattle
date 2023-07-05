Feature: HardStopCommand
	Hard остановка потока

@позитивный_Hard
Scenario: Команда остановки HARD
	Given создать очередь
	And добавить команду
	And добавить команду HardStop
	And добавить команду
	And читается очередь
	When поток останавливается
	Then в очереди осталась 1 команда
	
@позитивный_Hard
Scenario: Команда остановки HARD 2
	Given создать очередь
	And добавить команду HardStop
	And добавить команду
	And добавить команду
	And читается очередь
	When поток останавливается
	Then в очереди осталась 2 команда
	
	
@позитивный_Hard
Scenario: Команда остановки HARD 3
	Given создать очередь
	And добавить команду
	And добавить команду
	And добавить команду HardStop
	And читается очередь
	When поток останавливается
	Then в очереди осталась 0 команда
	
	
@позитивный_SOFT
	Scenario: Команда остановки Soft
		Given создать очередь
		And добавить команду
		And добавить команду SoftStop
		And добавить команду
		And читается очередь
		When поток останавливается
		Then в очереди осталась 0 команда
	
@позитивный_SOFT
	Scenario: Команда остановки Soft 2
		Given создать очередь
		And добавить команду SoftStop
		And добавить команду
		And добавить команду
		And читается очередь
		When поток останавливается
		Then в очереди осталась 0 команда