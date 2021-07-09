using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using System.Linq;

namespace StopList
{
    public class StopList : Plugin
    {


        public string[] InputType { get; } = { "Tokens" };
        public string OutputType { get; } = "Tokens";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "TokenizedText" } };
        public bool InheritHeader { get; } = false;

        private string stopListString = Properties.Resources.StopListCharacters;
        private bool caseSensitive = false;
        private HashSet<string> stopList { get; set; }
        private int WordWindowLeft { get; set; } = 0;
        private int WordWindowRight { get; set; } = 0;



        #region Plugin Details and Info

        public string PluginName { get; } = "Remove Stop Words";
        public string PluginType { get; } = "Preprocessing";
        public string PluginVersion { get; } = "1.0.31";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Omit words from your list of tokens.";
        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "Coming Soon";

        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_StopList(stopListString, caseSensitive, WordWindowLeft, WordWindowRight))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    stopListString = form.stopListString;
                    caseSensitive = form.caseSensitive;
                    WordWindowLeft = form.WordWindowLeft;
                    WordWindowRight = form.WordWindowRight;
                }
            }

        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;

            for (int i = 0; i < Input.StringArrayList.Count; i++)
            {

                for (int tokenPosition = 0; tokenPosition < Input.StringArrayList[i].Length; tokenPosition++)
                {
                    //when we find a token that matches something in the stop list...
                    if (stopList.Contains(Input.StringArrayList[i][tokenPosition]))
                    {
                        //we make that token an empty string
                        Input.StringArrayList[i][tokenPosition] = String.Empty;

                        //then we obliterate everything to the left, where appropriate
                        if (WordWindowLeft > 0)
                        {
                            for (int leftOffset = 1; (leftOffset <= WordWindowLeft) && (tokenPosition - leftOffset >= 0); leftOffset++)
                            {
                                Input.StringArrayList[i][tokenPosition - leftOffset] = String.Empty;
                            }
                        }

                        //aaaaand to the right as well
                        if (WordWindowRight > 0)
                        {
                            for (int rightOffset = 1; (rightOffset <= WordWindowRight) && (tokenPosition + rightOffset < Input.StringArrayList[i].Length); rightOffset++)
                            {
                                Input.StringArrayList[i][tokenPosition + rightOffset] = String.Empty;
                            }
                        }

                    }
                }

                pData.StringArrayList.Add(Input.StringArrayList[i].Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
                pData.SegmentNumber.Add(Input.SegmentNumber[i]);
            }

            return (pData);

        }



        public void Initialize()
        {

            stopList = new HashSet<string>();

            string[] stoplistTemp = new string[0];

            if (caseSensitive)
            {
                stoplistTemp = stopListString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            }
            else
            {
                stoplistTemp = stopListString.ToLower().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            }
            
            for (int i = 0; i < stoplistTemp.Length; i++) stoplistTemp[i] = stoplistTemp[i].Trim();

            stopList = new HashSet<string>(stoplistTemp);


        }




        public bool InspectSettings()
        {
            return true;
        }



        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }




        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            stopListString = SettingsDict["stopListString"];
            caseSensitive = Boolean.Parse(SettingsDict["caseSensitive"]);
            WordWindowLeft = Convert.ToInt32(SettingsDict["WordWindowLeft"]);
            WordWindowRight = Convert.ToInt32(SettingsDict["WordWindowRight"]);
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("stopListString", stopListString);
            SettingsDict.Add("caseSensitive", caseSensitive.ToString());
            SettingsDict.Add("WordWindowLeft", WordWindowLeft.ToString());
            SettingsDict.Add("WordWindowRight", WordWindowRight.ToString());
            return (SettingsDict);
        }
        #endregion


    }
}
