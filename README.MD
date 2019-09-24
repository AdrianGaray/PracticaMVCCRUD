# Practica de Desarrollo MVC 5 - EF6

#### CRUD MVC5 - EF6:

- Models: **Product - ManageViewModels - IdentityModels**
- Controllers: **ProductController - ManageController - AccountController**
- DataAnnotations.
- EntityFramework 6.
- Creacion de la Carpeta/Clase, **Context/StoreContext**, representa la conexino a la base de datos.

  > Se crea la Base de datos, y si no existe la BD, en la primera ejecucion la crea, lo mismo pasa con las tablas.

#### Tecnica de Migraciones

> En el **Package Manager Console** se ejecuta los siguientes comando.

#### Comandos de Migracion

- **Enable-Migrations**: habilita la migración en el proyecto. Y crea la carpeta llamada Migrations.
  Ej; _Enable-Migrations -ContextType "NombreContexto"_

- **Add-Migration**: prepara los cambios que se van agregar a la base de datos.
  Ej; _Add-Migration "NombreMigracion"_

- **Update-Database**: actualiza los cambios pendientes a la base de datos.
  Ej; _Update-Database_
