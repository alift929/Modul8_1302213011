// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        AppConfig appConfig = new AppConfig();

        if(appConfig.bankTransferConfig.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");
        }
        else
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
        }

        int transfer = int.Parse(Console.ReadLine());
        int biayaTransfer;
        if(transfer <= appConfig.bankTransferConfig.transfer.treshold)
        {
            biayaTransfer = appConfig.bankTransferConfig.transfer.low_fee;
        }
        else
        {
            biayaTransfer = appConfig.bankTransferConfig.transfer.high_fee;
        }

        if (appConfig.bankTransferConfig.lang == "en")
        {
            Console.WriteLine($"Transfer fee = {biayaTransfer}");
            Console.WriteLine($"Total amount = {transfer+biayaTransfer}");
            int i = 1;
            Console.WriteLine("\nTransfer method:");
            foreach (string method in appConfig.bankTransferConfig.methods)
            {
                Console.WriteLine($"{i}. {method}");
                i++;
            }
            Console.WriteLine("\nSelect transfer method: ");
            int tfMethod = int.Parse(Console.ReadLine());
            Console.Write($"Please type \"{appConfig.bankTransferConfig.confirmation.en}\" to confirm the transaction: ");
            string confirm = Console.ReadLine();
            if(confirm == appConfig.bankTransferConfig.confirmation.en)
            {
                Console.WriteLine("The transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {biayaTransfer}");
            Console.WriteLine($"Total biaya = {transfer + biayaTransfer}");
            int i = 1;
            Console.WriteLine("\nMetode transfer:");
            foreach (string method in appConfig.bankTransferConfig.methods)
            {
                Console.WriteLine($"{i}. {method}");
                i++;
            }
            Console.WriteLine("\nPilih metode transfer: ");
            int tfMethod = int.Parse(Console.ReadLine());
            Console.Write($"Ketik \"{appConfig.bankTransferConfig.confirmation.id}\" untuk mengkonfirmasi transaksi: ");
            string confirm = Console.ReadLine();
            if (confirm == appConfig.bankTransferConfig.confirmation.id)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }

        
    }
}