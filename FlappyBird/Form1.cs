using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Anna Volková
//PRG2 2020/2021
//Zápočtový program - Flappy Bird

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        // region : promenne
        int gravitace = 3; //o gravitaci se zmeni ptackova pozice o 3 smerem dolu po ose x pohybuje (tzn. zajistuje padani)
        readonly int rychlostprekazek = 4; //slouzi k posunuti prekazek smerem doleva
        double skoreHrace = 0;
        // end region

        public Form1()
        {
            InitializeComponent();
            NastavStav(Stav.START); //nastaveni 'defaultiho' stavu
        }

        // region : stavy
        enum Stav { START, HRA, KONEC};
        Stav stav;

        void NastavStav(Stav novy)
        {
            switch (novy)
            {
                case Stav.START:
                    prekazkaDOWN.Visible = false;
                    prekazkaTOP.Visible = false;
                    prekazkaDOWN2.Visible = false;
                    prekazkaTOP2.Visible = false;
                    prekazkaDOWN3.Visible = false;
                    prekazkaTOP3.Visible = false;
                    ptacek.Visible = false;
                    startNapis.Visible = true;
                    konecNapis.Visible = false;
                    hratZnovu.Visible = false;
                    zmackniMe.Visible = false;
                    vysledekLabel.Visible = false; //stav START zobrazuje uvitaci obrazovku a skore, nic jineho

                    skoreHrace = 0; //skore je na zacatku hry nastaveno na 0 
                    skore.Text = "Počet kreditů: 0"; 
                    gravitace = 3; //nastaveni gravitace na hodnotu 6 je potreba v pripade opakovane hry 

                    ptacek.Left = 125;
                    ptacek.Top = 195; //umisteni ptacka na defaultni pozici

                    prekazkaDOWN.Left = 208;
                    prekazkaDOWN.Top = 280;
                    prekazkaTOP.Left = 208;
                    prekazkaTOP.Top = -170;

                    prekazkaDOWN2.Left = 338;
                    prekazkaDOWN2.Top = 330;
                    prekazkaTOP2.Left = 338;
                    prekazkaTOP2.Top = -120;

                    prekazkaDOWN3.Left = 460;
                    prekazkaDOWN3.Top = 300;
                    prekazkaTOP3.Left = 460;
                    prekazkaTOP2.Top = -150; //umisteni prekazek na defaultni pozici
                    break;
                case Stav.HRA:
                    prekazkaDOWN.Visible = true;
                    prekazkaTOP.Visible = true;
                    prekazkaDOWN2.Visible = true;
                    prekazkaTOP2.Visible = true;
                    prekazkaDOWN3.Visible = true;
                    prekazkaTOP3.Visible = true;
                    ptacek.Visible = true;
                    startNapis.Visible = false;
                    konecNapis.Visible = false;
                    hratZnovu.Visible = false;
                    zmackniMe.Visible = false;
                    vysledekLabel.Visible = false; //ve stavu HRA se zobrazi prekazky, ptacek, zmizi uvitaci a gameover obrazovka
                    break;
                case Stav.KONEC:
                    prekazkaDOWN.Visible = false;
                    prekazkaTOP.Visible = false;
                    prekazkaDOWN2.Visible = false;
                    prekazkaTOP2.Visible = false;
                    prekazkaDOWN3.Visible = false;
                    prekazkaTOP3.Visible = false;
                    ptacek.Visible = false;
                    startNapis.Visible = false;
                    konecNapis.Visible = true;
                    hratZnovu.Visible = true;
                    zmackniMe.Visible = true;

                    if (skoreHrace < 10)
                    {
                        vysledekLabel.Text = "To teda nic moc";
                        
                    }
                    if (skoreHrace < 20 & skoreHrace > 10)
                    {
                        vysledekLabel.Text = "Po prváku konec";
                    }
                    if (skoreHrace < 40 & skoreHrace > 20)
                    {
                        vysledekLabel.Text = "Takovej kousek!";
                    }
                    if (skoreHrace >= 40)
                    {
                        vysledekLabel.Text = "Bc. Flappy Bird!";
                    }

                    int delkavysledku = vysledekLabel.Width;
                    vysledekLabel.Left = (int)Math.Ceiling((288 - Convert.ToDouble(delkavysledku))/2);

                    vysledekLabel.Visible = true; //pri stavu KONEC se zobrazi gameover napisy, zmizi ptacek a prekazky, uvitaci obrazovka take neni videt
                    break;
                default:
                    break;
            }
            stav = novy;
        }
        //end region
        //region : management prekazek
        private void PosouvaniPrekazky(int index)
        {
            List<System.Windows.Forms.PictureBox> prekazky = new List<PictureBox>();
            // slouzi k uchovani prekazek, aby se s nimi lepe pracovalo, abych jimi mohla iterovat
            prekazky.Add(prekazkaTOP);
            prekazky.Add(prekazkaDOWN);
            prekazky.Add(prekazkaTOP2);
            prekazky.Add(prekazkaDOWN2);
            prekazky.Add(prekazkaTOP3);
            prekazky.Add(prekazkaDOWN3); //pridani vsech prekazek do listu prekazky

            Random randomCislo = new Random();

            if (index == 1)
            {
                foreach (System.Windows.Forms.PictureBox pre in prekazky) //posunuti vsechn prekazek smerem doleva k ptackovi, 
                {
                    pre.Left -= rychlostprekazek; //aby vypadalo, ze se ptacek priblizuje k prekazkam

                }

                for (int i = 0; i < 6; i++) //pokud prekazka je mimo obrazovku vlevo, je premistena mimo obrazovku vpravo
                {
                    System.Windows.Forms.PictureBox p = prekazky[i]; //aby dochazelo k 'nekonecnemu' behu prekazek

                    if (p.Left < -51)
                    {
                        p.Left = 338;
                        if (p.Tag.Equals("TP")) //rozeznani prekazek podle tagu, TP znamena prekazka, ktera je v horni casti obrazovky
                        {
                            p.Top = randomCislo.Next(-230, -101); //prekazky jsou umistovany ruzne vysoko v intervalu <-230, -101> v pripade TOP prekazky
                            prekazky[i + 1].Left = 338; //aby nebyly stale stejne vysoko a hra byla o neco stizena, na tomto radku dochazi k posunu doprava
                            prekazky[i + 1].Top = p.Top + 450; // aby byla mezi prekazkami stale stejna mezera, vyska DOWN prekazky je dana vyskou TOP prekazky
                        }
                    }                       
                }
            }

            if(index == 0) //osetreni v pripade stavu KONEC, aby nebyly prekazky generovany, kdyz hrac prohral a pri stavu HRA
            {
                return; 
            }
        }
        //end region
        //region : 'gameEngine'
        private void CasovacHryEvent(object sender, EventArgs e)
        {
            if (stav == Stav.HRA) //podminka, aby reseni kolizi, skore a posun ptacka probihal jen pokud se stav HRA, jinak by se musel stopovat timer                              a to se mi nechtelo :)
            {
                ptacek.Top += gravitace; //zmena pozice ptacka, aby stale padal
                PosouvaniPrekazky(1); //iniciace posouvani prekazek
                zeme.BringToFront(); //picturebox zeme a skore renderuju do popredi v tomto poradi, aby pohybujici se prekazky
                skore.BringToFront(); //zakryvala zemi a skore, a aby zeme zakryvala skore
                skoreHrace += 0.022; //zvysovani skore, aby to vychazelo s timerem na minuti prekazky
                int intSkore = Convert.ToInt32(skoreHrace);
                skore.Text = "Počet kreditů: " + intSkore.ToString();

                // nize resim kolize, pokud ptacek narazi do prekazek, zeme, ci je moc vysoko (mimo okno) nastavim stav KONEC
                //System.Windows.Forms.PictureBox prek in prekazky
                if (ptacek.Bounds.IntersectsWith(zeme.Bounds) || ptacek.Top < -15 || ptacek.Bottom > 350 || ptacek.Bounds.IntersectsWith(prekazkaTOP.Bounds)
                   || ptacek.Bounds.IntersectsWith(prekazkaDOWN.Bounds) || ptacek.Bounds.IntersectsWith(prekazkaTOP2.Bounds)
                   || ptacek.Bounds.IntersectsWith(prekazkaDOWN2.Bounds) || ptacek.Bounds.IntersectsWith(prekazkaTOP3.Bounds)
                   || ptacek.Bounds.IntersectsWith(prekazkaDOWN3.Bounds))
                {
                    PosouvaniPrekazky(0);
                    NastavStav(Stav.KONEC);
                }
            }
        }
        //end region
        //region : ovladani
        private void KeyDownEvent(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Space && stav == Stav.HRA) //ovladani ptacka, pouze ve stavu HRA, pokud hrac stiskne mezernik, ptacek vyleti nahoru
            {
                if (gravitace > -16) //pokud by tu tato podminka nebyla, hrac by mohl pri dlouhem drzeni mezerniku vystrelit nahoru
                    gravitace += -8;
                else
                    gravitace = 3; //v pripade, ze rychlost letu vzhuru by presahla limit, ptak zacne znovu padat dolu               
            }

            if (stav == Stav.KONEC)
            {
                if (e.KeyCode == Keys.Escape) //pokud chce hrac skoncit, ve stavu KONEC stiskne ESC
                {
                    Application.Exit();
                }

                NastavStav(Stav.START); //jinak pokud ve stavu KONEC stiskne mezernik, hrac se vrati na uvitaci obrazovku
            }

            if (stav == Stav.START)
            {
                NastavStav(Stav.HRA); //iniciace hry, ve stavu START hrac zmackne mezernik
            }
        }
        private void KeyUpEvent(object sender, KeyEventArgs e) //po uvolneni je gravitace zmenena o 6, aby ptacek 
        {
            if (e.KeyCode == Keys.Space) //misto padani nezacal letet vzhuru
            {
                gravitace = 3;
            }
        }
        //endregion        
    }
}
