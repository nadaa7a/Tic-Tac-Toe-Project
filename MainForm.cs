using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace Tic_Tac_Toe_Project
{
    public partial class MainForm : Form
    {
        private int currentPlayer = 1;
        private string[] board = new string[9];

        private int playerXScore = 0;
        private int playerOScore = 0;

        private int currentRound = 1;
        private const int TotalRounds = 3;

        private int elapsedSeconds = 0;

        private bool matchFinished = false;
        private bool roundFinished = false;
        private bool soundEnabled = true;

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer winAnimationTimer;

        private Button[] winningButtons;
        private Button[] gameButtons;

        private Image[] questionImages;

        private bool animationState = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }


        private void InitializeGame()
        {
            Button[] unsorted = new Button[]
            {
                btn1, btn2, btn3,
                btn4, btn5, btn6,
                btn7, btn8, btn9
            };

            Button[] byTop = unsorted.OrderBy(b => b.Top).ToArray();

            gameButtons = new Button[9];

            for (int r = 0; r < 3; r++)
            {
                Button[] row = byTop.Skip(r * 3).Take(3).OrderBy(b => b.Left).ToArray();

                for (int c = 0; c < 3; c++)
                    gameButtons[r * 3 + c] = row[c];
            }

            questionImages = new Image[9];

            for (int i = 0; i < gameButtons.Length; i++)
            {
                questionImages[i] = gameButtons[i].BackgroundImage;

                gameButtons[i].Click += GameButton_Click;

                gameButtons[i].UseVisualStyleBackColor = false;
                gameButtons[i].FlatStyle = FlatStyle.Flat;

                gameButtons[i].FlatAppearance.BorderSize = 1;
                gameButtons[i].FlatAppearance.BorderColor =
                    Color.FromArgb(155, 32, 255);

                gameButtons[i].FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(36, 16, 74);

                MakeRounded(gameButtons[i], 10);
            }

            MakeRounded(button1, 25);
            MakeRounded(btnReset, 25);
            MakeRounded(btnSound, 10);
            MakeRounded(panel1, 16);
            MakeRounded(pnlGameBoard, 12);

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            winAnimationTimer = new System.Windows.Forms.Timer();
            winAnimationTimer.Interval = 350;
            winAnimationTimer.Tick += WinAnimationTimer_Tick;

            button1.Click += btnNewGame_Click;
            btnSound.Click += btnSound_Click;

            UpdateScores();

            StartRound();
        }

        private void StartRound()
        {
            winAnimationTimer.Stop();
            winningButtons = null;

            if (matchFinished)
                return;

            currentPlayer = 1;
            roundFinished = false;
            elapsedSeconds = 0;

            for (int i = 0; i < gameButtons.Length; i++)
            {
                board[i] = string.Empty;
                gameButtons[i].Tag = null;

                gameButtons[i].Text = "";

                gameButtons[i].BackgroundImage = questionImages[i];
                gameButtons[i].BackgroundImageLayout = ImageLayout.Zoom;

                gameButtons[i].Enabled = true;

                gameButtons[i].BackColor = Color.FromArgb(11, 9, 32);

                gameButtons[i].ForeColor = Color.White;
            }

            gameTimer.Stop();

            lblTimer.Text = "00:00";

            lblRoundNumber.Text =
                currentRound + " / " + TotalRounds;

            for (int i = 0; i < gameButtons.Length; i++)
            {
                gameButtons[i].Text = "";

                gameButtons[i].BackgroundImage = questionImages[i];
                gameButtons[i].BackgroundImageLayout = ImageLayout.Zoom;

                gameButtons[i].Enabled = true;

                gameButtons[i].BackColor =
                    Color.FromArgb(11, 9, 32);

                gameButtons[i].ForeColor = Color.White;
            }

            lblCurrentPlayer.Text = "Player X";
            lblCurrentPlayer.ForeColor =
                Color.FromArgb(176, 38, 255);

            lblStatus.Text = "In Progress...";
            lblStatus.ForeColor =
                Color.FromArgb(0, 223, 255);

            gameTimer.Start();
        }


        private void GameButton_Click(object sender, EventArgs e)
        {
            if (roundFinished || matchFinished)
                return;

            Button btn = sender as Button;

            if (btn == null || !btn.Enabled)
                return;

            int index = Array.IndexOf(gameButtons, btn);

            if (index < 0 || !string.IsNullOrEmpty(board[index]))
                return;

            if (currentPlayer == 1)
            {
                board[index] = "X";
                btn.Tag = "X";

                btn.BackgroundImage = Properties.Resources.X_Logo;

                currentPlayer = 2;
            }
            else
            {
                board[index] = "O";
                btn.Tag = "O";

                btn.BackgroundImage = Properties.Resources.O_Logo;

                currentPlayer = 1;
            }

            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.Text = "";
            btn.Enabled = false;

            PlaySound();

            Button[] result = CheckWinner();

            if (result != null)
            {
                FinishRound(result);
                return;
            }

            if (CheckDraw())
            {
                FinishDraw();
                return;
            }

            UpdateCurrentPlayer();
        }

        private bool CheckLine(Button b1, Button b2, Button b3)
        {
            if (b1?.Tag == null || b2?.Tag == null || b3?.Tag == null)
                return false;

            return b1.Tag.ToString() == b2.Tag.ToString() &&
                   b2.Tag.ToString() == b3.Tag.ToString();
        }


        private Button[] CheckWinner()
        {
            Button[] g = gameButtons;

            // Horizontal - 3 Rows
            if (CheckLine(g[0], g[1], g[2]))
                return new Button[] { g[0], g[1], g[2] };

            if (CheckLine(g[3], g[4], g[5]))
                return new Button[] { g[3], g[4], g[5] };

            if (CheckLine(g[6], g[7], g[8]))
                return new Button[] { g[6], g[7], g[8] };


            // Vertical - 3 Columns
            if (CheckLine(g[0], g[3], g[6]))
                return new Button[] { g[0], g[3], g[6] };

            if (CheckLine(g[1], g[4], g[7]))
                return new Button[] { g[1], g[4], g[7] };

            if (CheckLine(g[2], g[5], g[8]))
                return new Button[] { g[2], g[5], g[8] };


            // Diagonal - 2 Diagonals
            if (CheckLine(g[0], g[4], g[8]))
                return new Button[] { g[0], g[4], g[8] };

            if (CheckLine(g[2], g[4], g[6]))
                return new Button[] { g[2], g[4], g[6] };


            return null;
        }

        private void FinishRound(Button[] winnerButtons)
        {
            if (roundFinished)
                return;

            roundFinished = true;
            gameTimer.Stop();

            string winner = winnerButtons[0].Tag.ToString();

            winningButtons = winnerButtons;
            animationState = false;

            foreach (Button btn in gameButtons)
            {
                btn.Enabled = false;
            }

            if (winner == "X")
            {
                playerXScore++;

                lblStatus.Text = "Player X Wins!";

                lblStatus.ForeColor =
                    Color.FromArgb(176, 38, 255);
            }
            else
            {
                playerOScore++;

                lblStatus.Text = "Player O Wins!";

                lblStatus.ForeColor =
                    Color.FromArgb(0, 217, 255);
            }

            UpdateScores();

            winAnimationTimer.Start();

            CheckMatchWinner();

            ShowWinnerMessage(winner);
        }


        private void ShowWinnerMessage(string winner)
        {
            string message;

            string title;

            if (matchFinished)
            {
                if (playerXScore > playerOScore)
                {
                    message =
                        "CONGRATULATIONS!\n\n" +
                        "Player X is the CHAMPION!\n\n" +
                        "Final Score:\n" +
                        "Player X: " + playerXScore + "\n" +
                        "Player O: " + playerOScore;

                    title = "🏆 MATCH WINNER!";
                }
                else if (playerOScore > playerXScore)
                {
                    message =
                        "CONGRATULATIONS!\n\n" +
                        "Player O is the CHAMPION!\n\n" +
                        "Final Score:\n" +
                        "Player X: " + playerXScore + "\n" +
                        "Player O: " + playerOScore;

                    title = "🏆 MATCH WINNER!";
                }
                else
                {
                    message =
                        "CONGRATULATIONS!\n\n" +
                        "Player " + winner + " WINS THE FINAL ROUND!\n\n" +
                        "The Match Has Ended!\n\n" +
                        "It's a DRAW!\n\n" +
                        "Final Score:\n" +
                        "Player X: " + playerXScore + "\n" +
                        "Player O: " + playerOScore;

                    title = "MATCH DRAW!";
                }
            }
            else
            {
                message =
                    "CONGRATULATIONS!\n\n" +
                    "Player " + winner + " WINS THIS ROUND!\n\n" +
                    "Great Job!";

                title = "🎉 ROUND WINNER!";
            }

            if (soundEnabled)
            {
                SystemSounds.Exclamation.Play();
            }

            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private bool CheckDraw()
        {
            foreach (string cell in board)
            {
                if (string.IsNullOrEmpty(cell))
                    return false;
            }

            return true;
        }

        private void FinishDraw()
        {
            if (roundFinished)
                return;

            roundFinished = true;
            gameTimer.Stop();

            lblStatus.Text = "It's a Draw!";
            lblStatus.ForeColor = Color.Gold;

            foreach (Button btn in gameButtons)
            {
                btn.Enabled = false;
            }

            CheckMatchWinner();

            if (matchFinished)
            {
                ShowMatchDrawOrWinner();
            }
            else
            {
                MessageBox.Show(
                    "The round ended in a draw!\n\nGood Game!",
                    "Round Draw",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void ShowMatchDrawOrWinner()
        {
            string message;

            if (playerXScore > playerOScore)
            {
                message =
                    "CONGRATULATIONS!\n\n" +
                    "Player X is the MATCH CHAMPION!\n\n" +
                    "Final Score: " +
                    playerXScore + " - " + playerOScore;
            }
            else if (playerOScore > playerXScore)
            {
                message =
                    "CONGRATULATIONS!\n\n" +
                    "Player O is the MATCH CHAMPION!\n\n" +
                    "Final Score: " +
                    playerXScore + " - " + playerOScore;
            }
            else
            {
                message =
                    "The Match Has Ended!\n\n" +
                    "It's a DRAW!\n\n" +
                    "Final Score: " +
                    playerXScore + " - " + playerOScore;
            }

            MessageBox.Show(
                message,
                "FINAL MATCH RESULT",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void WinAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (winningButtons == null)
                return;

            animationState = !animationState;

            foreach (Button btn in winningButtons)
            {
                btn.BackColor = animationState
                    ? Color.FromArgb(176, 38, 255)
                    : Color.FromArgb(0, 217, 255);
            }
        }


        private void UpdateCurrentPlayer()
        {
            if (currentPlayer == 1)
            {
                lblCurrentPlayer.Text = "Player X";

                lblCurrentPlayer.ForeColor =
                    Color.FromArgb(176, 38, 255);
            }
            else
            {
                lblCurrentPlayer.Text = "Player O";

                lblCurrentPlayer.ForeColor =
                    Color.FromArgb(0, 217, 255);
            }
        }


        private void UpdateScores()
        {
            xscore.Text = playerXScore.ToString();
            label2.Text = playerOScore.ToString();
        }


        private void CheckMatchWinner()
        {
            if (currentRound < TotalRounds)
                return;

            matchFinished = true;
            roundFinished = true;

            gameTimer.Stop();

            foreach (Button btn in gameButtons)
            {
                btn.Enabled = false;
            }

            if (playerXScore > playerOScore)
            {
                lblStatus.Text = "Player X Wins The Game!";

                lblStatus.ForeColor =
                    Color.FromArgb(176, 38, 255);
            }
            else if (playerOScore > playerXScore)
            {
                lblStatus.Text = "Player O Wins The Game!";

                lblStatus.ForeColor =
                    Color.FromArgb(0, 217, 255);
            }
            else
            {
                lblStatus.Text = "Match Draw!";
                lblStatus.ForeColor = Color.Gold;
            }
        }

        private void MakeRounded(Control control, int radius)
        {
            SetRoundedRegion(control, radius);

            control.Resize += (sender, e) =>
            {
                SetRoundedRegion(control, radius);
            };
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0)
                return;

            int diameter = Math.Min(
                radius * 2,
                Math.Min(control.Width, control.Height));

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();

                path.AddArc(
                    0, 0,
                    diameter, diameter,
                    180, 90);

                path.AddArc(
                    control.Width - diameter,
                    0,
                    diameter, diameter,
                    270, 90);

                path.AddArc(
                    control.Width - diameter,
                    control.Height - diameter,
                    diameter, diameter,
                    0, 90);

                path.AddArc(
                    0,
                    control.Height - diameter,
                    diameter, diameter,
                    90, 90);

                path.CloseFigure();

                Region oldRegion = control.Region;

                control.Region = new Region(path);

                if (oldRegion != null)
                    oldRegion.Dispose();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            TimeSpan time =
                TimeSpan.FromSeconds(elapsedSeconds);

            lblTimer.Text = time.ToString(@"mm\:ss");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (matchFinished)
            {
                MessageBox.Show(
                    "The match is finished! Start a New Game.",
                    "Game Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            if (roundFinished)
            {
                currentRound++;
            }

            StartRound();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            winAnimationTimer.Stop();

            matchFinished = false;
            roundFinished = false;

            playerXScore = 0;
            playerOScore = 0;

            currentRound = 1;

            UpdateScores();

            StartRound();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            soundEnabled = !soundEnabled;

            if (soundEnabled)
            {
                btnSound.Text = "🔊 Sound: ON";

                btnSound.ForeColor =
                    Color.FromArgb(0, 217, 255);
            }
            else
            {
                btnSound.Text = "🔇 Sound: OFF";

                btnSound.ForeColor = Color.Gray;
            }
        }

        private void PlaySound()
        {
            if (soundEnabled)
            {
                SystemSounds.Beep.Play();
            }
        }

    }
}
