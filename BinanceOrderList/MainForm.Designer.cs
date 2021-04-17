
namespace BinanceOrderList
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Panel optionsPanel;
			System.Windows.Forms.Label sideLabel;
			System.Windows.Forms.Label pairSymbolLabel;
			System.Windows.Forms.Label orderStatusLabel;
			System.Windows.Forms.Label endDateLabel;
			System.Windows.Forms.Label startDateLabel;
			System.Windows.Forms.Label secretKeyLabel;
			System.Windows.Forms.Label apiKeyLabel;
			System.Windows.Forms.Panel userPanel;
			System.Windows.Forms.Label userLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sideComboBox = new System.Windows.Forms.ComboBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.pairSymbolTextBox = new System.Windows.Forms.TextBox();
			this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
			this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.publicApiKeyTextBox = new System.Windows.Forms.TextBox();
			this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.secretApiKeyTextBox = new System.Windows.Forms.TextBox();
			this.usersListComboBox = new System.Windows.Forms.ComboBox();
			this.deleteUserButton = new System.Windows.Forms.Button();
			this.saveUserDataButton = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			optionsPanel = new System.Windows.Forms.Panel();
			sideLabel = new System.Windows.Forms.Label();
			pairSymbolLabel = new System.Windows.Forms.Label();
			orderStatusLabel = new System.Windows.Forms.Label();
			endDateLabel = new System.Windows.Forms.Label();
			startDateLabel = new System.Windows.Forms.Label();
			secretKeyLabel = new System.Windows.Forms.Label();
			apiKeyLabel = new System.Windows.Forms.Label();
			userPanel = new System.Windows.Forms.Panel();
			userLabel = new System.Windows.Forms.Label();
			optionsPanel.SuspendLayout();
			userPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// optionsPanel
			// 
			optionsPanel.Controls.Add(this.sideComboBox);
			optionsPanel.Controls.Add(sideLabel);
			optionsPanel.Controls.Add(this.searchButton);
			optionsPanel.Controls.Add(pairSymbolLabel);
			optionsPanel.Controls.Add(this.pairSymbolTextBox);
			optionsPanel.Controls.Add(orderStatusLabel);
			optionsPanel.Controls.Add(this.orderStatusComboBox);
			optionsPanel.Controls.Add(endDateLabel);
			optionsPanel.Controls.Add(startDateLabel);
			optionsPanel.Controls.Add(secretKeyLabel);
			optionsPanel.Controls.Add(this.toDateTimePicker);
			optionsPanel.Controls.Add(apiKeyLabel);
			optionsPanel.Controls.Add(this.publicApiKeyTextBox);
			optionsPanel.Controls.Add(this.fromDateTimePicker);
			optionsPanel.Controls.Add(this.secretApiKeyTextBox);
			optionsPanel.Location = new System.Drawing.Point(12, 62);
			optionsPanel.Name = "optionsPanel";
			optionsPanel.Size = new System.Drawing.Size(533, 188);
			optionsPanel.TabIndex = 6;
			// 
			// sideComboBox
			// 
			this.sideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sideComboBox.FormattingEnabled = true;
			this.sideComboBox.Location = new System.Drawing.Point(350, 156);
			this.sideComboBox.Name = "sideComboBox";
			this.sideComboBox.Size = new System.Drawing.Size(64, 21);
			this.sideComboBox.TabIndex = 13;
			this.sideComboBox.TabStop = false;
			// 
			// sideLabel
			// 
			sideLabel.AutoSize = true;
			sideLabel.Location = new System.Drawing.Point(348, 141);
			sideLabel.Name = "sideLabel";
			sideLabel.Size = new System.Drawing.Size(31, 13);
			sideLabel.TabIndex = 12;
			sideLabel.Text = "Side:";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(430, 154);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(94, 24);
			this.searchButton.TabIndex = 8;
			this.searchButton.TabStop = false;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// pairSymbolLabel
			// 
			pairSymbolLabel.AutoSize = true;
			pairSymbolLabel.Location = new System.Drawing.Point(2, 92);
			pairSymbolLabel.Name = "pairSymbolLabel";
			pairSymbolLabel.Size = new System.Drawing.Size(70, 13);
			pairSymbolLabel.TabIndex = 11;
			pairSymbolLabel.Text = "Pair Symbols:";
			// 
			// pairSymbolTextBox
			// 
			this.pairSymbolTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.pairSymbolTextBox.Location = new System.Drawing.Point(3, 108);
			this.pairSymbolTextBox.Name = "pairSymbolTextBox";
			this.pairSymbolTextBox.Size = new System.Drawing.Size(521, 20);
			this.pairSymbolTextBox.TabIndex = 10;
			this.pairSymbolTextBox.TabStop = false;
			this.pairSymbolTextBox.TextChanged += new System.EventHandler(this.ApiKeysTextBox_TextChanged);
			this.pairSymbolTextBox.Enter += new System.EventHandler(this.ApiKeysTextBox_Enter);
			this.pairSymbolTextBox.Leave += new System.EventHandler(this.ApiKeysTextBox_Leave);
			// 
			// orderStatusLabel
			// 
			orderStatusLabel.AutoSize = true;
			orderStatusLabel.Location = new System.Drawing.Point(238, 141);
			orderStatusLabel.Name = "orderStatusLabel";
			orderStatusLabel.Size = new System.Drawing.Size(69, 13);
			orderStatusLabel.TabIndex = 9;
			orderStatusLabel.Text = "Order Status:";
			// 
			// orderStatusComboBox
			// 
			this.orderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.orderStatusComboBox.FormattingEnabled = true;
			this.orderStatusComboBox.Location = new System.Drawing.Point(239, 156);
			this.orderStatusComboBox.Name = "orderStatusComboBox";
			this.orderStatusComboBox.Size = new System.Drawing.Size(95, 21);
			this.orderStatusComboBox.TabIndex = 7;
			this.orderStatusComboBox.TabStop = false;
			// 
			// endDateLabel
			// 
			endDateLabel.AutoSize = true;
			endDateLabel.Location = new System.Drawing.Point(120, 141);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new System.Drawing.Size(55, 13);
			endDateLabel.TabIndex = 8;
			endDateLabel.Text = "End Date:";
			// 
			// startDateLabel
			// 
			startDateLabel.AutoSize = true;
			startDateLabel.Location = new System.Drawing.Point(2, 141);
			startDateLabel.Name = "startDateLabel";
			startDateLabel.Size = new System.Drawing.Size(58, 13);
			startDateLabel.TabIndex = 7;
			startDateLabel.Text = "Start Date:";
			// 
			// secretKeyLabel
			// 
			secretKeyLabel.AutoSize = true;
			secretKeyLabel.Location = new System.Drawing.Point(2, 47);
			secretKeyLabel.Name = "secretKeyLabel";
			secretKeyLabel.Size = new System.Drawing.Size(62, 13);
			secretKeyLabel.TabIndex = 6;
			secretKeyLabel.Text = "Secret Key:";
			// 
			// toDateTimePicker
			// 
			this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.toDateTimePicker.Location = new System.Drawing.Point(121, 157);
			this.toDateTimePicker.Name = "toDateTimePicker";
			this.toDateTimePicker.Size = new System.Drawing.Size(102, 20);
			this.toDateTimePicker.TabIndex = 1;
			this.toDateTimePicker.TabStop = false;
			this.toDateTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// apiKeyLabel
			// 
			apiKeyLabel.AutoSize = true;
			apiKeyLabel.Location = new System.Drawing.Point(2, 2);
			apiKeyLabel.Name = "apiKeyLabel";
			apiKeyLabel.Size = new System.Drawing.Size(48, 13);
			apiKeyLabel.TabIndex = 5;
			apiKeyLabel.Text = "API Key:";
			// 
			// publicApiKeyTextBox
			// 
			this.publicApiKeyTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.publicApiKeyTextBox.Location = new System.Drawing.Point(3, 18);
			this.publicApiKeyTextBox.Name = "publicApiKeyTextBox";
			this.publicApiKeyTextBox.Size = new System.Drawing.Size(521, 20);
			this.publicApiKeyTextBox.TabIndex = 3;
			this.publicApiKeyTextBox.TabStop = false;
			this.publicApiKeyTextBox.TextChanged += new System.EventHandler(this.ApiKeysTextBox_TextChanged);
			this.publicApiKeyTextBox.Enter += new System.EventHandler(this.ApiKeysTextBox_Enter);
			this.publicApiKeyTextBox.Leave += new System.EventHandler(this.ApiKeysTextBox_Leave);
			// 
			// fromDateTimePicker
			// 
			this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fromDateTimePicker.Location = new System.Drawing.Point(3, 157);
			this.fromDateTimePicker.Name = "fromDateTimePicker";
			this.fromDateTimePicker.Size = new System.Drawing.Size(102, 20);
			this.fromDateTimePicker.TabIndex = 0;
			this.fromDateTimePicker.TabStop = false;
			this.fromDateTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// secretApiKeyTextBox
			// 
			this.secretApiKeyTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.secretApiKeyTextBox.Location = new System.Drawing.Point(3, 63);
			this.secretApiKeyTextBox.Name = "secretApiKeyTextBox";
			this.secretApiKeyTextBox.Size = new System.Drawing.Size(521, 20);
			this.secretApiKeyTextBox.TabIndex = 4;
			this.secretApiKeyTextBox.TabStop = false;
			this.secretApiKeyTextBox.TextChanged += new System.EventHandler(this.ApiKeysTextBox_TextChanged);
			this.secretApiKeyTextBox.Enter += new System.EventHandler(this.ApiKeysTextBox_Enter);
			this.secretApiKeyTextBox.Leave += new System.EventHandler(this.ApiKeysTextBox_Leave);
			// 
			// userPanel
			// 
			userPanel.Controls.Add(userLabel);
			userPanel.Controls.Add(this.usersListComboBox);
			userPanel.Controls.Add(this.deleteUserButton);
			userPanel.Controls.Add(this.saveUserDataButton);
			userPanel.Location = new System.Drawing.Point(12, 7);
			userPanel.Name = "userPanel";
			userPanel.Size = new System.Drawing.Size(533, 49);
			userPanel.TabIndex = 10;
			// 
			// userLabel
			// 
			userLabel.AutoSize = true;
			userLabel.Location = new System.Drawing.Point(2, 4);
			userLabel.Name = "userLabel";
			userLabel.Size = new System.Drawing.Size(32, 13);
			userLabel.TabIndex = 14;
			userLabel.Text = "User:";
			// 
			// usersListComboBox
			// 
			this.usersListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.usersListComboBox.FormattingEnabled = true;
			this.usersListComboBox.Location = new System.Drawing.Point(3, 20);
			this.usersListComboBox.MaxDropDownItems = 15;
			this.usersListComboBox.Name = "usersListComboBox";
			this.usersListComboBox.Size = new System.Drawing.Size(139, 21);
			this.usersListComboBox.Sorted = true;
			this.usersListComboBox.TabIndex = 0;
			this.usersListComboBox.TabStop = false;
			this.usersListComboBox.SelectedIndexChanged += new System.EventHandler(this.UsersListComboBox_SelectedIndexChanged);
			// 
			// deleteUserButton
			// 
			this.deleteUserButton.BackgroundImage = global::BinanceOrderList.Properties.Resources.Delete_Icon_Gray;
			this.deleteUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteUserButton.Enabled = false;
			this.deleteUserButton.Location = new System.Drawing.Point(229, 19);
			this.deleteUserButton.Name = "deleteUserButton";
			this.deleteUserButton.Size = new System.Drawing.Size(22, 23);
			this.deleteUserButton.TabIndex = 9;
			this.deleteUserButton.TabStop = false;
			this.toolTip.SetToolTip(this.deleteUserButton, "Delete Current User");
			this.deleteUserButton.UseVisualStyleBackColor = true;
			this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
			// 
			// saveUserDataButton
			// 
			this.saveUserDataButton.Enabled = false;
			this.saveUserDataButton.Location = new System.Drawing.Point(148, 19);
			this.saveUserDataButton.Name = "saveUserDataButton";
			this.saveUserDataButton.Size = new System.Drawing.Size(75, 23);
			this.saveUserDataButton.TabIndex = 8;
			this.saveUserDataButton.Text = "Save User";
			this.toolTip.SetToolTip(this.saveUserDataButton, "Saves the entered API Key, Secret Key and Pair Symbols");
			this.saveUserDataButton.UseVisualStyleBackColor = true;
			this.saveUserDataButton.Click += new System.EventHandler(this.SaveUserDataButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 258);
			this.Controls.Add(userPanel);
			this.Controls.Add(optionsPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Binance Orders";
			optionsPanel.ResumeLayout(false);
			optionsPanel.PerformLayout();
			userPanel.ResumeLayout(false);
			userPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker fromDateTimePicker;
		private System.Windows.Forms.DateTimePicker toDateTimePicker;
		private System.Windows.Forms.TextBox publicApiKeyTextBox;
		private System.Windows.Forms.TextBox secretApiKeyTextBox;
		private System.Windows.Forms.ComboBox orderStatusComboBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox pairSymbolTextBox;
		private System.Windows.Forms.ComboBox sideComboBox;
		private System.Windows.Forms.ComboBox usersListComboBox;
		private System.Windows.Forms.Button saveUserDataButton;
		private System.Windows.Forms.Button deleteUserButton;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

