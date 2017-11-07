using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class ArmeImporteur
    {
        private Dictionary<String, int> dicoArme { get; }
        private string armeFilePath { get; }
        private string blackListFilePath { get; }
        private List<String> blackList { get; }
        

        public ArmeImporteur()
        {
            // Blacklist à importer
            blackListFilePath = OpenFile();
            // Ajout des arme blacklisté
            Blacklisting();
            // Liste arme à importer
            armeFilePath = OpenFile();
            // Verification et ajout dans le dictionnaire
            ExtractionText();
        }

        public string OpenFile()
        {
            // ouvre une fenetre servant à rechercher le fichier text
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                Filter = "Text Files (*.txt*)|*.txt*",
                FilterIndex = 1,
                Multiselect = false
            };

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                return openFileDlg.FileName;
            }
            else
            {
                return "";
            }
        }

        public void ExtractionText()
        {
            if(armeFilePath != null && File.Exists(armeFilePath))
            {
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(armeFilePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine().ToLower().Trim()) != null)
                    {
                        if (!blackList.Contains(s))
                        {
                            if (dicoArme.ContainsKey(s))
                            {
                                dicoArme[s] += 1;
                            }
                            else
                            {
                                dicoArme.Add(s, 1);
                            }
                        }
                    }
                }
            }
        }

        public void Blacklisting()
        {
            if (blackListFilePath != null && File.Exists(blackListFilePath))
            {
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(blackListFilePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine().ToLower().Trim()) != null)
                    {
                        if (!blackList.Contains(s))
                        {
                            blackList.Add(s);
                        }
                    }
                }
            }
        }

        public void DicoArmeVersArmurerie()
        {
            if(dicoArme.Count > 0)
            {

            }
        }
    }
}
