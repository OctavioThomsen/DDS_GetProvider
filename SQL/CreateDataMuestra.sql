INSERT INTO MODELO (NOMBRE)
VALUES
	('Z407')
GO

INSERT INTO MARCA (NOMBRE) 
VALUES 
	('Logitech')
GO

INSERT INTO CATEGORIA (NOMBRE) 
VALUES 
	('Deportes'),
	('Tecnología'),
	('Vehículos') 
GO

INSERT INTO SUBCATEGORIA (NOMBRE, ID_CATEGORIA) 
VALUES 
	('Parlantes', (SELECT ID_CATEGORIA FROM CATEGORIA WHERE NOMBRE = 'Tecnología')),
	('Mouses', (SELECT ID_CATEGORIA FROM CATEGORIA WHERE NOMBRE = 'Tecnología')),
	('Teclados', (SELECT ID_CATEGORIA FROM CATEGORIA WHERE NOMBRE = 'Tecnología'))
GO

INSERT INTO PRODUCTO (NOMBRE, TIPO_DISPONIBILIDAD, ID_MARCA, ID_SUBCATEGORIA)
VALUES
	('Parlante Logitech Z407', 'Disponible', (SELECT ID_MARCA FROM MARCA WHERE NOMBRE = 'Logitech'), (SELECT ID_SUBCATEGORIA FROM SUBCATEGORIA WHERE NOMBRE = 'Parlantes'))
GO
