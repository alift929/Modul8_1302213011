using System;
using System.Text.Json;

public class AppConfig
{
	public BankTransferConfig bankTransferConfig { get; set; }
	private const string filePath = @"bank_transfer_config.json";
	public AppConfig()
	{
		try
		{
			readConfig();
		}
		catch
		{
			setDefault();
			writeConfigFile();
		}
	}

	private BankTransferConfig readConfig()
	{
		string readResult = File.ReadAllText(filePath);
		bankTransferConfig = JsonSerializer.Deserialize<BankTransferConfig>(readResult);
		return bankTransferConfig;
	}

	private void setDefault()
	{
		Transfer transfer = new Transfer(25000000, 6500, 15000);
		Confirmation confirmation = new Confirmation("yes", "ya");
		List<String> methods = new List<String>();
		methods.Add("RTO (real-time)");
		methods.Add("SKN");
		methods.Add("RTGS");
		methods.Add("BI FAST");
		bankTransferConfig = new BankTransferConfig("en",transfer,methods,confirmation);
	}

	private void writeConfigFile()
	{
		JsonSerializerOptions options = new JsonSerializerOptions()
		{
			WriteIndented = true,
		};

		string writeText = JsonSerializer.Serialize(bankTransferConfig,options);
		File.WriteAllText(filePath,writeText);
	}
}
