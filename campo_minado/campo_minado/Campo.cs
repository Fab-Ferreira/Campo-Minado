using System;
using System.Drawing;
using System.Windows.Forms;

namespace campo_minado
{
	public class Campo : Label
	{
		public Campo()
		{
		}
		
		//Variáveis int
		public int[] bombas;
		public int columns, lines, quantidade, numL, numC, LocationX, LocationY, numeracao, valorQuant, variavel, i, flags, free, numCampos, numBombas;
		public int numberN, numberNE, numberE, numberSE, numberS, numberSW, numberW, numberNW;
		
		//Variáveis string
		public string[] campos, numero;
		public string campoN, campoNE, campoE, campoSE, campoS, campoSW, campoW, campoNW;
		
		//Variáveis boolean
		public bool marcado, repetido;
		
		//Vetores Label e instanciamento de Random
		public Label[] possiveisBomb, quantCampos, quantFreeCampos;
		public Random rand = new Random();
				
		//Definir características dos campos
		public void Caracteristica(Panel painel)
		{
			quantidade = 0;
			
			//Localização
			LocationX = (MainForm.ActiveForm.Width / 2) - (columns * 25) / 2;
			LocationY = (MainForm.ActiveForm.Height / 2) - (lines * 25) / 2;
			
			for(numL = 0; numL < lines; numL++)
			{
				for(numC = 0; numC <  columns; numC++)
				{
					quantCampos[quantidade] = new Label(); //Criar legenda
					quantCampos[quantidade].Parent = painel; //Inserí-la no Painel
					quantCampos[quantidade].BackColor = Color.Silver; //Cor cinza
					quantCampos[quantidade].Size = new Size(25, 25); //Tamanho 25x25
					quantCampos[quantidade].Location = new Point(LocationX, LocationY); //Localização
					quantCampos[quantidade].BorderStyle = BorderStyle.FixedSingle; //Definir estilo de borda
					quantCampos[quantidade].ForeColor = Color.Silver; //Definir cor da fonte para Prata
					quantCampos[quantidade].TextAlign = ContentAlignment.MiddleCenter; //Definir o alinhamento do texto
					quantCampos[quantidade].MouseDown += Tentativa; //Método do MouseDown "Tentativa"
					quantCampos[quantidade].Font = new Font("Arial", 8F, FontStyle.Bold); //Definir a fonte
					quantCampos[quantidade].Name = "campo" + quantidade; //Definir o nome
					
					quantidade += 1;
					LocationX += 25;
					
				}
				LocationX = (MainForm.ActiveForm.Width / 2) - (columns * 25) / 2;
				LocationY += 25;
			}
		}
		
		//Dificuldades
		public void Dificuldades(Panel painel, object sender)
		{
			//Clear
			i = 0;
			free = 0;
			variavel = 0;
			
			//Identificar qual botão foi clicado
			switch ((sender as Button).Name)
			{
				case "easy":
					columns = 10;
					lines = 10;
					numBombas = 20;
					flags = 20;
					break;
					
				case "medium":
					columns = 15;
					lines = 15;
					numBombas = 45;
					flags = 45;
					break;
					
				case "hard":
					columns = 20;
					lines = 20;
					numBombas = 80;
					flags = 80;
					break;
			}
			
			numCampos = columns * lines; //Definir número de campos
			quantCampos = new Label[numCampos]; //Definir o tamanho do vetor do número de campos

			Caracteristica(painel); //Chamar o método Caracteristica
			
			bombas = new int[numBombas]; //Definir o tamanho do vetor do número de bombas
			
			while (i < numBombas)
			{
				bombas[i] = rand.Next(0, numCampos); //Sortear aleatoriamente entre 0 à 99
				repetido = false;
				
				for(int rndm = 0; rndm < i; rndm++)
				{
					//Se o número já foi sorteado
					if(bombas[rndm] == bombas[i])
					{
						repetido = true;
					}
				}
				
				//Se não foi sorteado antes
				if(repetido == false)
				{
					quantCampos[bombas[i]].Text = "Bomb"; //Definir texto para "Bomb"
					i++;
				}
			}
			
			quantFreeCampos = new Label[numCampos - numBombas]; //Definir o tamanho do vetor do número de campos seguros
			
			//Guardar quais são os campos seguros
			while(variavel < numCampos)
			{
				if(quantCampos[variavel].Text != "Bomb") //Se for um campo seguro
				{
					quantFreeCampos[free] = quantCampos[variavel];
					free++;
				}
				
				variavel++;
			}
		}
		
		//IdentificarBotoes
		public void IdentificarBotoes(object sender)
		{
			//Definir tamanho dos vetores
			campos = new string[8];
			possiveisBomb = new Label[8];
			
			for(i = 0; i < 8; i++)
			{
				possiveisBomb[i] = new Label();
			}
			
			valorQuant = 0;
			
			//Separar o nome da label através do caracter 'o' (exemplo: campo21 -> camp, 21)
			numero = ((sender as Label).Name).Split('o');
			
			//Pegar o valor da segunda parte de "numero" (seguindo o exemplo acima, seria 21)
			numeracao = int.Parse(numero[1]);
			
			//Localizar todos os 8 campos ao redor do campo selecionado
			numberNW = numeracao - (columns + 1); //Noroeste
			numberN = numeracao - columns; //Norte
			numberNE = numeracao - (columns - 1); //Nordeste
			numberW = numeracao - 1; //Oeste
			numberE = numeracao + 1; //Leste
			numberSW = numeracao + (columns - 1); //Sudoeste
			numberS = numeracao + columns; //Sul
			numberSE = numeracao + (columns + 1); //Sudeste
	 		
			//Concatenação
			campoN = "campo" + numberN;
			campoNE = "campo" + numberNE;
			campoE = "campo" + numberE;
			campoSE = "campo" + numberSE;
			campoS = "campo" + numberS;
			campoSW = "campo" + numberSW;
			campoW = "campo" + numberW;
			campoNW = "campo" + numberNW;
			
			//Exceções (caso o campo selecionado esteja na borda)
			if(numeracao % columns == 0 && numeracao < columns)
			{
				campoSW = "";
				campoNW = "";
				campoW = "";
				campoN = "";
				campoNE = "";
			}
			
			else if(numeracao % columns == 0 && numeracao > (columns * lines) - (columns - 1))
			{
				campoSW = "";
				campoNW = "";
				campoW = "";
				campoS = "";
				campoSE = "";
			}
			
			else if(numeracao % columns == (columns - 1) && numeracao > (columns * lines) - (columns - 1))
			{
				campoSW = "";
				campoNE = "";
				campoE = "";
				campoS = "";
				campoSE = "";
			}
			
			else if(numeracao % columns == (columns - 1) && numeracao < columns)
			{
				campoNW = "";
				campoN = "";
				campoNE = "";
				campoE = "";
				campoSE = "";
			}
			
			else if(numeracao % columns == 0)
			{
				campoSW = "";
				campoNW = "";
				campoW = "";
			}
			
			else if(numeracao < columns)
			{
				campoNW = "";
				campoN = "";
				campoNE = "";
			}
			
			else if(numeracao % columns == (columns - 1))
			{
				campoSE = "";
				campoNE = "";
				campoE = "";
			}
			
			else if(numeracao > (columns * lines) - (columns - 1))
			{
				campoSW = "";
				campoS = "";
				campoSE = "";
			}
			
			//Guardar valores no vetor string "campos"
			campos[0] = campoNW;
			campos[1] = campoN;
			campos[2] = campoNE;
			campos[3] = campoW;
			campos[4] = campoE;
			campos[5] = campoSW;
			campos[6] = campoS;
			campos[7] = campoSE;
			
			//Guardar as labels no vetor "possiveisBomb" caso possua um dos nomes entre as labels ao redor da Label selecionada
			foreach (Label label in quantCampos)
			{
				for(i = 0; i < 8; i++)
				{
					if(label.Name == campos[i])
					{
						possiveisBomb[i] = label;
					}
				}
			}
			
			//Identificar quais das labels guardadas em "possiveisBomb" são bombas
			for(i = 0; i < 8; i++)
			{
				if(possiveisBomb[i].Text == "Bomb")
				{
					valorQuant++;
				}
			}
			
			//Inserir o número de bombas ao redor no Text da label selecionada
			(sender as Label).Text = valorQuant.ToString();
			
			//Colorir texto
			switch (valorQuant)
			{
				case 0: //Se valorQuant for 0
					(sender as Label).Text = "";
					break;
					
				case 1: //Se valorQuant for 1
					(sender as Label).ForeColor = Color.Fuchsia;
					break;
					
				case 2: //Se valorQuant for 2
					(sender as Label).ForeColor = Color.Blue;
					break;
								
				case 3: //Se valorQuant for 3
					(sender as Label).ForeColor = Color.Turquoise;
					break;
								
				case 4: //Se valorQuant for 4
					(sender as Label).ForeColor = Color.Lime;
					break;
								
				case 5: //Se valorQuant for 5
					(sender as Label).ForeColor = Color.Gold;
					break;
								
				case 6: //Se valorQuant for 6
					(sender as Label).ForeColor = Color.DarkOrange;
					break;
								
				case 7: //Se valorQuant for 7
					(sender as Label).ForeColor = Color.Red;
					break;
							
				case 8: //Se valorQuant for 8
					(sender as Label).ForeColor = Color.Maroon;
					break;
			}
		}
		
		//Ao clicar em um campo
		public void Tentativa(object sender, MouseEventArgs e)
		{
			//Se o usuário clicou com o botão esquerdo do mouse
			if(e.Button == MouseButtons.Left)
			{
				if((sender as Label).ForeColor == Color.Red)
				{
					//Remover imagem
					(sender as Label).Image = null;
					flags++;
				}
				
				//Se clicar na bomba
				if((sender as Label).Text == "Bomb")
				{
					//Para cada label em "quantCampos"
					foreach(Label label in quantCampos)
					{
						//Se a Label possuir o texto "Bomb"
						if(label.Text == "Bomb")
						{
							label.Text = "";
							label.ForeColor = Color.White;
							label.BackColor = Color.White;
							label.Image = Image.FromFile("bomb.png"); //Inserir imagem da bomba
						}
						
						//Desativar todos os campos
						label.Enabled = false;
					}
					
					MessageBox.Show("Você perdeu!");
				}
				
				(sender as Label).MouseDown -= Tentativa; //Remover método do MouseDown
				IdentificarBotoes(sender); //Chamar o método IdentificarBotoes
				(sender as Label).BackColor = Color.White; //Colorir o fundo da label para branco
				
				//Identificar se todos os campos seguros estão marcados
				for(i = 0; i < quantFreeCampos.Length; i++)
				{
					marcado = false;
					
					for(int j = 0; j < i; j++)
					{
						if(quantFreeCampos[j].BackColor != quantFreeCampos[i].BackColor)
						{
							marcado = true; //Indicar como verdadeiro caso algum campo seguro não estiver marcado ainda
						}
					}
				}
				
				//Identificar vitória
				if(marcado == false && (sender as Label).ForeColor != Color.White)
				{
					MessageBox.Show("Parabéns, você venceu!");
					
					foreach(Label label in quantCampos)
					{
						//Se a Label possuir o texto "Bomb"
						if(label.Text == "Bomb")
						{
							label.Text = "";
							label.ForeColor = Color.White;
							label.BackColor = Color.White;
							label.Image = Image.FromFile("bomb.png"); //Inserir imagem da bomba
							label.Enabled = false; //Desativar todos os campos
						}
					}
				}
			}
			
			//Senão, se o usuário clicou com o botão direito do mouse
			else if(e.Button == MouseButtons.Right)
			{
				//Se ja estiver com bandeirinha e quiser desmarcar
				if((sender as Label).ForeColor == Color.Red)
				{
					(sender as Label).Image = null;
					(sender as Label).ForeColor = Color.Silver;
					
					flags++;
				}
				else
				{
					//Se não ultrapassou o limite
					if(flags > 0)
					{
						(sender as Label).Image = Image.FromFile("flag.png"); //Inserir imagem da bandeira
						(sender as Label).ForeColor = Color.Red;
					
						flags--;
					}
					
					//Se ultrapassou
					else
					{
						MessageBox.Show("Bandeirinhas esgotadas!");
					}
				}
			}
		}
	}
}
