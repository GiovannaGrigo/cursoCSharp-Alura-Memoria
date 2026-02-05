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


// Stopwatch sw = new Stopwatch();

// for (int i = 0; i < 100000000; i++)
// {
//     Coordenada coordenada = new Coordenada(123.456, -123.456);
//     var latitude = coordenada.Latitude;
//     var longitude = coordenada.Longitude;
// }

// sw.Stop();

// Console.WriteLine(sw.Elapsed.TotalMilliseconds);

// FormularioDto dto = new FormularioDto("Giovanna", "111111111", "Dev") { Idade = 19 };
// Console.WriteLine($"Valor do nome: {dto.Nome}");

// FormularioDto dto2 = new FormularioDto();
// dto.Nome = "Giovanna";
// dto.Idade = 19;
// dto.Cargo = "Dev";
// dto.Cpf = "1234567890";

// Console.WriteLine(dto == dto2);

UsuarioDto dto1 = new UsuarioDto();
dto1.Nome = "Giovanna";
dto1.Email = "giovanna@email.com";
dto1.Telefones = new List<string>();

UsuarioDto dto2 = new UsuarioDto();
dto2.Nome = "Giovanna";
dto2.Email = "giovanna@email.com";
dto2.Telefones = new List<string>();

Console.WriteLine(dto1 == dto2);