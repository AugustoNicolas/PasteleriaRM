
namespace Pasteleria
{
    partial class winAsignarPed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAsignar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnUndo = new FontAwesome.Sharp.IconPictureBox();
            this.DGTrabajador = new System.Windows.Forms.DataGridView();
            this.cbkTrabajador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsignar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsignar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnAsignar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignar.IconSize = 43;
            this.btnAsignar.Location = new System.Drawing.Point(17, 148);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(1);
            this.btnAsignar.Rotation = 1D;
            this.btnAsignar.Size = new System.Drawing.Size(61, 43);
            this.btnAsignar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.TabStop = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 43;
            this.btnCerrar.Location = new System.Drawing.Point(241, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Rotation = 1D;
            this.btnCerrar.Size = new System.Drawing.Size(61, 43);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUndo.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnUndo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUndo.IconSize = 43;
            this.btnUndo.Location = new System.Drawing.Point(17, 197);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Padding = new System.Windows.Forms.Padding(1);
            this.btnUndo.Rotation = 1D;
            this.btnUndo.Size = new System.Drawing.Size(61, 43);
            this.btnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnUndo.TabIndex = 5;
            this.btnUndo.TabStop = false;
            // 
            // DGTrabajador
            // 
            this.DGTrabajador.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.DGTrabajador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTrabajador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbkTrabajador});
            this.DGTrabajador.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGTrabajador.Location = new System.Drawing.Point(101, 74);
            this.DGTrabajador.MultiSelect = false;
            this.DGTrabajador.Name = "DGTrabajador";
            this.DGTrabajador.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTrabajador.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGTrabajador.RowHeadersVisible = false;
            this.DGTrabajador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGTrabajador.RowTemplate.Height = 24;
            this.DGTrabajador.Size = new System.Drawing.Size(200, 246);
            this.DGTrabajador.TabIndex = 6;
            this.DGTrabajador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGTrabajador.SelectionChanged += new System.EventHandler(this.DGTrabajador_SelectionChanged);
            // 
            // cbkTrabajador
            // 
            this.cbkTrabajador.HeaderText = "Check";
            this.cbkTrabajador.MinimumWidth = 6;
            this.cbkTrabajador.Name = "cbkTrabajador";
            this.cbkTrabajador.ReadOnly = true;
            this.cbkTrabajador.Width = 60;
            // 
            // winAsignarPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(322, 335);
            this.Controls.Add(this.DGTrabajador);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAsignar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(60, 40);
            this.MaximizeBox = false;
            this.Name = "winAsignarPed";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(30, 20, 3, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "winAsignarPed";
            this.Load += new System.EventHandler(this.winAsignarPed_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.winAsignarPed_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnAsignar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTrabajador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnAsignar;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnUndo;
        private System.Windows.Forms.DataGridView DGTrabajador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbkTrabajador;
    }
}