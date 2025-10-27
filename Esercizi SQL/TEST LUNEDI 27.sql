CREATE DATABASE test_libreria_vendite;


CREATE TABLE `libri` (
  id int NOT NULL,
  titolo varchar(100),
  autore varchar(100),
  genere varchar(50),
  prezzo decimal(5,2),
  anno_pubblicazione int,
  PRIMARY KEY (`id`)
) ;

CREATE TABLE Vendite(
	id INT NOT NULL, 
    id_libro INT, 
    data_vendita DATE,
    quantita INT,
    negozio VARCHAR(100)
);



INSERT INTO `libri` (id, titolo, autore, genere, prezzo, anno_pubblicazione) VALUES
(1, 'Il Nome della Rosa', 'Umberto Eco', 'Storico', 12.50, 1980),
(2, '1984', 'George Orwell', 'Distopico', 9.99, 1949),
(3, 'Il Signore degli Anelli', 'J.R.R. Tolkien', 'Fantasy', 15.00, 1954),
(4, 'Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 'Fantasy', 10.50, 1997),
(5, 'Il Piccolo Principe', 'Antoine de Saint-Exupéry', 'Fiaba', 7.50, 1943),
(6, 'La Divina Commedia', 'Dante Alighieri', 'Classico', 14.00, 1320),
(7, 'Il Gattopardo', 'Giuseppe Tomasi di Lampedusa', 'Storico', 13.00, 1958),
(8, 'Orgoglio e Pregiudizio', 'Jane Austen', 'Romantico', 9.00, 1813),
(9, 'Il Grande Gatsby', 'F. Scott Fitzgerald', 'Classico', 11.00, 1925),
(10, 'Moby Dick', 'Herman Melville', 'Avventura', 12.00, 1851),
(11, 'Cime Tempestose', 'Emily Brontë', 'Romantico', 10.00, 1847),
(12, 'Il Codice Da Vinci', 'Dan Brown', 'Thriller', 12.50, 2003),
(13, 'Angeli e Demoni', 'Dan Brown', 'Thriller', 11.50, 2000),
(14, 'Inferno', 'Dan Brown', 'Thriller', 13.00, 2013),
(15, 'La Solitudine dei Numeri Primi', 'Paolo Giordano', 'Contemporaneo', 12.00, 2008),
(16, 'La Casa degli Spiriti', 'Isabel Allende', 'Contemporaneo', 14.50, 1982),
(17, "Cent'anni di Solitudine", 'Gabriel Garcia Marquez', 'Magico', 15.00, 1967),
(18, 'Lo Hobbit', 'J.R.R. Tolkien', 'Fantasy', 10.00, 1937),
(19, 'Dracula', 'Bram Stoker', 'Horror', 9.50, 1897),
(20, 'Frankenstein', 'Mary Shelley', 'Horror', 8.50, 1818),
(21, 'Il Cacciatore di Aquiloni', 'Khaled Hosseini', 'Contemporaneo', 11.50, 2003),
(22, 'Shining', 'Stephen King', 'Horror', 12.00, 1977),
(23, 'It', 'Stephen King', 'Horror', 14.00, 1986),
(24, 'Misery', 'Stephen King', 'Thriller', 11.00, 1987),
(25, 'Fahrenheit 451', 'Ray Bradbury', 'Distopico', 10.50, 1953),
(26, 'La Metamorfosi', 'Franz Kafka', 'Classico', 9.50, 1915),
(27, 'Se questo è un uomo', 'Primo Levi', 'Storico', 13.00, 1947),
(28, 'Norwegian Wood', 'Haruki Murakami', 'Romantico', 12.50, 1987),
(29, 'Kafka sulla spiaggia', 'Haruki Murakami', 'Contemporaneo', 14.00, 2002),
(30, 'Il Gabbiano Jonathan Livingston', 'Richard Bach', 'Fiaba', 8.50, 1970);



INSERT INTO Vendite (id, id_libro, data_vendita, quantita, negozio) VALUES
(1, 1, '2025-01-05', 3, 'Libreria Centrale'),
(2, 2, '2025-01-07', 2, 'Libreria Moderna'),
(3, 3, '2025-01-10', 1, 'Libreria Centrale'),
(4, 4, '2025-01-11', 4, 'Libreria Universitaria'),
(5, 5, '2025-01-12', 5, 'Libreria Moderna'),
(6, 6, '2025-01-13', 2, 'Libreria Centrale'),
(7, 7, '2025-01-15', 1, 'Libreria Universitaria'),
(8, 8, '2025-01-16', 3, 'Libreria Moderna'),
(9, 9, '2025-01-17', 2, 'Libreria Centrale'),
(10, 10, '2025-01-18', 1, 'Libreria Universitaria'),
(11, 11, '2025-01-19', 2, 'Libreria Centrale'),
(12, 12, '2025-01-20', 3, 'Libreria Moderna'),
(13, 13, '2025-01-21', 1, 'Libreria Universitaria'),
(14, 14, '2025-01-22', 2, 'Libreria Centrale'),
(15, 15, '2025-01-23', 4, 'Libreria Moderna'),
(16, 16, '2025-01-24', 1, 'Libreria Universitaria'),
(17, 17, '2025-01-25', 2, 'Libreria Centrale'),
(18, 18, '2025-01-26', 3, 'Libreria Moderna'),
(19, 19, '2025-01-27', 1, 'Libreria Universitaria'),
(20, 20, '2025-01-28', 2, 'Libreria Centrale'),
(21, 21, '2025-01-29', 3, 'Libreria Moderna'),
(22, 22, '2025-01-30', 2, 'Libreria Universitaria'),
(23, 23, '2025-02-01', 1, 'Libreria Centrale'),
(24, 24, '2025-02-02', 2, 'Libreria Moderna'),
(25, 25, '2025-02-03', 3, 'Libreria Universitaria'),
(26, 26, '2025-02-04', 1, 'Libreria Centrale'),
(27, 27, '2025-02-05', 2, 'Libreria Moderna'),
(28, 28, '2025-02-06', 3, 'Libreria Universitaria'),
(29, 29, '2025-02-07', 2, 'Libreria Centrale'),
(30, 30, '2025-02-08', 1, 'Libreria Moderna');


/* visualizzo le tabelle*/
SELECT * FROM libri;
SELECT * FROM vendite;

/*esercizio 1*/ 

SELECT l.titolo, l.autore, v.data_vendita, v.negozio
FROM libri l
INNER JOIN Vendite v
ON l.id = v.id_libro
WHERE LOWER(l.autore) LIKE '%king%';

/*esercizio 2*/

SELECT l.titolo, l.anno_pubblicazione, l.prezzo, v.data_vendita
FROM libri l LEFT JOIN vendite v 
ON l.id = v.id_libro
WHERE l.anno_pubblicazione BETWEEN 2000 AND 2010;

/*esercizio 3*/
INSERT INTO Vendite (id, id_libro, data_vendita, quantita, negozio) VALUES
(31, 1, '2025-03-01', 2, 'BookCity Milano'),
(32, 2, '2025-03-02', 1, 'Cartoleria Roma'),
(33, 3, '2025-03-03', 4, 'BookCity Milano'),
(34, 4, '2025-03-04', 2, 'Cartoleria Roma'),
(35, 5, '2025-03-05', 3, 'BookCity Milano'),
(36, 6, '2025-03-06', 1, 'Cartoleria Roma');


SELECT l.titolo, v.negozio, v.quantita, (v.quantita * l.prezzo) AS prezzo_totale
FROM libri l INNER JOIN Vendite v ON l.id = v.id_libro
WHERE v.negozio IN ('Libreria Centrale', 'BookCity Milano', 'Cartoleria Roma');

/*esercizio 4*/

SELECT l.titolo, v.data_vendita, l.prezzo, v.quantita
FROM vendite v RIGHT JOIN libri l
ON v.id_libro = l.id
WHERE v.data_vendita BETWEEN '2020-01-01' AND '2022-12-31' AND LOWER(v.negozio) LIKE '%book%';


/*esercizio 5*/


SELECT l.titolo, l.autore, v.data_vendita, l.prezzo, v.quantita FROM libri l INNER JOIN Vendite v 
ON l.id = v.id_libro
WHERE l.genere IN ('Fantasy', 'Horror', 'Giallo') AND l.anno_pubblicazione > 2015 AND v.negozio IN ('Store')
ORDER BY l.anno_pubblicazione DESC;

