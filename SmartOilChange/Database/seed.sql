-- Marcas
INSERT INTO MARCAS (nome) VALUES ('Chevrolet');
INSERT INTO MARCAS (nome) VALUES ('Fiat');
INSERT INTO MARCAS (nome) VALUES ('Volkswagen');
INSERT INTO MARCAS (nome) VALUES ('Ford');
INSERT INTO MARCAS (nome) VALUES ('Honda');

-- Modelos (Chevrolet)
INSERT INTO MODELOS (marca_id, nome) VALUES (1, 'Onix');
INSERT INTO MODELOS (marca_id, nome) VALUES (1, 'Tracker');

-- Modelos (Fiat)
INSERT INTO MODELOS (marca_id, nome) VALUES (2, 'Argo');
INSERT INTO MODELOS (marca_id, nome) VALUES (2, 'Cronos');

-- Modelos (Volkswagen)
INSERT INTO MODELOS (marca_id, nome) VALUES (3, 'Gol');
INSERT INTO MODELOS (marca_id, nome) VALUES (3, 'Polo');

-- Modelos (Ford)
INSERT INTO MODELOS (marca_id, nome) VALUES (4, 'Ka');

-- Modelos (Honda)
INSERT INTO MODELOS (marca_id, nome) VALUES (5, 'Civic');

-- Motores
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('1.0 Turbo Flex', 2020, 2025);
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('1.0 Flex', 2017, 2023);
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('1.3 Firefly Flex', 2018, 2024);
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('1.0 MPI Flex', 2015, 2023);
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('1.5 Flex', 2017, 2021);
INSERT INTO MOTORES (nome_motor, ano_inicio, ano_fim) VALUES ('2.0 Flex', 2017, 2024);

-- Modelos_Motores (Onix -> 1.0 Turbo, 1.0 Flex)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (1, 1);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (1, 2);

-- Modelos_Motores (Tracker -> 1.0 Turbo)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (2, 1);

-- Modelos_Motores (Argo -> 1.3 Firefly, 1.0 Flex)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (3, 3);
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (3, 2);

-- Modelos_Motores (Cronos -> 1.3 Firefly)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (4, 3);

-- Modelos_Motores (Gol -> 1.0 MPI)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (5, 4);

-- Modelos_Motores (Polo -> 1.0 MPI)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (6, 4);

-- Modelos_Motores (Ka -> 1.5 Flex)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (7, 5);

-- Modelos_Motores (Civic -> 2.0 Flex)
INSERT INTO MODELOS_MOTORES (modelo_id, motor_id) VALUES (8, 6);

-- Especificacoes de Oleo
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (1, '0W-20', 'API SP / ILSAC GF-6', 4.0);
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (2, '5W-30', 'API SN', 3.5);
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (3, '5W-30', 'API SN Plus / ILSAC GF-5', 3.3);
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (4, '5W-40', 'API SN / VW 502.00', 4.0);
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (5, '5W-30', 'API SN', 4.3);
INSERT INTO ESPECIFICACOES_OLEO (motor_id, viscosidade, especificacao, capacidade_litros) VALUES (6, '0W-20', 'API SP', 4.2);

-- Filtros OEM
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'GM', '26694172');
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'GM', '93382720');
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'Fiat', '55594651');
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'VW', '04E115561H');
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'Ford', 'BE8Z6731AB');
INSERT INTO FILTROS_OEM (tipo, marca, numero_peca) VALUES ('Blindado', 'Honda', '15400-RTA-003');

-- Motores_Filtros_OEM
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (1, 1);
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (2, 2);
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (3, 3);
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (4, 4);
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (5, 5);
INSERT INTO MOTORES_FILTROS_OEM (motor_id, filtro_oem_id) VALUES (6, 6);

-- Filtros Equivalentes
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Tecfil', 'PSL550');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Fram', 'PH6607');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Tecfil', 'PSL150');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mann', 'W712/94');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Tecfil', 'PSL640');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Fram', 'PH6017A');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Fram', 'PH10601');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mann', 'W67/2');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mahle', 'OX 427');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Purolator', 'PL20195');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Fram', 'PH5433');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Tecfil', 'PSL330');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mann', 'W68/1');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mahle', 'OC 613');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mann', 'W712/83');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Purolator', 'PL14612');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Fram', 'PH7317');
INSERT INTO FILTROS_EQUIVALENTES (marca, numero_peca) VALUES ('Mahle', 'OC 196');

-- OEM_Filtros_Equivalentes
-- OEM 1 - GM 26694172 (1.0 Turbo Flex - Onix / Tracker): 4 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (1, 1);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (1, 7);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (1, 8);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (1, 9);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (1, 10);
-- OEM 2 - GM 93382720 (1.0 Flex - Onix): 3 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (2, 2);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (2, 11);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (2, 12);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (2, 13);
-- OEM 3 - Fiat 55594651 (1.3 Firefly - Argo / Cronos): 3 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (3, 3);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (3, 11);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (3, 15);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (3, 16);
-- OEM 4 - VW 04E115561H (1.0 MPI - Gol / Polo): 3 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (4, 4);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (4, 7);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (4, 9);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (4, 14);
-- OEM 5 - Ford BE8Z6731AB (1.5 Flex - Ka): 2 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (5, 5);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (5, 11);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (5, 13);
-- OEM 6 - Honda 15400-RTA-003 (2.0 Flex - Civic): 3 equivalentes
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (6, 6);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (6, 17);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (6, 15);
INSERT INTO OEM_FILTROS_EQUIVALENTES (filtro_oem_id, filtro_equivalente_id) VALUES (6, 18);
