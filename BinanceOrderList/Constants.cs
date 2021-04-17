namespace BinanceOrderList
{
	public static class Constants
	{
		//Options
		public static string SettingsFilename { get; } = "Settings.xml";
		public static int MinimumApiKeyLength { get; } = 64;
		public static int MinimumPairSymboLength { get; } = 5;
		public static int MinimumUsernameLength { get; } = 3;
		public static int MaximumUsernameLength { get; } = 25;

		//UI Strings
		public static string PublicApiKeyTextBoxPlaceholder { get; } = "API Key";
		public static string SecretApiKeyTextBoxPlaceholder { get; } = "Secret Key";
		public static string PairSymbolTextBoxPlaceholder { get; } = "BTCUSDT, ETHBTC, etc";
		public static string AddUserComboBoxItemText { get; } = "+ New User";

		//Error Strings
		public static string WrongApiKeyError { get; } = "- Wrong API Key";
		public static string WrongSecretKeyError { get; } = "- Wrong Secret Key";
		public static string WrongPairSymbolsError { get; } = "- Wrong Pair Symbols";
		public static string WrongDateError { get; } = "- End date must be greater than the Start date";
	}
}
