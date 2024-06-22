namespace proyectoCatalogo
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lvPeliculas = new System.Windows.Forms.ListBox();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbPelicula = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.FormattingEnabled = true;
            this.lvPeliculas.ItemHeight = 15;
            this.lvPeliculas.Location = new System.Drawing.Point(265, 12);
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(293, 94);
            this.lvPeliculas.TabIndex = 0;
            this.lvPeliculas.SelectedIndexChanged += new System.EventHandler(this.lvPeliculas_SelectedIndexChanged_1);
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(228, 264);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(98, 27);
            this.btnAgregarPelicula.TabIndex = 1;
            this.btnAgregarPelicula.Text = "Agregar";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pbPelicula
            // 
            this.pbPelicula.Image = ((System.Drawing.Image)(resources.GetObject("pbPelicula.Image")));
            this.pbPelicula.Location = new System.Drawing.Point(308, 308);
            this.pbPelicula.Name = "pbPelicula";
            this.pbPelicula.Size = new System.Drawing.Size(181, 108);
            this.pbPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPelicula.TabIndex = 4;
            this.pbPelicula.TabStop = false;
            this.pbPelicula.Click += new System.EventHandler(this.pbPelicula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 122);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbPelicula);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.lvPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAD";
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lvPeliculas;
        private Button btnAgregarPelicula;
        private Button button2;
        private Button button3;
        private PictureBox pbPelicula;
        private DataGridView dataGridView1;
    }
}