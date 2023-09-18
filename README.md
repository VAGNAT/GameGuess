# GameGuess SOLID
## Проект создан для демонстрации SOLID принципов
### Принцип единственной ответственности (Single Responsibility Principle, SRP):
* Класс GuessNumber имеет одну ответственность - управление игрой "Угадай число".
* Классы SecretNumber, ConsoleOutput, ConsoleOutputGame, GuessNumberLimitedAttempts также следуют этому принципу, каждый выполняя свою специфическую задачу.
## Принцип открытости/закрытости (Open/Closed Principle, OCP):
* Используются абстракции и интерфейсы (IOutput, IOutputGameMessage, ISecret, IGame), которые могут быть реализованы разными классами без изменения исходного кода этих интерфейсов.
## Принцип подстановки Лисков (Liskov Substitution Principle, LSP):
* Классы GuessNumber и GuessNumberLimitedAttempts являются подклассами класса Game и соблюдают этот принцип, поскольку они могут быть использованы вместо объектов типа Game, не нарушая работоспособность программы.
## Принцип разделения интерфейса (Interface Segregation Principle, ISP):
* Интерфейсы (IOutput, IOutputGameMessage, ISecret, IGame) довольно маленькие и имеют отдельные методы, что способствует их независимости и уменьшает нагрузку на классы, реализующие эти интерфейсы.
## Принцип инверсии зависимостей (Dependency Inversion Principle, DIP):
* Классы Game, GuessNumber, и GuessNumberLimitedAttempts принимают абстракции в виде интерфейсов в конструкторе (IOutputGameMessage, ISecret), а не конкретные реализации. Это позволяет легко заменять конкретные реализации, не меняя клиентский код.
## Принципы SOLID являются важным аспектом хорошего проектирования.
