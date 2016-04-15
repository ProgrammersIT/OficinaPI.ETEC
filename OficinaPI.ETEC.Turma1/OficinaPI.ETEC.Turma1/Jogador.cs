/*
 * Created by SharpDevelop.
 * User: lazaro.menezes
 * Date: 13/04/2016
 * Time: 19:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OficinaPI.ETEC.Turma1
{
	/// <summary>
	/// Description of Jogador.
	/// </summary>
	public class Jogador
	{
		public Jogador(string opcao){
			PremeditaResultado = opcao;
		}
		
		public string EscolheOpcao(){
			return PremeditaResultado;
		}
		
		public string PremeditaResultado { get; set; }
	}
}
