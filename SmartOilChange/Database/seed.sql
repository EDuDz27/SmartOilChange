-- Marcas
INSERT INTO MARCAS (nome) VALUES ('Chevrolet');
INSERT INTO MARCAS (nome) VALUES ('Fiat');
INSERT INTO MARCAS (nome) VALUES ('Volkswagen');
INSERT INTO MARCAS (nome) VALUES ('Ford');
INSERT INTO MARCAS (nome) VALUES ('Honda');

-- Modelos
INSERT INTO MODELOS (marca_id, nome) VALUES (1, 'Onix');
INSERT INTO MODELOS (marca_id, nome) VALUES (1, 'Tracker');
INSERT INTO MODELOS (marca_id, nome) VALUES (2, 'Argo');
INSERT INTO MODELOS (marca_id, nome) VALUES (2, 'Cronos');
INSERT INTO MODELOS (marca_id, nome) VALUES (3, 'Gol');
INSERT INTO MODELOS (marca_id, nome) VALUES (3, 'Polo');
INSERT INTO MODELOS (marca_id, nome) VALUES (4, 'Ka');
INSERT INTO MODELOS (marca_id, nome) VALUES (5, 'Civic');

-- Motores
INSERT INTO MOTORES (nome) VALUES ('1.0 Turbo Flex');
INSERT INTO MOTORES (nome) VALUES ('1.0 Flex');
INSERT INTO MOTORES (nome) VALUES ('1.3 Firefly Flex');
INSERT INTO MOTORES (nome) VALUES ('1.0 MPI Flex');
INSERT INTO MOTORES (nome) VALUES ('1.5 Flex');
INSERT INTO MOTORES (nome) VALUES ('2.0 Flex');

-- Modelos_Motores
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (1, 1, 2020, 2025);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (1, 2, 2017, 2023);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (2, 1, 2021, 2025);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (3, 3, 2018, 2024);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (3, 2, 2018, 2022);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (4, 3, 2018, 2024);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (5, 4, 2015, 2023);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (6, 4, 2018, 2024);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (7, 5, 2017, 2021);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id, ano_inicio, ano_fim) VALUES (8, 6, 2017, 2024);

-- Especificacoes de Oleo
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (1, '0W-20', 'API SP', 'ACEA C5', 4.00, 'Troca recomendada a cada 10.000 km');
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (2, '5W-30', 'API SN', 'ACEA A5/B5', 3.50, 'Uso normal urbano e rodoviario');
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (3, '5W-30', 'API SN PLUS', 'ACEA C3', 3.30, 'Verificar nivel a cada 1.000 km');
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (4, '5W-40', 'API SN', 'ACEA A3/B4', 4.00, 'Atende aplicacoes de alta temperatura');
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (5, '5W-30', 'API SN', 'ACEA A5/B5', 4.30, 'Ideal para uso misto');
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, norma_api, norma_acea, capacidade_litros, observacoes) VALUES (6, '0W-20', 'API SP', 'ACEA C5', 4.20, 'Usar oleo sintetico homologado');

-- Filtros
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'GM', '26694172');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Tecfil', 'PSL550');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Fram', 'PH10601');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mann', 'W67/2');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'GM', '93382720');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Fram', 'PH6607');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Tecfil', 'PSL330');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Fiat', '55594651');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Tecfil', 'PSL150');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mann', 'W712/83');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'VW', '04E115561H');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mann', 'W712/94');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mahle', 'OC 613');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Ford', 'BE8Z6731AB');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Tecfil', 'PSL640');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mann', 'W68/1');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Honda', '15400-RTA-003');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Fram', 'PH7317');
INSERT INTO FILTROS (tipo, marca, numero_peca) VALUES ('blindado', 'Mahle', 'OC 196');

-- Motor_Filtros (modelo_motor_id -> filtros compativeis)
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (1, 1);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (1, 2);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (1, 3);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (1, 4);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (2, 5);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (2, 6);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (2, 7);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (3, 1);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (3, 2);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (3, 3);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (4, 8);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (4, 9);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (4, 10);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (5, 5);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (5, 6);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (5, 7);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (6, 8);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (6, 9);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (6, 10);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (7, 11);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (7, 12);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (7, 13);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (8, 11);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (8, 12);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (8, 13);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (9, 14);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (9, 15);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (9, 16);

INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (10, 17);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (10, 18);
INSERT INTO MOTOR_FILTROS (modelo_motor_id, filtro_id) VALUES (10, 19);
