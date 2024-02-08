namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new Personnage();
        public Form1()
        {
            InitializeComponent();
            //Personnage personnage = new Personnage();
            //personnage.PointsDePuissance = 5;
            //personnage.PointsDevie = -10;
            //////personnage.Nom = "Flash";

            ////MessageBox.Show(personnage.PointsDevie.ToString());
            ////if (personnage.EstEnVie )
            ////{

            ////}
            joueur.PointsDevie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDevie = joueur.PointsDevie * 3;
            dragon.PointsDePuissance = 3;


        }
        private void actualiserLabels()
        {
            lbl_pointsVieJoueur.Text = " Vie du joueur : " + joueur.PointsDevie.ToString();
            lbl_pointsVieDragon.Text = "Vie du dragon : " + dragon.PointsDevie.ToString();
            lbl_puissanceAttaqueDragon.Text = " Attaque du dragon : " + dragon.PointsDePuissance.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Attaque du joueur : " + joueur.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {

        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualiserLabels();
        }
    }
}