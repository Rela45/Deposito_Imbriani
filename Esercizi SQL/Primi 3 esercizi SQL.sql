/*esercizio 1*/

SELECT DISTINCT Region FROM world.country
WHERE Continent = 'Europe';

/*esercizio 2*/

SELECT Name, Population FROM city
WHERE CountryCode = 'USA'
ORDER BY Population > 1000000;

SELECT * FROM city;

/*esercizio 3*/
SELECT * FROM Country;


SELECT 
    Continent,
    COUNT(Name) AS Numero_Paesi,
    SUM(Population) AS Popolazione_Totale
FROM 
    Country
GROUP BY 
    Continent
ORDER BY Popolazione_Totale DESC;
