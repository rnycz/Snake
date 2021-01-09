using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
            gameSettings();
        }

        private List<Point> snake = new List<Point>()
        {
            new Point(10 ,10)
        };
        private Point snakeDirection = new Point(10, 10);
        private Point food = new Point();
        private Point badFood = new Point();
        private Random rand = new Random();
        private int snakeMove = 10;
        private int score = 0;
        private bool startGame = false;
        private Timer timer = new Timer();

        private void gameSettings()
        {
            ClientSize = new Size(300, 300);
            CenterToScreen();
            generateFood();

            controlLBL.Text = "Control the Snake with the WASD keys. \nClick P to pause.";

            timer.Tick += loopGame;
        }
        private void generateFood()
        {
            food.X = 10 * rand.Next(0, 300 / 10 - 1);
            food.Y = 10 * rand.Next(0, 300 / 10 - 1);

            badFood.X = 10 * rand.Next(0, 300 / 10 - 1);
            badFood.Y = 10 * rand.Next(0, 300 / 10 - 1);
        }
        private void snakeUpdate()
        {
            try
            {
                //new head position - snake move
                Point newPosition = new Point(
                snake[0].X + snakeDirection.X,
                snake[0].Y + snakeDirection.Y);

                snake.Insert(0, newPosition);
                snake.RemoveAt(snake.Count - 1);

                //eating
                if (snake[0].X == food.X && snake[0].Y == food.Y)
                {
                    snake.Add(new Point(food.X, food.Y));
                    score++;
                    SnakeGame.ActiveForm.Text = "Snake score " + score;
                    generateFood();
                }

                //eating bad food
                if (snake[0].X == badFood.X && snake[0].Y == badFood.Y)
                {
                    score--;
                    SnakeGame.ActiveForm.Text = "Snake score " + score;
                    snake.RemoveAt(snake.Count - 1);
                }

                //collid with body
                for (int i = 1; i < snake.Count - 1; i++)
                {
                    if (snake[0].X == snake[i].X && snake[0].Y == snake[i].Y)
                    {
                        timer.Stop();
                        MessageBox.Show("You have collided with your body! Play again.\nScore: " + score);
                        SnakeGame snakeGame = new SnakeGame();
                        snakeGame.Show();
                        this.Dispose(false);
                    }
                }

                //leave the map field
                if (snake[0].X > this.ClientSize.Width - 10 || snake[0].X < 0 ||
                    snake[0].Y > this.ClientSize.Height - 10 || snake[0].Y < 0)
                {
                    timer.Stop();
                    MessageBox.Show("You left the map field! Play again.\nScore: " + score);
                    SnakeGame snakeGame = new SnakeGame();
                    snakeGame.Show();
                    this.Dispose(false);
                }
            }
            catch(ArgumentException)
            {
                //eating bad food first to kill snake
                timer.Stop();
                MessageBox.Show("You ate bad food by accident! The Snake is dead. Play again.\nScore: " + score);
                SnakeGame snakeGame = new SnakeGame();
                snakeGame.Show();
                this.Dispose(false);
            }          
        }
        private void loopGame(object sender, EventArgs e)
        {
            snakeUpdate();
            Invalidate();
        }
        private void drawRect(int x, int y, Color color, int size = 10)
        {
            Graphics graphics = CreateGraphics();
            SolidBrush solidBrush = new SolidBrush(color);
            graphics.FillRectangle(solidBrush, new Rectangle(x, y, size, size));
            solidBrush.Dispose();
            graphics.Dispose();
        }
        private void drawSnake()
        {
            //draw snake in one color
            /*foreach(Point body in snake)
            {
                drawRect(body.X, body.Y, Color.DarkGreen);
            }*/
            //draw snake head in different color
            for(int i = 0; i < snake.Count; i++)
            {
                if (i == 0)
                {
                    drawRect(snake[i].X, snake[i].Y, Color.Black);
                }
                else
                {
                    drawRect(snake[i].X, snake[i].Y, Color.DarkGreen);
                }
            }
        }
        private void drawFood()
        {
            drawRect(food.X, food.Y, Color.Red);
        }
        private void drawBadFood()
        {
            drawRect(badFood.X, badFood.Y, Color.Brown);
        }
        private void SnakeGame_Paint(object sender, PaintEventArgs e)
        {
            drawFood();
            drawSnake();
            if (snake.Count == 1 || snake.Count == 5 || snake.Count == 10 || snake.Count == 15 || snake.Count == 20 || snake.Count == 25 || snake.Count == 30 || snake.Count == 35)
            {
                drawBadFood();
            }
        }
        private void SnakeGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(startGame == true)
            {
                timer.Start();
            }
            switch (e.KeyChar)
            {
                case 'w':
                    snakeDirection.X = 0;
                    snakeDirection.Y = -snakeMove;
                    break;
                case 'a':
                    snakeDirection.X = -snakeMove;
                    snakeDirection.Y = 0;
                    break;
                case 's':
                    snakeDirection.X = 0;
                    snakeDirection.Y = snakeMove;
                    break;
                case 'd':
                    snakeDirection.X = snakeMove;
                    snakeDirection.Y = 0;
                    break;
                case 'p':
                    timer.Stop();
                    break;
            }
        }

        private void easyBTN_Click(object sender, EventArgs e)
        {
            startGame = true;
            timer.Interval = 120;

            easyBTN.Enabled = false;
            easyBTN.Visible = false;
            mediumBTN.Enabled = false;
            mediumBTN.Visible = false;
            hardBTN.Enabled = false;
            hardBTN.Visible = false;
            diffLvlLBL.Visible = false;
            controlLBL.Visible = false;
            SnakeGame.ActiveForm.Focus();
        }

        private void mediumBTN_Click(object sender, EventArgs e)
        {
            startGame = true;
            timer.Interval = 75;

            easyBTN.Enabled = false;
            easyBTN.Visible = false;
            mediumBTN.Enabled = false;
            mediumBTN.Visible = false;
            hardBTN.Enabled = false;
            hardBTN.Visible = false;
            diffLvlLBL.Visible = false;
            controlLBL.Visible = false;
            SnakeGame.ActiveForm.Focus();
        }

        private void hardBTN_Click(object sender, EventArgs e)
        {
            startGame = true;
            timer.Interval = 35;

            easyBTN.Enabled = false;
            easyBTN.Visible = false;
            mediumBTN.Enabled = false;
            mediumBTN.Visible = false;
            hardBTN.Enabled = false;
            hardBTN.Visible = false;
            diffLvlLBL.Visible = false;
            controlLBL.Visible = false;
            SnakeGame.ActiveForm.Focus();
        }
    }
}
