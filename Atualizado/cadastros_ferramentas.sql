-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Out-2021 às 08:01
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
-- Estrutura da tabela `cadastros_ferramentas`
--

CREATE TABLE `cadastros_ferramentas` (
  `id_ferramenta` int(11) NOT NULL,
  `ferramenta` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cadastros_ferramentas`
--

INSERT INTO `cadastros_ferramentas` (`id_ferramenta`, `ferramenta`) VALUES
(2, 'martelo'),
(3, 'furadeira'),
(4, 'giselle'),
(5, 'lll'),
(6, 'makita');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastros_ferramentas`
--
ALTER TABLE `cadastros_ferramentas`
  ADD PRIMARY KEY (`id_ferramenta`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastros_ferramentas`
--
ALTER TABLE `cadastros_ferramentas`
  MODIFY `id_ferramenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
