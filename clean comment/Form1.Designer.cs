namespace clean_comment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelTop.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 32);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panelIzq.Controls.Add(this.label4);
            this.panelIzq.Controls.Add(this.label3);
            this.panelIzq.Controls.Add(this.label2);
            this.panelIzq.Controls.Add(this.button1);
            this.panelIzq.Controls.Add(this.label1);
            this.panelIzq.Controls.Add(this.pictureBox1);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 32);
            this.panelIzq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(303, 418);
            this.panelIzq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tangerine", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "NicoS App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.panelMain.Controls.Add(this.richTextBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(303, 32);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(597, 418);
            this.panelMain.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.button1.Image = global::clean_comment.Properties.Resources.ai;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clean_comment.Properties.Resources.milogosinnombre2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elimina Los Comentarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "de tus archivos de texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(55, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "o arrasta y suelta tu archivo";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::clean_comment.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(832, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::clean_comment.Properties.Resources.icons8_close_48;
            this.btnClose.Location = new System.Drawing.Point(863, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.richTextBox1.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(204)))));
            this.richTextBox1.Location = new System.Drawing.Point(24, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 381);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

