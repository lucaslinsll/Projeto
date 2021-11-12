-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Nov-2021 às 08:59
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistema_ferramentas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro_morador`
--

CREATE TABLE `cadastro_morador` (
  `cod_morador` int(5) NOT NULL,
  `nome_morador` varchar(65) NOT NULL,
  `cpf_morador` bigint(20) NOT NULL,
  `data_nasc_morador` varchar(10) NOT NULL,
  `cod_bloco` int(4) NOT NULL,
  `cod_ap` int(4) NOT NULL,
  `tel_morador` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cadastro_morador`
--

INSERT INTO `cadastro_morador` (`cod_morador`, `nome_morador`, `cpf_morador`, `data_nasc_morador`, `cod_bloco`, `cod_ap`, `tel_morador`) VALUES
(1, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(2, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(3, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(4, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(5, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(6, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(7, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(8, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(9, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(10, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(11, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(12, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(13, 'LAUDI', 0, '20/05/1995', 0, 0, 0),
(14, 'lucasssaaa', 0, '20/05/1995', 0, 0, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro_morador`
--
ALTER TABLE `cadastro_morador`
  ADD PRIMARY KEY (`cod_morador`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_morador`
--
ALTER TABLE `cadastro_morador`
  MODIFY `cod_morador` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
