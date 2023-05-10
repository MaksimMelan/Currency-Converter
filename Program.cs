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
            double usdToRur = 76.82;
            double rurToUsd = 1 / usdToRur;
            double usdToCnh = 6.91;
            double cnhToUsd = 1/ usdToCnh;
            double cnhToRur = 11.12;
            double rurToCnh = 1/ cnhToRur;
            double purchaseVolume;
            bool isExit = false;
            string userInput;                      
            string exitProgramMessege = "Завершение работы программы.\nДосвидания!";
            string wrongOption = "Такого варианта нет";
            string requestPurchaseVolume = $"Какой обобъём меняете?";
            string notEnoughMoneys = "Недостаточно денег на вашем счету.";

            while (isExit == false)
            {
                string programMenu = $"На вашем счету {Math.Round(rurCount, 2)} рублей, {Math.Round(usdCount, 2)} долларов,{Math.Round(cnhCount, 2)} юаней." +
                                     $"\nКурс валют USD/RUR: {usdToRur}, USD/CNH: {usdToCnh}, CNH/RUR: {cnhToRur}." +
                                     $" Операции на выбор:" +
                                     $"\n{RurToUsd} - обменять рубли на доллары.\n{RurToCnh} - обменять рубли на юани." +
                                     $"\n{UsdToRur} - обменять доллраны на рубли.\n{UsdToCnh} - обменять доллары на юани." +
                                     $"\n{CnhToRur} - обмен юани на рубли.\n{CnhToUsd} - обмен юаней на доллары." +
                                     $"\n{IsExit} - закрыть программу";

                Console.WriteLine(programMenu);
                userInput = Console.ReadLine();           

                switch (userInput)
                {
                    case RurToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= rurCount)
                        {
                            rurCount -= purchaseVolume;
                            usdCount += purchaseVolume * rurToUsd;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
                        break;

                    case RurToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= rurCount)
                        {
                            rurCount -= purchaseVolume;
                            cnhCount += purchaseVolume * rurToCnh;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
                        break;

                    case UsdToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= usdCount)
                        {
                            usdCount -= purchaseVolume;
                            rurCount += purchaseVolume * usdToRur;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
                        break;

                    case UsdToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= usdCount)
                        {
                            usdCount -= purchaseVolume;
                            cnhCount += purchaseVolume * usdToCnh;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
                        break;

                    case CnhToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= cnhCount)
                        {
                        cnhCount -= purchaseVolume;
                        rurCount += purchaseVolume * cnhToRur;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
                        break;

                    case CnhToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = (float)Convert.ToDouble(Console.ReadLine());
                        if (purchaseVolume <= cnhCount)
                        {
                        cnhCount -= purchaseVolume;
                        usdCount += purchaseVolume * cnhToUsd;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }
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
