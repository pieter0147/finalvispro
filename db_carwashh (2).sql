-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2024 at 09:47 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_carwashh`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_history`
--

CREATE TABLE `tbl_history` (
  `date` date NOT NULL,
  `license_plate` varchar(10) NOT NULL,
  `package` varchar(11) NOT NULL,
  `cost` int(20) DEFAULT NULL,
  `id_history` int(2) NOT NULL,
  `tipe_kendaraan` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_history`
--

INSERT INTO `tbl_history` (`date`, `license_plate`, `package`, `cost`, `id_history`, `tipe_kendaraan`) VALUES
('2024-11-12', 'db 999 h', 'premium', 200000, 29, 'mobil besar'),
('2024-11-12', 'db 1111 f', 'deep wash', 150000, 30, 'mobil kecil'),
('2024-11-12', 'db 777 g', 'basic wash', 50000, 31, 'motor besar'),
('2024-11-12', 'db 8765', 'deep wash', 70000, 32, 'motor kecil'),
('2024-09-01', 'db 505 bd', 'basic wash', 100000, 33, 'mobil besar'),
('2024-10-22', 'db 8463 j', 'premium', 100000, 34, 'mobil kecil'),
('2024-11-12', 'db 9876 h', 'deep wash', 70000, 35, 'motor besar'),
('2024-07-31', 'db 6543 g', 'basic wash', 50000, 36, 'motor kecil'),
('2024-11-12', 'DB 9880 NH', 'Premium', 200000, 37, 'mobil besar'),
('2024-11-12', 'DB 897 N', 'Package', 150000, 38, 'mobil besar'),
('2024-11-12', 'DB 68 H', 'Deep Wash', 150000, 39, 'mobil besar'),
('2024-11-12', 'DB 84 NF', 'Basic Wash', 100000, 40, 'mobil besar'),
('2024-11-12', 'db 5676 h', 'premium', 100000, 41, 'mobil kecil'),
('2024-11-17', 'ff', 'deep wash', 10000, 42, 'mobil besar'),
('2024-11-17', 'db 123 ll', 'deep wash', 100, 43, 'mobil besar'),
('2024-11-17', 'hjh', 'premium', 150, 44, 'mobil besar'),
('2024-11-17', 'fff', 'deep wash', 100, 45, 'mobil besar'),
('2024-11-17', 'hhh', 'premium', 150, 46, 'mobil besar'),
('2024-11-17', 'asdf', 'premium', 150, 47, 'mobil besar'),
('2024-11-17', 'dddd', 'deep wash', 100000, 48, 'mobil besar'),
('2024-11-17', 'db 89 g', 'basic wash', 100000, 49, 'mobil besar'),
('2024-11-17', 'db 28', 'deep wash', 150000, 50, 'mobil besar'),
('2024-11-17', 'db 38 f', 'premium', 200000, 51, 'mobil besar'),
('2024-11-17', 'db 74', 'basic wash', 50000, 52, 'mobil kecil'),
('2024-11-17', 'db 36 h', 'deep wash', 100000, 53, 'mobil kecil'),
('2024-11-17', 'db 81', 'premium', 150000, 54, 'mobil kecil'),
('2024-11-17', 'db 77 y', 'basic wash', 50000, 55, 'motor besar'),
('2024-11-17', 'db 123 r', 'deep wash', 70000, 56, 'motor besar'),
('2024-11-17', 'db 69 g', 'basic wash', 50000, 57, 'motor kecil'),
('2024-11-17', 'db 12 g', 'deep wash', 70000, 58, 'motor kecil'),
('2024-11-17', 'License', 'basic wash', 50000, 59, 'motor besar'),
('2024-11-23', '1234', 'premium', 200000, 60, 'mobil besar'),
('2024-11-23', '098', 'deep wash', 150000, 61, 'mobil besar'),
('2024-11-23', '6786', 'deep wash', 150000, 62, 'mobil besar');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login`
--

CREATE TABLE `tbl_login` (
  `user_id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `name` varchar(30) NOT NULL,
  `posisi` varchar(10) DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_login`
--

INSERT INTO `tbl_login` (`user_id`, `username`, `password`, `name`, `posisi`, `tanggal_lahir`) VALUES
(8, 'awriel', '0000', 'ariellya sayow', 'karyawan', '2006-04-21'),
(16, 'kunang', 'kaunang', 'ipo', 'karyawan', '2005-09-08'),
(19, 'marco', 'peter marco', 'van marco', NULL, '2005-02-15');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login_admin`
--

CREATE TABLE `tbl_login_admin` (
  `id_pengguna` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `name` varchar(30) NOT NULL,
  `level` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_login_admin`
--

INSERT INTO `tbl_login_admin` (`id_pengguna`, `username`, `password`, `name`, `level`) VALUES
(1, 'rolly', '54321', 'rolly lontaan', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_history`
--
ALTER TABLE `tbl_history`
  ADD PRIMARY KEY (`id_history`);

--
-- Indexes for table `tbl_login`
--
ALTER TABLE `tbl_login`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tbl_login_admin`
--
ALTER TABLE `tbl_login_admin`
  ADD PRIMARY KEY (`id_pengguna`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_history`
--
ALTER TABLE `tbl_history`
  MODIFY `id_history` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `tbl_login`
--
ALTER TABLE `tbl_login`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tbl_login_admin`
--
ALTER TABLE `tbl_login_admin`
  MODIFY `id_pengguna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
