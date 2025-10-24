CREATE TABLE Libri(
id INT PRIMARY KEY,
titolo VARCHAR(100),
autore VARCHAR(100),
genere VARCHAR(50),
prezzo DECIMAL(5,2),
anno_pubblicazione INT);


/* per vedere un attimo la tabella*/
SELECT * FROM Libri;

/*1 */
INSERT INTO Libri(id, titolo, autore, genere,prezzo, anno_pubblicazione) 
values(0, "Il silenzio dei numeri", "Giulia Rossi", "Thriller", 14.90, 2015),
(1, "Stella di Carta", "Marco Bianchi", "Fantasy", 22.50, 2012),
(103, 'Cuore di pietra','Anna Verdi','Romanzo', 15.00, 2008), 
(104, 'Algoritmi del destino',  'Luca Neri', 'Fantasy', 19.99, 2021),
(105, "Mare d'inverno",'Sara Conti','Narrativa', 16.75, 2010),
(106, 'La via del codice','Paolo De Luca','Saggistica',24.40, 2018);

/*2 */
SELECT genere, COUNT(titolo) AS Numero_libri, AVG(prezzo) AS Prezzo_medio 
FROM Libri
GROUP BY genere
ORDER BY genere ASC;

/*3 */

SELECT *
FROM   libri
WHERE  anno_pubblicazione > 2010
ORDER  BY anno_pubblicazione DESC,
prezzo ASC;
