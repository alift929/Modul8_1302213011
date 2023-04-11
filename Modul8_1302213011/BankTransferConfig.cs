using System;

public class BankTransferConfig
{
	public string lang { get; set; }
	public Transfer transfer { get; set; }
	public List<String> methods { get; set; }
	public Confirmation confirmation { get; set; }

	public BankTransferConfig()
	{

	}

    public BankTransferConfig(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
    {
        this.lang = lang;
        this.transfer = transfer;
        this.methods = methods;
        this.confirmation = confirmation;
    }
}

public class Transfer
{
	public int treshold { get; set; }
	public int low_fee { get; set; }
	public int high_fee { get; set; }

    public Transfer()
    {
    }

    public Transfer(int treshold, int low_fee, int high_fee)
    {
        this.treshold = treshold;
        this.low_fee = low_fee;
        this.high_fee = high_fee;
    }
}

public class Confirmation
{
	public string en { get; set; }
	public string id { get; set; }

    public Confirmation()
    {
    }

    public Confirmation(string en, string id)
    {
        this.en = en;
        this.id = id;
    }
}
