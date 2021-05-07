
namespace TareaBasesDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSQLServer = new System.Windows.Forms.Button();
            this.buttonMySQL = new System.Windows.Forms.Button();
            this.buttonOracle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSQLServer
            // 
            this.buttonSQLServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSQLServer.Location = new System.Drawing.Point(268, 125);
            this.buttonSQLServer.Name = "buttonSQLServer";
            this.buttonSQLServer.Size = new System.Drawing.Size(122, 40);
            this.buttonSQLServer.TabIndex = 0;
            this.buttonSQLServer.Text = "SQL Server";
            this.buttonSQLServer.UseVisualStyleBackColor = true;
            this.buttonSQLServer.Click += new System.EventHandler(this.buttonSQLServer_Click);
            // 
            // buttonMySQL
            // 
            this.buttonMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMySQL.Location = new System.Drawing.Point(268, 182);
            this.buttonMySQL.Name = "buttonMySQL";
            this.buttonMySQL.Size = new System.Drawing.Size(122, 40);
            this.buttonMySQL.TabIndex = 1;
            this.buttonMySQL.Text = "MySQL";
            this.buttonMySQL.UseVisualStyleBackColor = true;
            this.buttonMySQL.Click += new System.EventHandler(this.buttonMySQL_Click);
            // 
            // buttonOracle
            // 
            this.buttonOracle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOracle.Location = new System.Drawing.Point(268, 239);
            this.buttonOracle.Name = "buttonOracle";
            this.buttonOracle.Size = new System.Drawing.Size(122, 40);
            this.buttonOracle.TabIndex = 2;
            this.buttonOracle.Text = "Oracle";
            this.buttonOracle.UseVisualStyleBackColor = true;
            this.buttonOracle.Click += new System.EventHandler(this.buttonOracle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIJA UN MOTOR DE BASE DE DATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOracle);
            this.Controls.Add(this.buttonMySQL);
            this.Controls.Add(this.buttonSQLServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSQLServer;
        private System.Windows.Forms.Button buttonMySQL;
        private System.Windows.Forms.Button buttonOracle;
        private System.Windows.Forms.Label label1;
    }
}

