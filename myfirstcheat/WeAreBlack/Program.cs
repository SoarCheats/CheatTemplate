using ManualMapInjection.Injection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace soarcheats.xyz
{
    class Program
    {

        private static void WriteColoredLines(string lines, Point start, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            for (int row = 0; row < lines.Length; row++)
            {
                Console.SetCursorPosition(start.X, start.Y + row);
                Console.Write(lines[row]);
            }
        }
        static void Main(string[] args)
        {
            /*                                                                                                   
 ________  ___  _________  ___  ___  ___  ___  ________      ________  ________  _____ ______           ___ ________  ________  ________  ________  ________  ___  ___  _______   ________  _________  ________      
|\   ____\|\  \|\___   ___\\  \|\  \|\  \|\  \|\   __  \    |\   ____\|\   __  \|\   _ \  _   \        /  /|\   ____\|\   __  \|\   __  \|\   __  \|\   ____\|\  \|\  \|\  ___ \ |\   __  \|\___   ___\\   ____\     
\ \  \___|\ \  \|___ \  \_\ \  \\\  \ \  \\\  \ \  \|\ /_   \ \  \___|\ \  \|\  \ \  \\\__\ \  \      /  //\ \  \___|\ \  \|\  \ \  \|\  \ \  \|\  \ \  \___|\ \  \\\  \ \   __/|\ \  \|\  \|___ \  \_\ \  \___|_    
 \ \  \  __\ \  \   \ \  \ \ \   __  \ \  \\\  \ \   __  \   \ \  \    \ \  \\\  \ \  \\|__| \  \    /  //  \ \_____  \ \  \\\  \ \   __  \ \   _  _\ \  \    \ \   __  \ \  \_|/_\ \   __  \   \ \  \ \ \_____  \   
  \ \  \|\  \ \  \   \ \  \ \ \  \ \  \ \  \\\  \ \  \|\  \ __\ \  \____\ \  \\\  \ \  \    \ \  \  /  //    \|____|\  \ \  \\\  \ \  \ \  \ \  \\  \\ \  \____\ \  \ \  \ \  \_|\ \ \  \ \  \   \ \  \ \|____|\  \  
   \ \_______\ \__\   \ \__\ \ \__\ \__\ \_______\ \_______\\__\ \_______\ \_______\ \__\    \ \__\/_ //       ____\_\  \ \_______\ \__\ \__\ \__\\ _\\ \_______\ \__\ \__\ \_______\ \__\ \__\   \ \__\  ____\_\  \ 
    \|_______|\|__|    \|__|  \|__|\|__|\|_______|\|_______\|__|\|_______|\|_______|\|__|     \|__|__|/       |\_________\|_______|\|__|\|__|\|__|\|__|\|_______|\|__|\|__|\|_______|\|__|\|__|    \|__| |\_________\
                                                                                                              \|_________|                                                                               \|_________|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            */

            Console.WriteLine(@"   _____                   _____ _                _         _  _  ___   ___  _  _   ___  ");
            Console.WriteLine(@"  / ____|                 / ____| |              | |      _| || ||__ \ / _ \| || | / _ \ ");
            Console.WriteLine(@" | (___   ___   __ _ _ __| |    | |__   ___  __ _| |_ ___|_  __  _| ) | (_) | || || (_) |");
            Console.WriteLine(@"  \___ \ / _ \ / _` | '__| |    | '_ \ / _ \/ _` | __/ __|_| || |_ / / > _ <|__   _> _ < ");
            Console.WriteLine(@"  ____) | (_) | (_| | |  | |____| | | |  __/ (_| | |_\__ \_  __  _/ /_| (_) |  | || (_) |");
            Console.WriteLine(@" |_____/ \___/ \__,_|_|   \_____|_| |_|\___|\__,_|\__|___/ |_||_||____|\___/   |_| \___/ ");
            Console.WriteLine(@"                                                                                         ");
            Console.WriteLine(@"-----------------------------------------------------------------------------------------");


            // THIS IS WHERE INFO GOES

            string Title = "your title here"; // title of window

            string version = "version here";

            string name = "cheat name here";

            string game = "game name"; // game name

            string processname = "game process name here"; // process name for injection (Manual Map)

            string dllname = "dll name here.dll"; //has to be in same folder (used in downloadcheat) include .dll



            // if you want these change to true or edit them


            // randomtitle
            bool randomtitle = false; // change to true if you want a random title of window
            //end


            // download dll
            bool downloadcheat = false;


            // DONT EDIT THIS SHIT OK
            if (downloadcheat == true)
            {
                //leave this alone!
                WebClient wb = new WebClient();
                string link = "PASTE DOWNLOAD HERE";
                wb.DownloadFile(link, dllname);
            }
            //


            //






            // DO NOT EDIT THIS UNLESS YOU KNOW WHAT YOUR DOING!

            // title
            if (randomtitle == false)
            {
                Console.Title = Title;
            }
            if (randomtitle == true)
            {
                int num = 20;
                char[] array = new char[62];
                array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
                byte[] array2 = new byte[num];
                randomNumberGenerator.GetNonZeroBytes(array2);
                StringBuilder stringBuilder = new StringBuilder(num);
                foreach (byte b in array2)
                {
                    stringBuilder.Append(array[(int)b % (array.Length - 1)]);
                }
                StringBuilder stringBuilder2 = stringBuilder;
                Console.Title = (((stringBuilder2 != null) ? stringBuilder2.ToString() : null) ?? "");
            }
            Console.WriteLine("Welcome To - ");
            WriteColoredLines(" ", new Point(12, 8), ConsoleColor.Red);
            Thread.Sleep(10);
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Version - ");
            WriteColoredLines(" ", new Point(9, 9), ConsoleColor.Green);
            Thread.Sleep(10);
            Console.WriteLine(version);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Process - ");
            WriteColoredLines(" ", new Point(10, 10), ConsoleColor.Magenta);
            Thread.Sleep(10);
            Console.WriteLine(game);
            Thread.Sleep(2000);
            Console.WriteLine(@"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Press any Key To Inject " + name + " into " + game + "...");
            Console.ReadKey();
            Console.WriteLine(@"Searching For " + processname + "...");
            Process[] search = Process.GetProcessesByName(processname);
            if (search.Length > 0)
            {
                Console.WriteLine(processname + " Located Injecting...");
                Thread.Sleep(3000);
                WebClient wb = new WebClient();
                var target = Process.GetProcessesByName(processname).FirstOrDefault();
                var file2 = File.ReadAllBytes(dllname);
                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                injector.Inject(file2).ToInt64();
            }
            else
            {
                Console.WriteLine("Failed To Locate Process");
                Thread.Sleep(2000);
                return;
            }
        }
    }
}
