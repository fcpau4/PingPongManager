using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongManager
{
    public class Player
    {
        public String id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String email { get; set; }
        public String photo { get; set; }
        public int pts { get; set; }
        public int gp { get; set; }

        public Player()
        {

        }

      

        public Player(String photo, String name, String surname, String email)
        {
            this.name = name;
            this.photo = photo;
            this.surname = surname;
            this.email = email;
        }

        public override string ToString()
        {
            return "\nId: " + id + "\nName: " + name + "\nPhoto: " + photo + "\nPoints: " + pts + "\nGames Played: " + gp;
        }

        public static explicit operator Player(ListViewItem v)
        {
            throw new NotImplementedException();
        }
    }
}
