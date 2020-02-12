namespace SirtCantasi
{
    partial class UserInterface
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxButtonBar = new System.Windows.Forms.ToolStrip();
            this.uxOpen = new System.Windows.Forms.ToolStripButton();
            this.uxLimit = new System.Windows.Forms.TextBox();
            this.uxSolutionContainer = new System.Windows.Forms.Panel();
            this.uxSolution = new System.Windows.Forms.DataGridView();
            this.uxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxLimitLabel = new System.Windows.Forms.Label();
            this.uxTotalWeight = new System.Windows.Forms.TextBox();
            this.uxTotalValue = new System.Windows.Forms.TextBox();
            this.uxValueLabel = new System.Windows.Forms.Label();
            this.uxWeightLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxButtonBar.SuspendLayout();
            this.uxSolutionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButtonBar
            // 
            this.uxButtonBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen});
            this.uxButtonBar.Location = new System.Drawing.Point(0, 0);
            this.uxButtonBar.Name = "uxButtonBar";
            this.uxButtonBar.Size = new System.Drawing.Size(701, 27);
            this.uxButtonBar.TabIndex = 0;
            // 
            // uxOpen
            // 
            this.uxOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(75, 24);
            this.uxOpen.Text = "Dosya Aç";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxLimit
            // 
            this.uxLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxLimit.Location = new System.Drawing.Point(151, 51);
            this.uxLimit.Margin = new System.Windows.Forms.Padding(4);
            this.uxLimit.Name = "uxLimit";
            this.uxLimit.ReadOnly = true;
            this.uxLimit.Size = new System.Drawing.Size(100, 34);
            this.uxLimit.TabIndex = 2;
            this.uxLimit.TextChanged += new System.EventHandler(this.uxLimit_TextChanged);
            // 
            // uxSolutionContainer
            // 
            this.uxSolutionContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSolutionContainer.Controls.Add(this.uxSolution);
            this.uxSolutionContainer.Location = new System.Drawing.Point(17, 123);
            this.uxSolutionContainer.Margin = new System.Windows.Forms.Padding(4);
            this.uxSolutionContainer.Name = "uxSolutionContainer";
            this.uxSolutionContainer.Size = new System.Drawing.Size(668, 426);
            this.uxSolutionContainer.TabIndex = 3;
            // 
            // uxSolution
            // 
            this.uxSolution.AllowUserToAddRows = false;
            this.uxSolution.AllowUserToDeleteRows = false;
            this.uxSolution.AllowUserToResizeRows = false;
            this.uxSolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxId,
            this.uxValue,
            this.uxWeight,
            this.uxDensity,
            this.uxSelected});
            this.uxSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSolution.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxSolution.Location = new System.Drawing.Point(0, 0);
            this.uxSolution.Margin = new System.Windows.Forms.Padding(4);
            this.uxSolution.Name = "uxSolution";
            this.uxSolution.ReadOnly = true;
            this.uxSolution.RowHeadersVisible = false;
            this.uxSolution.Size = new System.Drawing.Size(668, 426);
            this.uxSolution.TabIndex = 0;
            this.uxSolution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxSolution_CellContentClick);
            // 
            // uxId
            // 
            this.uxId.HeaderText = "ID";
            this.uxId.Name = "uxId";
            this.uxId.ReadOnly = true;
            // 
            // uxValue
            // 
            this.uxValue.HeaderText = "Değer";
            this.uxValue.Name = "uxValue";
            this.uxValue.ReadOnly = true;
            // 
            // uxWeight
            // 
            this.uxWeight.HeaderText = "Ağırlık";
            this.uxWeight.Name = "uxWeight";
            this.uxWeight.ReadOnly = true;
            // 
            // uxDensity
            // 
            this.uxDensity.HeaderText = "Kar";
            this.uxDensity.Name = "uxDensity";
            this.uxDensity.ReadOnly = true;
            // 
            // uxSelected
            // 
            this.uxSelected.HeaderText = "Seçim";
            this.uxSelected.Name = "uxSelected";
            this.uxSelected.ReadOnly = true;
            // 
            // uxLimitLabel
            // 
            this.uxLimitLabel.AutoSize = true;
            this.uxLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxLimitLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uxLimitLabel.Location = new System.Drawing.Point(2, 54);
            this.uxLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLimitLabel.Name = "uxLimitLabel";
            this.uxLimitLabel.Size = new System.Drawing.Size(141, 29);
            this.uxLimitLabel.TabIndex = 4;
            this.uxLimitLabel.Text = "Ağırlık Sınırı";
            this.uxLimitLabel.Click += new System.EventHandler(this.uxLimitLabel_Click);
            // 
            // uxTotalWeight
            // 
            this.uxTotalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxTotalWeight.Location = new System.Drawing.Point(185, 602);
            this.uxTotalWeight.Margin = new System.Windows.Forms.Padding(4);
            this.uxTotalWeight.Name = "uxTotalWeight";
            this.uxTotalWeight.ReadOnly = true;
            this.uxTotalWeight.Size = new System.Drawing.Size(96, 34);
            this.uxTotalWeight.TabIndex = 5;
            // 
            // uxTotalValue
            // 
            this.uxTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxTotalValue.Location = new System.Drawing.Point(185, 562);
            this.uxTotalValue.Margin = new System.Windows.Forms.Padding(4);
            this.uxTotalValue.Name = "uxTotalValue";
            this.uxTotalValue.ReadOnly = true;
            this.uxTotalValue.Size = new System.Drawing.Size(96, 34);
            this.uxTotalValue.TabIndex = 6;
            this.uxTotalValue.TextChanged += new System.EventHandler(this.uxTotalValue_TextChanged);
            // 
            // uxValueLabel
            // 
            this.uxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxValueLabel.AutoSize = true;
            this.uxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxValueLabel.Location = new System.Drawing.Point(2, 562);
            this.uxValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxValueLabel.Name = "uxValueLabel";
            this.uxValueLabel.Size = new System.Drawing.Size(175, 29);
            this.uxValueLabel.TabIndex = 7;
            this.uxValueLabel.Text = "Toplam Değer:";
            this.uxValueLabel.Click += new System.EventHandler(this.uxValueLabel_Click);
            // 
            // uxWeightLabel
            // 
            this.uxWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxWeightLabel.AutoSize = true;
            this.uxWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxWeightLabel.Location = new System.Drawing.Point(2, 602);
            this.uxWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxWeightLabel.Name = "uxWeightLabel";
            this.uxWeightLabel.Size = new System.Drawing.Size(175, 29);
            this.uxWeightLabel.TabIndex = 8;
            this.uxWeightLabel.Text = "Toplam Ağırlık:";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "Comma-separated-value files|*.csv|All files|*.*";
            // 
            // uxSaveDialog
            // 
            this.uxSaveDialog.Filter = "Comma-separated-value files|*.csv|All files|*.*";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(701, 639);
            this.Controls.Add(this.uxWeightLabel);
            this.Controls.Add(this.uxValueLabel);
            this.Controls.Add(this.uxTotalValue);
            this.Controls.Add(this.uxTotalWeight);
            this.Controls.Add(this.uxLimitLabel);
            this.Controls.Add(this.uxSolutionContainer);
            this.Controls.Add(this.uxLimit);
            this.Controls.Add(this.uxButtonBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(414, 408);
            this.Name = "UserInterface";
            this.Text = "Sırt Çantası Problemi Çözücü";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.uxButtonBar.ResumeLayout(false);
            this.uxButtonBar.PerformLayout();
            this.uxSolutionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxButtonBar;
        private System.Windows.Forms.ToolStripButton uxOpen;
        private System.Windows.Forms.TextBox uxLimit;
        private System.Windows.Forms.Panel uxSolutionContainer;
        private System.Windows.Forms.DataGridView uxSolution;
        private System.Windows.Forms.Label uxLimitLabel;
        private System.Windows.Forms.TextBox uxTotalWeight;
        private System.Windows.Forms.TextBox uxTotalValue;
        private System.Windows.Forms.Label uxValueLabel;
        private System.Windows.Forms.Label uxWeightLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxSelected;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
    }
}

