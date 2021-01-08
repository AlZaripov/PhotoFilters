
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
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPicture
            // 
            this.originalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPicture.Location = new System.Drawing.Point(17, 22);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(480, 300);
            this.originalPicture.TabIndex = 0;
            this.originalPicture.TabStop = false;
            // 
            // resultPicture
            // 
            this.resultPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPicture.Location = new System.Drawing.Point(17, 344);
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
            this.SelectFilterLabel.Location = new System.Drawing.Point(610, 22);
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
            this.filterSelector.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterSelector.FormattingEnabled = true;
            this.filterSelector.IntegralHeight = false;
            this.filterSelector.Location = new System.Drawing.Point(525, 45);
            this.filterSelector.MaxDropDownItems = 10;
            this.filterSelector.Name = "filterSelector";
            this.filterSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filterSelector.Size = new System.Drawing.Size(240, 23);
            this.filterSelector.Sorted = true;
            this.filterSelector.TabIndex = 5;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyButton.Location = new System.Drawing.Point(525, 139);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(240, 30);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileButton.Location = new System.Drawing.Point(525, 614);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(240, 30);
            this.SaveFileButton.TabIndex = 7;
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(525, 578);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(240, 30);
            this.OpenFileButton.TabIndex = 8;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.filterSelector);
            this.Controls.Add(this.SelectFilterLabel);
            this.Controls.Add(this.resultPicture);
            this.Controls.Add(this.originalPicture);
            this.Icon = global::PhotoFilters.Properties.Resources.Icon;
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
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button OpenFileButton;
    }
}

