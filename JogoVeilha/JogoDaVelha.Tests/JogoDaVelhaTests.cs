using JogoVelha.App;

namespace JogoDaVelha.Tests
{
	public class JogoDaVelhaTests
	{
		[Fact(DisplayName = "Iniciar Jogo Da Velha - Tabuleiro Esta Vazio")]
		[Trait("Categoria", "Jogo Da Velha - IniciarJogo")]
		public void JogoDaVelha_IniciarTabuleiro_DeveEstarVazio()
		{
			//Arrange
			var jogoDaVelha = new JogoDaVelhaApp();

			//Act
			jogoDaVelha.IniciarJogo();

			//Assert
			bool TabuleiroEstaVazio = true;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (jogoDaVelha.Tabuleiro.matriz[i, j] != Simbolo.Vazio)
					{
						TabuleiroEstaVazio = false;
						break;
					}
				}
			}

			Assert.True(TabuleiroEstaVazio);

		}



		[Fact(DisplayName = "Jogador X Realizar uma Jogada - Celula preenchida com X")]
		[Trait("Categoria", "Jogo Da Velha - X realizar Jogada")]
		public void JogoDaVelha_JogadorXrealizarJogada_CelulaDeveEstarPreenchida()
		{
			//Arrange
			var jogoDaVelha = new JogoDaVelhaApp();

			//Act
			jogoDaVelha.IniciarJogo();
			Simbolo valorCelulaAntesJogada = jogoDaVelha.ObterValorCelula(0, 0);
			jogoDaVelha.RealizarJogada(jogoDaVelha.JogadorX, 0, 0);
			bool celulaOcupada = jogoDaVelha.CelularOcupada(0, 0);
			Simbolo valorCelulaOcupada = jogoDaVelha.ObterValorCelula(0, 0);

			//Assert

			Assert.Equal(Simbolo.Vazio , valorCelulaAntesJogada);
			Assert.True(celulaOcupada);
			Assert.Equal(Simbolo.X, valorCelulaOcupada);
		}

		[Fact(DisplayName = "Jogador X Realizar Jogadas Seguidas - Dispara Excepetion ")]
		[Trait("Categoria", "Jogo Da Velha - X Realizar Jogadas Seguidas")]
		public void JogoDaVelha_JogadorXrealizarJogadaSeguidas_ErroJogadaNaoPermitida()
		{
			//Arrange
			var jogoDaVelha = new JogoDaVelhaApp();

			//Act
			jogoDaVelha.IniciarJogo();
			jogoDaVelha.RealizarJogada(jogoDaVelha.JogadorX, 0, 0);

			//Assert
			var excecao = Assert.Throws<Exception>(() => jogoDaVelha.RealizarJogada(jogoDaVelha.JogadorX, 0, 0));
		
			Assert.Equal("Jogada não realizada, o Jogador fazer jogadas seguidas", excecao.Message);
		}
	}
}