using System;
using System.Collections.Generic;
using System.Linq;

namespace OficinaPI.ETEC.Turma2
{
	public class Banheiro
	{
		List<Mictorio> mictorios=new List<Mictorio>();
		
		public void AdicionarMictorio(Mictorio novoMictorio){
			mictorios.Add(novoMictorio);
		}
		
		public int QuantasPessoasPodemEntrar(){
			
			if(mictorios.All(mictorio => mictorio.Ocupado))
			   return 0;
			
			if(mictorios.All(mictorio => !mictorio.Ocupado))
			   return mictorios.Count / 2 + mictorios.Count % 2;
			
			var total = mictorios.Count;
			var i = 0;
			var pessoas = 0;
			
			do{
				if(mictorios[i].Ocupado) {
					if (pessoas > 0)
						pessoas --;
					
					i++;
				}
				else pessoas ++; 
				
				i++;
			}while(i < total);
			
			return pessoas; 
		}
	}
}
