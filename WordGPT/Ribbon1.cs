using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenAI_API;
using Microsoft.Office.Interop.Word;
using OpenAI_API.Chat;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WordGPT
{
    public partial class Ribbon1
    {
        Dictionary<int, string> styles = new Dictionary<int, string>
        {
            {0, "a professional writer"},
            {1, "a science fiction writer"},
            {2, "a truthful journalist"},
            {3, "a factual researcher"}
        };

        Dictionary<int, string> editStyles = new Dictionary<int, string>
        {
            {0, "while keeping it's style"},
            {1, "using more official words"},
            {2, "using simple day to day conversation words"}
        };

        OpenAIAPI api;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private async void button1_Click(object sender, RibbonControlEventArgs e)
        {
            string req = $"You are a {styles[dropDown1.SelectedItemIndex]}. Write a long answer:\n- without greeting the user\n- as if it a text in wikipedia\n- using request's language\nRequest: \"{editBox1.Text}\"";
            button1.Enabled = false;
            string res = await GPTRequest(req);

            PasteString(res);

            editBox1.Text = null; button1.Enabled = true;
        }

        private async void button2_Click(object sender, RibbonControlEventArgs e)
        {
            string req = $"You are a {styles[dropDown1.SelectedItemIndex]}. Write a short answer:\n- without greeting the user\n- as if it a text in wikipedia\n- using request's language\nRequest: \"{editBox1.Text}\"";
            button2.Enabled = false;
            string res = await GPTRequest(req);

            PasteString(res);

            editBox1.Text = null; button2.Enabled = true;
        }

        private void editBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {
            button1.Enabled = editBox1.Text.Length > 0;
            button2.Enabled = editBox1.Text.Length > 0;
        }

        private void group1_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            BigQuery bigQuery = new BigQuery();
            bigQuery.ShowDialog();
        }

        private void group2_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            BigEdit bigEdit = new BigEdit();
            bigEdit.ShowDialog();
        }

        private async void button3_Click(object sender, RibbonControlEventArgs e)
        {
            string req;
            if (editBox2.Text.Length > 0)
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Keep it's structure, but change words to fit the theme \"{editBox2.Text}\". Decrease a number of words.";
            else 
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Decrease a number of words.";
            button3.Enabled = false;
            string res = await GPTRequest(req);

            PasteString(res);

            editBox2.Text = null; button3.Enabled = true;
        }

        private async void button4_Click(object sender, RibbonControlEventArgs e)
        {
            string req;
            if (editBox2.Text.Length > 0)
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Keep it's structure, but change words to fit the theme \"{editBox2.Text}\". Keep a word count.";
            else
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Keep a word count.";
            button4.Enabled = false;
            string res = await GPTRequest(req);

            PasteString(res);

            editBox2.Text = null; button4.Enabled = true;
        }

        private async void button5_Click(object sender, RibbonControlEventArgs e)
        {
            string req;
            if (editBox2.Text.Length > 0)
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Keep it's structure, but change words to fit the theme \"{editBox2.Text}\". Increase a number of words.";
            else
                req = $"{GetSelectedText()}\n\nRewrite this text {editStyles[dropDown2.SelectedItemIndex]}. Keep the language of the text. Increase a number of words.";
            button5.Enabled = false;
            string res = await GPTRequest(req);

            PasteString(res);

            editBox2.Text = null; button5.Enabled = true;
        }

        private void PasteString(string text)
        {
            Selection selection = Globals.ThisAddIn.Application.Selection;
            Range range = selection.Range;

            range.InsertBefore(text);
            range.Collapse(WdCollapseDirection.wdCollapseEnd);
            selection.SetRange(range.Start, range.End);
        }

        private string GetSelectedText()
        {
            Selection selection = Globals.ThisAddIn.Application.Selection;

            if (selection != null && selection.Type == WdSelectionType.wdSelectionNormal)
            {
                string selectedText = selection.Text;

                // Do something with the selected text
                return selectedText;
            }
            return null;
        }

        private async Task<string> GPTRequest(string request)
        {
            api = new OpenAIAPI("");
            Conversation chat = api.Chat.CreateConversation();
            chat.AppendUserInput(request);

            string res = await chat.GetResponseFromChatbotAsync();
            return res;
        }
    }
}