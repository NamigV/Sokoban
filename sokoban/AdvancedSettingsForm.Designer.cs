using System.ComponentModel;

namespace sokoban
{
    partial class AdvancedSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._nameOfModelsDirectoryLabel = new System.Windows.Forms.Label();
            this._nameOfLevelsDirectoryLabel = new System.Windows.Forms.Label();
            this._nameOfDataSaveDirectoryLabel = new System.Windows.Forms.Label();
            this._nameOfModelsDirectoryTextBox = new System.Windows.Forms.TextBox();
            this._nameOfLevelsDirectoryTextBox = new System.Windows.Forms.TextBox();
            this._nameOfDataSaveDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _nameOfModelsDirectoryLabel
            // 
            this._nameOfModelsDirectoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._nameOfModelsDirectoryLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this._nameOfModelsDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this._nameOfModelsDirectoryLabel.Name = "_nameOfModelsDirectoryLabel";
            this._nameOfModelsDirectoryLabel.Size = new System.Drawing.Size(110, 47);
            this._nameOfModelsDirectoryLabel.TabIndex = 0;
            this._nameOfModelsDirectoryLabel.Text = "Имя папки с моделями";
            // 
            // _nameOfLevelsDirectoryLabel
            // 
            this._nameOfLevelsDirectoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._nameOfLevelsDirectoryLabel.ForeColor = System.Drawing.Color.Brown;
            this._nameOfLevelsDirectoryLabel.Location = new System.Drawing.Point(12, 56);
            this._nameOfLevelsDirectoryLabel.Name = "_nameOfLevelsDirectoryLabel";
            this._nameOfLevelsDirectoryLabel.Size = new System.Drawing.Size(110, 47);
            this._nameOfLevelsDirectoryLabel.TabIndex = 0;
            this._nameOfLevelsDirectoryLabel.Text = "Имя папки с уровнями";
            // 
            // _nameOfDataSaveDirectoryLabel
            // 
            this._nameOfDataSaveDirectoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._nameOfDataSaveDirectoryLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this._nameOfDataSaveDirectoryLabel.Location = new System.Drawing.Point(12, 103);
            this._nameOfDataSaveDirectoryLabel.Name = "_nameOfDataSaveDirectoryLabel";
            this._nameOfDataSaveDirectoryLabel.Size = new System.Drawing.Size(110, 90);
            this._nameOfDataSaveDirectoryLabel.TabIndex = 0;
            this._nameOfDataSaveDirectoryLabel.Text = "Имя папки для хранения данных";
            // 
            // _nameOfModelsDirectoryTextBox
            // 
            this._nameOfModelsDirectoryTextBox.Location = new System.Drawing.Point(149, 12);
            this._nameOfModelsDirectoryTextBox.Name = "_nameOfModelsDirectoryTextBox";
            this._nameOfModelsDirectoryTextBox.Size = new System.Drawing.Size(79, 20);
            this._nameOfModelsDirectoryTextBox.TabIndex = 1;
            // 
            // _nameOfLevelsDirectoryTextBox
            // 
            this._nameOfLevelsDirectoryTextBox.Location = new System.Drawing.Point(149, 59);
            this._nameOfLevelsDirectoryTextBox.Name = "_nameOfLevelsDirectoryTextBox";
            this._nameOfLevelsDirectoryTextBox.Size = new System.Drawing.Size(79, 20);
            this._nameOfLevelsDirectoryTextBox.TabIndex = 1;
            // 
            // _nameOfDataSaveDirectoryTextBox
            // 
            this._nameOfDataSaveDirectoryTextBox.Location = new System.Drawing.Point(149, 103);
            this._nameOfDataSaveDirectoryTextBox.Name = "_nameOfDataSaveDirectoryTextBox";
            this._nameOfDataSaveDirectoryTextBox.Size = new System.Drawing.Size(79, 20);
            this._nameOfDataSaveDirectoryTextBox.TabIndex = 1;
            // 
            // AdvancedSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this._nameOfDataSaveDirectoryTextBox);
            this.Controls.Add(this._nameOfLevelsDirectoryTextBox);
            this.Controls.Add(this._nameOfModelsDirectoryTextBox);
            this.Controls.Add(this._nameOfDataSaveDirectoryLabel);
            this.Controls.Add(this._nameOfLevelsDirectoryLabel);
            this.Controls.Add(this._nameOfModelsDirectoryLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdvancedSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _nameOfModelsDirectoryTextBox;
        private System.Windows.Forms.TextBox _nameOfLevelsDirectoryTextBox;
        private System.Windows.Forms.TextBox _nameOfDataSaveDirectoryTextBox;

        private System.Windows.Forms.Label _nameOfModelsDirectoryLabel;
        private System.Windows.Forms.Label _nameOfLevelsDirectoryLabel;
        private System.Windows.Forms.Label _nameOfDataSaveDirectoryLabel;

        #endregion
    }
}