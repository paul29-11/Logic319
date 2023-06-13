

-- Membuat Database
CREATE DATABASE DBPenerbit

-- Membuat Tabel Pengarang
CREATE TABLE tblPengarang(
id int primary key identity,
kd_Pengarang varchar(7) not null,
Nama varchar(30) not null,
Alamat varchar(80) not null,
Kota varchar(15) not null,
Kelamin varchar(1) not null
)

-- Membuat Tabel Gaji
CREATE TABLE tblGaji(
id int primary key identity,
kd_Pengarang varchar(7) not null,
Nama varchar(30) not null,
Gaji decimal(18,4) not null
)

-- Memasukan data ke tabel pengarang

INSERT INTO tblPengarang
(kd_Pengarang,Nama,Alamat,Kota,Kelamin)
VALUES
('P0001','Ashadi','Jl. Beo 25','Yogya','P'),
('P0002','Rian','Jl. Solo 123','Yogya','P'),
('P0003','Suwadi','Jl. Semangka 13','Bandung','P'),
('P0004','Siti','Jl. Durian 15','Solo','W'),
('P0005','Amir','Jl. Gajah 33','Kudus','P'),
('P0006','Suparman','Jl. Harimau 25','Jakarta','P'),
('P0007','Jaja','Jl. Singa 7','Bandung','P'),
('P0008','Saman','Jl. Naga 12','Yogya','P'),
('P0009','Anwar','Jl. Tidar 6A','Magelang','P'),
('P0010','Fatmawati','Jl. Renjana 4','Bogor','W')

-- Memasukan Data tabel gaji
INSERT INTO tblGaji
(kd_Pengarang,Nama,Gaji)
VALUES
('P0002','Rian',600000),
('P0005','Amir',700000),
('P0004','Siti',500000),
('P0003','Suwadi',1000000),
('P0010','Fatmawati',600000),
('P0008','Saman',750000)

-- 1. Menghitung jumlah pengarang di tabel pengarang
SELECT COUNT(id) as Jumlah FROM tblPengarang

-- 2. Mengitung jumlah pengarang wanita & pria
-- Pria
SELECT COUNT(kelamin) as Jumlah FROM tblPengarang WHERE kelamin='p'
-- Wanita
SELECT COUNT(kelamin) as Jumlah FROM tblPengarang WHERE kelamin='w'

-- Cara Digabung
SELECT Kelamin, Count(Kelamin) AS Jumlah FROM tblPengarang GROUP BY Kelamin

-- 3. Menampilkan Record Kota dan Jumlah Kotanya dari tabel Pengarang
SELECT Kota, COUNT(Kota) AS Jumlah FROM tblPengarang GROUP BY Kota ORDER BY Kota ASC

-- 4. Menampilkan Record Kota diatas 1 kota dari tbl pengarang
SELECT Kota, COUNT(Kota) AS Jumlah FROM tblPengarang GROUP BY Kota HAVING COUNT(Kota) > 1 ORDER BY Jumlah ASC

-- 5. Menampilkan kd_pengarang yang terbesar dan terkecil dari tabel tbl pengarang
-- Terbesar
SELECT MAX(kd_pengarang) AS Terbesar FROM tblPengarang
-- Terkecil
SELECT MIN(kd_pengarang) AS Terkecil FROM tblPengarang

-- 6. Menampilkan gaji tertinggi dan terrendah
-- Terbesar
SELECT MAX(Gaji) AS Terbesar FROM tblGaji
-- Terkecil
SELECT MIN(Gaji) As Terkecil FROM tblGaji

-- 7. Menampilkan Gaji diatas 600000
SELECT SUM(Gaji) AS Gaji FROM tblGaji GROUP BY Gaji HAVING SUM(Gaji) > 600000 ORDER BY Gaji ASC

-- 8. Menampilkan jumlah gaji
SELECT SUM(Gaji) as Jumlah FROM  tblGaji

-- 9. Menampilkan Jumlah gaji berdasarkan Kota
SELECT p.kota AS Kota, g.Gaji AS Gaji FROM tblPengarang AS p JOIN tblGaji AS g ON p.kd_Pengarang = g.kd_Pengarang

-- 10. Menampilkan Seluruh Record Pengarang Antara P0003 - P0006
SELECT * FROM tblPengarang WHERE kd_pengarang BETWEEN 'P0003' AND 'P0006'

-- 11. Menampilkan Seluruh Data Yogya,Solo Dan Magelang
SELECT * FROM tblPengarang WHERE Kota = 'Yogya' OR Kota = 'Solo' OR Kota = 'Magelang' ORDER BY Kota

-- 12. Menampilkan Seluruh data selain Yogya di table pengarang
SELECT * FROM tblPengarang WHERE NOT Kota = 'Yogya'

-- 13. Menampikan Seluruh data pengarang yang nama (terpisah):
-- a. Dimulai dengan huruf A
SELECT * FROM tblPengarang WHERE Nama LIKE 'A%'
-- b. Berakhiran i
SELECT * FROM tblPengarang WHERE Nama LIKE '%i'
-- c. Huruf Ketiganya a
SELECT * FROM tblPengarang WHERE Nama LIKE '__a%'
-- d. Tidak Berakhiran n
SELECT * FROM tblPengarang WHERE Nama NOT LIKE '%n'

-- 14. Tampilkan Seluruh data tabel pengarang dan tabel gaji dengan kd_pengarang yang sama
SELECT g.kd_Pengarang AS id, g.Nama AS Nama, g.Gaji AS Gaji, p.Kota AS Kota FROM tblGaji AS g 
JOIN tblPengarang AS p ON g.kd_Pengarang = p.kd_Pengarang

-- 15. Tampilkan kota yang memiliki gaji dibawah 1.000.000
SELECT p.kota AS Kota, g.Gaji AS Gaji FROM tblPengarang AS p JOIN tblGaji AS g ON p.kd_Pengarang = g.kd_Pengarang 
WHERE g.Gaji < 1000000 

-- 16. Ubah Panjang dari tipe tipe kelamin menjadi 10
ALTER TABLE tblPengarang ALTER COLUMN kelamin VARCHAR(10) NOT NULL

-- 17. Menambahkan Kolom Gelar dengan tipe varchar (12) pada tabel pengarang
ALTER TABLE tblPengarang ADD Gelar Varchar(12)

-- 18. Mengubah alamat rian dan kota dari rian di table pengarang
UPDATE tblPengarang SET Alamat = 'Jl. Cendrawasih 65', Kota = 'Pekanbaru' WHERE Nama = 'Rian'

-- 19. Buatlah View Untuk atribut kd_pengarang,nama,kota,gaji dengan nama vwPengarang
CREATE VIEW vmPengarang AS
SELECT p.kd_Pengarang, p.Nama, p.Kota, g.Gaji FROM tblPengarang AS p JOIN tblGaji AS g ON p.kd_Pengarang = g.kd_Pengarang

SELECT * FROM vmPengarang


