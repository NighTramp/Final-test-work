# Контрольная работа
Релиз v1.0.0.1: [Скачать](https://github.com/NighTramp/Final-test-work/releases/download/v1.0.0.1/Code.exe)<br>
Исходники: [Открыть](https://github.com/NighTramp/Final-test-work/releases/tag/v1.0.0.1)
## Задача:

    Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длинна которых меньше либо равна 3 символа. Первоначальный массив можно 
    ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Реализация:
Была разработана программа для поиска строк в массиве, длина которых меньше либо равна 3.<br>
### 1. Основная логика алгоритма
Описание алгоритма решения поставленной задачи описано в виде блок-схемы и представлено в файле: [block-diagram.drawio.png](https://github.com/NighTramp/Final-test-work/blob/main/block-diagram.drawio.png)
### 2. Пользовательский интерфейс
Для взаимодействия пользователя с консольным приложением был реализован визуальный интерфейс с использованием псевдографики.<br>
![Скриншот](https://raw.githubusercontent.com/NighTramp/Final-test-work/main/ui.jpg)<br>
### 3. Команды
Для управления были реализованы следующие команды:

* __start__ - команда запускает сценарий, при котором алгоритм для работы использует изначально заданные входные данные.
* __start random__ - команда сапускает сценарий, при котором алгоритм для работы использует случайным образом сгенерированные входные данные.
* __exit__ - команда завершает работу программы.
