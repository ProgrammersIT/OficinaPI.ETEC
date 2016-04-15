/*
 * Created by SharpDevelop.
 * User: lazaro.menezes
 * Date: PAPEL5/04/TESOURA0PAPEL6
 * Time: PAPEL8:4PEDRA
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace OficinaPI.ETEC.Turma3.Tests
{
	public class JuizTeste
	{
		const int PAPEL = 1;
		const int TESOURA = 2;
		const int PEDRA = 3;
		
		Juiz juiz= new Juiz();
		
		[Test]
		public void ValidarJogada_Passando_PAPEL_Eh_Valido()
		{
			
			bool jogada = juiz.ValidarJogada(PAPEL);
			
			Assert.IsTrue(jogada);
		}
		
		[Test]
		public void ValidarJogada_Passando_TESOURA_Eh_Valido()
		{
			bool jogada = juiz.ValidarJogada(TESOURA);
			
			Assert.IsTrue(jogada);
		}		
		
		[Test]
		public void ValidarJogada_Passando_PEDRA_Eh_Valido()
		{
			bool jogada = juiz.ValidarJogada(PEDRA);
			
			Assert.IsTrue(jogada);
		}	

		[TestCase(4)]
		[TestCase(-PAPEL)]
		public void ValidarJogada_Passando_Diferente_De_PAPEL_TESOURA_PEDRA_Eh_Invalido(int valor)
		{
			bool jogada = juiz.ValidarJogada(valor);
			
			Assert.IsFalse(jogada);
		}		
		
		[TestCase(PAPEL, PAPEL)]
		[TestCase(TESOURA, TESOURA)]
		[TestCase(PEDRA, PEDRA)]
		public void Testa_se_jogadas_iguais_eh_empate(int jogada1, int jogada2)
		{
			var resultado = juiz.VerSeEhEmpate(jogada1, jogada2);
			
			Assert.IsTrue(resultado);
		}
				
		[TestCase(TESOURA, PEDRA)]

		public void Testa_se_jogadas_diferentes_nao_eh_empate(int jogada1, int jogada2)
		{
			var resultado = juiz.VerSeEhEmpate(jogada1, jogada2);
			
			Assert.IsFalse(resultado);
		}
		
		[TestCase(5, PEDRA)]
	    [TestCase(5, 4)]		
		[TestCase(5, PAPEL)]
		public void Testa_se_jogadas_invalidas_disparam_erro_ao_ver_se_eh_empate(int jogada1, int jogada2)
		{
			Assert.Throws<JogadaInvalidaException>(() =>
			        juiz.VerSeEhEmpate(jogada1, jogada2));
		}
		
		[TestCase(PEDRA, TESOURA, PEDRA)]
		[TestCase(PAPEL, PEDRA, PAPEL)]
		[TestCase(TESOURA, PAPEL,TESOURA)]
		[TestCase(PAPEL, TESOURA, TESOURA)]
		[TestCase(PEDRA, PAPEL, PAPEL)]
		[TestCase(TESOURA, PEDRA, PEDRA)]
		public void Testa_jogada1_Eh_Pedra_Eh_jogada2_Eh_Tesoura_PedraGanha(int jogada1, int jogada2, int jogadaVencedoraEsperada)
		{
			int jogadaVencedora =  juiz.DefinirJogadaVencedora(jogada1, jogada2);
			
			Assert.AreEqual(jogadaVencedoraEsperada, jogadaVencedora);
		}
		
		[Test]
		public void Testa_vencedor_com_jogada_invalida()
		{
			Assert.Throws<JogadaInvalidaException>(() =>
			        juiz.DefinirJogadaVencedora(5, PEDRA));
		}
		
		[Test]
		public void testa_ver_resultado_retorna_empate_se_for_empate(){
			var resultado=juiz.Verresultado(PEDRA,PEDRA);
			Assert.AreEqual("empate",resultado);
 		}
	}
}