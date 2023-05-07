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
            const string optionОne = "1";
            const string optionTwo = "2";
            const string optionThree = "3";
            const string optionFour = "4";
            const string optionFive = "5";
            const string optionSix = "6";
            const string optionEight = "7";
            



            double rurCount = 1000, usdCount = 1000, cnhCount = 1000;
            double usdRur = 76.82;
            double usdCnh = 6.91;
            double cnhRur = 11.12;
            double purchaseVolume;
            bool isExit = false;
            string userInput;                      
            string exitProgramMessege = "Завершение работы программы.\nДосвидания!";
            string programMenu = $"На вашем счету {rurCount} рублей, {usdCount} долларов,{cnhCount} юаней." +
                $"\nКурс валют USD/RUR: {usdRur}, USD/CNH: {usdCnh}, CNH/RUR: {cnhRur}." +              
                $" Операции на выбор:" +
                $"\n1 - обменять рубли на доллары. 2 - обменять рубли на юани." +
                $"\n3 - обменять доллраны на рубли. 4 - обменять доллары на юани." +
                $"\n5 - обмен юани на рубли. 6 - обмен юаней на доллары." +
                $"\n7 - закрыть программу";
            string wrongOption = "Такого варианта нет";
            string requestPurchaseVolume = $"Какой обобъём меняете?";




            while (isExit == false)
            {
                Console.WriteLine(programMenu);
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case optionОne:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        rurCount -= purchaseVolume;
                        usdCount += purchaseVolume / usdCount;
                        break;
                    case optionTwo:
                        break;
                    case optionThree:
                        break;
                    case optionFour:
                        break;
                    case optionFive:
                        break;
                    case optionSix:
                        break;
                    case optionEight:
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
