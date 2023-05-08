using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RurToUsd = "1";
            const string RurToCnh = "2";
            const string UsdToRur = "3";
            const string UsdToCnh = "4";
            const string CnhToRur = "5";
            const string CnhToUsd = "6";
            const string IsExit = "7";


            double rurCount = 1000, usdCount = 1000, cnhCount = 1000;
            double usdRur = 76.82;
            double rurUsd = 1 / usdRur;
            double usdCnh = 6.91;
            double cnhUsd = 1/ usdCnh;
            double cnhRur = 11.12;
            double rurCnh = 1/ cnhRur;
            double purchaseVolume;
            bool isExit = false;
            string userInput;                      
            string exitProgramMessege = "Завершение работы программы.\nДосвидания!";
            string wrongOption = "Такого варианта нет";
            string requestPurchaseVolume = $"Какой обобъём меняете?";

            while (isExit == false)
            {
                string programMenu = $"На вашем счету {rurCount} рублей, {usdCount} долларов,{cnhCount} юаней." +
                                     $"\nКурс валют USD/RUR: {usdRur}, USD/CNH: {usdCnh}, CNH/RUR: {cnhRur}." +
                                     $" Операции на выбор:" +
                                     $"\n{RurToUsd} - обменять рубли на доллары. {RurToCnh} - обменять рубли на юани." +
                                     $"\n{RurToCnh} - обменять доллраны на рубли. {UsdToCnh} - обменять доллары на юани." +
                                     $"\n{CnhToRur} - обмен юани на рубли. {CnhToUsd} - обмен юаней на доллары." +
                                     $"\n{IsExit} - закрыть программу";

                Console.WriteLine(programMenu);
                userInput = Console.ReadLine();           

                switch (userInput)
                {
                    case RurToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        rurCount -= purchaseVolume;
                        usdCount += purchaseVolume * rurUsd;
                        break;
                    case RurToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        rurCount -= purchaseVolume;
                        cnhCount += purchaseVolume * rurCnh;
                        break;
                    case UsdToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        usdCount -= purchaseVolume;
                        rurCount += purchaseVolume * usdRur;
                        break;
                    case UsdToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        usdCount -= purchaseVolume;
                        cnhCount += purchaseVolume * usdCnh;
                        break;
                    case CnhToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        cnhCount -= purchaseVolume;
                        rurCount += purchaseVolume * cnhRur;
                        break;
                    case CnhToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        cnhCount -= purchaseVolume;
                        usdCount += purchaseVolume * cnhUsd;
                        break;
                    case IsExit:
                        Console.WriteLine(exitProgramMessege);
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine(wrongOption);
                        break;
                }
                
            }
        }
    }
}
