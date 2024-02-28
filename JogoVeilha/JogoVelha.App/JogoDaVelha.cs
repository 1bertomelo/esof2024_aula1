using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha.App
{
	public class JogoDaVelhaApp
	{
		public Jogador JogadorX { get; private set; }
		public Jogador JogadorO { get; private set; }
		public Jogador JogadorDaVez { get; private set; }
		public bool JogoIniciado { get; private set; }
		public Tabuleiro Tabuleiro { get; private set; }
		public JogoDaVelhaApp()
		{
			JogoIniciado = false;

		}

		public void IniciarJogo()
		{
			JogoIniciado = true;
			Tabuleiro = new Tabuleiro();
			JogadorX = new Jogador("Jogador X", Simbolo.X);
			JogadorO = new Jogador("Jogador O", Simbolo.O);
			JogadorDaVez = JogadorX;
		}
		

		public void RealizarJogada(Jogador jogador, int linha, int coluna)
		{
			if (!JogoIniciado)
				throw new Exception("Jogo não iniciado, jogada não pode ser realizada");
		
			if(JogadorDaVez.Simbolo != jogador.Simbolo)
				throw new Exception("Jogada não realizada, o Jogador fazer jogadas seguidas");

			Tabuleiro.RealizaJogada(jogador, linha, coluna);

			JogadorDaVez = ProximoJogador();
		}

		private Jogador ProximoJogador()
		{
			return JogadorDaVez == JogadorX ? JogadorO : JogadorX;
		}

		public bool CelularOcupada(int linha, int coluna) =>
		 Tabuleiro.CelulaOcupada(linha, coluna);

		public Simbolo ObterValorCelula(int linha, int coluna)
		{
			return Tabuleiro.ValorCelula(linha, coluna);
		}

		public void ChecarVitoria()
		{

		}

	}
}
