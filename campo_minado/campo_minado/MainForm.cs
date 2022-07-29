using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Código desenvolvido por Fabrício Prudente Ferreira (Fab Ferreira)
namespace campo_minado
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public Panel painel = new Panel();
		Campo campoClasse = new Campo();
		
		//Deixar ferramentas invisiveis ao iniciar a partida
		public void Invisible()
		{
			easy.Visible = false;
			medium.Visible = false;
			hard.Visible = false;
			label1.Visible = false;
			restart.Visible = true;
			legenda.Visible = true;
			
			restart.Location = new Point(Width - (restart.Width * 2), Height - (restart.Height * 4));
			legenda.Location = new Point((Width / 2) + 400, (Height / 2) - (legenda.Height / 2));
		}
		
		//Click do modo fácil
		void PlayEasyClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized; //Maximizar tela
			
			Invisible(); //Deixar invisível
			
			painel.Parent = this; //Inserir um Panel na tela
			painel.Size = new Size(Width, Height); //Definir tamanho
			
			campoClasse.Dificuldades(painel, sender); //Chamar o método Dificuldades
		}
		
		//Click do modo médio
		void PlayMediumClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized; //Maximizar tela
			
			Invisible(); //Deixar invisível
			
			painel.Parent = this; //Inserir um Panel na tela
			painel.Size = new Size(Width, Height); //Definir tamanho
			
			campoClasse.Dificuldades(painel, sender); //Chamar o método Dificuldades
		}
		
		//Click do modo difícil
		void PlayHardClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized; //Maximizar tela
			
			Invisible(); //Deixar invisível
			
			painel.Parent = this; //Inserir um Panel na tela
			painel.Size = new Size(Width, Height); //Definir tamanho
			
			campoClasse.Dificuldades(painel, sender); //Chamar o método Dificuldades
		}
		
		//Botão de Reiniciar
		void RestartClick(object sender, EventArgs e)
		{
			restart.Visible = false;
			legenda.Visible = false;
			
			//Resetar valores
			campoClasse.LocationX = 30;
			campoClasse.LocationY = 30;
			campoClasse.quantidade = 0;
			
			for(campoClasse.numL = 0; campoClasse.numL < campoClasse.lines; campoClasse.numL++)
			{
				for(campoClasse.numC = 0; campoClasse.numC < campoClasse.columns; campoClasse.numC++)
				{
					campoClasse.quantCampos[campoClasse.quantidade].Dispose(); //Excluir todos os campos
					campoClasse.quantidade += 1;
					
				}
			}
			
			easy.Visible = true;
			medium.Visible = true;
			hard.Visible = true;
			label1.Visible = true;
			
			WindowState = FormWindowState.Normal; //Definir tamanho do MainForm para padrão
		}
	}
}
