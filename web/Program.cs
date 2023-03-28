using MySFT.sft;
using MySFT.sft.ContractDefinition;
using Nethereum.Web3;

namespace MySFTWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test().Wait();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

            //Console.ReadLine();

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
        }

        static async Task Test()
        {
            var url = "http://localhost:8545";
            var contractAddress = "0x2353705fa0471d607EE7c6D6d1A0cB66C3657C5e";
            var web3 = new Web3(url);

            var service = new SftService(web3, contractAddress);
            var transferValueHandler = service.ContractHandler.GetEvent<TransferValueEventDTO>();
            var filterAllTransferEventsForContract = transferValueHandler.CreateFilterInput();
            var allTransferEventsForContract = await transferValueHandler.GetAllChangesAsync(filterAllTransferEventsForContract);

            Console.WriteLine(allTransferEventsForContract[0].Event.ToTokenId);
        }
    }


}

