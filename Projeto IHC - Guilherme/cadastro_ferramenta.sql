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
-- Estrutura da tabela `cadastro_ferramenta`
--

CREATE TABLE `cadastro_ferramenta` (
  `cod_ferramenta` int(5) NOT NULL,
  `desc_ferramenta` varchar(160) NOT NULL,
  `marca_ferramenta` varchar(60) NOT NULL,
  `tipo_ferramenta` varchar(11) NOT NULL,
  `estado_ferramenta` varchar(11) NOT NULL,
  `disponibilidade` varchar(13) NOT NULL,
  `cod_local` int(4) NOT NULL,
  `cod_morador` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro_ferramenta`
--
ALTER TABLE `cadastro_ferramenta`
  ADD PRIMARY KEY (`cod_ferramenta`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_ferramenta`
--
ALTER TABLE `cadastro_ferramenta`
  MODIFY `cod_ferramenta` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
