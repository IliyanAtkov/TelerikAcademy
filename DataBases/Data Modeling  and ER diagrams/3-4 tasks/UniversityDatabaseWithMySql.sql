-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 23, 2014 at 03:33 PM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `homework`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE IF NOT EXISTS `courses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE IF NOT EXISTS `departments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Department_name` varchar(50) NOT NULL,
  `Professor_id` int(11) NOT NULL,
  `Course_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Professor_id` (`Professor_id`),
  KEY `Course_id` (`Course_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE IF NOT EXISTS `faculty` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Faculty_name` varchar(50) NOT NULL,
  `Department_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `facultydeparts`
--

CREATE TABLE IF NOT EXISTS `facultydeparts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Faculty_id` int(11) NOT NULL,
  `Department_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Faculty_id` (`Faculty_id`,`Department_id`),
  KEY `Department_id` (`Department_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `professorcourses`
--

CREATE TABLE IF NOT EXISTS `professorcourses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `CourseID` int(11) NOT NULL,
  `ProfessorID` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `CourseID` (`CourseID`),
  KEY `ProfessorID` (`ProfessorID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `professors`
--

CREATE TABLE IF NOT EXISTS `professors` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Professor_name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `professortitles`
--

CREATE TABLE IF NOT EXISTS `professortitles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Professor_id` int(11) NOT NULL,
  `Title_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Professor_id` (`Professor_id`,`Title_id`),
  KEY `Title_id` (`Title_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `studentcourses`
--

CREATE TABLE IF NOT EXISTS `studentcourses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentID` int(11) NOT NULL,
  `courseID` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `studentID` (`studentID`,`courseID`),
  KEY `courseID` (`courseID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE IF NOT EXISTS `students` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `titles`
--

CREATE TABLE IF NOT EXISTS `titles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `courses`
--
ALTER TABLE `courses`
  ADD CONSTRAINT `courses_ibfk_1` FOREIGN KEY (`id`) REFERENCES `professorcourses` (`CourseID`);

--
-- Constraints for table `departments`
--
ALTER TABLE `departments`
  ADD CONSTRAINT `departments_ibfk_1` FOREIGN KEY (`Course_id`) REFERENCES `courses` (`id`);

--
-- Constraints for table `faculty`
--
ALTER TABLE `faculty`
  ADD CONSTRAINT `faculty_ibfk_1` FOREIGN KEY (`id`) REFERENCES `facultydeparts` (`Faculty_id`);

--
-- Constraints for table `facultydeparts`
--
ALTER TABLE `facultydeparts`
  ADD CONSTRAINT `facultydeparts_ibfk_1` FOREIGN KEY (`Department_id`) REFERENCES `departments` (`id`);

--
-- Constraints for table `professorcourses`
--
ALTER TABLE `professorcourses`
  ADD CONSTRAINT `professorcourses_ibfk_1` FOREIGN KEY (`ProfessorID`) REFERENCES `professors` (`id`);

--
-- Constraints for table `professors`
--
ALTER TABLE `professors`
  ADD CONSTRAINT `professors_ibfk_1` FOREIGN KEY (`id`) REFERENCES `departments` (`Professor_id`);

--
-- Constraints for table `professortitles`
--
ALTER TABLE `professortitles`
  ADD CONSTRAINT `professortitles_ibfk_2` FOREIGN KEY (`Title_id`) REFERENCES `titles` (`id`),
  ADD CONSTRAINT `professortitles_ibfk_1` FOREIGN KEY (`Professor_id`) REFERENCES `professors` (`id`);

--
-- Constraints for table `studentcourses`
--
ALTER TABLE `studentcourses`
  ADD CONSTRAINT `studentcourses_ibfk_2` FOREIGN KEY (`courseID`) REFERENCES `courses` (`id`),
  ADD CONSTRAINT `studentcourses_ibfk_1` FOREIGN KEY (`studentID`) REFERENCES `students` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
