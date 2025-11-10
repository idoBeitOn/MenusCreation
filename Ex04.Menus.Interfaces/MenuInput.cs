using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuInput
    {
        public static bool CheckUserInput(int i_NumberOfMenuOptions, string i_UserInput, out int o_MenuChoice)
        {
            bool inputValid = int.TryParse(i_UserInput, out o_MenuChoice);
            if (inputValid && (o_MenuChoice < 0 || o_MenuChoice > i_NumberOfMenuOptions))
            {
                inputValid = false;
            }

            return inputValid;
        }
        public static int GetInputFromUser(int i_NumberOfMenuOptions)
        {
            int validUserChoice = 0;
            bool isInputValid = false;
            while (!isInputValid)
            {
                string userInput = Console.ReadLine();
                isInputValid = CheckUserInput(i_NumberOfMenuOptions, userInput, out validUserChoice);
                if (isInputValid == false)
                {
                    MenuOutput.PrintInputError(i_NumberOfMenuOptions);
                }
            }

            return validUserChoice;
        }
    }
}
