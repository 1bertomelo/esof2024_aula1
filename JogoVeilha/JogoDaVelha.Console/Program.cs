// See https://aka.ms/new-console-template for more information
using JogoVelha.App;

Console.WriteLine("Bem vindo ao jogo da Velha do H1!");
JogoDaVelhaApp jogoDaVelha = new JogoDaVelhaApp();
jogoDaVelha.IniciarJogo();
jogoDaVelha.RealizarJogada(jogoDaVelha.JogadorX, 1, 1);
jogoDaVelha.RealizarJogada(jogoDaVelha.JogadorO, 1, 2);

