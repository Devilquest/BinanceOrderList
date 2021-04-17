using Binance.Net.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BinanceOrderList
{
	public partial class MainForm : Form
	{
		private readonly XmlDocument settingsXmlDocument = new XmlDocument();
		private readonly List<string> usersList = new List<string>();

		private readonly DataForm dataForm = new DataForm();

		public MainForm()
		{
			InitializeComponent();

			LoadUserData();

			//First dat of the current week.
			fromDateTimePicker.Value = DateTime.Today.AddDays(-1 * ((7 + (DateTime.Today.DayOfWeek - DayOfWeek.Monday)) % 7)).Date;

			//First dat of the current month.
			//fromDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

			//Set to 23:59:59 toDateTimePicker hour.
			toDateTimePicker.Value = DateTime.Today.AddDays(1).AddTicks(-1);

			List<string> orderStatusList = Enum.GetNames(typeof(OrderStatus)).ToList();
			orderStatusList.Sort();
			orderStatusList.Insert(0, "All");
			orderStatusComboBox.DataSource = orderStatusList;

			List<string> orderSideList = Enum.GetNames(typeof(OrderSide)).ToList();
			orderSideList.Sort();
			orderSideList.Insert(0, "All");
			sideComboBox.DataSource = orderSideList;
		}

		#region Data Validation & Data Management
		private string UserDataCheck(bool saveUserRequirements = false)
		{
			List<string> errorList = new List<string>();

			if (string.IsNullOrEmpty(publicApiKeyTextBox.Text) || publicApiKeyTextBox.Text.Length < Constants.MinimumApiKeyLength || publicApiKeyTextBox.Text == Constants.PublicApiKeyTextBoxPlaceholder)
				errorList.Add(Constants.WrongApiKeyError);

			if (string.IsNullOrEmpty(secretApiKeyTextBox.Text) || secretApiKeyTextBox.Text.Length < Constants.MinimumApiKeyLength || secretApiKeyTextBox.Text == Constants.SecretApiKeyTextBoxPlaceholder)
				errorList.Add(Constants.WrongSecretKeyError);

			if (!saveUserRequirements)
			{
				if (string.IsNullOrEmpty(pairSymbolTextBox.Text) || pairSymbolTextBox.Text.Length < Constants.MinimumPairSymboLength || pairSymbolTextBox.Text == Constants.PairSymbolTextBoxPlaceholder)
					errorList.Add(Constants.WrongPairSymbolsError);
			
				if (fromDateTimePicker.Value > toDateTimePicker.Value)
					errorList.Add(Constants.WrongDateError);
			}

			if (errorList.Count > 0)
			{
				string errors = string.Empty;

				for (int i = 0; i < errorList.Count; i++)
				{
					errors += errorList[i];
					if (i < errorList.Count - 1)
						errors += "\n";
				}
				return errors;
			}
			else
				return string.Empty;
		}

		private void LoadUserData()
		{
			usersListComboBox.Items.Add(Constants.AddUserComboBoxItemText);
			usersListComboBox.SelectedIndex = usersListComboBox.FindStringExact(Constants.AddUserComboBoxItemText);

			if (File.Exists(Constants.SettingsFilename))
			{
				settingsXmlDocument.Load(Constants.SettingsFilename);

				foreach (XmlNode user in settingsXmlDocument.GetElementsByTagName("User"))
				{
					usersList.Add(user.Attributes["UserName"].Value);
					usersListComboBox.Items.Add(user.Attributes["UserName"].Value);
				}

				if (settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings/LastUser") != null && usersList.Contains(settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings/LastUser").InnerText))
				{
					usersListComboBox.SelectedIndex = usersListComboBox.FindStringExact(settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings/LastUser").InnerText);
					ChangeTextBoxesText(usersListComboBox.SelectedItem.ToString());
				}
				else
					TextBoxesAndComboBoxToDefault();
			}
			else
			{
				new XDocument(
					new XElement("Settings",
						new XElement("OtherSettings")
					)
				)
				.Save(Constants.SettingsFilename);

				settingsXmlDocument.Load(Constants.SettingsFilename);

				TextBoxesAndComboBoxToDefault();
			}
		}

		private void SaveUserData()
		{
			if (File.Exists(Constants.SettingsFilename))
			{
				if (usersList.Contains(usersListComboBox.SelectedItem.ToString()))
				{
					XmlNode userNode = settingsXmlDocument.SelectSingleNode("//node()[@UserName='" + usersListComboBox.SelectedItem + "']");

					if (userNode != null)
					{
						userNode.SelectSingleNode("PublicApiKey").InnerText = publicApiKeyTextBox.Text;
						userNode.SelectSingleNode("SecretApiKey").InnerText = secretApiKeyTextBox.Text;
						userNode.SelectSingleNode("LastSearchedPairs").InnerText = pairSymbolTextBox.Text;

						settingsXmlDocument.Save(Constants.SettingsFilename);
					}
				}
			}
		}

		private void ChangeTextBoxesText(string username)
		{
			if (usersList.Contains(username))
			{
				saveUserDataButton.Enabled = false;

				XmlNode userNode = settingsXmlDocument.SelectSingleNode("//node()[@UserName='" + username + "']");

				if (userNode != null)
				{
					publicApiKeyTextBox.Text = userNode.SelectSingleNode("PublicApiKey").InnerText;
					secretApiKeyTextBox.Text = userNode.SelectSingleNode("SecretApiKey").InnerText;
					if (string.IsNullOrWhiteSpace(userNode.SelectSingleNode("LastSearchedPairs").InnerText))
					{
						pairSymbolTextBox.Text = Constants.PairSymbolTextBoxPlaceholder;
						pairSymbolTextBox.ForeColor = Color.DarkGray;
					}
					else
						pairSymbolTextBox.Text = userNode.SelectSingleNode("LastSearchedPairs").InnerText;

					deleteUserButton.Enabled = true;
					deleteUserButton.BackgroundImage = Properties.Resources.Delete_Icon;
				}

				if (settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings/LastUser") != null)
				{
					settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings/LastUser").InnerText = username;
				}
				else
				{
					XmlElement lastUserNode = settingsXmlDocument.CreateElement("LastUser");
					lastUserNode.InnerText = username;
					settingsXmlDocument.SelectSingleNode("/Settings/OtherSettings").AppendChild(lastUserNode);
				}

				settingsXmlDocument.Save(Constants.SettingsFilename);
			}
			else
				TextBoxesAndComboBoxToDefault();

		}
		#endregion

		#region UI Events
		#region Buttons
		private void SaveUserDataButton_Click(object sender, EventArgs e)
		{
			string errors = UserDataCheck(true);

			if (string.IsNullOrEmpty(errors))
			{
				string usernameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Username", "Save User", null, Left + Width / 5, Top + Height / 5).Trim();

				if (!string.IsNullOrEmpty(usernameInput))
				{
					if (usernameInput.Length >= Constants.MinimumUsernameLength && usernameInput.Length <= Constants.MaximumUsernameLength)
					{
						if (settingsXmlDocument.SelectSingleNode("//node()[@UserName='" + usernameInput + "']") == null)
						{
							XmlElement newUserNode = settingsXmlDocument.CreateElement("User");
							newUserNode.SetAttribute("UserName", usernameInput);

							XmlElement newUserChild = settingsXmlDocument.CreateElement("PublicApiKey");
							newUserChild.InnerText = publicApiKeyTextBox.Text;
							newUserNode.AppendChild(newUserChild);

							newUserChild = settingsXmlDocument.CreateElement("SecretApiKey");
							newUserChild.InnerText = secretApiKeyTextBox.Text;
							newUserNode.AppendChild(newUserChild);

							newUserChild = settingsXmlDocument.CreateElement("LastSearchedPairs");
							if (!string.IsNullOrEmpty(pairSymbolTextBox.Text) && pairSymbolTextBox.Text != Constants.PairSymbolTextBoxPlaceholder)
								newUserChild.InnerText = pairSymbolTextBox.Text;
							newUserNode.AppendChild(newUserChild);

							settingsXmlDocument.DocumentElement.AppendChild(newUserNode);

							settingsXmlDocument.Save(Constants.SettingsFilename);

							usersList.Add(usernameInput);
							usersListComboBox.Items.Add(usernameInput);
							usersListComboBox.SelectedIndex = usersListComboBox.FindStringExact(usernameInput);
						}
						else
							MessageBox.Show("Username already exists.\nTry another.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else if (usernameInput.Length > Constants.MaximumUsernameLength)
						MessageBox.Show("User not saved.\nUsername too long, maximum " + Constants.MaximumUsernameLength + " characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
						MessageBox.Show("User not saved.\nUsername too short, minimum " + Constants.MinimumUsernameLength + " characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
				MessageBox.Show("Please fix the following errors and try again.\n" + errors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void DeleteUserButton_Click(object sender, EventArgs e)
		{
			DialogResult deleteUserConfirmation = MessageBox.Show("The user \"" + usersListComboBox.SelectedItem + "\" will be deleted permanently.\nAre you sure you want to continue?", "Delete User " + usersListComboBox.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (deleteUserConfirmation == DialogResult.Yes)
			{
				XmlNode userNode = settingsXmlDocument.SelectSingleNode("//node()[@UserName='" + usersListComboBox.SelectedItem + "']");

				if (userNode != null)
				{
					userNode.ParentNode.RemoveChild(userNode);
					settingsXmlDocument.Save(Constants.SettingsFilename);

					usersList.Remove(usersListComboBox.SelectedItem.ToString());
					usersListComboBox.Items.Remove(usersListComboBox.SelectedItem);
					usersListComboBox.SelectedIndex = usersListComboBox.FindStringExact(Constants.AddUserComboBoxItemText);
				}
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			string errors = UserDataCheck();

			if (string.IsNullOrEmpty(errors))
			{
				dataForm.GetData(
					publicApiKeyTextBox.Text,
					secretApiKeyTextBox.Text,
					pairSymbolTextBox.Text.ToUpper(),
					fromDateTimePicker.Value,
					toDateTimePicker.Value,
					orderStatusComboBox.SelectedItem.ToString(),
					sideComboBox.SelectedItem.ToString(),
					new Point(Left + Width, Top)
				);
				SaveUserData();
			}
			else
				MessageBox.Show("Please fix the following errors and try again.\n" + errors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		#endregion

		#region TextBoxEvents
		private void ApiKeysTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			if (!string.IsNullOrWhiteSpace(box.Text))
			{
				switch (box.Name)
				{
					case "publicApiKeyTextBox":
						if (box.Text != Constants.PublicApiKeyTextBoxPlaceholder)
							box.ForeColor = Color.Black;
						break;
					case "secretApiKeyTextBox":
						if (box.Text != Constants.SecretApiKeyTextBoxPlaceholder)
						{
							box.PasswordChar = '*';
							box.ForeColor = Color.Black;
						}
						break;
					case "pairSymbolTextBox":
						if (box.Text != Constants.PairSymbolTextBoxPlaceholder)
						{
							if (!Regex.IsMatch(box.Text, @"^[a-z ,]+$", RegexOptions.IgnoreCase))
							{
								box.Text = box.Text.Remove(box.Text.Length - 1);
								box.SelectionStart = box.Text.Length;
								box.SelectionLength = 0;
							}

							box.ForeColor = Color.Black;
						}
						break;
				}
			}
		}

		private void ApiKeysTextBox_Enter(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			switch (box.Name)
			{
				case "publicApiKeyTextBox":
					if (box.Text == Constants.PublicApiKeyTextBoxPlaceholder)
						box.Text = string.Empty;
					break;
				case "secretApiKeyTextBox":
					if (box.Text == Constants.SecretApiKeyTextBoxPlaceholder)
						box.Text = string.Empty;
					break;
				case "pairSymbolTextBox":
					if (box.Text == Constants.PairSymbolTextBoxPlaceholder)
					{
						box.CharacterCasing = CharacterCasing.Upper;
						box.Text = string.Empty;
					}
					break;
			}
		}

		private void ApiKeysTextBox_Leave(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(box.Text))
			{
				switch (box.Name)
				{
					case "publicApiKeyTextBox":
						box.Text = Constants.PublicApiKeyTextBoxPlaceholder;
						break;
					case "secretApiKeyTextBox":
						box.PasswordChar = '\0';
						box.Text = Constants.SecretApiKeyTextBoxPlaceholder;
						break;
					case "pairSymbolTextBox":
						box.CharacterCasing = CharacterCasing.Normal;
						box.Text = Constants.PairSymbolTextBoxPlaceholder;
						break;
				}
				box.ForeColor = Color.DarkGray;
			}
		}
		#endregion

		#region Other Events
		private void UsersListComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeTextBoxesText(usersListComboBox.SelectedItem.ToString());
		}

		private void TextBoxesAndComboBoxToDefault()
		{
			publicApiKeyTextBox.Text = Constants.PublicApiKeyTextBoxPlaceholder;
			secretApiKeyTextBox.Text = Constants.SecretApiKeyTextBoxPlaceholder;
			pairSymbolTextBox.Text = Constants.PairSymbolTextBoxPlaceholder;

			publicApiKeyTextBox.ForeColor = Color.DarkGray;
			secretApiKeyTextBox.ForeColor = Color.DarkGray;
			pairSymbolTextBox.ForeColor = Color.DarkGray;

			saveUserDataButton.Enabled = true;
			deleteUserButton.Enabled = false;
			deleteUserButton.BackgroundImage = Properties.Resources.Delete_Icon_Gray;
		}
		#endregion

		#endregion
	}
}