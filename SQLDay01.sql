

-- SQL Day 01

-- DDL

-- (Create) Membuat DateBase

create database db_kampus

-- Drop Database / Table
-- drop database db_kampus

-- Create Tabel 
create table mahasiswa(
id bigint primary key identity(1,1),
name varchar(50) not null,
address varchar(50) not null,
email varchar(255) null
)

-- Create View
create view vw_mahasiswa as select * from mahasiswa

-- Alter
-- Add Column
alter table mahasiswa add nomor_hp varchar(100) not null

-- Drop Column
alter table mahasiswa drop column nomor_hp 

-- Alter Column
alter table mahasiswa alter column email varchar(100) not null

-- Drop
drop database db_mahasiswa (db_mahasiswa itu adalah nama database)

-- Drop table
drop table nama_table

-- Drop View
drop view nama_view

-- DML (Data Manipulation Language)
-- Insert / Menambahkan Data
insert into mahasiswa (name, address, email) values ('Rizwan Hidayat', 'Tasikmalaya', 'rizwan@email.email')
insert into mahasiswa (name, address, email) values 
('Abiyu', 'Bekasi', 'abiyu@email.com'),
('Rizky', 'Tanggerang', 'risky@email.com'),
('Banu', 'Ciamis', 'banu@email.com'),
('Ezi', 'Malang', 'ezi@email.com'),
('fika', 'Palembang', 'fika@email.com')

-- Select / Menampilkan Data
select * from mahasiswa
select id,name,address,email from mahasiswa

-- Update / Mengubah Data
update mahasiswa set name = 'Fika' where id=6 -- , email = 'zwan@email.id' where id=1

-- Delete / Menghapus Data
delete from mahasiswa where id=2;
delete mahasiswa where id=2;

-- Join


-- Membuat Biodata
create table biodata(
id bigint primary key identity,
mahasiswa_id bigint,
tgl_lahir datetime,
gender varchar(10) not null)

alter table biodata alter column mahasiswa_id bigint null

-- create view vw_biodata as select * from biodata

insert into biodata (mahasiswa_id, tgl_lahir,gender ) 
values
(2,'2001-01-01','Perempuan'),
(3,'2010-10-10','Laki-Laki')

insert into biodata (mahasiswa_id, tgl_lahir,gender ) 
values
(4,'2001-02-01','Perempuan')


select * from biodata

-- Join (Ada AND OR dan NOT)
select mhs.id as id_mahasiswa, mhs.name as nama_mahasiswa, mhs.address as alamat, mhs.email as email, 
bio.tgl_lahir as tanggal_lahir, bio.gender as gender
from mahasiswa as mhs 
join biodata as bio on mhs.id = bio.mahasiswa_id where mhs.id=2 -- NOT mhs.id=2 -- AND/OR mhs.name = 'zwan';

-- ORDER BY (ASC atau DESC)
select * from biodata order by tgl_lahir 

-- Select Top (Membatasi jumlah baris data yang di tampilkan)
select top 1 mahasiswa_id from biodata order by mahasiswa_id DESC

-- Between (Untuk mencocokan nilai dengan rentang nilai)
select * from biodata where mahasiswa_id between 2 and 3
select * from biodata where tgl_lahir between '2001-01-01' and '2002-05-05'

-- LIKE (Seperti/Mengandung)
select * from mahasiswa where name like 'a%u'
--'e__%'  
--'%z%' 
--'%ik%' (bebas yang penting ada ik) 
--'%a'(Yang dibelakang huruf nya a) 
--'a%'(yang depan huruf a)

-- Grup BY
select name from mahasiswa group by name 

-- Having
SELECT name, SUM(id) AS jumlah FROM mahasiswa GROUP BY name HAVING SUM(id) > 5 ORDER BY jumlah ASC