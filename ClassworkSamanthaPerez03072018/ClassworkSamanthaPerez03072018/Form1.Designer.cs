namespace ClassworkSamanthaPerez03072018
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
            this.theBigBadDataGrid = new System.Windows.Forms.DataGridView();
            this.dataLoadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theBigBadDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // theBigBadDataGrid
            // 
            this.theBigBadDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theBigBadDataGrid.Location = new System.Drawing.Point(7, 10);
            this.theBigBadDataGrid.Name = "theBigBadDataGrid";
            this.theBigBadDataGrid.Size = new System.Drawing.Size(761, 205);
            this.theBigBadDataGrid.TabIndex = 0;
            this.theBigBadDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataLoadButton
            // 
            this.dataLoadButton.Location = new System.Drawing.Point(289, 238);
            this.dataLoadButton.Name = "dataLoadButton";
            this.dataLoadButton.Size = new System.Drawing.Size(75, 23);
            this.dataLoadButton.TabIndex = 1;
            this.dataLoadButton.Text = "Load Data";
            this.dataLoadButton.UseVisualStyleBackColor = true;
            this.dataLoadButton.Click += new System.EventHandler(this.dataLoadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(408, 238);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 273);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataLoadButton);
            this.Controls.Add(this.theBigBadDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.theBigBadDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView theBigBadDataGrid;
        private System.Windows.Forms.Button dataLoadButton;
        private System.Windows.Forms.Button closeButton;
    }
}

