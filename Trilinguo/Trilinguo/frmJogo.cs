using System.Text.Json.Serialization;

namespace Trilinguo
{
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        cfg cfg = Program.cfgP;
        eng eng = new eng();
        it it = new it();
        int[] jf = new int[5];
        int[] ji = new int[5];
        int Q = 0;
        bool f;

        private bool DSelecionado()
        {
            if (cfg.Dificuldade > 0)
            {
                return true;
            }
            else { return false; }
        } // Verificar se possui Dificuldade selecionada

        private void Jogar(int D, int L)
        {
            Random P = new Random();
            Random M = new Random();

            if (L == 1)
            {
                while(pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = eng.Pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = eng.Pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = eng.Pergunta3[p];
                                    break;

                            }
                            
                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblQ.Text = "Escreva o nome do animal";
                        lblF.Hide();
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = eng.Pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = eng.Pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = eng.Pergunta3[p];
                                    break;

                            }
                            pictureBox3.Show();
                            Q = p;
                        }
                        break;
                    }
                    if (pgb.Value == 100)
                    {
                        lblF.Hide();
                        lblQ.Hide();
                        txtbR.Hide();
                        pictureBox3.Hide();

                        pictureBox2.Show();
                        pictureBox2.Image = Properties.Resources.duofeliz;
                        btnM.Show();
                        btnR.Show();
                        pgb.Location = new Point(0, 0);
                    }
                }
            } // Configuração em Ingles
            else if (L == 2)
            {
                while (pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = it.pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = it.pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = it.pergunta3[p];
                                    break;

                            }

                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblF.Hide();
                        lblQ.Text = "Escreva o nome do animal";
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    pictureBox3.Image = it.Imagem1[p];
                                    break;
                                case 2:
                                    pictureBox3.Image = it.Imagem2[p];
                                    break;
                                case 3:
                                    pictureBox3.Image = it.Imagem3[p];
                                    break;

                            }
                            Q = p;
                        }
                        pictureBox3.Show();
                        break;
                    }
                if (pgb.Value == 100)
                {
                    lblF.Hide();
                    lblQ.Hide();
                    txtbR.Hide();
                    pictureBox3.Hide();

                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.duofeliz;
                    btnM.Show();
                    btnR.Show();
                    pgb.Location = new Point(0, 0);
                }
                }
            } // Configuração em Italiano


        } // Script do jogo


        private void button2_Click(object sender, EventArgs e)
        {
            FrmConfig fc = new();
            fc.ShowDialog();
        } // Configuração

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Sair

        private void button1_Click(object sender, EventArgs e)
        {
            if (DSelecionado())
            {
                timer1.Start();
                Jogar(cfg.Dificuldade, cfg.Lingua);
            }
            else
            {
                MessageBox.Show("Primeiro deve selecionar uma Linguagem e uma Dificuldade.");
            }
        } // Iniciar o jogo

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0.20000000000000007)
            {

                btnJ.Hide();
                btnC.Hide();
                btnS.Hide();
                btnT.Hide();
                pictureBox2.Hide();
                btnR.Hide();
                btnM.Hide();

                btnE.Show();
                lblF.Show();
                lblQ.Show();
                txtbR.Show();
                pgb.Show();

                timer1.Stop();
                timer2.Start();
            }
            else
            {
                Opacity -= 0.20;
            }
        } // Inicio da transição para o jogo

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Stop();
            }
            Opacity += 0.2;
        } // Fim da transição

        private void btnT_Click(object sender, EventArgs e)
        {
            ex.Text = "Lingua: " + cfg.Lingua + "\n Dificuldade: " + cfg.Dificuldade;
        } // Controle

        private void btnE_Click(object sender, EventArgs e)
        {
            EnviarResposta(cfg.Lingua,cfg.Dificuldade);
            
        } // Script das respostas

        private void EnviarResposta(int L, int D)
        {
            if (pgb.Value == 100)
            {
                lblF.Hide();
                lblQ.Hide();
                txtbR.Hide();
                btnE.Hide();

                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.duofeliz;
                btnM.Show();
                btnR.Show();
                pgb.Location = new Point(0, 0);
            }
            else if (L == 1)
            {
                bool x = false;
                if (f)
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(eng.Resposta1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(eng.Resposta2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(eng.Resposta3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;

                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
                else
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text == it.Respostaimg1[Q])
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text == it.Respostaimg2[Q])
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text == it.Respostaimg3[Q])
                                x = true;
                            break;
                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }   
            } // Resposta em Ingles
            else if (L == 2)
            {
                bool x = false;
                if (f)
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(it.resposta1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(it.resposta2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(it.resposta3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;

                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
                else
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text == it.Respostaimg1[Q])
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text == it.Respostaimg2[Q])
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text == it.Respostaimg3[Q])
                                x = true;
                            break;
                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
            } // Resposta em Italiano

        }
        private void btnR_Click(object sender, EventArgs e)
        {
            timer1.Start();
            resetJogo();
            Jogar(cfg.Dificuldade, cfg.Lingua);
        } // Restart

        private void resetJogo()
        {
            pgb.Value = 0;
            Array.Clear(jf, 0, jf.Length);
            Array.Clear(ji, 0, ji.Length);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            resetJogo();
            timer3.Start();
        } // Voltar para o Menu

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0.20000000000000007)
            {
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.trilingo;
                btnJ.Show();
                btnC.Show();
                btnT.Show();
                btnS.Show();

                btnR.Hide();
                pgb.Hide();
                lblF.Hide();
                lblQ.Hide();
                btnE.Hide();
                txtbR.Hide();
                btnM.Hide();

                timer3.Stop();
                timer2.Start();
            }
            else
            {
                Opacity -= 0.20;
            }
        } // Inicio da transição para o menu

        private void btnE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnE.PerformClick();
        }
    }
}