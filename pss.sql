-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 18, 2022 at 11:01 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pss`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Check_if_area_exists` (IN `name` VARCHAR(50))  NO SQL SELECT * FROM `tb_area` WHERE `are_name` = name$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Check_if_block_exists` (IN `name` VARCHAR(50))  NO SQL SELECT * FROM `tb_block` WHERE `Block_name` = name$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Check_if_customer_exists` (IN `ID` VARCHAR(50))  NO SQL SELECT * FROM `subscriber` WHERE `Subscriber_ElectricMeter_ID`= ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Check_if_subsc_exists` (IN `type` VARCHAR(50))  NO SQL SELECT * FROM `subscription` WHERE `Subscription_Type` = type$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `delecte_block` (IN `id` INT)   DELETE FROM `tb_block` WHERE `ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_are` (IN `Id` INT)   DELETE FROM tb_area WHERE tb_area.ID=Id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_fines` (IN `id` INT)   DELETE FROM `fines` WHERE `fines`.`ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_Fine_type` (IN `ID` INT)   DELETE FROM `fines_type` WHERE `fines_type`.id=ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_reading_from_elect_meter` (IN `id` INT)   DELETE FROM `subscriber_electricmeter_reading` WHERE `subscriber_electricmeter_reading`.`ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_Sub` (IN `ID` INT)   DELETE from subscriber WHERE ID_Subscriber=ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_subscription` (IN `ID` INT)   Delete from subscription WHERE ID_Subscription = ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `delet_mhseal` (IN `id` INT)   DELETE FROM `almhslen`WHERE `almhslen` .`ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `fines_type_insert` (IN `fine_name` VARCHAR(20), IN `fines_cost` VARCHAR(20))   INSERT INTO `fines_type`( `type`, `fines_cost`) VALUES (fine_name,fines_cost)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_area` (IN `area_name` VARCHAR(50))   INSERT INTO `tb_area` ( `are_name`) VALUES (area_name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_block` (IN `block_name` VARCHAR(100), IN `area_ID` INT(11), IN `Block_meter_number` VARCHAR(100))   INSERT INTO `tb_block` ( `Block_name`, `ID_are`,`center_meter_number`) VALUES (block_name,area_ID,Block_meter_number)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_fines` (IN `fine_type` INT(30), IN `iD_Subscriber` INT, IN `Fine_data` DATE)   INSERT INTO `fines`(`fines_type_ID`, `ID_Subscriber`,  `fine_data`) VALUES (fine_type,iD_Subscriber,Fine_data)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_manth_customer_name` ()   INSERT INTO manth_customer_name SELECT `ID_Subscriber`,`Subscriber_name`,`Subscriber_adress`,`Subscriber_ElectricMeter_ID`,`block_iD`  FROM `subscriber`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_mhseal` (IN `id_block` INT, IN `name` VARCHAR(20), IN `adreas` VARCHAR(50), IN `number` VARCHAR(20))   INSERT INTO `almhslen`( `ID_block`, `name_mhsel`, `adreas`, `number`) VALUES (id_block,name,adreas,number)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_opening_reading` (IN `meter_num` VARCHAR(20), IN `reading` VARCHAR(30), IN `Dat_e` DATE)   INSERT INTO `opening_reading`( `meter_number`, `reading`,`Date`) VALUES (meter_num,reading,Dat_e)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_reading` (IN `current_read` VARCHAR(20), IN `privos_reading` VARCHAR(20), IN `Dat_e` DATE, IN `meter_ID` VARCHAR(30), IN `ID_subscriper` INT, IN `ID_block` INT)   INSERT INTO `subscriber_electricmeter_reading` (`Current_Reading`, `Previous_Reading`, `Data_time`, `Subscriber_ElectricMeter_ID`, `ID_Subscriber`, `ID_Block`) VALUES (current_read,privos_reading,Dat_e,meter_ID,ID_subscriper,ID_block)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_subscriper` (IN `name` VARCHAR(200), IN `phone_number` VARCHAR(30), IN `address` VARCHAR(100), IN `Ind_type` VARCHAR(100), IN `Ind_num` VARCHAR(30), IN `Id_subscription` INT, IN `sub_Elec_ID` VARCHAR(100), IN `Date_sub` DATE, IN `Block_ID` INT)   INSERT INTO `subscriber` (`Subscriber_name`,
                          `Subscriber_Phone_Number`, 
                          `Subscriber_adress`, 
                          `Identification_Type`,
                          `Identity_number`, 
                          `ID_Subscription`, 
                          `Subscriber_ElectricMeter_ID`,
                          `block_iD`,
                          `Date_subsriber`) VALUES 
(name,phone_number,address,Ind_type,Ind_num,
 Id_subscription,sub_Elec_ID,Block_ID
,Date_sub)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_subscription` (IN `sub_peiod` VARCHAR(100), IN `sub_stype` VARCHAR(200), IN `Kw_price` INT, IN `month_fee` INT)  NO SQL INSERT INTO `subscription` (`Subscription_period`, `Subscription_Type`, `KW_price`, `Month_fee`) VALUES (sub_peiod,sub_stype,Kw_price,month_fee)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `reading_done` (IN `meter_num` VARCHAR(100))   UPDATE `manth_customer_name` SET `ST_ATR`=1 WHERE `Subscriber_ElectricMeter_ID`=meter_num$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `search_subscriper` (IN `serch` VARCHAR(100))   SELECT `ID_Subscriber`,`Subscriber_name`, `Subscriber_Phone_Number`, `Subscriber_adress`, `Identification_Type`, `Identity_number`, `ID_Subscription`, `Subscriber_ElectricMeter_ID` FROM subscriber WHERE `Subscriber_name`+ `Subscriber_Phone_Number`+ `Subscriber_adress` + `Identification_Type`+`Identity_number`+`Subscriber_ElectricMeter_ID` LIKE '%'+serch+'%'$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `selection_sebscription` ()  NO SQL SELECT ID_Subscription,Subscription_Type FROM subscription$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_area` ()  NO SQL SELECT * FROM tb_area$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Select_Block` ()   SELECT `tb_block`.`ID`, `tb_block`.`Block_name`,`tb_area`.`are_name`, `tb_block`.`center_meter_number` FROM `tb_block`,`tb_area` WHERE `tb_block`.`id_are`=`tb_area`.`ID`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_fines_substriber` ()   SELECT `ID`, `fines_type_ID`, `ID_Subscriber`, `pay_it`, `fine_data` FROM `fines`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_fines_type` ()   SELECT `id`, `type`, `fines_cost` FROM `fines_type`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_manth_customer` ()   SELECT  `name`, `address`, `Subscriber_ElectricMeter_ID`, `ST_ATR` FROM `manth_customer_name` WHERE `ST_ATR`=0$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_mhsel` ()   SELECT `ID`, `ID_block`, `name_mhsel`, `adreas`, `number` FROM `almhslen`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_opening` ()  NO SQL SELECT `subscriber`.`Subscriber_name`, `subscriber`.`Subscriber_ElectricMeter_ID`, `opening_reading`.`reading`, `opening_reading`.`Date` FROM `opening_reading` , `subscriber` WHERE `subscriber`.`Subscriber_ElectricMeter_ID` = `opening_reading`.`meter_number`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_opening_reading` (IN `meter_num` VARCHAR(44))   SELECT  `reading` FROM `opening_reading` WHERE `reading`.`meter_number`=meter_num$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_reading` (IN `meter_num` VARCHAR(44))   SELECT  `reading` FROM `opening_reading` WHERE `reading`.`meter_number`=meter_num$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_reading_from_elect_reading` ()   SELECT `subscriber_electricmeter_reading`.`ID`, `Current_Reading`, `Previous_Reading`, `Data_time`, `subscriber_electricmeter_reading`.`Subscriber_ElectricMeter_ID`, `subscriber`.`Subscriber_name`,`tb_block`.`Block_name`, `invoice_state_relace` FROM `subscriber_electricmeter_reading`,`tb_block`,`subscriber` WHERE `subscriber_electricmeter_reading`.`ID_Block`=`tb_block`.`ID` AND `subscriber`.`ID_Subscriber`=`subscriber_electricmeter_reading`.`ID_Subscriber`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_sebscription` ()   SELECT `ID_Subscription`, `Subscription_period`, `Subscription_Type`, `KW_price`, `Month_fee` FROM `subscription`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_subscriper` ()   SELECT `ID_Subscriber`, `Subscriber_name`, `Subscriber_Phone_Number`, `Subscriber_adress`, `Identification_Type`, `Identity_number`,`subscription`.`Subscription_Type`, `Subscriber_ElectricMeter_ID`, `tb_block`.`Block_name`, `Date_subsriber` FROM `subscriber`,`tb_block`,`subscription` WHERE `subscriber`.`block_iD`=`tb_block`.`ID` AND `subscription`.`ID_Subscription`=`subscriber`.`ID_Subscription`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Select_sub_meter_reading` ()   SELECT `ID`, `Current_Reading`, `Previous_Reading`, `Data_time`, `Subscriber_ElectricMeter_ID`, `ID_Subscriber`, `ID_Block`, `invoice_state_relace` FROM `subscriber_electricmeter_reading`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_sub_name_and_prvios_reading` (IN `meter_ID` VARCHAR(100))   SELECT subscriber.`ID_Subscriber`,subscriber.`Subscriber_name`,subscriber.`block_iD`,opening_reading.`reading` FROM subscriber,opening_reading WHERE subscriber.Subscriber_ElectricMeter_ID=meter_ID AND opening_reading.meter_number=meter_ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `slecte_spacial_subscriper` (IN `ID` INT)   SELECT `ID_Subscriber`, `Subscriber_name`, `Subscriber_Phone_Number`, `Subscriber_adress`, `Identification_Type`, `Identity_number`, `ID_Subscription`, `Subscriber_ElectricMeter_ID`, `block_iD`, `Date_subsriber`, `Status` FROM `subscriber` WHERE `ID_Subscriber`= ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `udete_finse_type` (IN `ID` INT, IN `fines_type` VARCHAR(30), IN `fines_cost` VARCHAR(20))   UPDATE `fines_type` SET `type`=fines_type,`fines_cost`=fines_cost WHERE `fines_type`.id=ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `udete_mhseal` (IN `id` INT, IN `id_block` INT, IN `name` VARCHAR(50), IN `adreas` VARCHAR(20), IN `numbar` VARCHAR(20))   UPDATE `almhslen` SET`ID_block`=id_block,`name_mhsel`=name,`adreas`=adreas,`number`=numbar WHERE `almhslen`.`ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_area` (IN `I_D` INT, IN `name` VARCHAR(200))  NO SQL UPDATE `tb_area` SET `are_name` =name WHERE `tb_area`.`ID` = I_D$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_block` (IN `ID_block` INT, IN `block_name` VARCHAR(100), IN `center_meter` VARCHAR(50), IN `are_id` INT)  NO SQL UPDATE `tb_block` SET `Block_name`=block_name,`center_meter_number`=center_meter,`ID_are`=are_id WHERE  `tb_block`.`ID` = ID_block$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_elect_meter` (IN `i_d` INT, IN `curr_read` VARCHAR(30), IN `priviou` VARCHAR(30), IN `d_ate` DATE, IN `meter_number` VARCHAR(30), IN `Id_subscription` INT)   UPDATE `subscriber_electricmeter_reading` SET
`Current_Reading`=curr_read,
`Previous_Reading`=priviou,
`Data_time`=d_ate,
`Subscriber_ElectricMeter_ID`=meter_number
 WHERE `subscriber_electricmeter_reading`.`ID`=i_d$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_fine` (IN `id` INT, IN `fine_type` INT, IN `subscriper_id` INT, IN `d_ate` DATE)   UPDATE fines SET `fines_type_ID`=fine_type,`ID_Subscriber`=subscriper_id,`fine_data`=d_ate WHERE`fines`.`ID`=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `update_opening_reading` (IN `meter_num` VARCHAR(100), IN `reading` VARCHAR(30), IN `Dat_e` DATE)   UPDATE `opening_reading` SET `opening_reading`.`reading`=reading,`Date`=Dat_e WHERE `opening_reading`.`meter_number`=meter_num$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_subscription` (IN `I_D` INT, IN `sub_period` VARCHAR(200), IN `Sub_Type` VARCHAR(100), IN `KW_p` INT, IN `mo_fee` INT)   UPDATE `subscription` SET `Subscription_period` =sub_period,`Subscription_Type`=Sub_Type,KW_price=KW_p
,Month_fee=mo_fee WHERE `subscription`.`ID_Subscription` = I_D$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_subsecriper` (IN `name` VARCHAR(200), IN `phone_number` VARCHAR(30), IN `address` VARCHAR(100), IN `Ind_type` VARCHAR(100), IN `Ind_num` VARCHAR(30), IN `Id_subscription` INT, IN `sub_Elec_ID` VARCHAR(100), IN `I_D` INT, IN `Date_sub` DATE, IN `block_ID` INT)  NO SQL UPDATE `subscriber` set `Subscriber_name`=name, `Subscriber_Phone_Number`=phone_number, `Subscriber_adress`=address, `Identification_Type`=Ind_type, `Identity_number`=Ind_num, `ID_Subscription`=Id_subscription, `Subscriber_ElectricMeter_ID`=sub_Elec_ID ,`block_iD`=block_ID,`Date_subsriber`=Date_sub WHERE `ID_Subscriber`=I_D$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `almhslen`
--

CREATE TABLE `almhslen` (
  `ID` int(11) NOT NULL,
  `ID_block` int(11) DEFAULT NULL,
  `name_mhsel` varchar(40) NOT NULL,
  `adreas` varchar(50) NOT NULL,
  `number` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `almhslen`
--

INSERT INTO `almhslen` (`ID`, `ID_block`, `name_mhsel`, `adreas`, `number`) VALUES
(5, 14, 'هارون', 'المعاين', '999'),
(6, 15, 'ياسر', 'اب', '75'),
(8, 14, 'على', 'اب', '4567890'),
(9, 15, 'ياسر', 'السبل', '773445554'),
(10, 15, 'ياسر', 'الدائري', '773670443');

-- --------------------------------------------------------

--
-- Table structure for table `center_meter_reading`
--

CREATE TABLE `center_meter_reading` (
  `id` int(11) NOT NULL,
  `Previous_Reading` int(11) NOT NULL,
  `Current_Reading` int(11) NOT NULL,
  `ID_BLoci` int(11) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `electric_bill`
--

CREATE TABLE `electric_bill` (
  `Bill_ID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `total_due` double NOT NULL,
  `service_period` varchar(50) NOT NULL,
  `descriptioner_ID` int(11) NOT NULL,
  `Data_time` date NOT NULL,
  `sub_reading_ID` int(11) NOT NULL,
  `privous_reading` varchar(20) NOT NULL,
  `current_Reading` varchar(20) NOT NULL,
  `consumption_KW` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `fines`
--

CREATE TABLE `fines` (
  `ID` int(11) NOT NULL,
  `fines_type_ID` int(11) DEFAULT NULL,
  `ID_Subscriber` int(11) NOT NULL,
  `pay_it` tinyint(1) NOT NULL DEFAULT 0,
  `fine_data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fines`
--

INSERT INTO `fines` (`ID`, `fines_type_ID`, `ID_Subscriber`, `pay_it`, `fine_data`) VALUES
(6, NULL, 31, 0, '2022-08-14');

-- --------------------------------------------------------

--
-- Table structure for table `fines_type`
--

CREATE TABLE `fines_type` (
  `id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `fines_cost` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fines_type`
--

INSERT INTO `fines_type` (`id`, `type`, `fines_cost`) VALUES
(5, 'lkdff', '788');

-- --------------------------------------------------------

--
-- Table structure for table `identity`
--

CREATE TABLE `identity` (
  `ID` int(11) NOT NULL,
  `identity_type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `identity`
--

INSERT INTO `identity` (`ID`, `identity_type`) VALUES
(2, 'بطاقة شخصية'),
(3, 'حواز سغر');

-- --------------------------------------------------------

--
-- Table structure for table `manth_customer_name`
--

CREATE TABLE `manth_customer_name` (
  `ID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `Subscriber_ElectricMeter_ID` varchar(100) NOT NULL,
  `ST_ATR` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manth_customer_name`
--

INSERT INTO `manth_customer_name` (`ID`, `name`, `address`, `Subscriber_ElectricMeter_ID`, `ST_ATR`) VALUES
(30, 'ياسر', 'ابيبيب', '444444', 1),
(31, 'ياسر الحكمي', 'السبل', '3456789', 14);

-- --------------------------------------------------------

--
-- Table structure for table `opening_reading`
--

CREATE TABLE `opening_reading` (
  `ID` int(11) NOT NULL,
  `meter_number` varchar(30) NOT NULL,
  `reading` varchar(15) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `opening_reading`
--

INSERT INTO `opening_reading` (`ID`, `meter_number`, `reading`, `Date`) VALUES
(2, '444444', '655', '2022-08-11'),
(7, '8848384', '77', '2022-08-18'),
(9, '56565656', '0', '2022-08-18'),
(10, '8798798798798', '0', '2022-08-18');

-- --------------------------------------------------------

--
-- Table structure for table `station_name`
--

CREATE TABLE `station_name` (
  `ID` int(11) NOT NULL,
  `Station_name` varchar(100) NOT NULL,
  `Ownerr_name` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `phone_number` int(11) NOT NULL,
  `image` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `subscriber`
--

CREATE TABLE `subscriber` (
  `ID_Subscriber` int(11) NOT NULL,
  `Subscriber_name` varchar(200) NOT NULL,
  `Subscriber_Phone_Number` varchar(30) NOT NULL,
  `Subscriber_adress` varchar(100) NOT NULL,
  `Identification_Type` varchar(50) NOT NULL,
  `Identity_number` varchar(40) NOT NULL,
  `ID_Subscription` int(11) NOT NULL,
  `Subscriber_ElectricMeter_ID` varchar(100) NOT NULL,
  `block_iD` int(11) DEFAULT NULL,
  `Date_subsriber` date DEFAULT NULL,
  `Status` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subscriber`
--

INSERT INTO `subscriber` (`ID_Subscriber`, `Subscriber_name`, `Subscriber_Phone_Number`, `Subscriber_adress`, `Identification_Type`, `Identity_number`, `ID_Subscription`, `Subscriber_ElectricMeter_ID`, `block_iD`, `Date_subsriber`, `Status`) VALUES
(30, 'ياسر', '777837932', 'ابيبيب', 'جواز', '343', 2, '444444', 0, '2022-08-14', 0),
(31, 'ياسر الحكمي', '7777445', 'السبل', 'جواز', 'بطاقة شخصية', 1, '3456789', 14, '2022-08-14', 0),
(35, 'عمار', '34567890', 'اب القاعدة', 'بطاقة شخصية', '56789', 2, '798798687', 15, '2022-08-18', 0),
(36, 'محمد', 'الكامل', 'اب القاعدة', 'بطاقة شخصية', '5678987987', 2, '8848384', 15, '2022-08-18', 0),
(37, 'ييننيي', '67889787987', 'اب القدين', 'بطاقة شخصية', '987987987987', 1, '798798798', 15, '2022-08-18', 0),
(38, 'على', '456789', 'يبيبيبيب', 'بطاقة شخصية', '57689', 2, '76768', 14, '2022-08-18', 0),
(40, 'llklklklk', '4567890', 'hfkkkk', 'جواز', '759847598475', 1, '56565656', 14, '2022-08-18', 0),
(41, 'kkjkjkjk', '6876876876876876', 'kjlkjlkjlk', 'جواز', '87987987987', 1, '8798798798798', 14, '2022-08-18', 0);

-- --------------------------------------------------------

--
-- Table structure for table `subscriber_electricmeter_reading`
--

CREATE TABLE `subscriber_electricmeter_reading` (
  `ID` int(11) NOT NULL,
  `Current_Reading` double NOT NULL,
  `Previous_Reading` double NOT NULL,
  `Data_time` date NOT NULL,
  `Subscriber_ElectricMeter_ID` varchar(100) NOT NULL,
  `ID_Subscriber` int(11) NOT NULL,
  `ID_Block` int(11) NOT NULL,
  `invoice_state_relace` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subscriber_electricmeter_reading`
--

INSERT INTO `subscriber_electricmeter_reading` (`ID`, `Current_Reading`, `Previous_Reading`, `Data_time`, `Subscriber_ElectricMeter_ID`, `ID_Subscriber`, `ID_Block`, `invoice_state_relace`) VALUES
(12, 655, 654, '2022-08-18', '444444', 30, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `subscription`
--

CREATE TABLE `subscription` (
  `ID_Subscription` int(11) NOT NULL,
  `Subscription_period` varchar(100) NOT NULL,
  `Subscription_Type` varchar(100) NOT NULL,
  `KW_price` int(11) NOT NULL,
  `Month_fee` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subscription`
--

INSERT INTO `subscription` (`ID_Subscription`, `Subscription_period`, `Subscription_Type`, `KW_price`, `Month_fee`) VALUES
(1, 'نص شهر', 'منزلي', 449, 1200),
(2, 'شهري', 'نجاري', 500, 1500);

-- --------------------------------------------------------

--
-- Table structure for table `tb_area`
--

CREATE TABLE `tb_area` (
  `ID` int(11) NOT NULL,
  `are_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_area`
--

INSERT INTO `tb_area` (`ID`, `are_name`) VALUES
(7, 'السبل '),
(9, 'hhh');

-- --------------------------------------------------------

--
-- Table structure for table `tb_block`
--

CREATE TABLE `tb_block` (
  `ID` int(11) NOT NULL,
  `Block_name` varchar(100) NOT NULL,
  `id_are` int(15) NOT NULL,
  `center_meter_number` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_block`
--

INSERT INTO `tb_block` (`ID`, `Block_name`, `id_are`, `center_meter_number`) VALUES
(14, 'الحي الراقي', 7, '3434'),
(15, 'شارع جمال', 7, '123456');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `User_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `blocked` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `almhslen`
--
ALTER TABLE `almhslen`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_block` (`ID_block`);

--
-- Indexes for table `center_meter_reading`
--
ALTER TABLE `center_meter_reading`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ID_BLoci` (`ID_BLoci`),
  ADD UNIQUE KEY `ID_BLoci_2` (`ID_BLoci`),
  ADD UNIQUE KEY `ID_BLoci_3` (`ID_BLoci`);

--
-- Indexes for table `electric_bill`
--
ALTER TABLE `electric_bill`
  ADD PRIMARY KEY (`Bill_ID`),
  ADD KEY `descriptioner_ID` (`descriptioner_ID`),
  ADD KEY `sub_reading_ID` (`sub_reading_ID`);

--
-- Indexes for table `fines`
--
ALTER TABLE `fines`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Subscriber` (`ID_Subscriber`),
  ADD KEY `fines_type_ID` (`fines_type_ID`);

--
-- Indexes for table `fines_type`
--
ALTER TABLE `fines_type`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `identity`
--
ALTER TABLE `identity`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `manth_customer_name`
--
ALTER TABLE `manth_customer_name`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Subscriber_ElectricMeter_ID` (`Subscriber_ElectricMeter_ID`);

--
-- Indexes for table `opening_reading`
--
ALTER TABLE `opening_reading`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `meter_number` (`meter_number`);

--
-- Indexes for table `station_name`
--
ALTER TABLE `station_name`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `subscriber`
--
ALTER TABLE `subscriber`
  ADD PRIMARY KEY (`ID_Subscriber`),
  ADD UNIQUE KEY `Subscriber_ElectricMeter_ID` (`Subscriber_ElectricMeter_ID`),
  ADD KEY `ID_Subscription` (`ID_Subscription`),
  ADD KEY `indentity_ID` (`Identification_Type`),
  ADD KEY `block_iD` (`block_iD`);

--
-- Indexes for table `subscriber_electricmeter_reading`
--
ALTER TABLE `subscriber_electricmeter_reading`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Subscriber_ElectricMeter_ID` (`Subscriber_ElectricMeter_ID`),
  ADD KEY `ID_Subscriber` (`ID_Subscriber`),
  ADD KEY `Subscriber_ElectricMeter_ID_2` (`Subscriber_ElectricMeter_ID`),
  ADD KEY `ID_Block` (`ID_Block`),
  ADD KEY `ID_Block_2` (`ID_Block`);

--
-- Indexes for table `subscription`
--
ALTER TABLE `subscription`
  ADD PRIMARY KEY (`ID_Subscription`);

--
-- Indexes for table `tb_area`
--
ALTER TABLE `tb_area`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tb_block`
--
ALTER TABLE `tb_block`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_are` (`id_are`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `almhslen`
--
ALTER TABLE `almhslen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `center_meter_reading`
--
ALTER TABLE `center_meter_reading`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `electric_bill`
--
ALTER TABLE `electric_bill`
  MODIFY `Bill_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `fines`
--
ALTER TABLE `fines`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `fines_type`
--
ALTER TABLE `fines_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `identity`
--
ALTER TABLE `identity`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `opening_reading`
--
ALTER TABLE `opening_reading`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `station_name`
--
ALTER TABLE `station_name`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subscriber`
--
ALTER TABLE `subscriber`
  MODIFY `ID_Subscriber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `subscriber_electricmeter_reading`
--
ALTER TABLE `subscriber_electricmeter_reading`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `subscription`
--
ALTER TABLE `subscription`
  MODIFY `ID_Subscription` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_area`
--
ALTER TABLE `tb_area`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tb_block`
--
ALTER TABLE `tb_block`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `almhslen`
--
ALTER TABLE `almhslen`
  ADD CONSTRAINT `almhslen_ibfk_1` FOREIGN KEY (`ID_block`) REFERENCES `tb_block` (`ID`);

--
-- Constraints for table `center_meter_reading`
--
ALTER TABLE `center_meter_reading`
  ADD CONSTRAINT `center_meter_reading_ibfk_1` FOREIGN KEY (`ID_BLoci`) REFERENCES `tb_block` (`ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `electric_bill`
--
ALTER TABLE `electric_bill`
  ADD CONSTRAINT `electric_bill_ibfk_1` FOREIGN KEY (`descriptioner_ID`) REFERENCES `subscriber` (`ID_Subscriber`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `electric_bill_ibfk_2` FOREIGN KEY (`sub_reading_ID`) REFERENCES `subscriber_electricmeter_reading` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `fines`
--
ALTER TABLE `fines`
  ADD CONSTRAINT `fines_ibfk_1` FOREIGN KEY (`ID_Subscriber`) REFERENCES `subscriber` (`ID_Subscriber`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fines_ibfk_2` FOREIGN KEY (`fines_type_ID`) REFERENCES `fines_type` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `manth_customer_name`
--
ALTER TABLE `manth_customer_name`
  ADD CONSTRAINT `manth_customer_name_ibfk_1` FOREIGN KEY (`Subscriber_ElectricMeter_ID`) REFERENCES `subscriber` (`Subscriber_ElectricMeter_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `opening_reading`
--
ALTER TABLE `opening_reading`
  ADD CONSTRAINT `opening_reading_ibfk_1` FOREIGN KEY (`meter_number`) REFERENCES `subscriber` (`Subscriber_ElectricMeter_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `subscriber`
--
ALTER TABLE `subscriber`
  ADD CONSTRAINT `subscriber_ibfk_1` FOREIGN KEY (`ID_Subscription`) REFERENCES `subscription` (`ID_Subscription`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `subscriber_electricmeter_reading`
--
ALTER TABLE `subscriber_electricmeter_reading`
  ADD CONSTRAINT `subscriber_electricmeter_reading_ibfk_1` FOREIGN KEY (`ID_Subscriber`) REFERENCES `subscriber` (`ID_Subscriber`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `subscriber_electricmeter_reading_ibfk_2` FOREIGN KEY (`Subscriber_ElectricMeter_ID`) REFERENCES `subscriber` (`Subscriber_ElectricMeter_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `tb_block`
--
ALTER TABLE `tb_block`
  ADD CONSTRAINT `tb_block_ibfk_1` FOREIGN KEY (`id_are`) REFERENCES `tb_area` (`ID`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
