namespace WinformsAdoNet
{
    partial class MainForm
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
            this.CarInventoryGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRowToRemote = new System.Windows.Forms.TextBox();
            this.btnToRemoveRow = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarInventoryGridView)).BeginInit();
            this.Remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarInventoryGridView
            // 
            this.CarInventoryGridView.AllowUserToOrderColumns = true;
            this.CarInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarInventoryGridView.Location = new System.Drawing.Point(12, 59);
            this.CarInventoryGridView.Name = "CarInventoryGridView";
            this.CarInventoryGridView.RowTemplate.Height = 24;
            this.CarInventoryGridView.Size = new System.Drawing.Size(762, 336);
            this.CarInventoryGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here Is The Cars From The Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRowToRemote
            // 
            this.txtRowToRemote.AccessibleName = "txtRowToRemote";
            this.txtRowToRemote.Location = new System.Drawing.Point(6, 84);
            this.txtRowToRemote.Name = "txtRowToRemote";
            this.txtRowToRemote.Size = new System.Drawing.Size(294, 22);
            this.txtRowToRemote.TabIndex = 2;
            this.txtRowToRemote.TextChanged += new System.EventHandler(this.txtRowToRemote_TextChanged);
            // 
            // btnToRemoveRow
            // 
            this.btnToRemoveRow.Location = new System.Drawing.Point(329, 57);
            this.btnToRemoveRow.Name = "btnToRemoveRow";
            this.btnToRemoveRow.Size = new System.Drawing.Size(157, 49);
            this.btnToRemoveRow.TabIndex = 3;
            this.btnToRemoveRow.Text = "Remove By Id";
            this.btnToRemoveRow.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Controls.Add(this.btnToRemoveRow);
            this.Remove.Controls.Add(this.txtRowToRemote);
            this.Remove.Location = new System.Drawing.Point(12, 401);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(498, 128);
            this.Remove.TabIndex = 4;
            this.Remove.TabStop = false;
            this.Remove.Text = "Remove";
            this.Remove.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 541);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarInventoryGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarInventoryGridView)).EndInit();
            this.Remove.ResumeLayout(false);
            this.Remove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarInventoryGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRowToRemote;
        private System.Windows.Forms.Button btnToRemoveRow;
        private System.Windows.Forms.GroupBox Remove;
    }
}

