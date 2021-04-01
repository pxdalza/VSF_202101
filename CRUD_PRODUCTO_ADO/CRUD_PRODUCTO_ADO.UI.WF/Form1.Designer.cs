namespace CRUD_PRODUCTO_ADO.UI.WF
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::CRUD_PRODUCTO_ADO.UI.WF.Properties.Resources.categoria;
            this.button2.Location = new System.Drawing.Point(399, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Administrar Categorias";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.Image = global::CRUD_PRODUCTO_ADO.UI.WF.Properties.Resources.producto1;
            this.btnProducto.Location = new System.Drawing.Point(206, 165);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(161, 91);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "Administrar Productos";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(737, 58);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Bienvenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_PRODUCTO_ADO.UI.WF.Properties.Resources.bg_main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMessage;
    }
}

