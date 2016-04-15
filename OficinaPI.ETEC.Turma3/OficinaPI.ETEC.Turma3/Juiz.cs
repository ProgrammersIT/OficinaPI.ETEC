using System;

namespace OficinaPI.ETEC.Turma3
{
	public class Juiz
	{
		public bool ValidarJogada(int jogada)
		{
			if(jogada != 1 && jogada != 2 && jogada != 3)
				return false;
			
			return true;
		}
		
		public bool VerSeEhEmpate(int jogada1, int jogada2){
			
			var retornojogada1 = ValidarJogada(jogada1);
			var retornojogada2 = ValidarJogada(jogada2);
			
			if(retornojogada1 == false || retornojogada2 == false)
				throw new JogadaInvalidaException();
				
			return jogada1 == jogada2;
		}
		
		public int DefinirJogadaVencedora(int jogada1, int jogada2)
		{
			var retornojogada1 = ValidarJogada(jogada1);
			var retornojogada2 = ValidarJogada(jogada2);
			
			if(retornojogada1 == false || retornojogada2 == false)
				throw new JogadaInvalidaException();
			
			if(jogada1 == 3 && jogada2 == 2 || jogada1 == 1 && jogada2 == 3 || jogada1 == 2 && jogada2 == 1)
				return jogada1;
			
			return jogada2;
		}
		
		public string Verresultado(int jogada1,int jogada2){
			
			if(VerSeEhEmpate(jogada1, jogada2))
				return "empate";
			
			return "";
		}
	}
}