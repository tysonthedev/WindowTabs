using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTabs
{
    [Serializable]
    class MacroAction
    {
        //actiontype is basically the type of input it will emulate
        public ActionType actionType;
        public string parameters;

        public MacroAction()
        {
            actionType = ActionType.KeyDown;
            parameters = "A";
        }

        public MacroAction(ActionType type, string actionParameters)
        {
            actionType = type;
            parameters = actionParameters;
        }

        public enum ActionType
        {
            KeyDown,    //KeyDown,<keycode>
            KeyUp,      //KeyUp,<keycode>
            MouseClick, //MouseClick,<left(0)-right(1)-middle(2)>,<xpos>,<ypos>,<image path>
            MouseDown,  //MouseDown,<left(0)-right(1)-middle(2)>,<xpos>,<ypos>,<image path>
            MouseUp,    //MouseUp,<left(0)-right(1)-middle(2)>,<xpos>,<ypos>,<image path>
            PassKeys,   //PassKeys
            Wait,       //Wait,<time in milliseconds>
            TypeKey,    //TypeKey,<keycode>
            RunMacro    //RunMacro,<macro name>
        }
        public override string ToString()
        {
            return actionType.ToString() + "," + parameters;
        }
        public static MacroAction FromString(string data)
        {
            ActionType thisActionType;
            string[] splitData = data.Split(',');
            if (splitData.Length <= 0) return null;
            if (Enum.TryParse<ActionType>(splitData[0], out thisActionType))
            {
                return new MacroAction(thisActionType, data.Remove(0, splitData[0].Count()));
            }
            else
            {
                Console.WriteLine("couldn't parse actionType");
                return null;
            }
        }
    }
}
