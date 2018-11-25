using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace project___one_liners___jokes
{
    public partial class JokeHub : Form
    {
        
        public JokeHub()
        {
            InitializeComponent();
        }
        // UPISIVANJE U BAZU PODATAKA
        private void submitBtn_Click(object sender, EventArgs e)
        {   

            // UNOS U BAZU

            //ERROR FOR EMPTY TEXTBOX 
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please insert text before submiting joke");
            }
            else
            { 
                        //string za unos z bazu
                string questionString = textBox1.Text;
                string punchlineString = textBox2.Text;


                //string za odabir kategorije
                string choose, pitanje, odgovor, lajkovi;

                if (radioButton1.Checked == true)
                {
                    choose = "dirty";
                    pitanje = "dirtyQuestion";
                    odgovor = "dirtyPunchline";
                    lajkovi = "likeDirty";
                } else if (radioButton2.Checked == true)
                {
                    choose = "puns";
                    pitanje = "punsQuestion";
                    odgovor = "punsPunchline";
                    lajkovi = "likePuns";
                } else if (radioButton3.Checked == true)
                {
                    choose = "knock_knock";
                    pitanje = "kkQuestion";
                    odgovor = "kkPunchline";
                    lajkovi = "likeKnock_knock";
                }
                else if(radioButton4.Checked == true)
                {
                    choose = "bad_jokes";
                    pitanje = "bad_jokeQuestion";
                    odgovor = "bad_jokePunchline";
                    lajkovi = "likeBadJoke";
                } else
                {
                    choose = "other";
                    pitanje = "otherQuestion";
                    odgovor = "otherPunchline";
                    lajkovi = "likeOther";
                }
               
                

                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "INSERT INTO '"+choose+"' ('"+pitanje+"','"+odgovor+"','"+lajkovi+"') VALUES ('" + questionString + "','" + punchlineString + "',0);";
                        SQLiteDataReader myReader
                        = myCommand.ExecuteReader();
                        //za izpraznit texbox nakon unosa u bazu
                        textBox1.Text = "";
                        textBox2.Text = "";


                        myCommand.Dispose();
                    }
                   myConnection.Close();
                }
                
            }
            MessageBox.Show("Joke successfully submitted");
            Application.Restart();

        }


        // DON'T TOUCH !!!
        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }
        // DON'T TOUCH !!!
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }




        int dirtyGranica = 1;
        int punsGranica = 1;
        int knock_knockGranica = 1;
        int bad_jokesGranica = 1;
        int otherGranica = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

            //broj fori
            // BROJ FORI U DIRTY                   
            using (SQLiteConnection myConnection
                    = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT COUNT(*) FROM dirty;";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        dirtyGranica = myReader.GetInt32(0);
                        
                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }


                     // BROJ FORI U PUNS
                    using (SQLiteConnection myConnection
                    = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT COUNT(*) FROM puns;";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        punsGranica = myReader.GetInt32(0);

                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

                    //BROJ FORI U KNOCK KNOCK                    
                    using (SQLiteConnection myConnection
                    = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT COUNT(*) FROM knock_knock;";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        knock_knockGranica = myReader.GetInt32(0);

                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

                    //BROJ FORI BAD_JOKES                    
                    using (SQLiteConnection myConnection
                    = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT COUNT(*) FROM bad_jokes;";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        bad_jokesGranica = myReader.GetInt32(0);

                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

                    //BROJ FORI ZA OTHER                    
                    using (SQLiteConnection myConnection
                    = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT COUNT(*) FROM other;";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        otherGranica = myReader.GetInt32(0);

                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }





            // pomocne za dodavanje labela i buttona
            int i, dodavanje = 0;
            string iadd;
           
    

            // dodavanje labela i buttona na DIRTY
            dodavanje = 0;
            int adding = 0, likeAdding = 0, numLikeAdding = 0, likes = 0;
            string likesDirty = "";
            for (i = 1; i <= dirtyGranica; i++)
            {

                string questionString = "", punchlineString = "";
                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();


                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "SELECT * FROM dirty WHERE id='"+i+"';";

                        SQLiteDataReader myReader
                            = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            questionString = myReader.GetString(0);
                            punchlineString = myReader.GetString(1);
                            likes = myReader.GetInt32(3);
                            likesDirty = likes.ToString();
                            

                        }


                        //pocetak imena za sve dirty labele
                        string dirtylbl = "dirtyQuestion";
                        
                        //stvaranje novih labela
                        Label questionLbl = new Label();
                        questionLbl.Size = new Size(800, 20);
                        questionLbl.Location = new Point(20, 10 + dodavanje);
                        dirtyPage.Controls.Add(questionLbl);
                        dodavanje += 80;
                        iadd = i.ToString();
                        dirtylbl += iadd;
                        questionLbl.Name = dirtylbl;
                        questionLbl.Text = questionString;


                        //stvaranje novih buttona
                        string dirtyReveal = "dirtyPunchline";
                        Button dirtyBtn = new Button();
                        dirtyBtn.Size = new Size(100,30);
                        dirtyBtn.Location = new Point(20,40+adding);
                        dirtyPage.Controls.Add(dirtyBtn);
                        adding += 80;
                        dirtyReveal += iadd;
                        dirtyBtn.Name = dirtyReveal;
                        dirtyBtn.Text = "Reveal Punchline";



                        // stvaranje like buttona 
                        // spremit boolean da li je button kliknut
                        
                        Button likeBtn = new Button();
                        likeBtn.Size = new Size(50, 30);
                        likeBtn.Location = new Point(20+dirtyBtn.Width+15, 40+likeAdding);
                        likeBtn.Name = iadd;
                        dirtyPage.Controls.Add(likeBtn);
                        likeAdding += 80;
                        likeBtn.Text = "Like";
                        likeBtn.Click += delegate
                        {
                            likeBtn.BackColor = Color.Blue;
                            using (SQLiteConnection updateConnection = new SQLiteConnection("data source = fore.db"))
                            {
                                likeBtn.BackColor = Color.Blue;
                                updateConnection.Open();
                                using (SQLiteCommand likeDirtyUpdate = new SQLiteCommand(updateConnection))
                                {
                                    likeDirtyUpdate.CommandText = "UPDATE dirty SET likeDirty = likeDirty+1 WHERE id = '"+likeBtn.Name+"';";
                                    likeDirtyUpdate.ExecuteNonQuery();
                                    likeDirtyUpdate.Dispose();
                                }
                                updateConnection.Close();
                            }
                            Application.Restart();
                        };



                        


                        // stvaranje labela za broj lajkova
                        
                        string nameLikeLbl = "sumLikesLbl";
                        Label likeLbl = new Label();
                        likeLbl.Size = new Size(100,20);
                        likeLbl.Location = new Point(50 + dirtyBtn.Width + 30 + 15,45+numLikeAdding);
                        dirtyPage.Controls.Add(likeLbl);
                        numLikeAdding += 80;
                        nameLikeLbl += iadd;
                        likeLbl.Name = nameLikeLbl;
                        likeLbl.Font = new Font("Comic Sans MS",12);
                        likeLbl.Text = likesDirty;
                        

                        dirtyBtn.Click += delegate
                       {
                           MessageBox.Show(punchlineString);
                       };
                        

                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }
            }


            // dodavanje labela i buttona na PUNS
            likeAdding = 0;
            numLikeAdding = 0;
            dodavanje = 0;
            adding = 0;
            int intPunLikes = 0;
            string punLikes = "";
            for (i = 1; i <= punsGranica; i++)
            {
                string questionString = "", punchlineString = "";
                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "SELECT * FROM puns WHERE id='" + i + "';";

                        SQLiteDataReader myReader
                            = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            questionString = myReader.GetString(0);
                            punchlineString = myReader.GetString(1);
                            intPunLikes = myReader.GetInt32(3);
                            punLikes = intPunLikes.ToString();
                        }

                        //pocetak imena za sve dirty labele
                        string punslbl = "punsQuestion";

                        //stvaranje novih labela
                        Label questionLbl = new Label();
                        questionLbl.Size = new Size(800, 20);
                        questionLbl.Location = new Point(20, 10 + dodavanje);
                        punsPage.Controls.Add(questionLbl);
                        dodavanje += 80;
                        iadd = i.ToString();
                        punslbl += iadd;
                        questionLbl.Name = punslbl;
                        questionLbl.Text = questionString;


                        //stvaranje novih buttona
                        string punsReveal = "punsPunchline";
                        Button punsBtn = new Button();
                        punsBtn.Size = new Size(100, 30);
                        punsBtn.Location = new Point(20, 40 + adding);
                        punsPage.Controls.Add(punsBtn);
                        adding += 80;
                        punsReveal += iadd;
                        punsBtn.Name = punsReveal;
                        punsBtn.Text = "Reveal Punchline";

                        //stvaranje like buttona
                        Button likeBtn = new Button();
                        likeBtn.Size = new Size(50, 30);
                        likeBtn.Location = new Point(20 + punsBtn.Width + 15, 40 + likeAdding);
                        likeBtn.Name = iadd;
                        punsPage.Controls.Add(likeBtn);
                        likeAdding += 80;
                        likeBtn.Text = "Like";
                        likeBtn.Click += delegate
                        {
                            likeBtn.BackColor = Color.Blue;
                            using (SQLiteConnection updateConnection = new SQLiteConnection("data source = fore.db"))
                            {
                                likeBtn.BackColor = Color.Blue;
                                updateConnection.Open();
                                using (SQLiteCommand punsUpdate = new SQLiteCommand(updateConnection))
                                {
                                    punsUpdate.CommandText = "UPDATE puns SET likePuns = likePuns+1 WHERE id = '" + likeBtn.Name + "';";
                                    punsUpdate.ExecuteNonQuery();
                                    punsUpdate.Dispose();
                                }
                                updateConnection.Close();
                            }
                            Application.Restart();
                        };






                        // stvaranje labela za broj lajkova

                        string nameLikeLbl = "sumLikesLbl";
                        Label likeLbl = new Label();
                        likeLbl.Size = new Size(100, 20);
                        likeLbl.Location = new Point(50 + punsBtn.Width + 30 + 15, 45 + numLikeAdding);
                        punsPage.Controls.Add(likeLbl);
                        numLikeAdding += 80;
                        nameLikeLbl += iadd;
                        likeLbl.Name = nameLikeLbl;
                        likeLbl.Font = new Font("Comic Sans MS", 12);
                        likeLbl.Text = punLikes;



                        //messagebox sa punchline na button click
                        punsBtn.Click += delegate
                        {
                            MessageBox.Show(punchlineString);
                        };






                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }
            }



            //dodavanje label i buttona na KNOCK KNOCK
            likeAdding = 0;
            numLikeAdding = 0;
            dodavanje = 0;
            adding = 0;
            intPunLikes = 0;
            punLikes = "";
            for (i = 1; i <= knock_knockGranica; i++)
            {
                string questionString = "", punchlineString = "";
                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "SELECT * FROM knock_knock WHERE id='" + i + "';";

                        SQLiteDataReader myReader
                            = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            questionString = myReader.GetString(0);
                            punchlineString = myReader.GetString(1);
                            intPunLikes = myReader.GetInt32(3);
                            punLikes = intPunLikes.ToString();
                        }

                        //pocetak imena za sve dirty labele
                        string punslbl = "knock_knockQuestion";

                        //stvaranje novih labela
                        Label questionLbl = new Label();
                        questionLbl.Size = new Size(800, 60);
                        questionLbl.Location = new Point(20, 10 + dodavanje+adding);
                        knock_knockPage.Controls.Add(questionLbl);
                        dodavanje += 70;
                        iadd = i.ToString();
                        punslbl += iadd;
                        questionLbl.Name = punslbl;
                        questionLbl.Text = questionString;


                        //stvaranje novih buttona
                        string punsReveal = "punsPunchline";
                        Button punsBtn = new Button();
                        punsBtn.Size = new Size(100, 30);
                        punsBtn.Location = new Point(20,adding+dodavanje);
                        knock_knockPage.Controls.Add(punsBtn);                      
                        punsReveal += iadd;
                        punsBtn.Name = punsReveal;
                        punsBtn.Text = "Reveal Punchline";

                        //stvaranje like buttona
                        Button likeBtn = new Button();
                        likeBtn.Size = new Size(50, 30);
                        likeBtn.Location = new Point(punsBtn.Width + 40, adding + dodavanje);
                        likeBtn.Name = iadd;
                        knock_knockPage.Controls.Add(likeBtn);
                        likeAdding += 80;
                        likeBtn.Text = "Like";
                        likeBtn.Click += delegate
                        {
                            likeBtn.BackColor = Color.Blue;
                            using (SQLiteConnection updateConnection = new SQLiteConnection("data source = fore.db"))
                            {
                                likeBtn.BackColor = Color.Blue;
                                updateConnection.Open();
                                using (SQLiteCommand punsUpdate = new SQLiteCommand(updateConnection))
                                {
                                    punsUpdate.CommandText = "UPDATE knock_knock SET likeKnock_knock = likeKnock_knock+1 WHERE id = '" + likeBtn.Name + "';";
                                    punsUpdate.ExecuteNonQuery();
                                    punsUpdate.Dispose();
                                }
                                updateConnection.Close();
                            }
                            Application.Restart();
                        };






                        // stvaranje labela za broj lajkova

                        string nameLikeLbl = "sumLikesLbl";
                        Label likeLbl = new Label();
                        likeLbl.Size = new Size(100, 20);
                        likeLbl.Location = new Point(punsBtn.Width + 50 +likeBtn.Width, adding + dodavanje);
                        adding += 80;
                        knock_knockPage.Controls.Add(likeLbl);
                        numLikeAdding += 80;
                        nameLikeLbl += iadd;
                        likeLbl.Name = nameLikeLbl;
                        likeLbl.Font = new Font("Comic Sans MS", 12);
                        likeLbl.Text = punLikes;


                        //messagebox sa punchline na button click
                        punsBtn.Click += delegate
                        {
                            MessageBox.Show(punchlineString);
                        };


                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }
            }



            //dodavanje labela i buttona na BAD JOKES
            likeAdding = 0;
            numLikeAdding = 0;
            dodavanje = 0;
            dodavanje = 0;
            adding = 0;
            intPunLikes = 0;
            punLikes = "";
            for (i = 1; i <= bad_jokesGranica; i++)
            {
                string questionString = "", punchlineString = "";
                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "SELECT * FROM bad_jokes WHERE id='" + i + "';";

                        SQLiteDataReader myReader
                            = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            questionString = myReader.GetString(0);
                            punchlineString = myReader.GetString(1);
                            intPunLikes = myReader.GetInt32(3);
                            punLikes = intPunLikes.ToString();
                        }

                        //pocetak imena za sve dirty labele
                        string punslbl = "bad_jokesQuestion";

                        //stvaranje novih labela
                        Label questionLbl = new Label();
                        questionLbl.Size = new Size(800, 20);
                        questionLbl.Location = new Point(20, 10 + dodavanje);
                        bad_jokesPage.Controls.Add(questionLbl);
                        dodavanje += 80;
                        iadd = i.ToString();
                        punslbl += iadd;
                        questionLbl.Name = punslbl;
                        questionLbl.Text = questionString;


                        //stvaranje novih buttona
                        string punsReveal = "punsPunchline";
                        Button punsBtn = new Button();
                        punsBtn.Size = new Size(100, 30);
                        punsBtn.Location = new Point(20, 40 + adding);
                        bad_jokesPage.Controls.Add(punsBtn);
                        adding += 80;
                        punsReveal += iadd;
                        punsBtn.Name = punsReveal;
                        punsBtn.Text = "Reveal Punchline";


                        //stvaranje like buttona
                        Button likeBtn = new Button();
                        likeBtn.Size = new Size(50, 30);
                        likeBtn.Location = new Point(20 + punsBtn.Width + 15, 40 + likeAdding);
                        likeBtn.Name = iadd;
                        bad_jokesPage.Controls.Add(likeBtn);
                        likeAdding += 80;
                        likeBtn.Text = "Like";
                        likeBtn.Click += delegate
                        {
                            likeBtn.BackColor = Color.Blue;
                            using (SQLiteConnection updateConnection = new SQLiteConnection("data source = fore.db"))
                            {
                                likeBtn.BackColor = Color.Blue;
                                updateConnection.Open();
                                using (SQLiteCommand punsUpdate = new SQLiteCommand(updateConnection))
                                {
                                    punsUpdate.CommandText = "UPDATE bad_jokes SET likeBadJoke = likeBadJoke+1 WHERE id = '" + likeBtn.Name + "';";
                                    punsUpdate.ExecuteNonQuery();
                                    punsUpdate.Dispose();
                                }
                                updateConnection.Close();
                            }
                            Application.Restart();
                        };






                        // stvaranje labela za broj lajkova

                        string nameLikeLbl = "sumLikesLbl";
                        Label likeLbl = new Label();
                        likeLbl.Size = new Size(100, 20);
                        likeLbl.Location = new Point(50 + punsBtn.Width + 30 + 15, 45 + numLikeAdding);
                        bad_jokesPage.Controls.Add(likeLbl);
                        numLikeAdding += 80;
                        nameLikeLbl += iadd;
                        likeLbl.Name = nameLikeLbl;
                        likeLbl.Font = new Font("Comic Sans MS", 12);
                        likeLbl.Text = punLikes;

                        //messagebox sa punchline na button click
                        punsBtn.Click += delegate
                        {
                            MessageBox.Show(punchlineString);
                        };


                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }
            }



            //dodavanje labela i buttona na OTHER
            likeAdding = 0;
            numLikeAdding = 0;
            dodavanje = 0;
            dodavanje = 0;
            adding = 0;
            intPunLikes = 0;
            punLikes = "";
            for (i = 1; i <= otherGranica; i++)
            {
                string questionString = "", punchlineString = "";
                using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=fore.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand
                        = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText
                            = "SELECT * FROM other WHERE id='" + i + "';";

                        SQLiteDataReader myReader
                            = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            questionString = myReader.GetString(0);
                            punchlineString = myReader.GetString(1);
                            intPunLikes = myReader.GetInt32(3);
                            punLikes = intPunLikes.ToString();
                        }

                        //pocetak imena za sve dirty labele
                        string punslbl = "otherQuestion";

                        //stvaranje novih labela
                        Label questionLbl = new Label();
                        questionLbl.Size = new Size(800, 20);
                        questionLbl.Location = new Point(20, 10 + dodavanje);
                        otherPage.Controls.Add(questionLbl);
                        dodavanje += 80;
                        iadd = i.ToString();
                        punslbl += iadd;
                        questionLbl.Name = punslbl;
                        questionLbl.Text = questionString;


                        //stvaranje novih buttona
                        string punsReveal = "punsPunchline";
                        Button punsBtn = new Button();
                        punsBtn.Size = new Size(100, 30);
                        punsBtn.Location = new Point(20, 40 + adding);
                        otherPage.Controls.Add(punsBtn);
                        adding += 80;
                        punsReveal += iadd;
                        punsBtn.Name = punsReveal;
                        punsBtn.Text = "Reveal Punchline";

                        // stvaranje like buttona 
                        // spremit boolean da li je button kliknut

                        Button likeBtn = new Button();
                        likeBtn.Size = new Size(50, 30);
                        likeBtn.Location = new Point(20 + punsBtn.Width + 15, 40 + likeAdding);
                        likeBtn.Name = iadd;
                        otherPage.Controls.Add(likeBtn);
                        likeAdding += 80;
                        likeBtn.Text = "Like";
                        likeBtn.Click += delegate
                        {
                            likeBtn.BackColor = Color.Blue;
                            using (SQLiteConnection updateConnection = new SQLiteConnection("data source = fore.db"))
                            {
                                likeBtn.BackColor = Color.Blue;
                                updateConnection.Open();
                                using (SQLiteCommand likeDirtyUpdate = new SQLiteCommand(updateConnection))
                                {
                                    likeDirtyUpdate.CommandText = "UPDATE other SET likeOther = likeOther+1 WHERE id = '" + likeBtn.Name + "';";
                                    likeDirtyUpdate.ExecuteNonQuery();
                                    likeDirtyUpdate.Dispose();
                                }
                                updateConnection.Close();
                            }
                            Application.Restart();
                        };






                        // stvaranje labela za broj lajkova

                        string nameLikeLbl = "sumLikesLbl";
                        Label likeLbl = new Label();
                        likeLbl.Size = new Size(100, 20);
                        likeLbl.Location = new Point(50 + punsBtn.Width + 30 + 15, 45 + numLikeAdding);
                        otherPage.Controls.Add(likeLbl);
                        numLikeAdding += 80;
                        nameLikeLbl += iadd;
                        likeLbl.Name = nameLikeLbl;
                        likeLbl.Font = new Font("Comic Sans MS", 12);
                        likeLbl.Text = punLikes;


                        //messagebox sa punchline na button click
                        punsBtn.Click += delegate
                        {
                            MessageBox.Show(punchlineString);
                        };


                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }
            }

        }
        
        
        
        // nasumicna sala
        private void random_jokeBtn_Click(object sender, EventArgs e)
        {
            randPunchlineLbl.Visible = false;
            string joke = "";
            string punchline = "";
            int randCategory;
            using (SQLiteConnection myConnection
            = new SQLiteConnection("data source=fore.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    // random CATEGORY
                    Random rnd = new Random();
                    randCategory = rnd.Next(1, 6);


                    switch (randCategory)
                    {
                        case 1:
                            int randDirty = rnd.Next(1, dirtyGranica);
                            myCommand.CommandText = "SELECT * FROM dirty WHERE id='" + randDirty + "';";
                            SQLiteDataReader myReader
                            = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                joke = myReader.GetString(0);
                                punchline = myReader.GetString(1);
                            }
                            revealRand.Click += delegate
                            {
                                randPunchlineLbl.Text = punchline;
                                randPunchlineLbl.Visible = true;
                            };



                        break;

                        case 2:



                            myCommand.CommandText = "SELECT * FROM puns WHERE id='" + rnd.Next(1, punsGranica) + "';";
                             myReader
                            = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                joke = myReader.GetString(0);
                                punchline = myReader.GetString(1);
                            }
                            revealRand.Click += delegate
                            {
                                randPunchlineLbl.Text = punchline;
                                randPunchlineLbl.Visible = true;
                            };
                            break;

                        case 3:


                            myCommand.CommandText = "SELECT * FROM knock_knock WHERE id='" + rnd.Next(1, knock_knockGranica) + "';";
                            myReader
                           = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                joke = myReader.GetString(0);
                                punchline = myReader.GetString(1);
                            }
                            revealRand.Click += delegate
                            {
                                randPunchlineLbl.Text = punchline;
                                randPunchlineLbl.Visible = true;

                            };
                            break;

                        case 4:



                            myCommand.CommandText = "SELECT * FROM bad_jokes WHERE id='" + rnd.Next(1, bad_jokesGranica) + "';";
                            myReader
                           = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                joke = myReader.GetString(0);
                                punchline = myReader.GetString(1);
                            }
                            revealRand.Click += delegate
                            {
                                randPunchlineLbl.Text = punchline;
                                randPunchlineLbl.Visible = true;

                            };
                            break;

                        case 5:

                            //preventing same random jokes
       

                            myCommand.CommandText = "SELECT * FROM other WHERE id='" + rnd.Next(1, otherGranica) + "';";
                            myReader
                           = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                joke = myReader.GetString(0);
                                punchline = myReader.GetString(1);
                            }
                            revealRand.Click += delegate
                            {
                                randPunchlineLbl.Text = punchline;
                                randPunchlineLbl.Visible = true;

                            };
                            break;




                    }
                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            random_jokeLbl.Text = joke;
            random_jokeLbl.Visible = true;
        }







        // DONT TOUCH ne dirat ni pod razno
        private void topPage_Click(object sender, EventArgs e)
        {




        }












    }
}
