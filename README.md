# Lanzar el proyecto 
## a tener en cuenta ..
1- Crear base de datos SQLServer con el nombre : ReservasMVC 
2 - Cambiar cadena de conexion de configuration. .json file
      Add-Migration -Context ApplicationDbContext "name" --> no deberia hacer falta 
      Add-Migration -Context ReservasDbContext "anothername" --> no deberia hacer falta 
      Update-Database -Contex NombreContext (uno por cada contexto)

# ExamenFinalPOONet
NOTAS: he puesto como titulo ALQUILERMVC en vez de parking .. no lei bien el ejercicio al principio

Resquisitos funcionales : 

  #### Registro de usuarios : funciona correctamente con EFcore +  Identity (ApplicationDbContext : DbContext) 
  #### Inicio de sesion : funciona correctamente con EFcore +  Identity (ApplicationDbContext : DbContext) 

  #### Gestion de reservas : 
      -  el usuario dispones de un boton de crear reserva desde el Home una vez esta autenticado y autorizado
        - el modelo de Reserva en (/Model/Reserva) contiene las propiedades necesarias para hacer un scaffolding con EF usando el DbContext (/Data/ReservasDbContext.cs) (ReservasDbContext : DbContext).
        - a la vista del escaffolding de EF para Crear y editar le he añadido un DataPicker y TimePicker de JQuery. -> testeados : funcionando -> añadiendo opciones para maximo 10 dias de parking (todo en front si se metiera un valor no valido no hay 
        corroborracion con l base de datos )
        - tambien he creado una pequeña funcionalidad para crear un placeholder en el formulario para la ubicacion ya que al principo queria otra tabla cin ubis pero he decidido poner un valor por defecto 
        bloquear el campo input y placeholdear el valor que tendra por defecto. 
        - otros: algun estilo ha sido modificado 
  
  #### Confirmacion de la reserva : no esta implementada
   
                      
