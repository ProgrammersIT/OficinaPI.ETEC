/*
 * Created by SharpDevelop.
 * User: lazaro.menezes
 * Date: 13/04/2016
 * Time: 18:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OficinaPI.ETEC.Turma1
{
	/// <summary>
	/// Description of JuizJokenPo.
	/// </summary>
	public class JuizJokenPo
	{
		public Jogador declaraOVencedor(Jogador jogador1, Jogador jogador2) {
			var jogada1 = jogador1.EscolheOpcao();
			var jogada2 = jogador2.EscolheOpcao();
			
			
			if (EhEmpate(jogada1, jogada2))
				return null;
		
			if (jogada2 == "Pedra" && jogada1 == "Tesoura" ||
			    jogada2 == "Tesoura" && jogada1 == "Papel" || 
			    jogada2 == "Papel" && jogada1 == "Pedra")
				return jogador2;
			
			return jogador1;
		}
		
		private bool EhEmpate(string jogada1, string jogada2){
			return jogada1 == jogada2;
		}
	}
}
