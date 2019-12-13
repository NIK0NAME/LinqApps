CREATE TABLE [VehiculosLINQ].[CLIENTES](
	[DNI] [nvarchar](9) NULL,
	[Nombre] [nvarchar](20) NULL,
	[Domicilio] [nvarchar](30) NULL,
	[Población] [nvarchar](20) NULL,
	[Código postal] [int] NULL,
	[Teléfono] [nvarchar](12) NULL,
	[Forma de pago] [nvarchar](1) NULL,
	[SEXO] [nvarchar](1) NULL
) ON [PRIMARY]

CREATE TABLE [VehiculosLINQ].[DETALLES-NOTAS](
	[Código de nota] [int] NULL,
	[Línea] [int] NOT NULL,
	[Tipo] [nvarchar](1) NULL,
	[Ampliación] [nvarchar](20) NULL,
	[Importe] [money] NULL
) ON [PRIMARY]

CREATE TABLE [VehiculosLINQ].[NOTAS-REPARACIONES](
	[Código de nota] [int] NOT NULL,
	[matricula] [nvarchar](10) NULL,
	[Fecha de reparación] [datetime] NULL,
	[Descuento] [int] NULL,
	[Observaciones] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [VehiculosLINQ].[VEHICULOS](
	[Matrícula] [nvarchar](10) NULL,
	[Marca] [nvarchar](15) NULL,
	[Modelo] [nvarchar](15) NULL,
	[Color] [nvarchar](10) NULL,
	[Precio] [money] NULL,
	[Año] [int] NULL,
	[DNI] [nvarchar](9) NULL,
	[FECHA] [datetime] NULL
) ON [PRIMARY]

INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'15893631', N'JOSEFINA BAKER', N'Berminghan, 5-4º', N'DONOSTIA', 20002, N'943267145', N'1', N'2')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'15457824', N'LOUIS AMSTRONG', N'San Francisco, 28-3º', N'DONOSTIA', 20002, N'943267312', N'1', N'1')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'158456245', N'ROD STEWARD', N'Mayor, 19-1º iada.', N'HERNANI', 20013, N'943552645', N'3', N'1')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'15835241', N'JOHN LENNON', N'Pº Colón, 25,2º', N'DONOSTIA', 20014, N'943287116', N'2', N'1')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'16.456335', N'ALFREDO KRAUS', N'Zurriola, 28-4º', N'IRUN', 20021, N'943-261245', N'2', N'1')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'16.123742', N'JOAQUIN SABINA', N'Gran Vía, 22', N'MADRID', 30320, N'91666243', N'2', N'1')
INSERT [VehiculosLINQ].[CLIENTES] ([DNI], [Nombre], [Domicilio], [Población], [Código postal], [Teléfono], [Forma de pago], [SEXO]) VALUES (N'14.653.43', N'AHINOA ARTETA', N'Aldamar, 1', N'DONOSTI', 2003, N'943-287932', N'3', N'2')
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (3, 1, N'1', N'AAAA', 200000.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (3, 2, N'2', N'BBBB', 286000.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (3, 3, N'2', N'CCCCC', 12000.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (4, 4, N'1', N'DDDDDD', 1500.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (4, 5, N'2', N'JHJHJHG', 10000.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (10, 10, N'1', N'YYYYRTYTRYTRY', 100.0000)
INSERT [VehiculosLINQ].[DETALLES-NOTAS] ([Código de nota], [Línea], [Tipo], [Ampliación], [Importe]) VALUES (10, 11, N'2', N'GFGGFDGFD', 50.0000)
INSERT [VehiculosLINQ].[NOTAS-REPARACIONES] ([Código de nota], [matricula], [Fecha de reparación], [Descuento], [Observaciones]) VALUES (3, N'na-3425i', CAST(N'2003-02-12T00:00:00.000' AS DateTime), 0, NULL)
INSERT [VehiculosLINQ].[NOTAS-REPARACIONES] ([Código de nota], [matricula], [Fecha de reparación], [Descuento], [Observaciones]) VALUES (4, N'SE-1020', CAST(N'2003-03-26T00:00:00.000' AS DateTime), 0, NULL)
INSERT [VehiculosLINQ].[NOTAS-REPARACIONES] ([Código de nota], [matricula], [Fecha de reparación], [Descuento], [Observaciones]) VALUES (10, N'HRU1928', NULL, 0, NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'auditete', N'BMW', N'1021', N'Blanco', 4000000.0000, 2002, N'15457824', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'HRU1928', N'SEAT', N'Verano', N'Negro', 20000000.0000, 2003, N'15457824', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'PLO923', N'ZUZUKI', N'404', N'BEIGE', 35000000.0000, 2002, N'15457824', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'POT823', N'MERCEDES', N'202', N'VERDE', 40000000.0000, 2002, N'15457824', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'GE-2093', N'CADILLAC', N'1010', N'azul', 10000000.0000, 0, N'15835241', CAST(N'2004-09-20T00:00:00.000' AS DateTime))
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'SE-1020', N'DODGE', N'2931', N'VERDE', 5000000.0000, NULL, N'15835241', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'M-1393-s', N'Citroën', N'2c.v', N'BLANCO', 1200000.0000, 0, N'16.123742', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'M-1200-S', N'Seat', N'600', N'MATALIZADO', 500000.0000, 0, N'16.123742', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'SS-7692J', N'CITROEN', N'TXARA', N'BLANCO', 12000.0000, 0, N'14.653.43', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'na-3425i', N'RENAULT', N'12', N'ROJO', 20000.0000, 0, N'14.653.43', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'SS-3456', N'RENAULT', N'24', N'NEGRO', 0.0000, 0, N'14.653.43', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'SS-566', N'CITROEN', N'TXARA', N'BLANCO', 0.0000, 0, N'14.653.43', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'SS-123456', N'OPEL', N'100', N'ROJO', 0.0000, 2000, N'14.653.43', NULL)
INSERT [VehiculosLINQ].[VEHICULOS] ([Matrícula], [Marca], [Modelo], [Color], [Precio], [Año], [DNI], [FECHA]) VALUES (N'212123', N'ADADA', N'3453', N'FF', 0.0000, 0, NULL, CAST(N'2004-09-20T00:00:00.000' AS DateTime))
