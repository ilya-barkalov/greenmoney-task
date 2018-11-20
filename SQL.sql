/* 
	Необходимо из таблицы А найти последние значения Id, Status по UserId = 85. 
	Написать все возможные варианты запроса.
*/
SELECT TOP 1 U.ID, U.Status, U.UserID
FROM Users AS U
WHERE U.UserID = 85
ORDER BY U.ID DESC

SELECT U.ID, U.Status, U.UserID
FROM Users AS U
WHERE U.UserID = 85 AND U.ID = (SELECT MAX(U.ID)
																FROM Users AS U
																WHERE U.UserID = 85)

SELECT U.ID, U.Status, U.UserID
FROM Users AS U
WHERE U.UserID = 85 AND U.ID IN (SELECT MAX(U.ID)
																FROM Users AS U
																GROUP BY U.Status)

/* 
	Посчитать сумму поля Id с накопительным итогом для UserId = 86.
*/
SELECT SUM(U.ID) as "Сумма с накоплением" 
FROM Users AS U, Users AS UU
WHERE U.ID <= UU.ID AND U.UserID = 86
GROUP BY UU.ID 

/* 
	Вывести только четные записи по каждому UserId.
*/
SELECT U.ID, U.UserID
FROM Users AS U
WHERE U.ID % 2 = 0