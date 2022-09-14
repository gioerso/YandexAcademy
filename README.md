### P.S Меня не хватило на компилятор Яндекс.Контеста, после 6 попыток залива на 3-х ЯП у меня окончательно бомбануло. Код на C# (MS.NET 6.0 + ASP),
### Решение почти всех этих задач на Java 8 есть у коллеги тут: https://github.com/cat0cat/Yandex_algorithm#readme

# A. Совпадение? Не думаю

|                     |            Все языки            | GNU C++20 10.2 |
|---------------------|:-------------------------------:|:--------------:|
| Ограничение времени |            5 секунд             |   1 секунда    |
| Ограничение памяти  |              512Mb              |     512Mb      |
| Ввод                | стандартный ввод или input.txt  |
| Вывод               | стандартный ввод или output.txt |  

Алиса Селезнева была невероятно счастлива: она наконец запустила свой новый стартап по распознаванию увиденных облаков, который назвала строкой A длины N. Но вдруг она узнала, что Зелибоба также запустил свой стартап по распознаванию облаков и назвал его строкой B длины N.
Алиса уверена, что Зелибоба сплагиатил её идею! Для начала она хочет вычислить метрику похожести названий их стартапов — если название будет похоже, то ей будет сильно проще в дальнейших доказательствах и разбирательствах.
Более формально, пусть есть строки A — название стартапа Алисы и строка B — название стартапа Зелибобы. Обе строки имеют одинаковую длину N. Для каждой позиции 1≤i≤N строки B, нужно вычислить тип совпадения в этой позиции со строкой A.
Если Bi=Ai, то в позиции i тип совпадения должен быть равен P (от слова plagiarism).
Если Bi≠Ai, но существует другая позиция 1≤j≤N, такая что Bi=Aj, то в позиции i тип совпадения должен быть равен S (от слова suspicious).

Обратите внимание:
- Буквы в рамках одной строки могут повторяться.
- Каждую букву строки A можно использовать не более чем в одном совпадении типа plagiarism или suspicious.
- Предпочтение всегда отдается типу plagiarism.
- В случае совпадения типа suspicious, предпочтение всегда отдается самой левой позиции в строке A.

В остальных позициях тип совпадения должен быть равен I (от слова innocent).

### Формат ввода
В первой строке задана строка
A(1 ≤ ∣A∣ ≤ 10^6) — название стартапа, выбранное Алисой.
Во второй строке задана строка B(|B|=|A|) — название стартапа Зелибобы.
Гарантируется, что строки A и B содержат только заглавные латинские буквы.

### Формат вывода
Выведите единственную строку C(|C|=|B|), где Ci— тип совпадения символа
Bi(1≤i≤|B|): 
- для типа plagiarism Ci=P.
- для типа suspicious Ci=S.
- для типа innocent Ci=I.

#### Пример 1
| Ввод  | Вывод |
|-------|:-----:|
| CLOUD | PSIIP |
| CUPID |       |


#### Пример 2
| Ввод  | Вывод |
|-------|:-----:|
| ALICE | SPPII |
| ELIBO |       |

#### Пример 3
| Ввод    |  Вывод  |
|---------|:-------:|
| ABCBCYA | IPSSPIP |
| ZBBACAA |         |

#### Примечания
##### Пояснение к первому тесту
- B1=A1 и B5=A5, поэтому для позиций 1 и 5 ответ P.
- B2≠A2, но B2=A4, поэтому для позиции 2 ответ S.
- Буквы P и I не встречаются в строке A, поэтому для позиций 3 и 4 ответ I.

##### Пояснение ко второму тесту
- B2=A2 и B3=A3, поэтому для позиций 2 и 3 ответ P.
- B1≠A1, но B1=A5, поэтому для позиции 1 ответ S.
- Буквы B и O не встречаются в строке A, поэтому для позиций 4 и 5 ответ I.

##### Пояснение к третьему тесту
- B2=A2, B5=A5 и B7=A7, поэтому для позиций 2, 5 и 7 ответ P.
- B3≠A3, но B3=A2=A4. A2 уже задействовано в соответствии B2=A2, 
поэтому выбирается соответствие B3=A4— для позиции 3 ответ S.
- B4≠A4 и B6≠A6, но B4=B6=A1=A7. 
  - A7 уже задействовано в соответствии B7=A7; 
  - 4 < 6, поэтому для позиции 4 выбирается соответствие B4=A1 (ответ S);
  - для позиции 6 соответствий не осталось (ответ I).
- Буква Z не встречается в строке A, поэтому для позиции 1 ответ I.

# B. Фигуры высшего пилотажа

|                     |            Все языки            | GNU C++20 10.2 |
|---------------------|:-------------------------------:|:--------------:|
| Ограничение времени |            5 секунд             |   1 секунда    |
| Ограничение памяти  |              512Mb              |     512Mb      |
| Ввод                | стандартный ввод или input.txt  |
| Вывод               | стандартный ввод или output.txt |

Алиса Селезнева и Зелибоба помирились и создали объединенный стартап по распознаванию увиденных облаков. В качестве рекламы они решили провести соревнование по витанию в облаках.
Соревнование проходит в два этапа:
- в отборочном этапе все участники показывают владение заданными приёмами облачной акробатики.
- в финальном этапе прошедшие участники выступают в выбранной ими специальной дисциплине.

В первом этапе участникам было предложено **_12_** различных приёмов для показа. В первую очередь приоритет отдавался участникам, исполнившим большее число приёмов.
При равенстве количества выполненных приёмов участники сравниваются по штрафу — чем он ниже, тем выше приоритет у кандидата. Штраф определяется командой судей по особой формуле, что гарантирует отсутствие двух кандидатов с одинаковой парой количества исполненных приёмов и штрафа.
Для каждой специальной дисциплины финального этапа определено максимальное количество участников — больше звать нельзя, иначе зрителям станет скучно смотреть.
На вас возложена очень важная задача — по информации о результатах отборочного этапа и специальных дисциплинах финального этапа вывести всех участников, прошедших в финальный этап.

### Формат ввода
В первой строке содержится целое число n(1≤n≤10^4) — число специальных дисциплин финального этапа.
Следующие n строк имеют вид si, mi(1≤|si|≤30, 1≤mi≤10^4) — название и максимальное число участников на
i-ю дисциплину. Название дисциплины содержит только строчные латинские буквы и знак подчеркивания ‘_’. 
Далее следует строка, содержащая целое число k(1≤k≤10^5) — число участников отборочного этапа соревнования.
Последующие k строк имеют вид cj, qj, rj, pj(1≤∣cj∣≤30, 0≤rj≤12, 0≤pj≤10^9) — строковый идентификатор
j-го участника, название интересующей его специальной дисциплины, количество исполненных участником приёмов и начисленный ему штраф соответственно. Идентификатор участника содержит только строчные латинские буквы и знак подчеркивания ‘_’.

Гарантируется, что:
- Интересующие участников специальные дисциплины qj обязательно представлены во входных данных;
- Названия всех специальных дисциплин si попарно различны между собой;
- Идентификаторы участников cj попарно различны между собой;
- Не существует двух участников a и b таких, что ra=rb и pa=pb
(или различаются количества исполненных приёмов, или различается начисленный участникам штраф).

Все строки используют разделитель ‘,’ (запятая).

### Формат вывода
Выведите список идентификаторов всех участников, прошедших в финальный этап соревнования на интересующие их специальные дисциплины в лексикографическом (алфавитном) порядке идентификаторов.
Участник считается прошедшим по дисциплине i, если существует строго менее
mi участников, подавших заявки на i-ю дисциплину с большим, чем у данного участника, приоритетом (см. условие про сравнение приоритета участников).

#### Пример 1
| Ввод                             | Вывод          |
|----------------------------------|:---------------|
| 2                                | cheburashka    |
| ear_flying,1                     | crocodile_gena |
| sun_bathing,1                    |                |
| 3                                |                |
| cheburashka,ear_flying,11,100    |                |
| dambo,ear_flying,10,0            |                |
| crocodile_gena,sun_bathing,11,10 |                |

#### Пример 2                                             
| Ввод                         | Вывод       |
|------------------------------|:------------|
| 1                            | cheburashka |
| ear_flying,1                 |             |
| 2                            |             |
| dambo,ear_flying,7,234       |             |
| cheburashka,ear_flying,7,123 |             |

#### Пример 3
| Ввод                                  | Вывод             |
|---------------------------------------|:------------------|
| 2                                     | anonymous         |
| cloud_developer,2                     | bill_gates        |
| cloud_hacker,3                        | bjarne_stroustrup |   
| 5                                     | guccifer          |    
| anonymous,cloud_hacker,6,0            | julian_assange    |    
| bjarne_stroustrup,cloud_developer,6,1 |                   |    
| julian_assange,cloud_hacker,5,100500  |                   |   
| bill_gates,cloud_developer,3,1        |                   |
| guccifer,cloud_hacker,2,0             |                   |
                                               
#### Пример 4                                                      
| Ввод                               | Вывод  |
|------------------------------------|:-------|
| 2                                  | cactus |
| sun_charging,2                     | helios |
| racing,1                           | palm   |
| 5                                  |        |
| helios,racing,12,135               |        |
| acacia,sun_charging,0,5veloper,6,1 |        |
| cactus,sun_charging,0,1r,5,100500  |        |
| ficus,sun_charging,0,4,3,1         |        |
| palm,sun_charging,0,3              |        |
                                                             
#### Примечания
В первом тестовом примере на дисциплину «ear_ﬂying» претендуют два кандидата — ‘cheburashka’ показал
11 приёмов со 100 единицами штрафа, а ‘dambo’ — 10 приёмов с 0
штрафа. В первую очередь сравнение идет по приёмам: 11>10, поэтому в следующий этап проходит именно ‘cheburashka’.

Во втором тестовом примере у обоих претендентов одинаковое количество показанных приёмов, но у ‘cheburashka’ штраф
123, что меньше штрафа 234 у ‘dambo’. Поэтому в следующий этап проходит ‘cheburashka’.

В третьем тестовом примере важно отметить, что в ответе прошедшие участники идут в объединенном списке отсортированные в лексикографическом порядке независимо от своего приоритета при отборе и выбранной ими специальной дисциплине.

В четвертом тестовом примере развернулась борьба за дисциплину «зарядка на солнце». Хотя все участники не смогли показать владение ни одним из приёмов, ‘cactus’ и ‘palm’ набрали меньше всего штрафа, поэтому именно их приглашают в финальный этап соревнования.

# C. Корпоративные закупки

|                     |            Все языки            | GNU C++20 10.2 |
|---------------------|:-------------------------------:|:--------------:|
| Ограничение времени |            2 секунд             |   1 секунда    |
| Ограничение памяти  |              512Mb              |     512Mb      |
| Ввод                | стандартный ввод или input.txt  |
| Вывод               | стандартный ввод или output.txt |

Стартап Алисы Селезневой и Зелибобы привлек к себе внимание крупных инвесторов. Часть полученных от инвесторов денег было решено потратить на обновление офиса — новая мебель, оргтехника и другие прикольные штуки.
Алиса и Зелибоба выдвинули 5 критериев — товар должен удовлетворять всем данным критериям, чтобы его закупили в обновленный офис.
- «Наименование товара содержит подстроку в любом регистре» (критерий ‘NAME_CONTAINS’);
- «Цена больше либо равна чем» (критерий ‘PRICE_GREATER_THAN’);
- «Цена меньше либо равна чем» (критерий ‘PRICE_LESS_THAN’);
- «Товар поступил в продажу не позднее чем» (критерий ‘DATE_BEFORE’);
- «Товар поступил в продажу не ранее чем» (критерий ‘DATE_AFTER’);

Закупаться было решено в Выньдекс.Рынке. Для такого крупного клиента Выньдекс.Рынок предоставил стартапу персонального менеджера — да-да, именно вас.

Первым делом вам необходимо из имеющегося списка товаров на складе выбрать все товары, удовлетворяющие выданным Алисой и Зелибобой критериям.

### Формат ввода
Общее описание формата входных данных:

Первая строка входных данных содержит список всех имеющихся на складе Выньдекс.Рынка товаров в формате JSON.

Следующие 5 строк имеют вид qivi — фильтр и соответствующее ему актуальное значение.

Подробное описание формата списка товаров
Гарантии по формату JSON:
- нет запятых после последнего элемента массива;
- все имена полей и строки обернуты в двойные кавычки.

Обозначим количество товаров в списке через N. Гарантируется, что 0≤N≤1000.

Каждый товар в списке содержит следующую информацию (порядок полей не является фиксированным):
- целое число id(0≤id≤2^31−1) — уникальный идентификатор. Гарантируется, что идентификаторы всех товаров попарно различны;
- строка name(1≤|name|≤100) — наименование. Гарантируется, что наименование содержит только строчные и заглавные латинские буквы, а так же пробел;
- целое число price(0≤price≤2^31−1) — цена;
- строка date в формате «dd.MM.yyyy» (01.01.1970≤date≤31.12.2070) — дата поступления в продажу.

Подробное описание формата фильтров

Гарантируется, что:
- все qi различны между собой;
- qi является строкой из множества (NAME_CONTAINS, PRICE_GREATER_THAN, PRICE_LESS_THAN, DATE_BEFORE, DATE_AFTER);
- в фильтре ‘NAME_CONTAINS’ vi представляет из себя строку (1≤|vi|≤100), содержащую только строчные и заглавные латинские буквы;
- в фильтрах ‘PRICE_GREATER_THAN’ и ‘PRICE_LESS_THAN’ vi представляет из себя целое число (
0≤vi≤2^31−1);
- в фильтрах ‘DATE_BEFORE’ и ‘DATE_AFTER’ vi представляет из себя строку в формате «dd.MM.yyyy» (
01.01.1970≤vi≤31.12.2070).

### Формат вывода
Выведите в формате JSON список товаров, удовлетворяющих всем указанным во входных данных критериям. Каждый товар должен быть выведен ровно один раз в отсортированном по возрастанию
id порядке.

Выводить JSON допустимо как c дополнительными отступами и переводами строк, так и в одну строку.

Имена полей необходимо выводить в двойных кавычках.

Допустимо выводить запятую после последнего поля объекта или последнего элемента массива.

Каждый товар должен содержать информацию, аналогичную информации из входных данных:
- целое число id — уникальный идентификатор;
- строка name — наименование;
- целое число price — цена;
- строка date в формате «dd.MM.yyyy» — дата поступления в продажу.

#### Пример
| Ввод                                                                                                                                                                                                                                                                                                                                                            | Вывод                                                                                                                                  |
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------|
| [{"id": 1, "name": "Asus notebook","price": 1564,"date": "23.09.2021"},{"price": 2500, "id": 3, "date": "05.06.2020", "name": "Keyboardpods" }, {"date": "23.09.2021", "name": "Airpods","id": 5, "price": 2300}, {"name": "EaRPoDs", "id": 2, "date": "01.01.2022", "price": 2200}, { "id": 4, "date": "23.09.2021", "name": "Dell notebook",  "price": 2300}] | [{"name": "EaRPoDs", "id": 2, "date": "01.01.2022", "price": 2200}, {"date": "23.09.2021", "name": "Airpods", "id": 5, "price": 2300}] |
| PRICE_LESS_THAN 2400                                                                                                                                                                                                                                                                                                                                            ||
| DATE_AFTER 23.09.2021                                                                                                                                                                                                                                                                                                                                           ||
| NAME_CONTAINS pods                                                                                                                                                                                                                                                                                                                                              |                                                                                                                                        |
| PRICE_GREATER_THAN 2200                                                                                                                                                                                                                                                                                                                                         |                                                                                                                                        |
| DATE_BEFORE 02.01.2022                                                                                                                                                                                                                                                                                                                                          |                                                                                                                                        |

#### Примечания
При написании решения на Java можно выбрать комплятор «Java 8 + json-simple». В этом случае вы сможете воспользоваться библиотекой json-simple для парсинга и сериализации JSON.

При написании решения на C++ можно подключить #include "json.hpp" для использования библиотеки json для парсинга и сериализации JSON.

**Рассмотрим тестовый пример.**

В нем представлено 5 товаров:

- "id": 1, "name": "Asus notebook"price": 1564, "date": "23.09.2021"
- "id": 2, "name": "EaRPoDs"price": 2200, "date": "01.01.2022"
- "id": 3, "name": "Keyboardpods"price": 2500, "date": "05.06.2020"
- "id": 4, "name": "Dell notebook"price": 2300, "date": "23.09.2021"
- "id": 5, "name": "Airpods"price": 2300, "date": "23.09.2021"

и следующие критерии:
- название включает подстроку pods в любом регистре;
- цена находится в промежутке 2200≤price≤2400;
- дата поступления в продажу находится в промежутке 23.09.2021≤date≤02.01.2022.

Только товары с идентификаторами 2 и 5 удовлетворяют всем критериям:
- Товар с идентификатором 1 не удовлетворяет критериям имени (нет заданной подстроки) и цены (слишком низкая);
- Товар с идентификатором 3 не удовлетворяет критериям цены (слишком высокая) и даты (слишком ранняя);
- Товар с идентификатором 4 не удовлетворяет только критериям имени (нет заданной подстроки).

Обратите внимание, что выводить необходимо товары в порядке возрастания идентификаторов (заметьте, что во входных данных товар с идентификатором
5 стоит раньше товара с идентификатором 2).

# E. Облачные вычисления

| Язык                    | Ограничение времени | Ограничение памяти |   Ввод    |   Вывод    |
|-------------------------|:-------------------:|:------------------:|:---------:|:----------:|
| Все языки               |      6 секунд       |        42Mb        | input.txt | output.txt |
| GNU C++20 10.2          |      4 секунды      |        16Mb        |           |            |
| C# (MS .Net 6.0)+ASP    |      4 секунды      |        16Mb        |           |            |
| Python 3.7 (PyPy 7.3.3) |      10 секунд      |        42Mb        |           |            |

Для распознавания облаков Зелибоба и Алиса Селезнева пишут программы на специальном языке Cloud++. Его синтаксис содержит лишь следующие элементы:
- строчные английские буквы a-z;
- знаки математических операций: +, −, ∗, ∕, =;
- скобки { и };
- пробел.

По правилам языка Cloud++ фигурные скобки должны образовывать 
«правильную скобочную последовательность» — последовательность 
из «{» и «}» такая, что существует хотя бы одно разбиение всех 
скобок последовательности на пары «{» и «}», для которых верно:
- в любой паре порядковый номер «{» в последовательности меньше, 
чем у соответствующей ей «}».
- каждая скобка относится ровно к одной паре из разбиения.

Например, последовательность «{{}{}}{}» правильная, так как 
существует разбиение (1,6), (2,3), (4,5), (7,8) (скобки 
нумеруются с 1 слева направо).

Примеры неправильных скобочных последовательностей:
- «{{{}» неправильная, так как в единственно возможном 
разбиении (1,4), (2,4), (3,4) скобка 4 используется во всех трёх парах.
- «}{» неправильная, так как в единственно возможном разбиении
(2,1) позиция скобки «{» больше, чем позиция «}».
- «{{» неправильная, так как невозможно построить ни одной пары без скобок «}».

Алиса написала новую программу, но поймала ошибку компиляции. Компилятор утверждает, что последовательность скобок в программе отличается от правильной наличием ровно одной лишней скобки (правда не уточняет, какая это скобка и в какой она позиции).

Зелибоба не доверяет компиляторам (слишком они подозрительно себя ведут). Поэтому он просит вас, как главного специалиста по ремонту кофемашин, проверить правдивость слов компилятора.

Для заданного текста программы, написанной Алисой, выведите наименьшую позицию символа скобки (открывающей или закрывающей), удаление которой сделает последовательность скобок в программе правильной.

### Формат ввода
Обратите внимание, что в данной задаче разрешен только ввод из файла «input.txt».
В единственной строке файла содержится строка S(1≤∣S∣≤5⋅10^7) — программа на языке Cloud++. Строка гарантированно завершается символом перевода строки.

Гарантируется, что строка S содержит символы только из указанных ниже:
- строчные английские буквы a-z;
- знаки математических операций: +, −, ∗, ∕, =;
- скобки { и };
- пробел.

### Формат вывода
Если последовательность скобок в программе можно сделать правильной, удалив ровно одну скобку, то выведите наименьшую позицию такой скобки. В ином случае выведите число −1.
Позиции считаются, начиная от 1. Пробелы также считаются символами и учитываются при подсчёте позиции.

#### Пример 1
| Ввод          | Вывод |
|---------------|:-----:|
| a + b = b + a |  -1   |

#### Пример 2
| Ввод                                | Вывод |
|-------------------------------------|:-----:|
| d + {a + {b + c} = {a + b + } c + d |   5   |

#### Пример 3
| Ввод                | Вывод |
|---------------------|:-----:|
| a{{b + c} = ab + bc |  -1   |

#### Примечания
##### Первый тестовый пример
Последовательность скобок пустая, а значит она уже правильная, ничего удалять не нужно — поэтому ответом является −1.

##### Второй тестовый пример
Обратите внимание на нумерацию символов в начале строки:
1. d
2. пробел
3. _+_
4. пробел
5. {
6. a
7. пробел
8. _+_
9. пробел
10. {
11. a
12. т.д.

Последовательность скобок «{{}{}» отличается от правильной ровно 
одной лишней скобкой. Чтобы сделать её правильной, необходимо 
удалить одну из двух открывающих скобок в начале скобочной 
последовательности (позиции в строке 5 и 10). Так как требуется 
удалить скобку на наименьшей позиции, то ответом является 5.

Обратите внимание, что всё выражение даже после удаления не должно быть / стать корректным — необходимо лишь восстановить правильность скобочной последовательности.

##### Третий тестовый пример
Последовательность скобок «{{{}» невозможно сделать правильной 
удалением ровно одной скобки — поэтому ответ −1.
