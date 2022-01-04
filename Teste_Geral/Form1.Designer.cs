namespace Teste_Geral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.listArquivos = new System.Windows.Forms.ListView();
            this.btnAbrixXML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivos:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(12, 398);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(11, 13);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "*";
            // 
            // listArquivos
            // 
            this.listArquivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.id,
            this.descricao,
            this.qtde,
            this.unitario,
            this.valor});
            this.listArquivos.FullRowSelect = true;
            this.listArquivos.HideSelection = false;
            this.listArquivos.Location = new System.Drawing.Point(12, 109);
            this.listArquivos.Name = "listArquivos";
            this.listArquivos.Size = new System.Drawing.Size(776, 275);
            this.listArquivos.TabIndex = 3;
            this.listArquivos.UseCompatibleStateImageBehavior = false;
            this.listArquivos.View = System.Windows.Forms.View.Details;
            // 
            // btnAbrixXML
            // 
            this.btnAbrixXML.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrixXML.Image")));
            this.btnAbrixXML.Location = new System.Drawing.Point(736, 390);
            this.btnAbrixXML.Name = "btnAbrixXML";
            this.btnAbrixXML.Size = new System.Drawing.Size(52, 50);
            this.btnAbrixXML.TabIndex = 4;
            this.btnAbrixXML.UseVisualStyleBackColor = true;
            this.btnAbrixXML.Click += new System.EventHandler(this.btnAbrixXML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Op:";
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(69, 7);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(285, 20);
            this.txtOp.TabIndex = 6;
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(69, 35);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(486, 20);
            this.txtNF.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NFe:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(486, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(325, 390);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(87, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor:";
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 40;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 350;
            // 
            // qtde
            // 
            this.qtde.Text = "Quantidade";
            this.qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtde.Width = 100;
            // 
            // unitario
            // 
            this.unitario.Text = "Unitario";
            this.unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitario.Width = 100;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbrixXML);
            this.Controls.Add(this.listArquivos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ListView listArquivos;
        private System.Windows.Forms.Button btnAbrixXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOp;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader qtde;
        private System.Windows.Forms.ColumnHeader unitario;
        private System.Windows.Forms.ColumnHeader valor;
    }
}

