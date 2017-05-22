using System;
using System.Windows.Forms;
using Firebase.Database;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

namespace PingPongManager
{
    public partial class playerUc : UserControl
    {
        public List<Player> playersList;
        private String photoPath;

        public playerUc()
        {
            playersList = new List<Player>();
            InitializeComponent();

        }


        //This method is in charge of saving players asynchronously.
        public async void OnSavePbClick(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            String surname = surnameTb.Text;
            String email = emailTb.Text;


            var firebase = new FirebaseClient("https://pingpongmanager-1d7cc.firebaseio.com/");

            Player player = new Player(photoPath, name, surname, email);

            //Add new item to list of data and let the client generate new key for you (done offline)
            var p1 = await firebase
              .Child("players")
              .PostAsync(player);
        }


        //This method allows to load the image inside the picture box.
        public void OnPlayerImage(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                playerPb.ImageLocation = openFileDialog.FileName;
                photoPath = playerPb.ImageLocation;
            }
        }


        //This method allows to remove text in Text Boxes in one click.
        public void restartPb_Click(object sender, EventArgs e)
        {
            nameTb.Text = "";
            surnameTb.Text = "";
            emailTb.Text = "";
            playerPb.ImageLocation = "";
        }


        /* This Event is launched so that if user clicks on the update tab control, 
         * it's going to load a list of the current players.
         */
        public async void OnTabClicked(object sender, EventArgs e)
        {

            playersLv.Rows.Clear();
            
            Bitmap img;
            TabControl tc = (TabControl)sender;
            int count = 0;

            if (tc.SelectedIndex == 1)
            {
               
                    setDataGridViewProps();

                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                    imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgColumn.Name = "Photo";

                    DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
                    textColumn.Name = "Name";

                    playersLv.Columns.Add(imgColumn);
                    playersLv.Columns.Add(textColumn);

                    FirebaseClient firebase = new FirebaseClient("https://pingpongmanager-1d7cc.firebaseio.com/");
                    var players = await firebase
                        .Child("players")
                        .OnceAsync<Player>();

                    foreach (var p in players)
                    {
                        if (count < players.Count)
                        {
                            Console.WriteLine(p.Object.photo);
                            img = new Bitmap(@p.Object.photo);

                            playersLv.Rows.Add();
                            playersLv.Rows[count].Cells[0].Value = img;
                            playersLv.Rows[count].Cells[1].Value = p.Object.name;


                            //Add each Player Object to the List.
                            playersList.Add(p.Object);
                            count++;
                        }

                    }
                
                
                
            }



        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

    

        public void setDataGridViewProps()
        {
            playersLv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            playersLv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            playersLv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playersLv.AllowUserToAddRows = false;
        }


        //When a Cell is selected...
        public void playersLv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            //DataGridViewRow row = playersLv.Rows[rowIndex];
            Console.WriteLine(rowIndex);

            //I've got all Player objects from the List created when Update Tab was clicked.

            updateImagePb.ImageLocation = playersList[rowIndex].photo;
            updateNameTb.Text = playersList[rowIndex].name;
            updateSurnameTb.Text = playersList[rowIndex].surname;
            updateEmailTb.Text = playersList[rowIndex].email;


        }

        private void removePb_Click(object sender, EventArgs e)
        {

        }
    }
}
