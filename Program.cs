﻿// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// // conversao de tipo string para data
// dtData = DateTime.Parse(strdata [i]);
// // exibição da data no formato DateTime
// Console.WriteLine("Confirma a data digitada? " + dtData);
// // esperando pressionar qualquer tecla para finalizar a aplicação
// Console.ReadKey();





static void formularioViagem(){

string [] nome = new string [5];
string [] origem = new string [5];
string [] destino = new string [5];
string [] strdata = new string [5];


for (int i = 0; i < 5; i++)
{


Console.WriteLine($"Passageiro {i + 1}, preencha o seguinte formulario para o cadastro de sua viagem");


    Console.WriteLine($"Digite o seu nome:");
nome [i] = Console.ReadLine();


Console.WriteLine($"Digite a origem do seu voo:");
origem [i] = Console.ReadLine();

Console.WriteLine($"Digite o destino do seu voo:");
destino [i] = Console.ReadLine();



Console.WriteLine($"Digite a data do seu voo:");
Console.WriteLine("Favor digitar uma data no formato 'dd/mm/yyyy':");
// leitura do valor informado
strdata [i] = Console.ReadLine();
}
}



// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
 static void validacaoDeUsuario()
{
bool senhafalsa = true;

Console.WriteLine($"Antes de entrar em nosso sistema, confirme que e voce viajante:");
Console.WriteLine($"");


Console.WriteLine($"Digite seu nome de usuario:");
string user = Console.ReadLine();

Console.WriteLine($"Digite sua senha:");
string senha = Console.ReadLine();


do {Console.WriteLine($"Senha incorreta, digite novamente sua senha: ");
senha = Console.ReadLine();

if(senha == "123456")
{senhafalsa = false;}


}
while (senhafalsa);

Console.WriteLine($"Seja bem vindo {user}");

}

static void listaDePassagens()
{
Console.WriteLine(@$"Lista de passagens disponiveis:

1 - Japao
2 - Italia
3 - EUA
4 - China
5 - Argentina
");
}




validacaoDeUsuario();


Console.WriteLine(@$"Bem vindo ao sistema de passagens aereas viajante!

Selecione uma das opcoes abaixo para continuar:

        ------------------------------------------
        | 1 - Cadastrar passagem (5 viajantes)  |
        | 2 - Listar Passagens                  |
        | 0 - Sair                              |
        ------------------------------------------
");

Console.WriteLine($"Digite '1' , '2' ou '0' para continuar:");
Console.WriteLine($"");

char opcoes = char.Parse(Console.ReadLine());

switch (opcoes)
{
    case '1':
    formularioViagem();
        break;
        case '2':
    listaDePassagens();
    break;
    default:
    Console.WriteLine($"Saida autorizada, ate a proxima viajante;)");
    
        break;
}



