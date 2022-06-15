-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 10, 2022 at 09:54 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.4.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qronos`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblemployee`
--

DROP TABLE IF EXISTS `tblemployee`;
CREATE TABLE IF NOT EXISTS `tblemployee` (
  `Employee_ID` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Status` varchar(100) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Fname` varchar(100) NOT NULL,
  `Lname` varchar(100) NOT NULL,
  `Mname` varchar(100) NOT NULL,
  `Suffix` varchar(100) NOT NULL,
  `Position` varchar(100) NOT NULL,
  `Office` varchar(100) NOT NULL,
  `ID_pic` longtext NOT NULL,
  `Immediate_Head` varchar(200) NOT NULL,
  `QR_Code` varchar(200) NOT NULL,
  PRIMARY KEY (`Employee_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemployee`
--

INSERT INTO `tblemployee` (`Employee_ID`, `Password`, `Status`, `Name`, `Fname`, `Lname`, `Mname`, `Suffix`, `Position`, `Office`, `ID_pic`, `Immediate_Head`, `QR_Code`) VALUES
('000001', 'admin1', 'Active', 'Jaren Loyd C Heruela', 'Jaren Loyd', 'Heruela', 'C.', '', 'Administrator', 'IT Department', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\WIN_20220318_19_39_01_Pro.jpg', 'Athina D. Heruela ', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\qr1.jpg'),
('000002', '', 'Deactive', 'Bjorn Von H. Moro', 'Bjorn Von', 'Moro', 'H.', '', 'Supervisor', 'Head Office', 'C:\\Users\\Jaren\\Pictures\\curiculum schedule.png', 'Jaren Loyd C Heruela', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\qr2.jpg'),
('000005', '', 'Deactive', 'Jaren  Baliday ', 'Jaren', 'Baliday', '', '', 'Supervisor', 'Head Office', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\Untitled-1.png', '', ''),
('000009', '', 'Deactive', 'Jasper H. Castro ', 'Jasper', 'Castro', 'H.', '', 'Supervisor', 'Head Office', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\Untitled-1.png', '', 'C:\\Users\\Jaren\\Pictures\\Camera Roll\\q9.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tblemployee_attendance`
--

DROP TABLE IF EXISTS `tblemployee_attendance`;
CREATE TABLE IF NOT EXISTS `tblemployee_attendance` (
  `Employee_ID` varchar(100) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Num_Days_Present` varchar(11) NOT NULL,
  `Date` varchar(100) NOT NULL,
  PRIMARY KEY (`Employee_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemployee_attendance`
--

INSERT INTO `tblemployee_attendance` (`Employee_ID`, `Name`, `Num_Days_Present`, `Date`) VALUES
('000005', 'Jaren  Baliday ', '1', 'June 9, 2022'),
('000009', 'Jasper H. Castro ', '1', 'June 10, 2022');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_am`
--

DROP TABLE IF EXISTS `tbl_am`;
CREATE TABLE IF NOT EXISTS `tbl_am` (
  `id` varchar(20) NOT NULL,
  `Employee_ID` varchar(20) NOT NULL,
  `Time_IN` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `Time_OUT` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `Date` varchar(100) NOT NULL,
  `Remark` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_am`
--

INSERT INTO `tbl_am` (`id`, `Employee_ID`, `Time_IN`, `Time_OUT`, `Date`, `Remark`) VALUES
('1', '000001', '2022-06-09 01:00:04', '0000-00-00 00:00:00', '06/09/2022', 'Late'),
('2', '000002', '2022-06-09 01:43:49', '0000-00-00 00:00:00', '06/09/2022', 'Late'),
('3', '000005', '2022-06-09 01:44:31', '0000-00-00 00:00:00', '06/09/2022', 'Late'),
('\"+id1+\"', '\" + emp_id + \"', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '\" + DateTime.Now.ToString(\"MM/dd/yyyy\") + \"', '\" + remark + \"'),
('0610094854', '000005', '2022-06-10 01:48:54', '0000-00-00 00:00:00', '06/10/2022', 'Late'),
('0610095103', '000009', '2022-06-10 01:51:04', '0000-00-00 00:00:00', '06/10/2022', 'Late');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pm`
--

DROP TABLE IF EXISTS `tbl_pm`;
CREATE TABLE IF NOT EXISTS `tbl_pm` (
  `id` varchar(20) NOT NULL,
  `Employee_ID` varchar(20) NOT NULL,
  `Time_IN` timestamp NOT NULL DEFAULT current_timestamp(),
  `Time_OUT` timestamp NOT NULL DEFAULT current_timestamp(),
  `Date` varchar(30) NOT NULL,
  `Remark` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pm`
--

INSERT INTO `tbl_pm` (`id`, `Employee_ID`, `Time_IN`, `Time_OUT`, `Date`, `Remark`) VALUES
('1', '000001', '2022-06-10 01:19:40', '0000-00-00 00:00:00', '06/09/2022', 'On-Time'),
('2', '000002', '2022-06-10 01:19:47', '0000-00-00 00:00:00', '06/09/2022', 'On-Time'),
('3', '000005', '2022-06-10 01:19:57', '0000-00-00 00:00:00', '06/09/2022', 'On-Time');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
