# Pc1 - newSchool - Jose Ampudia


## Pasos
1. Instalar dependencias
   * Microsoft.AspNetCore.OpenApi v 7.0.4
   * Swashbuckle.AspNetCore v 6.5.0
   * Automapper v 12.0.1
   * Automapper.Extensions.Microsoft.DependencyInjection v 12.0.1
   * MySql.EntityFrameworkCore v 7.0.5
   * Microsoft.EntityFrameworkCore.Relational v 8.0.0-preview.3.23174.2
   * Microsoft.EntityFrameworkCore v 8.0.0-preview.3.23174.2
   * Microsoft.EntityFrameworkCore.Relational.Design 2.0.0-preview1-final


2. Crear Bounded context Profiles

3. Crear carpeta Shared

4. Dentro de Profiles, crear Domain, Controllers, Mapping, Persistence, Resources, Services

5. Dentro de Profiles/Domain , crear la carpeta Models y la entidad Student.cs

6. Agregar los atributos a la entidad Student.cs

7. Copiar la carpeta Shared, cambiar los nombres de los namespaces para que se adecúen al proyecto

8. Dentro de Shared/Perstistence/Contexts/AppDbContext cambiar los properties para que se adecúen al enunciado

9. Dentro de Profiles/Services crear el archivo StudentService

10. Dentro de Profiles/Resources crear SaveStudentResource y StudentResource
    
11. Dentro de Profiles/Domain crear la carpeta Repositories, y dentro crear IStudentRepository

12. Dentro de Profiles/Domain crear la carpeta Services, y dentro crear IStudentService, adicionalmente crear la carpeta Communication y dentro crear StudentResponse

13. Dentro de Profiles/Persistence crear la carpeta Repositories, y dentro crear StudentRepository

14. Dentro de Profiles/Mapping crear los archivos ResourceToModelProfile y ModelToResourceProfile

15. Dentro de Profiles/Resources crear los archivos SaveStudentResource y StudentResource

16. Dentro de Profiles/Controllers crear el archivo StudentsController

17. Modificar el archivo Program.cs

18. Modificar los puertos http y https a 8080 en Properties/launchSettings.json

19. Modificar el archivo appsettings.json para agregar defaultconnection, nombre de la base de datos, contraseña

   