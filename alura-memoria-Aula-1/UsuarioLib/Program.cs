using System.Diagnostics;
using UsuarioLib;

// Usuario usuario =
//     new Usuario(
//         "Giovanna",
//         "giovanna@email.com",
//         new List<string>() { "12345678" });

// //12345678
// usuario.ExibeTelefones();

// //efetuar a padronização
// usuario.PadronizaTelefones();

// //912345678
// usuario.ExibeTelefones();


Stopwatch sw = new Stopwatch();

for (int i = 0; i < 100000000; i++)
{
    Coordenada coordenada = new Coordenada(123.456, -123.456);
    var latitude = coordenada.Latitude;
    var longitude = coordenada.Longitude;
}

sw.Stop();

Console.WriteLine(sw.Elapsed.TotalMilliseconds);