-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 26, 2019 at 01:25 PM
-- Server version: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stafford`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
CREATE TABLE IF NOT EXISTS `courses` (
  `course_id` int(11) NOT NULL AUTO_INCREMENT,
  `courseName` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL,
  `fee` varchar(50) NOT NULL,
  `professor` varchar(50) DEFAULT NULL,
  `studentCount` int(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`course_id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `courseName`, `semester`, `fee`, `professor`, `studentCount`) VALUES
(2, 'it', '1', '234', 'BENALI', 1),
(3, 'ittt', '2', '234', 'benali', 2),
(4, '3242', '2', '234', 'benali', 10);

-- --------------------------------------------------------

--
-- Table structure for table `professors`
--

DROP TABLE IF EXISTS `professors`;
CREATE TABLE IF NOT EXISTS `professors` (
  `professorID` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `DOB` varchar(20) NOT NULL,
  PRIMARY KEY (`professorID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `professors`
--

INSERT INTO `professors` (`professorID`, `username`, `password`, `firstName`, `lastName`, `address`, `email`, `DOB`) VALUES
(1, 'tharindu', '123', '', '', '', '', ''),
(2, 'benali', '123', '', '', '', '', ''),
(3, 'gayan', '2345', 'gayan', 'anjeewa', 'kahanda', 'gayan@yahoo.com', '2019-05-30');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
CREATE TABLE IF NOT EXISTS `students` (
  `studentID` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `DOB` varchar(50) DEFAULT NULL,
  `courseCount` int(11) NOT NULL DEFAULT '0',
  `course01` varchar(50) DEFAULT NULL,
  `course02` varchar(50) DEFAULT NULL,
  `course03` varchar(50) DEFAULT NULL,
  `course04` varchar(50) DEFAULT NULL,
  `alternativeCourse01` varchar(50) DEFAULT NULL,
  `alternativeCourse02` varchar(50) DEFAULT NULL,
  `dueFee` varchar(50) DEFAULT NULL,
  `paidFee` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`studentID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`studentID`, `username`, `password`, `firstName`, `lastName`, `email`, `address`, `DOB`, `courseCount`, `course01`, `course02`, `course03`, `course04`, `alternativeCourse01`, `alternativeCourse02`, `dueFee`, `paidFee`) VALUES
(1, 'diliru', '123', '', '', '', '', '', 0, 'ittt', 'it', 'it', 'ittt', 'it', 'it', '-600', '200'),
(2, 'yasiru', '123', '', '', '', '', '', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(3, 'd', 'd', 'd', 'd', 'd', 'd', NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
