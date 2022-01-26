//Name: Mark Lynch
//Student Number: 19326691
//OS: windows
//IDE: VScode
//cammand disign pattern.

using System;
using System.IO;

namespace emoticon_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //boot up message
            Console.WriteLine("-------------------Emoticon-Generator----------------------");
            Console.WriteLine("Wellcome to emoticon generator!");
            Console.WriteLine("To view a list of commands type the \"help\" command.");
            Console.WriteLine(" -- Default emoticon created --");

            //command pattern set up 
            var modifyEmoticon = new ModifyEmoticon();
            var emoticon = new Emoticon();

            //user input loop
            bool isRunning = true;
            while(isRunning)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "quit":
                        Console.WriteLine("-- Exiting Emoticon Generator --");
                        Console.WriteLine("Goodbye! ('~')/` ");
                        isRunning = false;
                        break;

                    case "hide":
                         switch (input[1])
                        {
                            case "left-eye":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEye, "hide"));
                                 break;

                            case "right-eye":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEye, "hide"));
                                 break;

                            case "left-brow":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrow, "hide"));
                                 break;

                            case "right-brow ":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrow, "hide"));
                                 break;

                            case "mouth":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouth, "hide"));
                                 break;

                            default :
                                Console.WriteLine("** Error invalid command **");
                                Console.WriteLine("To view a list of commands type the \"help\" command.");
                                break;
                        }
                        Console.WriteLine("--  " +input[1]+ " was hidden -- ");
                        Console.WriteLine("-- to show " +input[1] + " again update it with the style command -- ");

                        break;

                    case "move":
                        int positive = Int32.Parse(input[3]);
                        int negitive = positive *-1;

                        switch (input[1])
                        {
                            case "left-eye":
                                 switch (input[2])
                                 {
                                     case "up":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEyePosY, negitive));
                                        break;

                                    case "left":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEyePosX, negitive));
                                        break;

                                    case "down":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEyePosY, positive));
                                        break;

                                    case "right":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEyePosX, positive));
                                        break;
                                 }
                                 break;

                            case "right-eye":
                                 switch (input[2])
                                 {
                                     case "up":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEyePosY, negitive));
                                        break;

                                    case "left":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEyePosX, negitive));
                                        break;

                                    case "down":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEyePosY, positive));
                                        break;

                                    case "right":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEyePosX, positive));
                                        break;

                                    default :
                                        Console.WriteLine("** Error invalid command **");
                                        Console.WriteLine("To view a list of commands type the \"help\" command.");
                                        break;
                                 }
                                 break;

                            case "left-brow":
                                 switch (input[2])
                                 {
                                     case "up":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrowPosY, negitive));
                                        break;

                                    case "left":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrowPosX, negitive));
                                        break;

                                    case "down":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrowPosY, positive));
                                        break;

                                    case "right":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrowPosX, positive));
                                        break;

                                    default :
                                        Console.WriteLine("** Error invalid command **");
                                        Console.WriteLine("To view a list of commands type the \"help\" command.");
                                        break;
                                 }
                                 break;

                            case "right-brow ":
                                 switch (input[2])
                                 {
                                     case "up":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrowPosY, negitive));
                                        break;

                                    case "left":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrowPosX, negitive));
                                        break;

                                    case "down":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrowPosY, positive));
                                        break;

                                    case "right":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrowPosX, positive));
                                        break;

                                    default :
                                        Console.WriteLine("** Error invalid command **");
                                        Console.WriteLine("To view a list of commands type the \"help\" command.");
                                        break;
                                 }
                                 break;

                            case "mouth":
                                 switch (input[2])
                                 {
                                     case "up":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouthPosY, negitive));
                                        break;

                                    case "left":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouthPosX, negitive));
                                        break;

                                    case "down":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouthPosY, positive));
                                        break;

                                    case "right":
                                        Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouthPosX, positive));
                                        break;

                                    default :
                                        Console.WriteLine("** Error invalid command **");
                                        Console.WriteLine("To view a list of commands type the \"help\" command.");
                                        break;
                                 }
                                 break;

                            default :
                                Console.WriteLine("** Error invalid command **");
                                Console.WriteLine("To view a list of commands type the \"help\" command.");
                                break;
                        }
                        
                        Console.WriteLine("--  " +input[1]+ " moved " + input[2] +" "+ input[3]+" pixles");

                        break;

                    case "reset":
                        Console.WriteLine(" ** are you sure you would like to reset? this can NOT be undone. (yes\no) ** ");
                        String doReset = Console.ReadLine();
                        if (doReset == "yes")
                        {
                            modifyEmoticon = new ModifyEmoticon();
                            emoticon = new Emoticon();
                            Console.WriteLine(" -- Emoticon was reset to defalt style --");
                        }
                        else 
                        {
                            Console.WriteLine(" -- Emoticon was NOT reset --");
                        }
                        break;

                    case "style":
                        switch (input[1])
                        {
                            case "left-eye":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftEye, input[2]));
                                 break;

                            case "right-eye":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightEye, input[2]));
                                 break;

                            case "left-brow":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.leftBrow, input[2]));
                                 break;

                            case "right-brow ":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.rightBrow, input[2]));
                                 break;

                            case "mouth":
                                 Execute(emoticon, modifyEmoticon, new EmoticonCommand(emoticon, EmoticonAction.mouth, input[2]));
                                 break;

                            default :
                                Console.WriteLine("** Error invalid command **");
                                Console.WriteLine("To view a list of commands type the \"help\" command.");
                                break;
                        }
                        Console.WriteLine("-- " +input[1]+ " was set to the " + input[2] + " style. ;) --"); 
                        break;

                    case "save":
                        File.WriteAllText(input[1]+".svg", emoticon.ToString());
                        Console.WriteLine("-- your emoticon has be saved to " + input[1] + ".svg --");
                        break;

                    case "draw":
                        Console.WriteLine("----------Your-Emoticon----------");
                        Console.WriteLine(emoticon.ToString());
                        Console.WriteLine("---------------------------------");
                        break;

                    case "undo":
                        Console.WriteLine("undo");
                        break;

                    case "redo":
                        Console.WriteLine("redo");
                        break;

                    case "help":
                        Console.WriteLine("-----------------------------------------------Command-List--------------------------------------------------");
                        Console.WriteLine("-- show	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                        Console.WriteLine("-- hide   { left-eye | right-eye	| left-brow	| right-brow | mouth }");
                        Console.WriteLine("-- move	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ up | down	| left | right } value");
                        Console.WriteLine("-- reset	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                        Console.WriteLine("-- style	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ happy	| angry	| sad }");
                        Console.WriteLine("-- save	 <file>");
                        Console.WriteLine("-- draw");
                        Console.WriteLine("-- undo");
                        Console.WriteLine("-- redo");
                        Console.WriteLine("-- help");
                        Console.WriteLine("-- quit");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("** Error invalid command **");
                        Console.WriteLine("To view a list of commands type the \"help\" command.");
                        break;
                }
            }
        }
        private static void Execute(Emoticon emoticon, ModifyEmoticon modifyEmoticon, ICommand emoticonCommand)
        {
            modifyEmoticon.SetCommand(emoticonCommand);
            modifyEmoticon.Invoke();
        }
    }

}
