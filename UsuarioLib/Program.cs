using UsuarioLib;

//Usuario usuario = 
//    new Usuario(
//        "Daniel", 
//        "daniel@email.com",
//        new List<string>() {"12345678"});

//Usuario usuario2 =
//    new Usuario(
//        "Luis",
//        "luis@email.com",
//        new List<string>() { "87654321" });


////12345678
//usuario.ExibeTelefones();

////efetuar a padronização
//usuario.PadronizaTelefones();

////912345678
//usuario.ExibeTelefones();

FormularioDTO usuario1 = new FormularioDTO(
    "Daniel@email.com",
    "Gerente",
    190)
    { Name = "Daniel" };

FormularioDTO usuario2 = new FormularioDTO(
    "Daniel@email.com",
    "gerente",
    190)
{
    Name = "Daniel",
};

Console.WriteLine(usuario1 == usuario2);