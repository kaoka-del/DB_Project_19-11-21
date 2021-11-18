namespace PROJETOBDDEDE.src.forms
{
    partial class frmViewAluno
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
            this.DataGV_Main = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGV_Main
            // 
            this.DataGV_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV_Main.Location = new System.Drawing.Point(0, 0);
            this.DataGV_Main.Name = "DataGV_Main";
            this.DataGV_Main.Size = new System.Drawing.Size(610, 362);
            this.DataGV_Main.TabIndex = 0;
            // 
            // frmViewAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 362);
            this.Controls.Add(this.DataGV_Main);
            this.Name = "frmViewAluno";
            this.Text = "frmViewAluno";
            this.Load += new System.EventHandler(this.frmViewAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGV_Main;
    }
}