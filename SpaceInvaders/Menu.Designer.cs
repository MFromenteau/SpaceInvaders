namespace SpaceInvaders
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gestion_joueur = new System.Windows.Forms.Button();
            this.Gestion_Enemy = new System.Windows.Forms.Button();
            this.Armurerie = new System.Windows.Forms.Button();
            this.creer_vaisseau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestion_joueur
            // 
            this.gestion_joueur.Location = new System.Drawing.Point(577, 23);
            this.gestion_joueur.Name = "gestion_joueur";
            this.gestion_joueur.Size = new System.Drawing.Size(137, 45);
            this.gestion_joueur.TabIndex = 0;
            this.gestion_joueur.Text = "Gestion Joueur";
            this.gestion_joueur.UseVisualStyleBackColor = true;
            this.gestion_joueur.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_Enemy
            // 
            this.Gestion_Enemy.Location = new System.Drawing.Point(577, 74);
            this.Gestion_Enemy.Name = "Gestion_Enemy";
            this.Gestion_Enemy.Size = new System.Drawing.Size(137, 63);
            this.Gestion_Enemy.TabIndex = 1;
            this.Gestion_Enemy.Text = "Gestion Ennemie";
            this.Gestion_Enemy.UseVisualStyleBackColor = true;
            this.Gestion_Enemy.Click += new System.EventHandler(this.button2_Click);
            // 
            // Armurerie
            // 
            this.Armurerie.Location = new System.Drawing.Point(577, 194);
            this.Armurerie.Name = "Armurerie";
            this.Armurerie.Size = new System.Drawing.Size(137, 45);
            this.Armurerie.TabIndex = 2;
            this.Armurerie.Text = "Armurerie";
            this.Armurerie.UseVisualStyleBackColor = true;
            this.Armurerie.Click += new System.EventHandler(this.Armurerie_Click);
            // 
            // creer_vaisseau
            // 
            this.creer_vaisseau.Location = new System.Drawing.Point(577, 143);
            this.creer_vaisseau.Name = "creer_vaisseau";
            this.creer_vaisseau.Size = new System.Drawing.Size(137, 45);
            this.creer_vaisseau.TabIndex = 3;
            this.creer_vaisseau.Text = "Créer Vaisseau";
            this.creer_vaisseau.UseVisualStyleBackColor = true;
            this.creer_vaisseau.Click += new System.EventHandler(this.creer_vaisseau_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 464);
            this.Controls.Add(this.creer_vaisseau);
            this.Controls.Add(this.Armurerie);
            this.Controls.Add(this.Gestion_Enemy);
            this.Controls.Add(this.gestion_joueur);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gestion_joueur;
        private System.Windows.Forms.Button Gestion_Enemy;
        private System.Windows.Forms.Button Armurerie;
        private System.Windows.Forms.Button creer_vaisseau;
    }
}