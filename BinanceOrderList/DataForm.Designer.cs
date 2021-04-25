
namespace BinanceOrderList
{
	partial class DataForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
			this.binanceDataDataGridView = new System.Windows.Forms.DataGridView();
			this.exportToExcelButton = new System.Windows.Forms.Button();
			this.clearDataButton = new System.Windows.Forms.Button();
			this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UpdateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PairColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuanityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SideColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.binanceDataDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// binanceDataDataGridView
			// 
			this.binanceDataDataGridView.AllowUserToAddRows = false;
			this.binanceDataDataGridView.AllowUserToDeleteRows = false;
			this.binanceDataDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.binanceDataDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.binanceDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.binanceDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.UpdateTimeColumn,
            this.PairColumn,
            this.QuanityColumn,
            this.PriceColumn,
            this.StatusColumn,
            this.TypeColumn,
            this.SideColumn});
			this.binanceDataDataGridView.Location = new System.Drawing.Point(12, 12);
			this.binanceDataDataGridView.Name = "binanceDataDataGridView";
			this.binanceDataDataGridView.ReadOnly = true;
			this.binanceDataDataGridView.RowHeadersVisible = false;
			this.binanceDataDataGridView.Size = new System.Drawing.Size(736, 398);
			this.binanceDataDataGridView.TabIndex = 0;
			this.binanceDataDataGridView.TabStop = false;
			// 
			// exportToExcelButton
			// 
			this.exportToExcelButton.Location = new System.Drawing.Point(649, 416);
			this.exportToExcelButton.Name = "exportToExcelButton";
			this.exportToExcelButton.Size = new System.Drawing.Size(99, 23);
			this.exportToExcelButton.TabIndex = 1;
			this.exportToExcelButton.TabStop = false;
			this.exportToExcelButton.Text = "Export to Excel";
			this.exportToExcelButton.UseVisualStyleBackColor = true;
			this.exportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
			// 
			// clearDataButton
			// 
			this.clearDataButton.Location = new System.Drawing.Point(12, 416);
			this.clearDataButton.Name = "clearDataButton";
			this.clearDataButton.Size = new System.Drawing.Size(75, 23);
			this.clearDataButton.TabIndex = 2;
			this.clearDataButton.TabStop = false;
			this.clearDataButton.Text = "Clear Data";
			this.clearDataButton.UseVisualStyleBackColor = true;
			this.clearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
			// 
			// DateColumn
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DateColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.DateColumn.HeaderText = "Date";
			this.DateColumn.Name = "DateColumn";
			this.DateColumn.ReadOnly = true;
			// 
			// UpdateTimeColumn
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.UpdateTimeColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.UpdateTimeColumn.HeaderText = "Update Time";
			this.UpdateTimeColumn.Name = "UpdateTimeColumn";
			this.UpdateTimeColumn.ReadOnly = true;
			// 
			// PairColumn
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PairColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.PairColumn.HeaderText = "Pair";
			this.PairColumn.Name = "PairColumn";
			this.PairColumn.ReadOnly = true;
			this.PairColumn.Width = 75;
			// 
			// QuanityColumn
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.QuanityColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.QuanityColumn.HeaderText = "Quanity";
			this.QuanityColumn.Name = "QuanityColumn";
			this.QuanityColumn.ReadOnly = true;
			// 
			// PriceColumn
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.PriceColumn.HeaderText = "Price";
			this.PriceColumn.Name = "PriceColumn";
			this.PriceColumn.ReadOnly = true;
			// 
			// StatusColumn
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.StatusColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.StatusColumn.HeaderText = "Status";
			this.StatusColumn.Name = "StatusColumn";
			this.StatusColumn.ReadOnly = true;
			// 
			// TypeColumn
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.TypeColumn.HeaderText = "Type";
			this.TypeColumn.Name = "TypeColumn";
			this.TypeColumn.ReadOnly = true;
			this.TypeColumn.Width = 75;
			// 
			// SideColumn
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SideColumn.DefaultCellStyle = dataGridViewCellStyle9;
			this.SideColumn.HeaderText = "Side";
			this.SideColumn.Name = "SideColumn";
			this.SideColumn.ReadOnly = true;
			this.SideColumn.Width = 60;
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 449);
			this.Controls.Add(this.clearDataButton);
			this.Controls.Add(this.exportToExcelButton);
			this.Controls.Add(this.binanceDataDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DataForm";
			this.Text = "Search Result";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.binanceDataDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView binanceDataDataGridView;
		private System.Windows.Forms.Button exportToExcelButton;
		private System.Windows.Forms.Button clearDataButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTimeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PairColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuanityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SideColumn;
	}
}