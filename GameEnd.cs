using System;
using System.IO;

namespace RockPaperScissors{
    class GameEnd{
       
        public static void tie(){
            addFile();
            Console.WriteLine("tie");

            string path = "scores.txt";
            string wins;
            string losses;
            string ties;

            using (StreamReader sr = new StreamReader(path)){
                wins = sr.ReadLine() ?? "";
                losses = sr.ReadLine() ?? "";
                ties = sr.ReadLine() ?? "";
            }

            int tiesNum = Int32.Parse(ties);

            tiesNum++;

            using (StreamWriter sw = new StreamWriter(path)){
                sw.WriteLine(wins);
                sw.WriteLine(losses);
                sw.WriteLine(tiesNum.ToString());
            }
        }

        public static void AIwin(){
           addFile();
           Console.WriteLine("the AI wins");

           string path = "scores.txt";
           string wins;
           string losses;
           string ties;

            using (StreamReader sr = new StreamReader(path)){
                wins = sr.ReadLine() ?? "";
                losses = sr.ReadLine() ?? "";
                ties = sr.ReadLine() ?? "";
            }

            int lossesNum = Int32.Parse(losses);

            lossesNum++;

            using (StreamWriter sw = new StreamWriter(path)){
                sw.WriteLine(wins);
                sw.WriteLine(lossesNum.ToString());
                sw.WriteLine(ties);
            }
        }

        public static void userWin(){
           addFile();
           Console.WriteLine("You win!");

           string path = "scores.txt";
           string wins;
           string losses;
           string ties;

            using (StreamReader sr = new StreamReader(path)){
                wins = sr.ReadLine() ?? "";
                losses = sr.ReadLine() ?? "";
                ties = sr.ReadLine() ?? "";

            }
            
            int winsNum = Int32.Parse(wins);

            winsNum++;

            using (StreamWriter sw = new StreamWriter(path)){
                sw.WriteLine(winsNum.ToString());
                sw.WriteLine(losses);
                sw.WriteLine(ties);
            }
        }

        public static void addFile(){
            string path = "scores.txt";

            if (!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)){
                    sw.WriteLine("0");
                    sw.WriteLine("0");
                    sw.WriteLine("0");
                }
            }
        }
    }
}