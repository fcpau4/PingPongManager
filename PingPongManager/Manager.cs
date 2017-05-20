using Firebase.Database;
using System;
using System.Windows.Forms;

namespace PingPongManager
{
    public partial class Manager : Form
    {

        public Manager()
        {
            InitializeComponent();

            // Per sincronitzar amb Firebase
            FirebaseClient firebase = new FirebaseClient("https://pingpongmanager-1d7cc.firebaseio.com/");
            var observable = firebase
                .Child("players")
                .AsObservable<Player>()
                .Subscribe(d => Console.WriteLine(d.Key));

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        //When Players Button is pressed...
        private void onClick(object sender, EventArgs e)
        {
            var str = sender.ToString();
            String[] name = str.Split(':');
            String finalName = name[1].Trim();
           
            if (finalName.Equals("Players"))
            { 
                playerUc playersControl = new playerUc();
                playersControl.Dock = DockStyle.Fill;
                userControlPn.Controls.Add(playersControl);
                
                playersControl.Visible = true;

            }
            
        }
    }
}
