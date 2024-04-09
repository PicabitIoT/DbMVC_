namespace GoMVC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDato = new Label();
            txtDatoNow = new TextBox();
            btnUp = new Button();
            lblAppRoute = new Label();
            lblAppVersion = new Label();
            lblAppYear = new Label();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDato.ForeColor = Color.Blue;
            lblDato.Location = new Point(55, 49);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(83, 32);
            lblDato.TabIndex = 0;
            lblDato.Text = "Dato: ";
            // 
            // txtDatoNow
            // 
            txtDatoNow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDatoNow.ForeColor = Color.Blue;
            txtDatoNow.Location = new Point(55, 121);
            txtDatoNow.Name = "txtDatoNow";
            txtDatoNow.Size = new Size(583, 39);
            txtDatoNow.TabIndex = 1;
            // 
            // btnUp
            // 
            btnUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUp.ForeColor = Color.Blue;
            btnUp.Location = new Point(665, 118);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(110, 45);
            btnUp.TabIndex = 2;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // lblAppRoute
            // 
            lblAppRoute.AutoSize = true;
            lblAppRoute.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppRoute.ForeColor = Color.Blue;
            lblAppRoute.Location = new Point(55, 180);
            lblAppRoute.Name = "lblAppRoute";
            lblAppRoute.Size = new Size(142, 32);
            lblAppRoute.TabIndex = 3;
            lblAppRoute.Text = "AppRoute: ";
            // 
            // lblAppVersion
            // 
            lblAppVersion.AutoSize = true;
            lblAppVersion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppVersion.ForeColor = Color.Blue;
            lblAppVersion.Location = new Point(55, 228);
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Size = new Size(160, 32);
            lblAppVersion.TabIndex = 4;
            lblAppVersion.Text = "AppVersion: ";
            // 
            // lblAppYear
            // 
            lblAppYear.AutoSize = true;
            lblAppYear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppYear.ForeColor = Color.Blue;
            lblAppYear.Location = new Point(55, 277);
            lblAppYear.Name = "lblAppYear";
            lblAppYear.Size = new Size(125, 32);
            lblAppYear.TabIndex = 5;
            lblAppYear.Text = "AppYear: ";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(55, 339);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(1303, 222);
            dgv.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 588);
            Controls.Add(dgv);
            Controls.Add(lblAppYear);
            Controls.Add(lblAppVersion);
            Controls.Add(lblAppRoute);
            Controls.Add(btnUp);
            Controls.Add(txtDatoNow);
            Controls.Add(lblDato);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato;
        private TextBox txtDatoNow;
        private Button btnUp;
        private Label lblAppRoute;
        private Label lblAppVersion;
        private Label lblAppYear;
        private DataGridView dgv;
    }
}