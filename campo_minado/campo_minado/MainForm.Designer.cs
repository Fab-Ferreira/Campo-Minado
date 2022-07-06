namespace campo_minado
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button easy;
		private System.Windows.Forms.Button medium;
		private System.Windows.Forms.Button hard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button restart;
		private System.Windows.Forms.Label legenda;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.easy = new System.Windows.Forms.Button();
			this.medium = new System.Windows.Forms.Button();
			this.hard = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.restart = new System.Windows.Forms.Button();
			this.legenda = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// easy
			// 
			this.easy.BackColor = System.Drawing.Color.DimGray;
			this.easy.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.easy.ForeColor = System.Drawing.Color.White;
			this.easy.Location = new System.Drawing.Point(333, 222);
			this.easy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.easy.Name = "easy";
			this.easy.Size = new System.Drawing.Size(171, 50);
			this.easy.TabIndex = 0;
			this.easy.Text = "FÁCIL";
			this.easy.UseVisualStyleBackColor = false;
			this.easy.Click += new System.EventHandler(this.PlayEasyClick);
			// 
			// medium
			// 
			this.medium.BackColor = System.Drawing.Color.DimGray;
			this.medium.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medium.ForeColor = System.Drawing.Color.White;
			this.medium.Location = new System.Drawing.Point(509, 222);
			this.medium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.medium.Name = "medium";
			this.medium.Size = new System.Drawing.Size(171, 50);
			this.medium.TabIndex = 1;
			this.medium.Text = "MÉDIO";
			this.medium.UseVisualStyleBackColor = false;
			this.medium.Click += new System.EventHandler(this.PlayMediumClick);
			// 
			// hard
			// 
			this.hard.BackColor = System.Drawing.Color.DimGray;
			this.hard.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hard.ForeColor = System.Drawing.Color.White;
			this.hard.Location = new System.Drawing.Point(685, 222);
			this.hard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.hard.Name = "hard";
			this.hard.Size = new System.Drawing.Size(171, 50);
			this.hard.TabIndex = 2;
			this.hard.Text = "DIFÍCIL";
			this.hard.UseVisualStyleBackColor = false;
			this.hard.Click += new System.EventHandler(this.PlayHardClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(424, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 50);
			this.label1.TabIndex = 3;
			this.label1.Text = "CAMPO MINADO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// restart
			// 
			this.restart.BackColor = System.Drawing.Color.DimGray;
			this.restart.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restart.ForeColor = System.Drawing.Color.White;
			this.restart.Location = new System.Drawing.Point(32, 34);
			this.restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.restart.Name = "restart";
			this.restart.Size = new System.Drawing.Size(217, 50);
			this.restart.TabIndex = 4;
			this.restart.Text = "REINICIAR";
			this.restart.UseVisualStyleBackColor = false;
			this.restart.Visible = false;
			this.restart.Click += new System.EventHandler(this.RestartClick);
			// 
			// legenda
			// 
			this.legenda.BackColor = System.Drawing.Color.Transparent;
			this.legenda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.legenda.ForeColor = System.Drawing.Color.White;
			this.legenda.Location = new System.Drawing.Point(911, 222);
			this.legenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.legenda.Name = "legenda";
			this.legenda.Size = new System.Drawing.Size(324, 212);
			this.legenda.TabIndex = 5;
			this.legenda.Text = "Botão esquerdo do mouse para descobrir um campo novo;                            " +
	"                            Botão direito do mouse para inserir uma bandeirinha." +
	"";
			this.legenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.legenda.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(1315, 486);
			this.Controls.Add(this.legenda);
			this.Controls.Add(this.restart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hard);
			this.Controls.Add(this.medium);
			this.Controls.Add(this.easy);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "campo_minado";
			this.ResumeLayout(false);

		}
	}
}
