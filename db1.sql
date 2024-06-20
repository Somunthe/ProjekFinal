CREATE DATABASE  IF NOT EXISTS `charmify` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `charmify`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: charmify
-- ------------------------------------------------------
-- Server version	8.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `keranjang`
--

DROP TABLE IF EXISTS `keranjang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `keranjang` (
  `idkeranjang` int NOT NULL AUTO_INCREMENT,
  `nama_barang` varchar(45) DEFAULT NULL,
  `harga_barang` int DEFAULT NULL,
  `jumlah_barang` int DEFAULT NULL,
  `total_harga` int DEFAULT NULL,
  `pemesan` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idkeranjang`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `keranjang`
--

LOCK TABLES `keranjang` WRITE;
/*!40000 ALTER TABLE `keranjang` DISABLE KEYS */;
INSERT INTO `keranjang` VALUES (17,'Smile Nekclace',30000,2,60000,'dewi'),(18,'Butterfly Bracelet',20000,3,60000,'dewi'),(19,'Strawberry Earring',10000,3,30000,'budi'),(20,'Smile Nekclace',30000,2,60000,'budi'),(21,'Butterfly Bracelet',20000,1,20000,'budi');
/*!40000 ALTER TABLE `keranjang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pesanan`
--

DROP TABLE IF EXISTS `pesanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pesanan` (
  `idpesanan` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `alamat` varchar(45) DEFAULT NULL,
  `no_hp` varchar(45) DEFAULT NULL,
  `jenis_pengiriman` varchar(45) DEFAULT NULL,
  `jenis_pembayaran` varchar(45) DEFAULT NULL,
  `no_pembayaran` varchar(45) DEFAULT NULL,
  `total_biaya` int DEFAULT NULL,
  `tgl_transaksi` datetime DEFAULT CURRENT_TIMESTAMP,
  `pemesan` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpesanan`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pesanan`
--

LOCK TABLES `pesanan` WRITE;
/*!40000 ALTER TABLE `pesanan` DISABLE KEYS */;
INSERT INTO `pesanan` VALUES (1,'jandsj','jnfjdasnf','098765678','JNE','DANA','45678987655',130000,'2024-06-13 17:31:30','dewi'),(2,'budi','jabsdjsabd','0987656789','JNE','DANA','8678987678',130000,'2024-06-13 19:05:36','budi'),(3,'budi','jasdnjasndjna','098767890','JNT','BRI','072374264',120000,'2024-06-13 19:21:50','budi'),(4,'budi siregar','jasbdasbdkabf','0987656789','JNE','DANA','082123884232',120000,'2024-06-13 19:23:14','budi'),(5,'budi','gyfudbhnjaf','890987678','JNE','DANA','098767893',120000,'2024-06-13 19:24:57','budi');
/*!40000 ALTER TABLE `pesanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('123','new'),('admin','admin'),('budi','123'),('dewi','123'),('iniuser','inipass'),('test','test');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-13 19:44:01
