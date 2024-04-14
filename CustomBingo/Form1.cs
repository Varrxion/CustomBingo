using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CustomBingo
{
    public partial class Form1 : Form
    {
        private string[] loadedLines;
        private string[,] generatedText = new string[5, 5]; // Always set to 5x5
        private bool[,] bingoBoard = new bool[5, 5];
        private bool totalBingo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Menu_File_Load_Click(object sender, EventArgs e) // Renamed to BtnLoad
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedLines = File.ReadAllLines(openFileDialog.FileName);
                btnGenerate.Enabled = true;
            }
        }
        
        private void BtnBingo_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string btnName = clickedButton.Name;
            int btnNum = ExtractNumberFromButtonName(btnName);
            btnNum--;
            int x = btnNum/5;
            int y = btnNum%5;
            if (clickedButton.BackColor == Color.White)
            {
                bingoBoard[x, y] = true;
                clickedButton.BackColor = Color.Green;
                if (!fullBoardCheck())
                {
                    if (totalBingo == true || !BingoCheck())
                    {
                        playSound(btnsound);
                    }
                }
            }
            else
            {
                bingoBoard[x, y] = false;
                BingoCheck();
                clickedButton.BackColor = Color.White;
            }
            
        }

        private void BtnGenerate_Click(object sender, EventArgs e) // Renamed to BtnGenerate
        {
            ResetButtons();
            ResetBingoBoard();

            if (loadedLines == null)
            {
                MessageBox.Show("Please load a text file first.");
                return;
            }

            Control[] controlsArray = tableLayoutPanel1.Controls.OfType<Button>().ToArray();
            int controlIndex = 0;
            Random random = new Random();
            HashSet<int> usedIndices = new HashSet<int>(); // Stores used indices to avoid duplicates

            usedIndices.Add(0);
            controlsArray[12].Text = loadedLines[0];
            generatedText[2, 2] = loadedLines[0];

            for (int i = 0; i < generatedText.GetLength(0); i++) // Loop through 5 rows
            {
                for (int j = 0; j < generatedText.GetLength(1); j++) // Loop through 5 columns
                {
                    if(!(i ==2 && j ==2))
                    {
                        int randomIndex;
                        do
                        {
                            randomIndex = random.Next(loadedLines.Length);
                        } while (usedIndices.Contains(randomIndex)); // Loop until a unique index is found

                        usedIndices.Add(randomIndex); // Add used index to the set

                        generatedText[i, j] = loadedLines[randomIndex];
                        controlsArray[controlIndex].Text = generatedText[i, j];
                    }
                    controlIndex++;
                }
            }
            playSound(gensound);
        }

        private bool BingoCheck()
        {
            bool bingoGet = false;
            // Check rows
            for (int i = 0; i < 5; i++)
            {
                bool rowBingo = true;
                for (int j = 0; j < 5; j++)
                {
                    if (!bingoBoard[i, j])
                    {
                        rowBingo = false;
                        break;
                    }
                }
                if (rowBingo)
                {
                    bingoGet=true;
                }
            }

            // Check columns
            for (int j = 0; j < 5; j++)
            {
                bool colBingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!bingoBoard[i, j])
                    {
                        colBingo = false;
                        break;
                    }
                }
                if (colBingo)
                {
                    bingoGet = true;
                }
            }

            // Check diagonals
            bool diagonalBingo1 = true;
            bool diagonalBingo2 = true;
            for (int i = 0; i < 5; i++)
            {
                if (!bingoBoard[i, i])
                {
                    diagonalBingo1 = false;
                }
                if (!bingoBoard[i, 4 - i])
                {
                    diagonalBingo2 = false;
                }
            }
            if (diagonalBingo1 || diagonalBingo2)
            {
                bingoGet = true;
            }
            if (bingoGet && totalBingo==false)
            {
                totalBingo = true;
                playSound(bingosound);
            }
            else
            {
                totalBingo = bingoGet;
            }

            if (totalBingo)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }

            return bingoGet;
        }

        //checks if the entire board is filled
        private bool fullBoardCheck()
        {
            for (int i = 0; i < bingoBoard.GetLength(0); i++) // Loop over rows
            {
                for (int j = 0; j < bingoBoard.GetLength(1); j++) // Loop over columns
                {
                    if (!bingoBoard[i, j]) // If any element is false
                    {
                        return false;
                    }
                }
            }
            playSound(eastersound);
            return true;
        }

        //You can add your own stuff here. I wont be uploading what I used for copyright reasons
        const string btnsound = "CustomBingo.Resources.btnsound.wav";
        const string bingosound = "CustomBingo.Resources.bingsound.wav";
        const string gensound = "CustomBingo.Resources.gensound.wav";
        const string eastersound = "CustomBingo.Resources.eastersound.wav";


        //plays embedded resources (wav only)
        private void playSound (string sound)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            // Play sound
            using (Stream stream = assembly.GetManifestResourceStream(sound))
            {
                if (stream != null)
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.Play();
                }
            }
        }

        private int ExtractNumberFromButtonName(string btnName)
        {
            string pattern = @"\d+";
            Match match = Regex.Match(btnName, pattern);
            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            else
            {
                // Handle the case where no number is found in the button name
                Console.WriteLine("No number found in button name.");
                return -1; // Or any other appropriate default value
            }
        }

        private void ResetBingoBoard()
        {
            foreach (int i in Enumerable.Range(0, bingoBoard.GetLength(0))) // Loop over rows
            {
                foreach (int j in Enumerable.Range(0, bingoBoard.GetLength(1))) // Loop over columns
                {
                    bingoBoard[i, j] = false; // Set each element to false
                }
            }
            totalBingo = false;
        }

        private void ResetButtons()
        {
            Control[] controlsArray = tableLayoutPanel1.Controls.OfType<Button>().ToArray();
            foreach (int i in Enumerable.Range(0, controlsArray.Length)) // Loop over rows
            {
                controlsArray[i].BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuBoardSaveClick(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Save Bingo Board State"; // Optional title for the dialog

                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<ButtonData> buttonDataList = new List<ButtonData>();

                    foreach (int i in Enumerable.Range(0, bingoBoard.GetLength(0)))
                    {
                        foreach (int j in Enumerable.Range(0, bingoBoard.GetLength(1)))
                        {
                            buttonDataList.Add(new ButtonData { Task = generatedText[i, j], Clicked = bingoBoard[i, j] });
                        }
                    }

                    string jsonData = JsonConvert.SerializeObject(buttonDataList);
                    File.WriteAllText(saveFileDialog.FileName, jsonData);
                }
            }
        }

        private void menuBoardLoadClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            string jsonData;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                jsonData = File.ReadAllText(openFileDialog.FileName);
                List<ButtonData> buttonDataList = JsonConvert.DeserializeObject<List<ButtonData>>(jsonData);
                Control[] controlsArray = tableLayoutPanel1.Controls.OfType<Button>().ToArray();

                foreach (int i in Enumerable.Range(0, bingoBoard.GetLength(0))) // Loop over rows
                {
                    foreach (int j in Enumerable.Range(0, bingoBoard.GetLength(1))) // Loop over columns
                    {
                        bingoBoard[i, j] = buttonDataList[i * 5 + j].Clicked;

                        controlsArray[i * 5 + j].Text = buttonDataList[i*5+j].Task;

                        if(buttonDataList[i * 5 + j].Clicked)
                        {
                            controlsArray[i * 5 + j].BackColor = Color.Green;
                        }
                        else
                        {
                            controlsArray[i * 5 + j].BackColor = Color.White;
                        }
                    }
                }
            }
        }

        [Serializable]
        public class ButtonData
        {
            [JsonProperty]
            public string Task { get; set; }
            [JsonProperty]
            public bool Clicked { get; set; }
        }
    }

}
