-- SCRIPT DE INSERÇÃO DE DADOS PARA O BANCO 'loja'
-- Versão ajustada para a nova ordem de colunas na tabela tb04_pedido.

-- 1. Inserindo os status de pedido (tabela de domínio)
-- Estes dados precisam existir antes de qualquer pedido ser criado.
INSERT INTO loja.tb03_status_pedido (descricao) VALUES
('Processando'),
('Pagamento Aprovado'),
('Enviado'),
('Entregue'),
('Cancelado');

-- 2. Inserindo 15 clientes
INSERT INTO loja.tb01_cliente (cpf, nome_cliente, data_nascimento, email, cep, endereco, cidade, estado) VALUES
('11122233344', 'Ana Carolina Souza', '1990-05-15', 'ana.carolina@email.com', '01001000', 'Rua da Consolação, 1500', 'São Paulo', 'SP'),
('22233344455', 'Bruno Alves', '1985-11-20', 'bruno.alves@email.com', '20040030', 'Avenida Rio Branco, 100', 'Rio de Janeiro', 'RJ'),
('33344455566', 'Carla Dias', '1992-02-10', 'carla.dias@email.com', '30110005', 'Avenida Afonso Pena, 500', 'Belo Horizonte', 'MG'),
('44455566677', 'Daniel Costa', '2000-07-30', 'daniel.costa@email.com', '70070150', 'SCS Quadra 5, Bloco A', 'Brasília', 'DF'),
('55566677788', 'Eduarda Ferreira', '1998-09-05', 'eduarda.f@email.com', '40026010', 'Avenida Sete de Setembro, 200', 'Salvador', 'BA'),
('66677788899', 'Fábio Martins', '1982-12-12', 'fabio.martins@email.com', '80010010', 'Rua XV de Novembro, 300', 'Curitiba', 'PR'),
('77788899900', 'Gabriela Lima', '1995-03-25', 'gabi.lima@email.com', '90010150', 'Rua dos Andradas, 800', 'Porto Alegre', 'RS'),
('88899900011', 'Heitor Ribeiro', '1979-06-18', 'heitor.r@email.com', '69010001', 'Avenida Eduardo Ribeiro, 1000', 'Manaus', 'AM'),
('99900011122', 'Isabela Santos', '2001-01-01', 'isabela.santos@email.com', '66010020', 'Avenida Presidente Vargas, 400', 'Belém', 'PA'),
('00011122233', 'João Pedro Gomes', '1993-04-14', 'jp.gomes@email.com', '50030000', 'Avenida Marquês de Olinda, 150', 'Recife', 'PE'),
('12312312312', 'Larissa Mendes', '1999-08-22', 'larissa.mendes@email.com', '01001000', 'Avenida Paulista, 2000', 'São Paulo', 'SP'),
('23423423423', 'Marcos Andrade', '1988-10-10', 'marcos.andrade@email.com', '20040030', 'Rua do Ouvidor, 50', 'Rio de Janeiro', 'RJ'),
('34534534534', 'Natália Rocha', '1991-05-19', 'natalia.rocha@email.com', '30110005', 'Rua da Bahia, 1200', 'Belo Horizonte', 'MG'),
('45645645645', 'Otávio Nunes', '1997-11-02', 'otavio.nunes@email.com', '70070150', 'Asa Norte, Quadra 205', 'Brasília', 'DF'),
('56756756756', 'Patrícia Azevedo', '1980-02-28', 'patricia.azevedo@email.com', '40026010', 'Largo do Pelourinho, 10', 'Salvador', 'BA');

-- 3. Inserindo 20 produtos de categorias variadas
INSERT INTO loja.tb02_produto (codigo_produto, nome_produto, preco, categoria, estoque) VALUES
('NTB-GMR-001', 'Notebook Gamer Predator', 7599.90, 'Eletrônicos', 15),
('MSE-LOG-203', 'Mouse Logitech MX Master 3', 499.90, 'Eletrônicos', 50),
('TEC-RED-K55', 'Teclado Mecânico Redragon Kumara', 289.00, 'Eletrônicos', 30),
('MON-DELL-U24', 'Monitor Dell UltraSharp 24"', 1899.00, 'Eletrônicos', 25),
('SSD-KNG-1TB', 'SSD Kingston NV2 1TB', 450.00, 'Eletrônicos', 80),
('CAM-NIK-D75', 'Câmera Nikon D7500', 6500.00, 'Eletrônicos', 10),
('LIV-SDA-001', 'Livro: O Senhor dos Anéis - Trilogia', 159.90, 'Livros', 100),
('LIV-CRN-001', 'Livro: As Crônicas de Nárnia', 89.90, 'Livros', 120),
('LIV-COD-CLN', 'Livro: Código Limpo', 75.50, 'Livros', 200),
('LIV-ARQ-LIM', 'Livro: Arquitetura Limpa', 85.00, 'Livros', 150),
('CAF-NES-DGU', 'Cafeteira Nespresso Dolce Gusto', 399.00, 'Casa e Cozinha', 40),
('LIQ-OST-MAX', 'Liquidificador Oster Clássico', 249.90, 'Casa e Cozinha', 60),
('TEN-NIK-PEG', 'Tênis Nike Pegasus 40', 799.90, 'Esportes', 70),
('CAM-FLA-2025', 'Camisa Oficial Flamengo 2025', 349.90, 'Esportes', 250),
('CAM-PAL-2025', 'Camisa Oficial Palmeiras 2025', 349.90, 'Esportes', 250),
('BOL-BSK-SPALD', 'Bola de Basquete Spalding', 199.90, 'Esportes', 90),
('CAL-JEA-LEV', 'Calça Jeans Levis 501', 450.00, 'Roupas', 180),
('CAM-POL-LAC', 'Camisa Polo Lacoste', 389.00, 'Roupas', 120),
('ASP-ROB-ROOM', 'Aspirador Robô Roomba', 2199.00, 'Casa e Cozinha', 20),
('FONE-SONY-XM5', 'Fone Sony WH-1000XM5', 2599.00, 'Eletrônicos', 35);

-- 4. Inserindo 25 pedidos (COM A ORDEM DE COLUNAS CORRIGIDA)
-- A ordem agora é: numero_pedido, data_pedido, id_cliente, id_status_pedido
INSERT INTO loja.tb04_pedido (numero_pedido, data_pedido, id_cliente, id_status_pedido) VALUES
('PED-2025-00001', '2025-01-15', 1, 4), ('PED-2025-00010', '2025-03-22', 1, 4), ('PED-2025-00025', '2025-08-10', 1, 3),
('PED-2025-00002', '2025-01-18', 2, 4), ('PED-2025-00011', '2025-04-01', 2, 5),
('PED-2025-00003', '2025-02-01', 3, 4),
('PED-2025-00004', '2025-02-05', 4, 4), ('PED-2025-00012', '2025-04-10', 4, 4), ('PED-2025-00018', '2025-06-15', 4, 4), ('PED-2025-00024', '2025-08-05', 4, 2),
('PED-2025-00005', '2025-02-20', 5, 3),
('PED-2025-00006', '2025-03-02', 6, 4),
('PED-2025-00007', '2025-03-10', 7, 4), ('PED-2025-00013', '2025-05-05', 7, 4),
('PED-2025-00008', '2025-03-11', 8, 5),
('PED-2025-00009', '2025-03-20', 9, 4), ('PED-2025-00014', '2025-05-12', 9, 3),
('PED-2025-00015', '2025-05-18', 10, 4), ('PED-2025-00019', '2025-06-20', 10, 4), ('PED-2025-00023', '2025-07-30', 10, 1),
('PED-2025-00016', '2025-05-25', 11, 4),
('PED-2025-00017', '2025-06-01', 12, 4),
('PED-2025-00020', '2025-07-05', 13, 4),
('PED-2025-00021', '2025-07-15', 14, 2),
('PED-2025-00022', '2025-07-22', 15, 1);

-- 5. Inserindo os itens dos pedidos
-- Esta parte não precisa de alteração, pois as chaves primárias são geradas automaticamente.
INSERT INTO loja.tb05_item_pedido (id_pedido, id_produto, quantidade, valor_unitario) VALUES
-- Pedido 1
(1, 1, 1, 7599.90), (1, 2, 1, 499.90),
-- Pedido 2
(2, 7, 1, 159.90),
-- Pedido 3
(3, 13, 1, 799.90), (3, 16, 1, 199.90),
-- Pedido 4
(4, 5, 2, 450.00),
-- Pedido 5 (Cancelado)
(5, 18, 1, 389.00),
-- Pedido 6
(6, 11, 1, 399.00),
-- Pedido 7
(7, 9, 1, 75.50), (7, 10, 1, 85.00),
-- Pedido 8 (Cancelado)
(8, 20, 1, 2599.00),
-- Pedido 9
(9, 17, 2, 450.00),
-- Pedido 10
(10, 3, 1, 289.00), (10, 4, 1, 1899.00),
-- Pedido 11
(11, 14, 1, 349.90),
-- Pedido 12
(12, 19, 1, 2199.00),
-- Pedido 13
(13, 8, 1, 89.90),
-- Pedido 14
(14, 1, 1, 7599.90), (14, 5, 2, 450.00), (14, 20, 1, 2599.00),
-- Pedido 15
(15, 2, 1, 499.90),
-- Pedido 16
(16, 15, 1, 349.90),
-- Pedido 17
(17, 6, 1, 6500.00),
-- Pedido 18
(18, 12, 1, 249.90),
-- Pedido 19
(19, 7, 2, 159.90), (19, 8, 2, 89.90),
-- Pedido 20
(20, 9, 5, 75.50),
-- Pedido 21
(21, 13, 2, 799.90),
-- Pedido 22
(22, 18, 3, 389.00),
-- Pedido 23
(23, 1, 1, 7599.90),
-- Pedido 24
(24, 2, 2, 499.90), (24, 3, 1, 289.00),
-- Pedido 25
(25, 4, 1, 1899.00);
