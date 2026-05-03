# PROYM5MOVIEAPP

# PROYM5MOVIEAPP
# Dosier del Proyecto — CineApp

Cuando empecé a pensar en qué tema hacer el proyecto, la primera idea que se me ocurrió fue hacer una aplicación de baloncesto, concretamente de la NBA, ya que me gusta este deporte. El problema fue que las APIs gratuitas que encontré no tenían suficientes datos o requerían un pago, así que tuve que descartarlo.

Entonces pensé en otro tema que me gusta: las películas, las series y el anime. El anime ya lo había escogido una compañera, así que me decanté por las películas y series, que también me gustan bastante.

La API que encontré fue TMDB (The Movie Database), que es gratuita, fácil de usar y tiene mucha información actualizada constantemente. Me pareció perfecta para el proyecto

# Esquema de arquitectura

[Navegador] → petición HTTP → [Controller]
                                    ↓
                              [Service] → GET request → [API TMDB]
                                    ↓                        ↓
                              [Model] ← JSON deserializado ←─┘
                                    ↓
                              [View] → HTML → [Navegador]

# Explicación del código MVC

# Modelo
Los modelos Movie.cs y TvShow.cs representan los datos que devuelve la API. Se utiliza el atributo [JsonProperty] de la librería Newtonsoft.Json para indicar qué campo del JSON corresponde a cada propiedad del modelo.

# Vista
Las vistas Movies/Index.cshtml y Series/Index.cshtml utilizan Razor para mezclar HTML con C#. Reciben los datos del controlador y los muestran en la página con @foreach. El diseño se ha hecho con Bootstrap 5 y CSS propio para darle un estilo de tema oscuro, inspirado en plataformas de streaming.

# Controlador
Los controladores MoviesController.cs y SeriesController.cs gestionan las rutas /Movies y /Series. Cada controlador llama al servicio para obtener los datos y los pasa a la vista con return View(datos).

# Servicio
TmdbService.cs es la clase que se conecta con la API de TMDB. Hace la petición HTTP, recibe el JSON y utiliza Newtonsoft.Json para convertirlo en objetos C# que se pueden usar en las vistas. La API key se guarda en appsettings.json para no tenerla directamente en el código.
