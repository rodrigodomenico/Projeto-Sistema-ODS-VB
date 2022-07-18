-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Jul-2022 às 06:01
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistema_erp`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `animais`
--

CREATE TABLE `animais` (
  `id_animal` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `raca` varchar(100) NOT NULL,
  `idade` int(11) NOT NULL,
  `data_cadastro` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `animais`
--

INSERT INTO `animais` (`id_animal`, `id_categoria`, `nome`, `raca`, `idade`, `data_cadastro`) VALUES
(32, 7, 'Rex', 'Pastor Alemão', 2, '2018-12-06'),
(33, 8, 'Ted', 'Persa', 5, '2018-12-06'),
(35, 8, 'Marron', 'Persa', 3, '2018-12-06');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro_cliente`
--

CREATE TABLE `cadastro_cliente` (
  `Id_cliente` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Genero` varchar(100) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `DataNascimento` varchar(20) NOT NULL,
  `Endereco` varchar(100) NOT NULL,
  `EnderecoNumero` varchar(20) NOT NULL,
  `Cep` varchar(16) NOT NULL,
  `Complemento` varchar(50) NOT NULL,
  `Cidade` varchar(100) NOT NULL,
  `Bairro` varchar(50) NOT NULL,
  `Estado` varchar(50) NOT NULL,
  `Data_cadastro` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cadastro_cliente`
--

INSERT INTO `cadastro_cliente` (`Id_cliente`, `Nome`, `Genero`, `Cpf`, `Telefone`, `DataNascimento`, `Endereco`, `EnderecoNumero`, `Cep`, `Complemento`, `Cidade`, `Bairro`, `Estado`, `Data_cadastro`) VALUES
(66, 'Rodrigo Rodzinski de Domenico', 'Masculino', '666.555.666-45', '51 1234-5543', '26/12/1999', 'Jose casemiro castilhos', '73', '93285-630', 'casa', 'Esteio', 'Olimpica', 'RS', '2022-07-08'),
(67, 'Felipe Nascimento', 'Masculino', '222.333.444-56', '51 6666-4444', '26/12/1999', 'jose casemiro castilhos 73', '73', '93285-630', 'casa', 'Esteio', 'Olimpica', 'Rs', '2022-07-09'),
(68, 'Rodolfo', 'Masculino', '666.514.500-00', '51 991057825', '02/09/2000', 'Olavo Frontora', '45', '93285-630', 'casa', 'esteio', 'Olimpica', 'RS', '2022-07-10');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro_funcionario`
--

CREATE TABLE `cadastro_funcionario` (
  `Id_Funcionario` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Bairro` varchar(100) NOT NULL,
  `Cep` varchar(100) NOT NULL,
  `Cidade` varchar(100) NOT NULL,
  `Complemento` varchar(11) NOT NULL,
  `Cpf` varchar(60) NOT NULL,
  `DataNascimento` varchar(30) NOT NULL,
  `Data_cadastro` date NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `Estado` varchar(50) NOT NULL,
  `Genero` text NOT NULL,
  `EnderecoNumero` int(11) NOT NULL,
  `Telefone` int(11) NOT NULL,
  `Login` varchar(100) NOT NULL,
  `Senha` varchar(100) NOT NULL,
  `Funcao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cadastro_funcionario`
--

INSERT INTO `cadastro_funcionario` (`Id_Funcionario`, `Nome`, `Bairro`, `Cep`, `Cidade`, `Complemento`, `Cpf`, `DataNascimento`, `Data_cadastro`, `Endereco`, `Estado`, `Genero`, `EnderecoNumero`, `Telefone`, `Login`, `Senha`, `Funcao`) VALUES
(10, 'Rodrigo', 'Olimpica', '93285-630', 'Esteio', 'Casa', '666.111.555.45', '26/12/1999', '2022-07-12', 'Jose Casemiro Castilhos', 'RS', 'Masculino', 73, 51, 'Rodrigo', 'OlaMundo!', 'Administrador'),
(11, 'Rodolfo', 'Olimpica', '941123-45', 'esteio', 'casa', '000.444.333-45', '25/12/1999', '2022-07-17', 'Jose Casemiro Castilhos', 'Rs', 'Mas', 73, 51, 'Rodolfo', '123456', 'Tecnico');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargo`
--

CREATE TABLE `cargo` (
  `Cargo_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cargo`
--

INSERT INTO `cargo` (`Cargo_ID`) VALUES
('Administrador'),
('Tecnico');

-- --------------------------------------------------------

--
-- Estrutura da tabela `chamado`
--

CREATE TABLE `chamado` (
  `Id_produto` int(11) NOT NULL,
  `Id_cliente` varchar(100) NOT NULL,
  `Produto` varchar(100) NOT NULL,
  `NumeroSerie` varchar(50) NOT NULL,
  `DataEntrada` date NOT NULL,
  `DataSaida` varchar(100) NOT NULL,
  `Descricao` varchar(500) NOT NULL,
  `Id_Tecnico` varchar(100) NOT NULL,
  `ParecerTecnico` varchar(100) NOT NULL,
  `Valor` int(30) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `mes` varchar(10) NOT NULL,
  `Ano` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `chamado`
--

INSERT INTO `chamado` (`Id_produto`, `Id_cliente`, `Produto`, `NumeroSerie`, `DataEntrada`, `DataSaida`, `Descricao`, `Id_Tecnico`, `ParecerTecnico`, `Valor`, `Status`, `mes`, `Ano`) VALUES
(11, 'Rodrigo Rodzinski de Domenico', 'Notebook', 'ZPI-021', '2022-07-18', '', 'Está com um defeito no carregador, possivel curto no conector. ', 'Rodolfo', '', 0, 'Análise técnica', '07', '2022');

-- --------------------------------------------------------

--
-- Estrutura da tabela `status_solicitacao`
--

CREATE TABLE `status_solicitacao` (
  `Solicitacao_id` int(11) NOT NULL,
  `Solicitacao` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `status_solicitacao`
--

INSERT INTO `status_solicitacao` (`Solicitacao_id`, `Solicitacao`) VALUES
(2, 'Finalizada'),
(4, 'Análise técnica'),
(5, 'Orçamento'),
(6, '');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro_cliente`
--
ALTER TABLE `cadastro_cliente`
  ADD PRIMARY KEY (`Id_cliente`);

--
-- Índices para tabela `cadastro_funcionario`
--
ALTER TABLE `cadastro_funcionario`
  ADD PRIMARY KEY (`Id_Funcionario`);

--
-- Índices para tabela `chamado`
--
ALTER TABLE `chamado`
  ADD PRIMARY KEY (`Id_produto`);

--
-- Índices para tabela `status_solicitacao`
--
ALTER TABLE `status_solicitacao`
  ADD UNIQUE KEY `1` (`Solicitacao_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro_cliente`
--
ALTER TABLE `cadastro_cliente`
  MODIFY `Id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT de tabela `cadastro_funcionario`
--
ALTER TABLE `cadastro_funcionario`
  MODIFY `Id_Funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `chamado`
--
ALTER TABLE `chamado`
  MODIFY `Id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `status_solicitacao`
--
ALTER TABLE `status_solicitacao`
  MODIFY `Solicitacao_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
