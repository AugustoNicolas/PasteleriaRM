
namespace Pasteleria
{
    partial class winGestorPedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winGestorPedido));
            this.lblTit = new System.Windows.Forms.Label();
            this.TxbIdTrabaj = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPedidosCerrados = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPedidosNoCerrados = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPedidosPen = new System.Windows.Forms.Button();
            this.ttMesagge = new System.Windows.Forms.ToolTip(this.components);
            this.DGPed = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGPed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTit.Location = new System.Drawing.Point(9, 14);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(141, 20);
            this.lblTit.TabIndex = 0;
            this.lblTit.Text = "Gestor de Pedidos";
            // 
            // TxbIdTrabaj
            // 
            this.TxbIdTrabaj.AcceptsReturn = true;
            this.TxbIdTrabaj.AcceptsTab = true;
            this.TxbIdTrabaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxbIdTrabaj.BackColor = System.Drawing.Color.Silver;
            this.TxbIdTrabaj.Enabled = false;
            this.TxbIdTrabaj.ForeColor = System.Drawing.Color.Maroon;
            this.TxbIdTrabaj.Location = new System.Drawing.Point(623, 4);
            this.TxbIdTrabaj.MaxLength = 100;
            this.TxbIdTrabaj.Name = "TxbIdTrabaj";
            this.TxbIdTrabaj.ReadOnly = true;
            this.TxbIdTrabaj.Size = new System.Drawing.Size(134, 20);
            this.TxbIdTrabaj.TabIndex = 1;
            this.TxbIdTrabaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(329, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 30);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnPedidosCerrados
            // 
            this.btnPedidosCerrados.AutoEllipsis = true;
            this.btnPedidosCerrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosCerrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosCerrados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosCerrados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPedidosCerrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPedidosCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosCerrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosCerrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPedidosCerrados.Location = new System.Drawing.Point(332, 65);
            this.btnPedidosCerrados.Name = "btnPedidosCerrados";
            this.btnPedidosCerrados.Size = new System.Drawing.Size(131, 33);
            this.btnPedidosCerrados.TabIndex = 4;
            this.btnPedidosCerrados.Text = "Cerrados";
            this.btnPedidosCerrados.UseVisualStyleBackColor = false;
            this.btnPedidosCerrados.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(163, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 30);
            this.panel3.TabIndex = 3;
            // 
            // btnPedidosNoCerrados
            // 
            this.btnPedidosNoCerrados.AutoEllipsis = true;
            this.btnPedidosNoCerrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosNoCerrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosNoCerrados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosNoCerrados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPedidosNoCerrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPedidosNoCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosNoCerrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosNoCerrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPedidosNoCerrados.Location = new System.Drawing.Point(166, 64);
            this.btnPedidosNoCerrados.Name = "btnPedidosNoCerrados";
            this.btnPedidosNoCerrados.Size = new System.Drawing.Size(150, 33);
            this.btnPedidosNoCerrados.TabIndex = 2;
            this.btnPedidosNoCerrados.Text = "En Proceso";
            this.btnPedidosNoCerrados.UseVisualStyleBackColor = false;
            this.btnPedidosNoCerrados.Click += new System.EventHandler(this.btnPedidosNoCerrados_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(13, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 30);
            this.panel2.TabIndex = 1;
            // 
            // btnPedidosPen
            // 
            this.btnPedidosPen.AutoEllipsis = true;
            this.btnPedidosPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPedidosPen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPedidosPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPedidosPen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosPen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPedidosPen.Location = new System.Drawing.Point(16, 64);
            this.btnPedidosPen.Name = "btnPedidosPen";
            this.btnPedidosPen.Size = new System.Drawing.Size(139, 33);
            this.btnPedidosPen.TabIndex = 0;
            this.btnPedidosPen.Text = "Pendientes";
            this.btnPedidosPen.UseVisualStyleBackColor = false;
            this.btnPedidosPen.Click += new System.EventHandler(this.btnPedidosPen_Click);
            // 
            // ttMesagge
            // 
            this.ttMesagge.BackColor = System.Drawing.Color.DarkOrange;
            this.ttMesagge.ForeColor = System.Drawing.Color.White;
            this.ttMesagge.IsBalloon = true;
            this.ttMesagge.Popup += new System.Windows.Forms.PopupEventHandler(this.ttMesagge_Popup);
            // 
            // DGPed
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGPed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGPed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGPed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DGPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGPed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGPed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.DGPed.GridColor = System.Drawing.Color.Maroon;
            this.DGPed.Location = new System.Drawing.Point(15, 117);
            this.DGPed.MultiSelect = false;
            this.DGPed.Name = "DGPed";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPed.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGPed.RowHeadersWidth = 15;
            this.DGPed.RowTemplate.Height = 24;
            this.DGPed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPed.Size = new System.Drawing.Size(567, 267);
            this.DGPed.TabIndex = 9;
            this.DGPed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPed_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "check";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.Width = 58;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.Location = new System.Drawing.Point(201, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAsignar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Maroon;
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAsignar.Location = new System.Drawing.Point(55, 405);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(126, 39);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "    Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // winGestorPedido
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(604, 471);
            this.Controls.Add(this.DGPed);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.TxbIdTrabaj);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.btnPedidosCerrados);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnPedidosNoCerrados);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPedidosPen);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "winGestorPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "winGestorPedido";
            this.Load += new System.EventHandler(this.winGestorPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.TextBox TxbIdTrabaj;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPedidosCerrados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPedidosNoCerrados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPedidosPen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ToolTip ttMesagge;
        private System.Windows.Forms.DataGridView DGPed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}