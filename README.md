**Описание решения задачи**

1. Создаем метод нахождения количества элементов массива, удовлетворяющее запросу (в данном случае длина элемента меньше, либо равна 3 символам). Для этого:
- задаем счетчик элементов (с ноля)
- сравниваем длину каждого элемента с запросом (в данном случае не более 3 символов)
- считаем количество элементов, удовлетворяющим запросу

2. Создаем метод получения нового массива из элементов старого массива,  удовлетворяющих запросу (в данном случае длина элемента меньше, либо равна 3 символам). Для этого:
- создаем массив из элементов, количество которых будем задавать методом описанным в п. 1
- заполняем новый массив элементами старого массива, удовлетворяющими запросу (в данном случае длина элемента меньше, либо равна 3 символам)

3. Пишем саму программу:
- вводим стартовый массив
- создаем новый массив, используя описанные выше методы
- выводим результат
