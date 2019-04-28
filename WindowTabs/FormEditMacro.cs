using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTabs
{
    public partial class FormEditMacro : Form
    {
        private Macro originalMacro;
        private Macro editedMacro;

        public enum MacroType
        {
            original,
            edited
        };

        public FormEditMacro()
        {
            InitializeComponent();
            originalMacro = new Macro();
            editedMacro = new Macro();
            comboBoxActionType.Items.AddRange(Enum.GetNames(typeof(MacroAction.ActionType)));
            comboBoxInputLevel.Items.AddRange(Enum.GetNames(typeof(Macro.InputLevel)));
            List<Control> allChildren = new List<Control>();
            GetAllChildren(panelMacroActionEditor, ref allChildren);
            foreach (Control control in allChildren)
            {
                control.TextChanged += SetParameter;
            }
            //MessageBox.Show(panelMacroActionEditor.Controls.Count.ToString());
        }

        private void GetAllChildren(Control whichControl, ref List<Control> AllControls)
        {
            foreach (Control thisControl in whichControl.Controls)
            {
                if (thisControl.HasChildren)
                {
                    GetAllChildren(thisControl, ref AllControls);
                }
                if (thisControl.GetType() != typeof(Label) && thisControl.GetType() != typeof(Panel) && thisControl.GetType() != typeof(Button))
                    AllControls.Add(thisControl);
            }
        }
        //we only added this to the control typed objects
        bool lockSetParameter;
        private void SetParameter(object sender, EventArgs e)
        {
            if (lockSetParameter == true) return;
            if (listBoxMacroActions.SelectedItem == null) return;
            listBoxMacroActions.Items[listBoxMacroActions.SelectedIndex] = GetEditorMacroAction();
        }

        string GetControlText(object whatObject)
        {
            if (whatObject == null) return "";
            Type objectType = whatObject.GetType();
            if (objectType == typeof(TextBox)) return ((TextBox)(whatObject)).Text;
            else if (objectType == typeof(ComboBox)) return ((ComboBox)(whatObject)).Text;
            else if (objectType == typeof(PictureBox)) return ((PictureBox)(whatObject)).ImageLocation;
            else return null;
        }
        void SetControlText(object whatObject, string whatText)
        {
            Type objectType = whatObject.GetType();
            if (objectType == typeof(TextBox)) ((TextBox)(whatObject)).Text = whatText;
            //breaks here
            else if (objectType == typeof(ComboBox)) ((ComboBox)(whatObject)).Text = whatText;
            else if (objectType == typeof(PictureBox)) ((PictureBox)(whatObject)).ImageLocation = whatText;
        }

        int GetParameterCount()
        {
            int highestTag = 0;
            foreach (Control control in panelMacroActionEditor.Controls)
            {
                if(control.Name == "panelActionType" + comboBoxActionType.Items[comboBoxActionType.SelectedIndex].ToString())
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl.Tag != null)
                        if (int.Parse(childControl.Tag.ToString()) > highestTag) highestTag = int.Parse(childControl.Tag.ToString());
                    }
                    return highestTag + 1;
                }
            }
            return 0;
        }

        string GetEditorMacroAction()
        {
            Control[] parameterControls = new Control[GetParameterCount()];
            foreach (Control control in panelMacroActionEditor.Controls)
            {
                if (control.Name == "panelActionType" + comboBoxActionType.Items[comboBoxActionType.SelectedIndex].ToString())
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if(childControl.Tag != null)
                        parameterControls[int.Parse(childControl.Tag.ToString())] = childControl;
                    }
                }
            }
            string macroAction = "";
            for (int i = 0; i < parameterControls.Length; i++)
            {
                if (i == 0) macroAction = GetControlText(comboBoxActionType);
                else macroAction += "," + GetControlText(parameterControls[i]);
            }
            return macroAction;
        }

        void SetEditorMacroAction(string macroAction)
        {
            if (listBoxMacroActions.SelectedItem == null) return;
            string currentAction = listBoxMacroActions.Items[listBoxMacroActions.SelectedIndex].ToString();
            string[] actionParameters = currentAction.Split(',');

            foreach (Control control in panelMacroActionEditor.Controls)
            {
                if (comboBoxActionType.SelectedIndex == -1) return;
                if (control.Name == "panelActionType" + comboBoxActionType.Items[comboBoxActionType.SelectedIndex].ToString())
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl.Tag != null)
                            if (actionParameters.Length > int.Parse(childControl.Tag.ToString()))
                            {
                                lockSetParameter = true;
                                SetControlText(childControl, actionParameters[int.Parse(childControl.Tag.ToString())]);
                                lockSetParameter = false;
                            }
                    }
                }
            }
        }

        internal void SetMacro(Macro whatMacro)
        {
            originalMacro = Macro.DeepCopy(whatMacro);
            editedMacro = Macro.DeepCopy(whatMacro);
            textBoxMacroName.Text = editedMacro.macroName;
            textBoxProcessName.Text = editedMacro.macroProcessName;
            textBoxClassPath.Text = editedMacro.macroClassPath;
            string hotKeyText = "";
            if(editedMacro.hotkey.Count > 0)
                for (int i = 0; i < editedMacro.hotkey.Count; i++)
                {
                    if (i == 0) hotKeyText = ((Keys)editedMacro.hotkey[i]).ToString();
                    else hotKeyText += "+" + ((Keys)editedMacro.hotkey[i]).ToString();
                }
            textBoxHotKey.Text = hotKeyText;
            checkBoxDirectInput.Checked = editedMacro.directInput;
            comboBoxInputLevel.SelectedIndex = (int)editedMacro.inputLevel;
            listBoxMacroActions.Items.Clear();
            if(editedMacro.macroActions.Count > 0)
            for (int i = 0; i < editedMacro.macroActions.Count; i++)
            {
                listBoxMacroActions.Items.Add(editedMacro.macroActions[i].ToString());
            }
        }
        internal Macro GetMacro(MacroType macroType)
        {
            if (macroType == MacroType.original)
            {
                return Macro.DeepCopy(originalMacro);
            }
                return Macro.DeepCopy(editedMacro);
        }

        private void listBoxMacroActions_MouseDown(object sender, MouseEventArgs e)
        {
            int itemIndex = listBoxMacroActions.IndexFromPoint(e.Location);
            if (itemIndex != -1) listBoxMacroActions.DoDragDrop(itemIndex.ToString(), DragDropEffects.Move);
            listBoxMacroActions_SelectedIndexChanged(this, EventArgs.Empty);
        }
        private void listBoxMacroActions_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                int oldItemIndex = Convert.ToInt32(e.Data.GetData(DataFormats.Text));
                int newItemIndex = listBoxMacroActions.IndexFromPoint(listBoxMacroActions.PointToClient(new Point(e.X, e.Y)));
                if (newItemIndex != -1)
                {
                    MacroAction oldItem = editedMacro.macroActions[oldItemIndex];
                    editedMacro.macroActions[oldItemIndex] = editedMacro.macroActions[newItemIndex];
                    editedMacro.macroActions[newItemIndex] = oldItem;
                    object obj = listBoxMacroActions.Items[oldItemIndex];
                    listBoxMacroActions.Items.Remove(obj);
                    listBoxMacroActions.Items.Insert(newItemIndex, obj);
                }
            }
        }
        private void listBoxMacroActions_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
        }
        private void listBoxMacroActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMacroActions.SelectedItem == null) return;
            MacroAction currentSelectedAction = MacroAction.FromString(listBoxMacroActions.SelectedItem.ToString());
            if (currentSelectedAction == null) return;
            lockSetParameter = true;
            comboBoxActionType.SelectedItem = currentSelectedAction.actionType.ToString();
            lockSetParameter = false;
            SetEditorMacroAction(listBoxMacroActions.Items[listBoxMacroActions.SelectedIndex].ToString());
            if (listBoxMacroActions.SelectedIndex >= 0)
            {
                //sets the macro action
                if (comboBoxActionType.Items.Contains(currentSelectedAction.actionType.ToString()))
                {
                    for (int i = 0; i < comboBoxActionType.Items.Count; i++)
                    {
                        if (comboBoxActionType.Items[i].ToString() == currentSelectedAction.actionType.ToString())
                        {
                            comboBoxActionType.SelectedIndex = i;
                            return;
                        }
                    }
                    MessageBox.Show("Couldn't find selected macro action(most likely a naming error)");
                }
                //sets the parameters
            }
        }

        bool lockKeyInput;
        private void textBoxHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (lockKeyInput)
            {
                editedMacro.hotkey.Clear();
                lockKeyInput = false;
            }
            if (!editedMacro.hotkey.Contains(e.KeyValue))
                editedMacro.hotkey.Add(e.KeyValue);
        }
        private void textBoxHotKey_KeyUp(object sender, KeyEventArgs e)
        {
            Keys[] keyCombo = new Keys[editedMacro.hotkey.Count];
            string keyComboString = "";

            lockKeyInput = true;
            if (editedMacro.hotkey.Count > 0)
            {
                for (int i = 0; i < editedMacro.hotkey.Count; i++)
                {
                    keyCombo[i] = (Keys)editedMacro.hotkey[i];
                }
                keyComboString = keyCombo[0].ToString();
                for (int i = 1; i < keyCombo.Length; i++)
                {
                    keyComboString += "+" + keyCombo[i].ToString();
                }
            }
            textBoxHotKey.Text = keyComboString;
        }
        private void textBoxHotKey_Enter(object sender, EventArgs e)
        {
            lockKeyInput = true;
        }

        private void textBoxActionTypeKeyDownWhichKey_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxActionTypeKeyDownWhichKey.Text = e.KeyCode.ToString();
        }
        private void textBoxActionTypeKeyUpWhichKey_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxActionTypeKeyUpWhichKey.Text = e.KeyCode.ToString();
        }
        private void textBoxActionTypeTypeKeyWhichKey_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxActionTypeTypeKeyWhichKey.Text = e.KeyCode.ToString();
        }

        private void comboBoxActionType_SelectedValueChanged(object sender, EventArgs e)
        {
            string newPanelName = "panelActionType" + comboBoxActionType.SelectedItem.ToString();
            Control[] neededPanel = panelMacroActionEditor.Controls.Find(newPanelName, false);
            if (neededPanel.Length == 0) return;
            neededPanel[0].Enabled = true;
            neededPanel[0].Visible = true;
            foreach (Control control in panelMacroActionEditor.Controls)
            {
                if (control.Name != newPanelName && control.Name != "comboBoxActionType" && control.Name != "lblActionType")
                {
                    control.Visible = false;
                    control.Enabled = false;
                }
            }
        }

        private void btnAddMacroAction_Click(object sender, EventArgs e)
        {
            MacroAction newAction = new MacroAction();
            lockSetParameter = true;
            listBoxMacroActions.Items.Add(newAction.ToString());
            if (listBoxMacroActions.Items.Count > 0) listBoxMacroActions.SelectedIndex = listBoxMacroActions.Items.Count - 1;
            if (listBoxMacroActions.SelectedIndex >= 0)
            {
                if (comboBoxActionType.Items.Contains(newAction.actionType.ToString()))
                {
                    for (int i = 0; i < comboBoxActionType.Items.Count; i++)
                    {
                        if (comboBoxActionType.Items[i].ToString() == newAction.actionType.ToString())
                        {
                            comboBoxActionType.SelectedIndex = i;
                            lockSetParameter = false;
                            return;
                        }
                    }
                    MessageBox.Show("Couldn't find selected macro action(most likely a naming error)");
                }
            }
            lockSetParameter = false;
        }

        private void btnDeleteMacroAction_Click(object sender, EventArgs e)
        {
            if (listBoxMacroActions.SelectedItem == null) return;
            listBoxMacroActions.Items.RemoveAt(listBoxMacroActions.SelectedIndex);
        }

        private void btnSaveMacroChanges_Click(object sender, EventArgs e)
        {
            editedMacro.macroActions = new List<MacroAction>();
            for (int i = 0; i < listBoxMacroActions.Items.Count; i++)
            {
                if (MacroAction.FromString(listBoxMacroActions.Items[i].ToString()) != null)
                {
                    editedMacro.macroActions.Add(MacroAction.FromString(listBoxMacroActions.Items[i].ToString()));
                }
                else
                {
                    MessageBox.Show("something went wrong with this macro action: " + listBoxMacroActions.Items[i].ToString() + " this macro action will not be included");
                    return;
                }
            }
            //macroName
            if (textBoxMacroName.Text == "")
            {
                MessageBox.Show("macro name is required");
                return;
            }
            else editedMacro.macroName = textBoxMacroName.Text;
            //process name
            if (textBoxProcessName.Text == "")
            {
                MessageBox.Show("process name is required");
                return;
            }
            else editedMacro.macroProcessName = textBoxProcessName.Text;
            //class path
            if (textBoxClassPath.Text == "")
            {
                MessageBox.Show("class path is required");
                return;
            }
            else editedMacro.macroClassPath = textBoxClassPath.Text;
            //hotkey
            if (textBoxHotKey.Text == "")
            {
                MessageBox.Show("hotkey is required");
                return;
            }
            else
            {
                //clear hotkey data to allow for new data
                editedMacro.hotkey.Clear();
                string hotKeyText = textBoxHotKey.Text;
                string[] splitHotKey = hotKeyText.Split('+');
                for (int a = 0; a < splitHotKey.Length; a++)
                {
                    Keys key;
                    Enum.TryParse<Keys>(splitHotKey[a], out key);
                    editedMacro.hotkey.Add((int)key);
                }
            }
            //direct input
            editedMacro.directInput = checkBoxDirectInput.Checked;
            //input level
            if (comboBoxInputLevel.Text == "")
            {
                MessageBox.Show("input level is required");
                return;
            }
            else editedMacro.inputLevel = (Macro.InputLevel)(Enum.Parse(typeof(Macro.InputLevel), comboBoxInputLevel.Text));

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancelMacroChanges_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        bool mouseDown = false;
        Point lastLocation;
        private void PnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void PnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void PnlTopBar_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }
        private void PnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }
    }
}
