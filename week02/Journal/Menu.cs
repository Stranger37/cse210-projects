using Microsoft.VisualBasic;

public class Menu{
        
        //A LIST OF OPTIONS TO THE MENU
        public List<string> options = ["1 - Write","2 - Display","3 - Load","4 - Save","5 - Quit"];

        //WRITE THE MENU ON THE TERMINAL TO THE USER
        public void printMenu(){

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please, select one of the following choices: ");

            foreach(string i in options){
                Console.WriteLine(i);
            }
        }

        //CONTROLL THE NAVIGATION THROUGH THE OPTION IN THE MENU, DOING DIFFERENT ACTIONS DEPENDING WHAT THER USER ENTER
        public bool navigation(Journal newEntry){

            Entry myEntry = new Entry();

            int userChoice = int.Parse(Console.ReadLine());
            bool open = true;

            
            //WRITE OPTION
            if(userChoice == 1){
                
                //SET THE VALUES TO THE ENTRY LIKE: DATE, PROMPT GENERATE AND USER ENTRY.
                PromptGenerator generator = new PromptGenerator();
                myEntry._date = DateTime.Now.ToShortDateString();
                myEntry._promptText = generator.GetRandomPrompt();
                Console.WriteLine(myEntry._promptText);
                myEntry._entryText = Console.ReadLine();

                //ADD THE VALUES IN A LIST TO DISPLAY IT OR SAVE IT ON A FILE
                newEntry.AddEntry(myEntry);

                
            //DISPLAY OPTION
            }else if(userChoice == 2){
                newEntry.DisplayAll();

            //LOAD OPTION
            }else if(userChoice == 3){
                Console.WriteLine("What is the File Name?");
                string file = Console.ReadLine();
                newEntry.LoadFromFile(file);
            
            //SAVE OPTION
            }else if(userChoice == 4){
                Console.WriteLine("What is the File Name?");
                string file = Console.ReadLine();
                newEntry.SaveToFile(file);

            //QUIT OPTION
            }else if(userChoice == 5){
                open = false;
            //HANDLE WITH INVALID ENTERS FROM THE USER
            }else{
                Console.WriteLine("Invalid Option");
            }
            //RETURN A VALUE TO THE MAIN, TO STOP OR CONTINUE THE WHILE LOOP
            return open;
        }
}