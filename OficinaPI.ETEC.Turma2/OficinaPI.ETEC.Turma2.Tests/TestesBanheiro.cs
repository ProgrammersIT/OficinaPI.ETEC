using System;
using NUnit.Framework;

namespace OficinaPI.ETEC.Turma2.Tests
{

	public class TestesBanheiro
	{
		[Test]
		public void TestaTemUmMictorioQueEstaVazio(){
			
			var banheiro = new Banheiro();
			var mictorio = new Mictorio{
				Ocupado = false
			};
			
			banheiro.AdicionarMictorio(mictorio);
						
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(1 , pessoas);			
		}
		
		[Test]
		public void TestaTemUmMictorioQueEstaOcupado(){
			
			var banheiro = new Banheiro();
			var mictorio = new Mictorio{
				Ocupado = true
			};
			
			banheiro.AdicionarMictorio(mictorio);
						
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(0 , pessoas);			
		}
		
		[Test]
		public void TestaTemDoisMictoriosQueEstamVazios()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = false
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = false
			};
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(1 , pessoas);
		}
		
		[Test]
		public void TestaTemDoisMictoriosCom_O_PrimeiroOcupado_E_O_SegundoVazio()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = true
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = false
			};
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(0 , pessoas);
		}
		
		[Test]
		public void TestaTemDoisMictoriosCom_O_PrimeiroVazio_E_O_SegundoOcupado()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = false
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = true
			};
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(0 , pessoas);
		}
		
		[Test]
		public void TestaTemDoisMictoriosComOsDoisMictoriosOcupado()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = true
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = true
			};
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(0 , pessoas);
		}
		
		[Test]
		public void TestaTemTresMictoriosComODoMeioOcupado()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = false
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = true
			};
			
			var mictorio3 = new Mictorio{
				Ocupado = false
			};			
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			banheiro.AdicionarMictorio(mictorio3);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(0 , pessoas);
		}	

		[Test]
		public void TestaTemTresMictorios_E_So_O_PrimeiroOcupado()
		{
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{
				Ocupado = true
			};
			
			var mictorio2 = new Mictorio{
				Ocupado = false
			};
			
			var mictorio3 = new Mictorio{
				Ocupado = false
			};			
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			banheiro.AdicionarMictorio(mictorio3);
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(1 , pessoas);
		}
		
		[Test]
		public void TestaBanheiroComSeisMictoriosComSegundo_E_O_QuartoOcupado(){
			var banheiro = new Banheiro();
			
			var mictorio1 = new Mictorio{ Ocupado = false };
			var mictorio2 = new Mictorio{ Ocupado = true };
			var mictorio3 = new Mictorio{ Ocupado = false };
			var mictorio4 = new Mictorio{ Ocupado = true };
			var mictorio5 = new Mictorio{ Ocupado = false };
			var mictorio6 = new Mictorio{ Ocupado = false };
			
			banheiro.AdicionarMictorio(mictorio1);
			banheiro.AdicionarMictorio(mictorio2);
			banheiro.AdicionarMictorio(mictorio3);
			banheiro.AdicionarMictorio(mictorio4);
			banheiro.AdicionarMictorio(mictorio5);
			banheiro.AdicionarMictorio(mictorio6);
			
			var pessoas = banheiro.QuantasPessoasPodemEntrar();
			
			Assert.AreEqual(1 , pessoas);
		}
	}
}
