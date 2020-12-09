using System;
using System.Windows.Forms;

namespace StopList
{
    internal partial class SettingsForm_StopList : Form
    {


       #region Get and Set Options

       public string stopListString { get; set; }
       public bool caseSensitive { get; set; }
       public int WordWindowLeft { get; set; }
       public int WordWindowRight { get; set; }

        #endregion


        private static string windowSizeErrorMsg = "Your word window parameters must be greater than or equal to 0.";


        public SettingsForm_StopList(string SLString, bool caseSense, int WordWindowLeftInput, int WordWindowRightInput)
        {
            InitializeComponent();


            //populate stop list language box, conversions box, and lemmatization box
            StopListLanguageSelector.Items.AddRange(new string[] {
            "Punctuation (Default)",
            "English (Mallet Stop List)",
            "English",
            "Беларуская (Bulgarian)",
            "中文 (Chinese; Jieba Stop List)",
            "čeština (Czech)",
            "français (French)",
            "Deutsch (German)",
            "Magyar (Hungarian)",
            "italiano (Italian)",
            "Македонски (Macedonian)",
            "فارسی (Persian)",
            "polski (Polish)",
            "Pyccĸий (Russian)",
            "Español (Spanish)",
            "Türkçe (Turkish)"});

            StopListLanguageSelector.SelectedIndex = 0;

            if (caseSense)
            {
                caseSensitive = true;
                CaseSensitiveCheckbox.Checked = true;
            }
            else
            {
                caseSensitive = false;
                CaseSensitiveCheckbox.Checked = false;
            }

            StopListTextbox.Text = SLString;

            WordWindowLeftTextbox.Text = WordWindowLeftInput.ToString();
            WordWindowRightTextbox.Text = WordWindowRightInput.ToString();




        }



        private void OKButton_Click(object sender, System.EventArgs e)
        {


            bool isNumeric = int.TryParse(WordWindowLeftTextbox.Text.Trim(), out int n);
            if (!isNumeric)
            {
                MessageBox.Show(windowSizeErrorMsg, "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (int.Parse(WordWindowLeftTextbox.Text.Trim()) < 0)
                {
                    MessageBox.Show(windowSizeErrorMsg, "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            isNumeric = int.TryParse(WordWindowRightTextbox.Text.Trim(), out int o);
            if (!isNumeric)
            {
                MessageBox.Show(windowSizeErrorMsg, "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (int.Parse(WordWindowRightTextbox.Text.Trim()) < 0)
                {
                    MessageBox.Show(windowSizeErrorMsg, "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            this.WordWindowLeft = int.Parse(WordWindowLeftTextbox.Text.Trim());
            this.WordWindowRight = int.Parse(WordWindowRightTextbox.Text.Trim());
            this.stopListString = StopListTextbox.Text;
            this.caseSensitive = (CaseSensitiveCheckbox.Checked);
            this.DialogResult = DialogResult.OK;
        }



        private void LoadStopListButton_Click(object sender, System.EventArgs e)
        {
            StopListTextbox.Text = Properties.Resources.StopListCharacters + Environment.NewLine;

            switch (StopListLanguageSelector.SelectedItem.ToString())
            {
                case "English":
                    StopListTextbox.Text += Properties.Resources.stoplist_english.ToLower();
                    break;

                case "Беларуская (Bulgarian)":
                    StopListTextbox.Text += Properties.Resources.bulgarianST.ToLower();
                    break;

                case "中文 (Chinese; Jieba Stop List)":
                    StopListTextbox.Text = Properties.Resources.ChineseJieba.ToLower();
                    break;

                case "čeština (Czech)":
                    StopListTextbox.Text += Properties.Resources.czechstoplist.ToLower();
                    break;

                case "français (French)":
                    StopListTextbox.Text += Properties.Resources.frenchstoplist.ToLower();
                    break;

                case "Deutsch (German)":
                    StopListTextbox.Text += Properties.Resources.germanstoplist.ToLower();
                    break;

                case "Magyar (Hungarian)":
                    StopListTextbox.Text += Properties.Resources.hungarianST.ToLower();
                    break;

                case "italiano (Italian)":
                    StopListTextbox.Text += Properties.Resources.italianstoplist.ToLower();
                    break;

                case "فارسی (Persian)":
                    StopListTextbox.Text += Properties.Resources.persianST.ToLower();
                    break;

                case "polski (Polish)":
                    StopListTextbox.Text += Properties.Resources.polishST.ToLower();
                    break;

                case "Pyccĸий (Russian)":
                    StopListTextbox.Text += Properties.Resources.russianstoplist.ToLower();
                    break;

                case "Español (Spanish)":
                    StopListTextbox.Text += Properties.Resources.spanishstoplist.ToLower();
                    break;

                case "Türkçe (Turkish)":
                    StopListTextbox.Text += Properties.Resources.turkishstoplist.ToLower();
                    break;

                case "English (Mallet Stop List)":
                    StopListTextbox.Text += Properties.Resources.stoplist_mallet_en.ToLower();
                    break;
                case "Punctuation (Default)":
                    break;

            }

            StopListTextbox.SelectionStart = StopListTextbox.Text.Length;
            StopListTextbox.SelectionLength = 0;
            StopListTextbox.ScrollToCaret();

        }

        private void ClearStopListButton_Click(object sender, EventArgs e)
        {
            StopListTextbox.Text = "";
        }
    }
    
}
