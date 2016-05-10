-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Gostitelj: 127.0.0.1
-- Čas nastanka: 09. maj 2016 ob 22.55
-- Različica strežnika: 10.1.13-MariaDB
-- Različica PHP: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Zbirka podatkov: `vzreja_psov`
--

DELIMITER $$
--
-- Procedure
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `iskanje_psa` (IN `name` CHAR(100))  BEGIN 
	SELECT p.id, p.ime, pa.ime, p.roj_datum, p.vzdevek, p.cena FROM psi p INNER JOIN pasme pa ON p.pasma_id = pa.id WHERE p.ime LIKE CONCAT('%', name , '%') ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `vse_pasme` ()  BEGIN 
	SELECT ime FROM pasme ;
END$$

--
-- Funkcije
--
CREATE DEFINER=`root`@`localhost` FUNCTION `dodaj_pasmo` (`name` VARCHAR(100), `doba` VARCHAR(100), `velikostM` VARCHAR(100), `velikostZ` VARCHAR(100)) RETURNS INT(11) BEGIN    
    INSERT INTO pasme(id, ime, ziv_doba, velikost_samca, velikost_samice) VALUES (NULL, name, doba, velikostM, velikostZ) ;
    RETURN 1 ;   
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `dodaj_psa` (`pasma` VARCHAR(100), `name` VARCHAR(100), `datum` TIMESTAMP, `nickname` VARCHAR(100), `price` FLOAT) RETURNS INT(11) BEGIN    
    INSERT INTO psi(id, pasma_id, ime, roj_datum, vzdevek, cena) VALUES (NULL, (SELECT id FROM pasme WHERE ime = pasma), name, datum, nickname, price) ;
    RETURN 1 ;   
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `menjava_gesla` (`st_geslo` VARCHAR(100), `nv_geslo` VARCHAR(100)) RETURNS INT(11) BEGIN  
  IF EXISTS (SELECT id FROM uporabniki WHERE geslo = st_geslo) 
  THEN   
    UPDATE uporabniki SET geslo = nv_geslo WHERE geslo = st_geslo ;
    RETURN 1 ;   
  ELSE
   RETURN 0 ;
  END IF ;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `nakup_psa` (`id_psa` INT, `kupec_name` VARCHAR(100), `kupec_surname` VARCHAR(100), `koncna_cena` FLOAT) RETURNS INT(11) BEGIN 
	UPDATE psi SET kupec_ime=kupec_name, kupec_priimek=kupec_surname, cena=koncna_cena WHERE id = id_psa ;
	DELETE FROM psi WHERE id = id_psa ;    
    RETURN 1 ;   
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `prijava` (`username` VARCHAR(100), `pass` VARCHAR(100)) RETURNS INT(11) BEGIN
IF EXISTS(SELECT id FROM uporabniki WHERE uporabnisko_ime = username AND geslo = pass)
THEN
RETURN 1;
ELSE
RETURN 0;
END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktura tabele `pasme`
--

CREATE TABLE `pasme` (
  `id` int(11) NOT NULL,
  `ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `ziv_doba` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `velikost_samca` varchar(100) COLLATE utf8mb4_slovenian_ci DEFAULT NULL,
  `velikost_samice` varchar(100) COLLATE utf8mb4_slovenian_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_slovenian_ci;

--
-- Odloži podatke za tabelo `pasme`
--

INSERT INTO `pasme` (`id`, `ime`, `ziv_doba`, `velikost_samca`, `velikost_samice`) VALUES
(1, 'Akita Inu', '10 - 12 let', '64 - 70 cm', '58 - 64 cm'),
(2, 'Ameriški buldog', '10 - 15 let', '56 - 69 cm', '51 - 64 cm'),
(3, 'Ameriški pit bull terier', '12 - 15 let', '41 - 61 cm', '35 - 61 cm'),
(4, 'Angleški Buldog', '8 - 10 let', '20 - 30 cm', '15 - 30 cm'),
(5, 'Baset', '8 - 13 let', '33 - 38 cm', '33 - 38 cm'),
(6, 'Beagle', '12 - 15 let', '33 - 40 cm', '33 - 40 cm'),
(7, 'Bernardinec', '8 - 10 let', '70 - 90 cm ', '65 - 80 cm'),
(8, 'Borderski ovčar', '12 - 15 let', '51 - 55 cm ', '49 - 53 cm'),
(9, 'Bullmastiff', '8 - 10 let', '64 - 69 cm', '61 - 66 cm'),
(10, 'Čivava', '14 - 18 let', '10 - 30 cm', '10 - 30 cm'),
(11, 'Dalmatinec', '11 - 16 let', '56 - 62 cm', '54 - 60 cm'),
(12, 'Doberman', '8 - 12 let', '68 - 72 cm', '63 - 68 cm'),
(13, 'Jazbečar - kratkodlaki', '12 - 15 let', '30 - 35 cm', '30 - 35 cm'),
(14, 'Kitajski goli pes', '10 - 12 let', '28 - 33 cm', '23 - 30 cm'),
(15, 'Koder - srednji', '12 - 15 let', '35 - 45 cm', '35 - 45 cm'),
(16, 'Kraški ovčar', '12 - 15 let', '57 - 63 cm', '54 - 60 cm'),
(17, 'Labradorec', '10 - 12 let', '56 - 57 cm', '54 - 56 cm'),
(18, 'Mastiff', '10 - 12 let', '60 - 67 cm', '56 - 60 cm'),
(19, 'Mops', '12 - 15 let', '20 - 35 cm', '20 - 35 cm'),
(20, 'Nemška doga', '6 - 8 let', '80 cm', '72 cm'),
(21, 'Nemški ovčar', '13 - 15 let', '60 - 65 cm', '55 - 60 cm'),
(22, 'Rottweiler', '10 - 12 let', '61 - 68 cm', '56 - 63 cm'),
(23, 'Zlati prinašalec', '12 - 14 let', '56 - 61 cm', '51 - 56 cm');

-- --------------------------------------------------------

--
-- Struktura tabele `prodani_psi`
--

CREATE TABLE `prodani_psi` (
  `id` int(11) NOT NULL,
  `ime_psa` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `kupec_ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `kupec_priimek` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `cena` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_slovenian_ci;

-- --------------------------------------------------------

--
-- Struktura tabele `psi`
--

CREATE TABLE `psi` (
  `id` int(11) NOT NULL,
  `pasma_id` int(11) NOT NULL,
  `ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `roj_datum` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `vzdevek` varchar(100) COLLATE utf8mb4_slovenian_ci DEFAULT NULL,
  `kupec_ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `kupec_priimek` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `cena` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_slovenian_ci;

--
-- Odloži podatke za tabelo `psi`
--

INSERT INTO `psi` (`id`, `pasma_id`, `ime`, `roj_datum`, `vzdevek`, `kupec_ime`, `kupec_priimek`, `cena`) VALUES
(1, 13, 'Alojz', '2016-03-02 23:00:00', 'Lojzek', '', '', 0),
(2, 1, 'Akitek', '2016-02-16 23:00:00', 'Akitic', '', '', 0),
(3, 23, 'Lena', '2015-05-12 22:00:00', 'Lenči', '', '', 120.45),
(4, 10, 'čćžšđšđčćž', '2016-05-08 22:00:00', 'čćžšđšđ', '', '', 12);

--
-- Sprožilci `psi`
--
DELIMITER $$
CREATE TRIGGER `prodan` BEFORE DELETE ON `psi` FOR EACH ROW BEGIN 
	INSERT INTO prodani_psi VALUES (NULL, OLD.ime, OLD.kupec_ime,OLD.kupec_priimek,OLD.cena) ;       
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktura tabele `uporabniki`
--

CREATE TABLE `uporabniki` (
  `id` int(11) NOT NULL,
  `ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `priimek` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `uporabnisko_ime` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL,
  `geslo` varchar(100) COLLATE utf8mb4_slovenian_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_slovenian_ci;

--
-- Odloži podatke za tabelo `uporabniki`
--

INSERT INTO `uporabniki` (`id`, `ime`, `priimek`, `uporabnisko_ime`, `geslo`) VALUES
(1, 'Jan', 'Rat', 'a', 'a');

--
-- Indeksi zavrženih tabel
--

--
-- Indeksi tabele `pasme`
--
ALTER TABLE `pasme`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `prodani_psi`
--
ALTER TABLE `prodani_psi`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `psi`
--
ALTER TABLE `psi`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `uporabniki`
--
ALTER TABLE `uporabniki`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT zavrženih tabel
--

--
-- AUTO_INCREMENT tabele `pasme`
--
ALTER TABLE `pasme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT tabele `prodani_psi`
--
ALTER TABLE `prodani_psi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT tabele `psi`
--
ALTER TABLE `psi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT tabele `uporabniki`
--
ALTER TABLE `uporabniki`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
