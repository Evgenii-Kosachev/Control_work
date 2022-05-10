Данная программа из одного массива строк формирует другой массив строк заданной длины. И выводит второй в консоль.

Программе на старте задается заполненный массив `userData` типа `string`. Далее этот массив, а так же указание длины строки 
(тип `int`) отправляетяс в метод `SelectData`.

### **SelectData**
`SelectData` из одного массива строк формирует другой массив строк заданной длины. Принимает следующие аргументы: `userData`, `lengthElement`.

Задается счетчик `count` равный 0, который будет работать в два этапа: 

1. подсчет элементов нужной длины в массиве `userData`;  
Задается цикл `for`, который проходит по всему массиву `data`.   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Внутри цикла задается условие `if`: если элемент массива меньше либо равен указанной в `lengthElement` длине `count` прибавляет 1.   
После завершения работы цикла `for` создается массив result типа `string`, длина которого задается count. Массив `result` 
возвращает результат работы метода `SelectData`.

2. (обнуление) переход от одного индекса к другому в массиве `result` для его заполнения.  
Перед повторным использованием `count` обнуляется.   
Снова задается цикл `for`, который проходит по всему массиву `data`.   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Внутри цикла задается условие `if`: если элемент массива меньше либо равен указанной в `lengthElement` длине то он присваивается в `result`, а `count` прибавляет 1.

После завершения работы цикла `for` массив `result` возвращает результат работы метода `SelectData`. 

### **PrintArray**
`PrintArray` выводит массив строк в консоль. Принимает следующие аргументы: `result`.  
Задается цикл `for`, который проходит по всему массиву `data`.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Внутри цикла задаются условия `if`:
1. Если в массиве есть один элемент, то в консоль выводится квадратная открывающая скобка.
2. Если в массиве есть один элемент и более `&&` последний элемент массива не учитывается, то в консоль выводится
элемент массива обрамленный двойными кавычками, запятой и одним отступом.
3. Если элемент в массиве один или является последним, то в консоль выводится элемент массива обрамленный
двойными кавычками и закрывающей квадратной скобкой (без запятой).  

После завершения работы цикла `for` программа завершает свою работу.

**Обработка исключений:** если аргумент `result` на входе `PrintArray` имеет длину равную 0, то в консоль выводятся открывающая и 
закрывающая квадратные скобки и программа завершает свою работу. 
___