using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_SearchFiles
{
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Список найденных файлов.
        /// </summary>
        private ListBox listBox;
        /// <summary>
        /// Путь поиска файлов.
        /// </summary>
        private string path;



        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="_listBox">Список файлов.</param>
        public SearchForm(ListBox _listBox)
        {
            InitializeComponent();

            this.listBox = _listBox;
            this.path = null;

            this.Load += SearchForm_Load;
        }



        // Обработчики.


        /// <summary>
        /// Обработчик загрузки формы поиска.
        /// </summary>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.buttonSelectAFolder.Click += ButtonSelectAFolder_Click;

            this.buttonSearchFiles.Click += ButtonSearchFiles_Click;

            this.buttonSearchFormCancel.Click += ButtonSearchFormCancel_Click;
        }


        /// <summary>
        /// Обработчик кнопки отмены поиска.
        /// </summary>
        private void ButtonSearchFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Обработчик кнопки поиска файлов.
        /// </summary>
        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();

            // Если папка выбрана.
            if (this.path != null)
            {
                this.AddToTheListFoundFiles();
            }
        }


        /// <summary>
        /// Обработчик выбора папки, в которой будет производиться поиск файлов.
        /// </summary>
        private void ButtonSelectAFolder_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder 
                    = Environment.SpecialFolder.LocalizedResources;
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    this.path = folderBrowserDialog.SelectedPath;

                    this.textBoxShowFullPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }



        // Методы.


        /// <summary>
        /// Добавить в список файлов найденные файлы,
        /// по указанному пути и маске.
        /// </summary>
        private void AddToTheListFoundFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(this.path);
            

            Regex regex = new Regex(ComputeFileMaskPattern());


            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                if (regex.IsMatch(item.Name) == true)
                {
                    this.listBox.Items.Add(item);
                }

            }
        }


        /// <summary>
        /// Вычисляем шаблон маски файла для поиска.
        /// </summary>
        /// <returns>Строка шаблона.</returns>
        private string ComputeFileMaskPattern()
        {
            if (this.textBoxSearchMask.Text == "")
            {
                return "^$";
            }
            else
            {
                return "^" + this.textBoxSearchMask.Text + "$";
            }
        }


    }
}