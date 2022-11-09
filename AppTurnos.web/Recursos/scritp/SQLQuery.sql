EXEC Usuarios_Agregar 'juanperez', '123ABC', 'AppTurnos'

create procedure Usuarios_Agregar
	@Usuario varchar(50),
	@Contraseña varchar(50),
	@PassPhrase varchar(50)
as
INSERT INTO Usuarios
	(Usuario, Contraseña)
values
	(@Usuario, EncryptByPassPhrase(@PassPhrase, @Contraseña))


exec Usuarios_Validar 'juanperez', '123ABC', 'AppTurnos'

alter procedure Usuarios_Validar
	@Usuario varchar(50),
	@Contraseña varchar(50),
	@PassPhrase varchar(50)

as
	select * 
	from	Usuarios
	where	Usuario = @Usuario
			and CONVERT(VARCHAR(50), DECRYPTBYPassPhrase(@PassPhrase , Contraseña)) = @Contraseña