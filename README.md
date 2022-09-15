Итоговая проверочная работа

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


# Алгоритм выполнения задания:

Создаем массив, находим длину нового массива, заполняем новый массив согласно условия задания, выводим на экран оба массива.

***SizeNewArray*** - Метод вычисления количества элементов, которые равны или меньше 3.
Подсчёт осуществляется перебором элементов массива array и сравнением количества их элементов с 3.
Результат выводится в переменную **sizearray**.
Инициализируется новый массив строк **newarray**, размером, равным переменной **sizearray**.

***SourceArray*** - Метод заполнения нового массива строк
Формирование осуществляется перебором элементов массива **array**, сравнением количества их элементов с 3
и добавлением в массив newarray элемента.
Получается заполненный массив  newarray, что и является решением задачи.
Вывод на экран методов **array** и **newarray** осуществляется с помощью метода **PrintArray**.

Блок-схем  основного алгоритма, в отдельном методе ***SourceArray*** . Файл ***block.drawio***