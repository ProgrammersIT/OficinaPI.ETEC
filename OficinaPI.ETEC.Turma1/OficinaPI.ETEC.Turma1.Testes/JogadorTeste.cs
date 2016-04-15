/*
 * Created by SharpDevelop.
 * User: lazaro.menezes
 * Date: 13/04/2016
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace OficinaPI.ETEC.Turma1.Testes
{
	/// <summary>
	/// Description of JogadorTeste.
	/// </summary>
	public class JogadorTeste
	{
		[Test]
		public void JogadorEscolheUmaOpcaoValida()
		{
			var jogador = new Jogador("Pedra");
			var opcao = jogador.EscolheOpcao();
			
			var resultadoValido = 
				opcao == "Pedra" || 
				opcao == "Papel" || 
				opcao == "Tesoura";
			
			Assert.IsTrue(resultadoValido);
		}
		
	}
}
