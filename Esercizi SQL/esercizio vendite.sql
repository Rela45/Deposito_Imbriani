CREATE DATABASE NEGOZIO;

CREATE TABLE Vendite( id INT, prodotto VARCHAR(100), categoria VARCHAR(50), quantita INT, prezzo_unitario DECIMAL(6,2), data_vendita DATE);

INSERT INTO Vendite (id, prodotto, categoria, quantita, prezzo_unitario, data_vendita) VALUES
(1, 'Laptop HP Pavilion 15', 'Informatica', 3, 799.99, '2025-01-12'),
(2, 'Mouse Logitech M185', 'Accessori PC', 10, 19.99, '2025-01-15'),
(3, 'iPhone 15 Pro', 'Telefonia', 2, 1299.00, '2025-02-03'),
(4, 'Custodia iPhone Silicone', 'Telefonia', 5, 29.99, '2025-02-04'),
(5, 'Monitor Samsung 27"', 'Informatica', 4, 219.90, '2025-02-20'),
(6, 'Tastiera Meccanica Corsair K70', 'Accessori PC', 2, 149.90, '2025-03-01'),
(7, 'Stampante Epson EcoTank L3250', 'Periferiche', 1, 229.00, '2025-03-10'),
(8, 'Cuffie Sony WH-1000XM5', 'Audio', 3, 349.99, '2025-03-22'),
(9, 'Smart TV LG 55"', 'Elettronica', 2, 699.00, '2025-04-05'),
(10, 'Hard Disk Esterno Seagate 2TB', 'Storage', 6, 89.90, '2025-04-12'),
(11, 'Scheda Grafica NVIDIA RTX 4070', 'Informatica', 1, 649.00, '2025-05-01'),
(12, 'Router TP-Link Archer AX50', 'Rete', 2, 129.99, '2025-05-09'),
(13, 'Smartwatch Samsung Galaxy Watch6', 'Wearable', 4, 299.90, '2025-05-18'),
(14, 'Tablet Apple iPad Air 11"', 'Tablet', 3, 749.00, '2025-06-07'),
(15, 'Chiavetta USB 128GB Sandisk', 'Storage', 15, 19.90, '2025-06-21'),
(16, 'Auricolari Bluetooth JBL Tune 230NC', 'Audio', 7, 79.90, '2025-07-02'),
(17, 'Console PlayStation 5', 'Gaming', 2, 549.99, '2025-07-14'),
(18, 'Videogioco FIFA 26', 'Gaming', 8, 69.99, '2025-09-01'),
(19, 'Drone DJI Mini 4 Pro', 'Droni', 1, 999.00, '2025-09-18'),
(20, 'Friggitrice ad Aria Philips XL', 'Elettrodomestici', 3, 189.90, '2025-10-10');


SELECT * FROM Vendite;
/*totale*/
SELECT categoria, SUM(quantita) AS max_vendite FROM Vendite
GROUP BY categoria;
/*media vendite*/
SELECT categoria, AVG(prezzo_unitario) AS media_prezzi FROM Vendite
GROUP BY categoria;

/*totale venduto per prodotto*/

SELECT prodotto, SUM(prezzo_unitario) AS totale_prezzo FROM Vendite
GROUP BY prodotto;

/*prezzo massimo e minimo sulla tabella*/

SELECT MAX(prezzo_unitario) AS Prezzo_massimo, MIN(prezzo_unitario) AS Prezzo_minimo FROM Vendite;

/*Conta righe*/

SELECT COUNT(id) AS Totale_vendite FROM Vendite;

/*5 prodotti piu costosi*/

SELECT prodotto, prezzo_unitario FROM Vendite
WHERE prezzo_unitario > 600
ORDER BY prezzo_unitario DESC LIMIT 5 ;

/*3 prodotti con la quantita totale piu bassa*/

SELECT prodotto, SUM(quantita) AS quantita_totale FROM Vendite
GROUP BY SUM(quantita)
ORDER BY SUM(quantita) LIMIT 3;

