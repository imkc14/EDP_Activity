-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: barangayis_db
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `bg_officials`
--

DROP TABLE IF EXISTS `bg_officials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bg_officials` (
  `bg_official_id` int NOT NULL AUTO_INCREMENT,
  `position` varchar(45) NOT NULL,
  `full_name` varchar(80) NOT NULL,
  `start_term` date NOT NULL,
  `end_term` date NOT NULL,
  `term_index` varchar(45) NOT NULL,
  PRIMARY KEY (`bg_official_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bg_officials`
--

LOCK TABLES `bg_officials` WRITE;
/*!40000 ALTER TABLE `bg_officials` DISABLE KEYS */;
INSERT INTO `bg_officials` VALUES (1,'Barangay Captain','Ariel P. Cha','2020-05-12','2023-10-30','2020-2023'),(2,'Barangay Secretary','Josephine E. Malinao','2020-05-12','2023-10-30','2020-2023'),(3,'Barangay Treasurer','Melissa N. Salem','2020-05-12','2023-10-30','2020-2023'),(4,'Barangay Kagawad 1','Jom B. Lee','2020-05-12','2023-10-30','2020-2023'),(5,'Barangay Kagawad 2','Gemma D. Valenzuela','2020-05-12','2023-10-30','2020-2023'),(6,'Barangay Kagawad 3','Seth L. Nieva','2020-05-12','2023-10-30','2020-2023'),(7,'Barangay Kagawad 4','Denver K. Lim','2020-05-12','2023-10-30','2020-2023'),(8,'Barangay Kagawad 5','Von C. Medina','2020-05-12','2023-10-30','2020-2023'),(9,'Barangay Kagawad 6','Kathryn S. Saut','2020-05-12','2023-10-30','2020-2023'),(10,'Barangay Kagawad 7','Mark L. Chu','2020-05-12','2023-10-30','2020-2022');
/*!40000 ALTER TABLE `bg_officials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `married_residents`
--

DROP TABLE IF EXISTS `married_residents`;
/*!50001 DROP VIEW IF EXISTS `married_residents`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `married_residents` AS SELECT 
 1 AS `FIRST NAME`,
 1 AS `MIDDLE NAME`,
 1 AS `LAST NAME`,
 1 AS `AGE`,
 1 AS `ADDRESS`,
 1 AS `CIVIL STATUS`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `purok`
--

DROP TABLE IF EXISTS `purok`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purok` (
  `purok_id` int NOT NULL AUTO_INCREMENT,
  `purok_name` varchar(45) NOT NULL,
  `population_per_purok` int NOT NULL,
  `purok_leader` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`purok_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purok`
--

LOCK TABLES `purok` WRITE;
/*!40000 ALTER TABLE `purok` DISABLE KEYS */;
INSERT INTO `purok` VALUES (1,'Purok 1',1,'Anthony Balala'),(2,'Purok 2',3,'Eric Natividad'),(3,'Purok 3',3,'Apple Medina'),(4,'Purok 4',4,'James Rodriguez'),(5,'Purok 5',3,'John Tonga'),(6,'Purok 6',2,'Melanie Nepomuceno'),(7,'Purok 7',2,'Darwin Cano'),(8,'Purok 8',2,'Arthur Tolentino'),(9,'Purok 9',2,'Joshua Magdamit'),(10,'Purok 10',2,'James Llenas');
/*!40000 ALTER TABLE `purok` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `residents`
--

DROP TABLE IF EXISTS `residents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `residents` (
  `resident_id` int NOT NULL AUTO_INCREMENT,
  `r_purok_id` int NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `middlename` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `birthdate` date NOT NULL,
  `age` int NOT NULL,
  `civil_status` varchar(45) NOT NULL,
  `religion` varchar(45) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `raddress` varchar(100) NOT NULL,
  `voter` varchar(10) NOT NULL,
  PRIMARY KEY (`resident_id`),
  KEY `purok_id_idx` (`r_purok_id`),
  CONSTRAINT `r_purok_id` FOREIGN KEY (`r_purok_id`) REFERENCES `purok` (`purok_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `residents`
--

LOCK TABLES `residents` WRITE;
/*!40000 ALTER TABLE `residents` DISABLE KEYS */;
INSERT INTO `residents` VALUES (1,4,'Ocharan','Cadag','Matt','1966-04-30',56,'Married','Born Again Christian','Male','Purok 4 Dancalan Donsol Sorsogon','Yes'),(2,2,'Cruz','Cano','Madelyn','1993-02-01',30,'Single','Born Again Christian','Female','Purok 2, Dancalan, Donsol, Sorsogon','Yes'),(3,3,'Llave','Cano','Madelyn','1933-02-01',30,'Single','Roman Catholic','Female','Purok 3, Dancalan, Donsol, Sorsogon','Yes'),(4,4,'Gubot','Aldea','Mark','1947-01-25',76,'Widower','Roman Catholic','Male','Purok 4, Dancalan, Donsol, Sorsogon','Yes'),(5,5,'Nantiza','Melitante','Khim','1994-05-14',28,'Single','Muslim','Male','Purok 5, Dancalan, Donsol, Sorsogon','Yes'),(6,6,'Oliquino','Rabulan','Janna','1987-06-23',35,'Married','Roman Catholic','Female','Purok 6, Dancalan, Donsol, Sorsogon','Yes'),(7,7,'Tolosa','Rabino','Gea','1982-08-13',40,'Single','Born Again Christian','Female','Purok 7, Dancalan, Donsol, Sorsogon','Yes'),(8,8,'Aves','Macandog','Carl','2013-02-05',10,'Single','Born Again Christian','Male','Purok 8, Dancalan, Donsol, Sorsogon','No'),(9,9,'Asusano','Yeo','Jenny','1967-10-28',55,'Separated','Born Again Christian','Female','Purok 9, Dancalan, Donsol, Sorsogon','Yes'),(10,10,'Nieva','Bagagnan','Dynzl','1979-12-17',43,'Married','Muslim','Male','Purok 10, Dancalan, Donsol, Sorsogon','No'),(11,3,'Cha','Pandaan','Ariel','1977-04-12',45,'Married','Roman Catholic','Male','Purok 3, Dancalan, Donsol, Sorsogon','Yes'),(12,2,'Soriano','Aban','Janneth','1990-07-19',32,'Married','Roman Catholic','Female','Purok 2, Dancalan, Donsol, Sorsogon','Yes'),(13,1,'Doe','Trinanes','John','1985-11-21',37,'Married','Roman Catholic','Male','Purok 1, Dancalan, Donsol, Sorsogon','Yes'),(14,4,'Dela Cruz','Abainza','Jayson','1979-01-10',44,'Married','Roman Catholic','Male','Purok 4, Dancalan, Donsol, Sorsogon','Yes'),(15,5,'Ombao','Magdamit','Kevin','1986-03-20',36,'Married','Roman Catholic','Male','Purok 5, Dancalan, Donsol, Sorsogon','Yes'),(16,6,'Aquino','Marinay','Rey','1984-05-31',38,'Married','Roman Catholic','Male','Purok 6, Dancalan, Donsol, Sorsogon','Yes'),(17,7,'Salen','Musa','Daryl','1988-05-02',34,'Married','Roman Catholic','Male','Purok 7, Dancalan, Donsol, Sorsogon','Yes'),(18,8,'Llenas','Barola','Von','1974-01-04',49,'Married','Roman Catholic','Male','Purok 8, Dancalan, Donsol, Sorsogon','Yes'),(19,9,'Duran','Loma','Raffy','1991-02-08',32,'Married','Roman Catholic','Male','Purok 9, Dancalan, Donsol, Sorsogon','Yes'),(20,10,'Batumbakal','De Guzman','Teddy','1982-01-18',41,'Married','Roman Catholic','Male','Purok 10, Dancalan, Donsol, Sorsogon','Yes'),(42,2,'Estrella','Cagayan','Lisa','1996-09-23',27,'Single','Roman Catholic','Female','Purok 2 Dancalan Donsol Sorsogon','Yes'),(43,3,'Dela Torre','Lozada','Rose','1994-08-24',28,'Single','Roman Catholic','Female','Purok 3 Dancalan Donsol Sorsogon','Yes'),(44,4,'Valen','Aranel','Jisoo','1993-07-25',29,'Single','Roman Catholic','Female','Purok 4 Dancalan Donsol Sorsogon','Yes'),(45,5,'Cordova','Serrani','Chanty','1992-06-23',30,'Single','Roman Catholic','Female','Purok 5 Dancalan Donsol Sorsogon','Yes');
/*!40000 ALTER TABLE `residents` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `population_AFTER_INSERT` AFTER INSERT ON `residents` FOR EACH ROW BEGIN
	if new.r_purok_id is not null then
    update purok set population_per_purok = population_per_purok + 1
    where purok_id = new.r_purok_id;
    end if;
    
    /* 
	The purpose of this AFTER INSERT trigger is to update the population in 
    a particular purok. Adding a new resident to the residents table will update 
    a row of a specific purok in the purok table's column 'population_per_purok',
    but only if the inserted r_purok_id has the same number 
    as the purok_id in the purok table.
	*/
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `population_AFTER_UPDATE` AFTER UPDATE ON `residents` FOR EACH ROW BEGIN
	if old.r_purok_id is not null then
    update purok set population_per_purok = population_per_purok - 1
    where purok_id = old.r_purok_id;
    end if;
    
    if new.r_purok_id is not null then
    update purok set population_per_purok = population_per_purok + 1 
    where purok_id = new.r_purok_id;
    end if;
    
    /* 
	The purpose of this AFTER UPDATE trigger is to update the population in 
    two puroks. Updating a resident's r_purok_id in the residents table 
    reduces the population of the purok it was previously a part of while 
    increasing the population of the new purok it was set to.
	*/
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `population_AFTER_DELETE` AFTER DELETE ON `residents` FOR EACH ROW BEGIN
	if old.r_purok_id is not null then
    update purok set population_per_purok = population_per_purok - 1 
    where purok_id = old.r_purok_id;
    end if;
    
    /* 
	The purpose of this AFTER DELETE trigger is to update the population in 
    a particular purok. Deleting a resident in the residents table will reduce
    the population of the purok it was a part of.
	*/
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `single_residents`
--

DROP TABLE IF EXISTS `single_residents`;
/*!50001 DROP VIEW IF EXISTS `single_residents`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `single_residents` AS SELECT 
 1 AS `FIRST NAME`,
 1 AS `MIDDLE NAME`,
 1 AS `LAST NAME`,
 1 AS `AGE`,
 1 AS `ADDRESS`,
 1 AS `CIVIL STATUS`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (2,'brgy.captain','kapitancha'),(3,'brgy.secretary','secretarymalinao'),(4,'brgy.treasurer','treasurersalem'),(5,'brgy.kagawad1','kagawad1lee'),(6,'brgy.kagawad2','kagawad2valenzuela'),(7,'brgy.kagawad3','kagawad3nieva'),(8,'brgy.kagawad4','kagawad4lim'),(9,'brgy.kagawad5','kagawad5medina'),(10,'brgy.kagawad6','kagawad6saut'),(11,'brgy.kagawad7','kagawad7chu');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `voter_residents`
--

DROP TABLE IF EXISTS `voter_residents`;
/*!50001 DROP VIEW IF EXISTS `voter_residents`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `voter_residents` AS SELECT 
 1 AS `FIRST NAME`,
 1 AS `MIDDLE NAME`,
 1 AS `LAST NAME`,
 1 AS `AGE`,
 1 AS `ADDRESS`,
 1 AS `VOTER`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'barangayis_db'
--

--
-- Dumping routines for database 'barangayis_db'
--
/*!50003 DROP FUNCTION IF EXISTS `get_monthlyincome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_monthlyincome`(r_fname VARCHAR(50), r_lname VARCHAR(50)) RETURNS float
    DETERMINISTIC
BEGIN
	DECLARE rmonthly_income FLOAT;
	SELECT monthly_income INTO rmonthly_income FROM residents WHERE firstname = r_fname and lastname = r_lname;
		RETURN rmonthly_income;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `count_with_sss` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `count_with_sss`(IN residents varchar(10), OUT with_sss INT)
BEGIN
	SELECT COUNT(*) INTO with_sss FROM barangayis_db.residents
	WHERE sss = residents;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `married_residents`
--

/*!50001 DROP VIEW IF EXISTS `married_residents`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `married_residents` AS select `residents`.`firstname` AS `FIRST NAME`,`residents`.`middlename` AS `MIDDLE NAME`,`residents`.`lastname` AS `LAST NAME`,`residents`.`age` AS `AGE`,`residents`.`raddress` AS `ADDRESS`,`residents`.`civil_status` AS `CIVIL STATUS` from `residents` where (`residents`.`civil_status` = 'married') order by `residents`.`r_purok_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `single_residents`
--

/*!50001 DROP VIEW IF EXISTS `single_residents`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `single_residents` AS select `residents`.`firstname` AS `FIRST NAME`,`residents`.`middlename` AS `MIDDLE NAME`,`residents`.`lastname` AS `LAST NAME`,`residents`.`age` AS `AGE`,`residents`.`raddress` AS `ADDRESS`,`residents`.`civil_status` AS `CIVIL STATUS` from `residents` where (`residents`.`civil_status` = 'single') order by `residents`.`r_purok_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `voter_residents`
--

/*!50001 DROP VIEW IF EXISTS `voter_residents`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `voter_residents` AS select `residents`.`firstname` AS `FIRST NAME`,`residents`.`middlename` AS `MIDDLE NAME`,`residents`.`lastname` AS `LAST NAME`,`residents`.`age` AS `AGE`,`residents`.`raddress` AS `ADDRESS`,`residents`.`voter` AS `VOTER` from `residents` where (`residents`.`voter` = 'Yes') order by `residents`.`r_purok_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-02  5:08:38
