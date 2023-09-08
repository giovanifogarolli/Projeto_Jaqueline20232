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
        per per = new per();
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

        private void Jogar()
        {
            Random P = new Random();
            Random M = new Random();

            if (cfg.Us)
            {
                switch (cfg.Dificuldade) // Dificuldade -> Case 1 - Facil |  Case 2 - Medio | Case 3 - Dificil
                {
                    case 1:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Pergunta[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                if (Mg == 2)
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT1[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
                        }
                    case 2:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Pergunta2[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                if (Mg == 2)
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT2[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
                        }
                    case 3:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Pergunta3[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                else
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT3[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
                        }
                }
            } // Configuração em Ingles
            else if (cfg.It)
            {
                switch (cfg.Dificuldade) // Dificuldade -> Case 1 - Facil |  Case 2 - Medio | Case 3 - Dificil
                {
                    case 1:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Itpergunta1[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                if (Mg == 2)
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT1[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
                        }
                    case 2:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text += "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                ex.Text += "\n" + Mg;
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Itpergunta2[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                if (Mg == 2)
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT2[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
                        }
                    case 3:
                        {
                            while (pgb.Value != 100)
                            {
                                int Mg = M.Next(1, 3);
                                int p = P.Next(5);
                                ex.Text = "\n" + jf[0] + jf[1] + jf[2] + jf[3] + jf[4];
                                if (Mg == 1)
                                {
                                    f = true;
                                    pictureBox3.Hide();
                                    while (jf.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        jf[p] = p + 1;
                                        lblF.Show();
                                        lblF.Text = per.Itpergunta3[p];
                                        Q = p;
                                    }
                                    break;
                                }
                                if (Mg == 2)
                                {
                                    f = false;
                                    lblF.Hide();
                                    while (ji.Contains(p + 1))
                                    {
                                        p = P.Next(5);
                                    }
                                    {
                                        ji[p] = p + 1;
                                        pictureBox3.Show();
                                        pictureBox3.Image = per.ImagemIT3[p];
                                        Q = p;
                                    }
                                    break;
                                }
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
                            break;
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
                Jogar();
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
            ex.Text = "Lingua: " + cfg.It + cfg.Us + "\n Dificuldade: " + cfg.Dificuldade;
        } // Controle

        private void btnE_Click(object sender, EventArgs e)
        {
            if (pgb.Value == 100)
            {
                lblF.Hide();
                lblQ.Hide();
                txtbR.Hide();

                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.duofeliz;
                btnM.Show();
                btnR.Show();
                pgb.Location = new Point(0, 0);
            }
            else if (cfg.Us)
            {
                if (f)
                {
                    switch (cfg.Dificuldade)
                    {
                        case 1:
                            {
                                if (txtbR.Text.Equals(per.Resposta[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (txtbR.Text.Equals(per.Resposta2[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (txtbR.Text.Equals(per.Resposta3[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                    }
                }
                else
                {
                    switch (cfg.Dificuldade)
                    {
                        case 1:
                            {
                                if (txtbR.Text == per.ITRespostaimg1[Q])
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (txtbR.Text == per.Resposta2[Q])
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (txtbR.Text == per.Resposta3[Q])
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                    }
                }
            } // Resposta em Ingles
            else if (cfg.It)
            {
                if (f)
                {
                    switch (cfg.Dificuldade)
                    {
                        case 1:
                            {
                                if (txtbR.Text.Equals(per.Itresposta1[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (txtbR.Text.Equals(per.Itresposta2[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (txtbR.Text.Equals(per.Itresposta3[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                    }
                }
                else
                {
                    switch (cfg.Dificuldade)
                    {
                        case 1:
                            {
                                if (txtbR.Text.Equals(per.ITRespostaimg1[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (txtbR.Text.Equals(per.ITRespostaimg2[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (txtbR.Text.Equals(per.ITRespostaimg3[Q], StringComparison.OrdinalIgnoreCase))
                                {
                                    pgb.Value += 20;
                                    txtbR.Text = "";
                                    Jogar();
                                }
                                else
                                {
                                    MessageBox.Show("Resposta errado");
                                }
                                break;
                            }
                    }
                }
            } // Resposta em Italiano

        } // Script das respostas

        private void btnR_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            pgb.Value = 0;
            Array.Clear(jf, 0, jf.Length);
            Array.Clear(ji, 0, ji.Length);
            timer1.Start();
            Jogar();
        } // Restart

        private void btnM_Click(object sender, EventArgs e)
        {
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