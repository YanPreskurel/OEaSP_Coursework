using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace AFConverter
{
    public partial class Converter : Form
    {
        private string[] formats = new string[] { ".mp3", ".wav", ".flac", ".odd" };
        private string itemFrom = null;
        private string itemIn = null;
        string fileExtension = null;
        string filePath = null;
        string fileName = null;
        public Converter()
        {
            InitializeComponent();

            comboBoxFrom.Items.AddRange(formats);
            comboBoxIn.Items.AddRange(formats);
        }
        private void LabelFrom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the file extension you want to convert",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
        private void LabelIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the extension you want to convert to",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void ComboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выпадающий список для From

            itemFrom = comboBoxFrom.SelectedItem.ToString();
            comboBoxFrom.ForeColor = System.Drawing.Color.Black;
        }
        private void ComboBoxIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выпадающий список для In

            itemIn = comboBoxIn.SelectedItem.ToString();
            comboBoxIn.ForeColor = System.Drawing.Color.Black;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Audio Files (*.mp3, *.wav, *.flac, *.odd)|*.mp3;*.wav;*.flac;*.odd";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь к выбранному файлу
                    filePath = openFileDialog.FileName;

                    // Получаем имя выбранного файла
                    fileName = openFileDialog.SafeFileName;
                    fileExtension = Path.GetExtension(filePath);

                    // Отображаем имя выбранного аудио файла
                    listViewAudio.Items.Clear();
                    listViewAudio.Items.Add(fileName);
                }
            }
        }
        private void ConvertioButton_Click(object sender, EventArgs e)
        {
            // Кнопка для конвертации

            bool conversionResult = ConversionMistakes();

            if (conversionResult)
            {
                DialogResult result = MessageBox.Show("Do you want to download a file?",
                                                      "The conversion is completed",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button1,
                                                      MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    ConversionLogic();

                    itemFrom = null;
                    itemIn = null;
                    filePath = null;
                    fileName = null;
                    fileExtension = null;

                    comboBoxIn.Text = "Choose";
                    comboBoxIn.ForeColor = System.Drawing.Color.LightSeaGreen;

                    comboBoxFrom.Text = "Choose";
                    comboBoxFrom.ForeColor = System.Drawing.Color.LightSeaGreen;

                    listViewAudio.Items.Clear();
                }                
            }
            else
            {
                MessageBox.Show("Sorry, let's try that again!",
                                "Conversion error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private bool ConversionMistakes()
        {
            if (filePath is null || fileName is null || itemFrom is null || itemIn is null || itemFrom != fileExtension || itemIn == fileExtension)
                return false;   

            return true;
        }
        private void ConversionLogic()
        {
            string extension = itemIn;

            try
            {
                switch (extension)
                {
                    case ".mp3":

                        ConvertToMp3(filePath);
                        break;

                    case ".wav":
                        ConvertToWav(filePath);
                        break;

                    case ".flac":
                        ConvertToFlac(filePath);
                        break;

                    case ".odd":
                        ConvertToOdd(filePath);
                        break;

                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, let's try that again!",
                                $"Conversion failed: {ex.Message}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void ConvertToMp3(string filePath)
        {
            // Создаем новый путь для сохранения файла в папке загрузки
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string convertedFilePath = Path.Combine(downloadPath, Path.GetFileNameWithoutExtension(filePath) + ".mp3");

            // Конвертируем файл и сохраняем его в папке загрузки
            using (var reader = new AudioFileReader(filePath))
            {
                WaveFileWriter.CreateWaveFile(convertedFilePath, reader);
            }

            MessageBox.Show("The file has been successfully saved to the download folder!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
        private void ConvertToWav(string filePath)
        {
            // Создаем новый путь для сохранения файла в папке загрузки
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string convertedFilePath = Path.Combine(downloadPath, Path.GetFileNameWithoutExtension(filePath) + ".wav");

            // Конвертируем файл и сохраняем его в папке загрузки
            using (var reader = new AudioFileReader(filePath))
            {
                WaveFileWriter.CreateWaveFile(convertedFilePath, reader);
            }

            MessageBox.Show("The file has been successfully saved to the download folder!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        } 
        private void ConvertToFlac(string filePath)
        {
            // Создаем новый путь для сохранения файла в папке загрузки
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string convertedFilePath = Path.Combine(downloadPath, Path.GetFileNameWithoutExtension(filePath) + ".flac");

            // Конвертируем файл и сохраняем его в папке загрузки
            using (var reader = new AudioFileReader(filePath))
            {
                WaveFileWriter.CreateWaveFile(convertedFilePath, reader);
            }

            MessageBox.Show("The file has been successfully saved to the download folder!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
        private void ConvertToOdd(string filePath)
        {
            // Создаем новый путь для сохранения файла в папке загрузки
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string convertedFilePath = Path.Combine(downloadPath, Path.GetFileNameWithoutExtension(filePath) + ".odd");

            // Конвертируем файл и сохраняем его в папке загрузки
            using (var reader = new AudioFileReader(filePath))
            {
                WaveFileWriter.CreateWaveFile(convertedFilePath, reader);
            }

            MessageBox.Show("The file has been successfully saved to the download folder!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
