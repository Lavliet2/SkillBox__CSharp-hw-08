## 8.6 Практическая работа - Коллекции
### Цель практической работы
Работа с различными типами коллекций. 
Практические навыки сериализации и десериализации объектов. 
 
### Что входит в задание
#### Задание 1. Работа с листом.
#### Задание 2. Телефонная книга.
#### Задание 3. Проверка повторов.
#### Задание 4. Записная книжка.
 
### Задание 1. Работа с листом
#### Что нужно сделать
Создайте лист целых чисел. 
Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
Выведите коллекцию чисел на экран. 
Удалите из листа числа, которые больше 25, но меньше 50. 
Снова выведите числа на экран. 
Рекомендация
Сделайте отдельные методы для заполнения, удаления и вывода на экран.

### Что оценивается
В программе используется три отдельных метода. 
В качестве хранилища данных используется List.


### Задание 2. Телефонная книга
#### Что нужно сделать
Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, а значением — ФИО владельца. Таким образом, у одного владельца может быть несколько номеров телефонов. Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
Далее программа предлагает найти владельца по введенному номеру телефона. Пользователь вводит номер телефона и ему выдаётся ФИО владельца. Если владельца по такому номеру телефона не зарегистрировано, программа выводит на экран соответствующее сообщение.
#### Совет
Для того, чтобы находить значение в Dictionary, нужно использовать TryGetValue.

### Что оценивается
Программа разделена на логические методы.
Для хранения элементов записной книжки используется Dictionary.

### Задание 3. Проверка повторов
#### Что нужно сделать
Пользователь вводит число. Число сохраняется в HashSet коллекцию. Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение, что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, что число успешно сохранено. 

### Советы и рекомендации
Для добавление числа в HashSet используйте метод Add. 

Стоит ли пользоваться поиском в Сети во время обучения?    

Однозначно стоит. Одна и та же информация, представленная в разных источниках, усваивается намного лучше, чем если бы вы пользовались только материалами курса. В будущем, когда вы станете самостоятельным разработчиком, поиск в интернете будет занимать большую часть вашей работы. Поэтому важно учиться этому уже сейчас. Обратите внимание на статью Google-oriented programming.

### Что оценивается
В программе в качестве коллекции используется HashSet.

### Задание 4. Записная книжка
#### Что нужно сделать
Программа спрашивает у пользователя данные о контакте:

ФИО
Улица
Номер дома
Номер квартиры
Мобильный телефон
Домашний телефон
С помощью XElement создайте xml файл, в котором есть введенная информация. XML файл должен содержать следующую структуру:

<Person name=”ФИО человека” >
    <Address>
        <Street>Название улицы</Street>
        <HouseNumber>Номер дома</HouseNumber>
        <FlatNumber>Номер квартиры</FlatNumber>
    </Address>
    <Phones>
        <MobilePhone>89999999999999</MobilePhone>
        <FlatPhone>123-45-67<FlatPhone>
    </Phones>
</Person>
### Советы и рекомендации
Заполняйте XElement в ходе заполнения данных. Изучите возможности XElement в документации Microsoft.

### Что оценивается
Программа создаёт Xml файл, содержащий все данные о контакте.

