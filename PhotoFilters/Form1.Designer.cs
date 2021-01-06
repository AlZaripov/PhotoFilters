﻿
namespace PhotoFilters
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
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.resultPicture = new System.Windows.Forms.PictureBox();
            this.SelectFilterLabel = new System.Windows.Forms.Label();
            this.filterSelector = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.filterParameters = new System.Windows.Forms.TextBox();
            this.filterParametersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPicture
            // 
            this.originalPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalPicture.Location = new System.Drawing.Point(12, 27);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(480, 300);
            this.originalPicture.TabIndex = 0;
            this.originalPicture.TabStop = false;
            // 
            // resultPicture
            // 
            this.resultPicture.Location = new System.Drawing.Point(12, 349);
            this.resultPicture.Name = "resultPicture";
            this.resultPicture.Size = new System.Drawing.Size(480, 300);
            this.resultPicture.TabIndex = 1;
            this.resultPicture.TabStop = false;
            // 
            // SelectFilterLabel
            // 
            this.SelectFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFilterLabel.AutoSize = true;
            this.SelectFilterLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFilterLabel.Location = new System.Drawing.Point(605, 27);
            this.SelectFilterLabel.Name = "SelectFilterLabel";
            this.SelectFilterLabel.Size = new System.Drawing.Size(82, 19);
            this.SelectFilterLabel.TabIndex = 4;
            this.SelectFilterLabel.Text = "Select filter";
            // 
            // filterSelector
            // 
            this.filterSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSelector.DropDownHeight = 120;
            this.filterSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSelector.FormattingEnabled = true;
            this.filterSelector.IntegralHeight = false;
            this.filterSelector.Location = new System.Drawing.Point(520, 50);
            this.filterSelector.MaxDropDownItems = 10;
            this.filterSelector.Name = "filterSelector";
            this.filterSelector.Size = new System.Drawing.Size(238, 21);
            this.filterSelector.TabIndex = 5;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(520, 288);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(238, 35);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // filterParameters
            // 
            this.filterParameters.Location = new System.Drawing.Point(520, 124);
            this.filterParameters.Name = "filterParameters";
            this.filterParameters.Size = new System.Drawing.Size(116, 20);
            this.filterParameters.TabIndex = 7;
            // 
            // filterParametersLabel
            // 
            this.filterParametersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterParametersLabel.AutoSize = true;
            this.filterParametersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterParametersLabel.Location = new System.Drawing.Point(516, 102);
            this.filterParametersLabel.Name = "filterParametersLabel";
            this.filterParametersLabel.Size = new System.Drawing.Size(120, 19);
            this.filterParametersLabel.TabIndex = 8;
            this.filterParametersLabel.Text = "Filter parameters";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.filterParametersLabel);
            this.Controls.Add(this.filterParameters);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.filterSelector);
            this.Controls.Add(this.SelectFilterLabel);
            this.Controls.Add(this.resultPicture);
            this.Controls.Add(this.originalPicture);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "MainForm";
            this.Text = "Photo filters";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.PictureBox resultPicture;
        private System.Windows.Forms.Label SelectFilterLabel;
        private System.Windows.Forms.ComboBox filterSelector;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox filterParameters;
        private System.Windows.Forms.Label filterParametersLabel;
    }
}

