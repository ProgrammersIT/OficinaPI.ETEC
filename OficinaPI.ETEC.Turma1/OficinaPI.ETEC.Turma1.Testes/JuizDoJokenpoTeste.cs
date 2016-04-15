using System;
using NUnit.Framework;

namespace OficinaPI.ETEC.Turma1.Testes
{

	public class JuizDoJokenpoTeste
	{
		[TestCase("Tesoura", "Pedra")]
		[TestCase("Papel", "Tesoura")]
		[TestCase("Pedra", "Papel")] 		
		public void Jogador1Vence(string jogada1, string jogada2){
			var jogador1 = new Jogador(jogada2);
			var jogador2 = new Jogador(jogada1);
			var juiz = new JuizJokenPo();
			
			Jogador vencedor = juiz.declaraOVencedor(jogador1, jogador2);
			
			Assert.AreEqual(jogador1, vencedor);
		}
		
		[TestCase("Tesoura", "Pedra")]
		[TestCase("Papel", "Tesoura")]
		[TestCase("Pedra", "Papel")]
		public void Jogador2Vence(string jogada1, string jogada2)
		{
			var jogador1 = new Jogador(jogada1);
			var jogador2 = new Jogador(jogada2);
			var juiz = new JuizJokenPo();
			
			Jogador vencedor = juiz.declaraOVencedor(jogador1, jogador2);
			
			Assert.AreEqual(jogador2, vencedor);
		}
		
		
		[Test]
		public void JuizDeclaraEmpate()
		{
			var jogador1 = new Jogador("Pedra");
			var jogador2 = new Jogador("Pedra");
			
			var juiz = new JuizJokenPo();
			
			Jogador resultado = juiz.declaraOVencedor(jogador1, jogador2);
			
			Assert.IsNull(resultado);		
		}

	}
}