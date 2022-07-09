## Labirary App
### Task 1 Create Book Class
> `Book` `class`ı yaradın. Bu `class`ın xüsusiyyətləri aşağıdakı kimi olmalıdır.
- `Name` ad fildi var. `Book`un adını saxlayır.
- `PageSize` kitabın səyfələrinin sayını tutur.
- `Price` kitabın qiymətini özündə saxlayır
- `AuthorName` kitabın müəlifinin adını göstərir.
- 2 tip `Constructor`u var. 
	1. Yaradılarkən daxilindəki bütün fildlərə uyğun olaraq dataları doldurulur.
	2. Yaradılarkən `Name`,`PageSize` və `Price` doldurulur.
 
### Task 2 Create Db
> `ArrayList` yaradılır və bu listə database kimi baxılır.

### Task 3 Main Task
>  App işə salınan anda `User`ə iki seçim verirlir `Shearch == > 1` və ya `Create ==> 2`. Userdən ikisindən birini seçməsini gözlənilir əks halda ekrana  `You select wrong` mesajı çıxarır. User seçimi 
- `1` olduqda `User`dən `Book`un `Name`i  yazılması tələb olunur.Axtarış yaradılmış databasedən(`ArrayList`dən) edilir və nəticə ekranda göstərilir.Ardınca `User`dən yenidən axtarış etmək istəyib istəmədiyi soruşulur. İstəyirsə axtarış davam edir.
- `2` olduqda `User`dən `Book` yardalıması üçün  dataları consoldan alib database-ə(`ArrayList`ə) əlavə edir..Ardınca `User`dən yenidən kitab əlavə etmək istəyib istəmədiyi soruşulur. İstəyirsə kitab əlavə etməyə davam edir.
>  işlər bitdikdən sonra `User`dən yenidən `Shearch == > 1` və ya `Create ==> 2` prosesi soruşulur.

### Exp

```md
  
	Shearch ==> 1
	Create  ==> 2
	-------------------------
	Select : 2
	=============== Create Book ==============
  Book Name : Robinzaon Kruzo
  Book PageSize : 455 
  Book Price : 15.5
  Book AuthorName : Daniel Defo
  -------------------------
  Continue Create Book ? Y/Any Key : N
  -------------------------
  Shearch ==> 1
	Create  ==> 2
	-------------------------
	Select : 1
	================ Search Book ==============
	Search Book Name :  robinzaon
	=============
	Book Name : Robinzaon Kruzo
  Book PageSize : 455 
  Book Price : 15.5
  Book AuthorName : Daniel Defo
  --------------------------
  Continue Search Book ? Y/Any Key : N
  -------------------------
  Shearch ==> 1
  Create  ==> 2
  -------------------------
  Select : |
```
