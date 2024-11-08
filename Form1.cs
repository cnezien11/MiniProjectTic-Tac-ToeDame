namespace MiniProjectTic_Tac_ToeDame
{
    public partial class Form1 : Form
    {
        // An array that represents my game board
        // Current player keeps tracks of which player's turn it is (either A || B)
        private char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int currentPlayer = 1; // 1 = Player A, -1 = B
        private int playerChoice;   // shows where player plays
        private int BChoice;       // B is the auto player
        private bool isGameOver = false; 
        public Form1()
        {
            InitializeComponent();
            txtStatus.Text = "Player A's turn";
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        // Event handlers for all buttons on the board. They triggered when clicked.
        private void btn1_Click(object sender, EventArgs e) => MakeMove(1);
        private void btn2_Click(object sender, EventArgs e) => MakeMove(2);
        private void btn3_Click(object sender, EventArgs e) => MakeMove(3);
        private void btn4_Click(object sender, EventArgs e) => MakeMove(4);
        private void btn5_Click(object sender, EventArgs e) => MakeMove(5);
        private void btn6_Click(object sender, EventArgs e) => MakeMove(6);
        private void btn7_Click(object sender, EventArgs e) => MakeMove(7);
        private void btn8_Click(object sender, EventArgs e) => MakeMove(8);
        private void btn9_Click(object sender, EventArgs e) => MakeMove(9);

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        // Move for player A= X and move for player B = O
        private void MakeMove(int choice)
        {
            if (isGameOver || board[choice] == 'X' || board[choice] == 'O') 
                return;

            // Player's move
            board[choice] = currentPlayer == 1 ? 'X' : 'O';
            UpdateBoardUI();

            if (CheckWin())
            {
                txtStatus.Text = $"Player {(currentPlayer == 1 ? "A" : "B")} wins!";
                isGameOver = true;
                return;
            }
            if (CheckDraw())
            {
                txtStatus.Text = "It's a TIE!";
                isGameOver = true;
                return;
            }

            // Switch player
            currentPlayer *= -1;

            // B move if Player vs B mode
            if (currentPlayer == -1 && !isGameOver)
            {
                int BChoice = GetBestMove();
                board[BChoice] = 'O'; // B move
                UpdateBoardUI();

                if (CheckWin())
                {
                    txtStatus.Text = "B wins!";
                    isGameOver = true;
                }
                else if (CheckDraw())
                {
                    txtStatus.Text = "It's a draw!";
                    isGameOver = true;
                }

                // Switch back to player after B move
                if (!isGameOver) currentPlayer = 1;
            }
            else
            {
                txtStatus.Text = $"Player {(currentPlayer == 1 ? "1" : "B")}'s turn";
            }
        }
        private void UpdateBoardUI()
        {
            btn1.Text = board[1].ToString();
            btn2.Text = board[2].ToString();
            btn3.Text = board[3].ToString();
            btn4.Text = board[4].ToString();
            btn5.Text = board[5].ToString();
            btn6.Text = board[6].ToString();
            btn7.Text = board[7].ToString();
            btn8.Text = board[8].ToString();
            btn9.Text = board[9].ToString();
        }

        private bool CheckWin()
        {
            int[,] winPatterns = {
                {1, 2, 3}, {4, 5, 6}, {7, 8, 9}, // Rows
                {1, 4, 7}, {2, 5, 8}, {3, 6, 9}, // Columns
                {1, 5, 9}, {3, 5, 7}  // Diagonals
            };

            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                int pos1 = winPatterns[i, 0];
                int pos2 = winPatterns[i, 1];
                int pos3 = winPatterns[i, 2];

                if (board[pos1] == board[pos2] && board[pos2] == board[pos3] && board[pos1] != '0')
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDraw()
        {
            return board.Skip(1).All(x => x == 'X' || x == 'O');
        }

        private int GetBestMove()
        {
            int bestValue = int.MinValue;
            int bestMove = -1;

            for (int i = 1; i <= 9; i++) // loop thru all numbers from 1-9 (available spots on the board)
            {
                if (board[i] != 'X' && board[i] != 'O') // checks if current spot empty (if it isn't occupied by x or O)
                {
                    board[i] = 'O'; // player B move
                    int moveValue = Minimax(board, 0, false);
                    board[i] = (char)(i + '0'); // Undo move move
                    if (moveValue > bestValue)
                    {
                        bestValue = moveValue;
                        bestMove = i;
                    }
                }
            }
            return bestMove;
        }

        // I used a tree recursion that addresses decision making in 2 players game.
        // it will explore all game spot where player B can make a possible move. 
        // there is an auto player that makes move after player A plays
        // The Minimax algorithm evaluates each node and assigns a score 
        //based on whether it’s a win, loss, or draw for the maximizing player.
        private int Minimax(char[] board, int depth, bool isMax)
        {
            if (CheckWin())
            {
                return isMax ? -1 : 1; // B wins: -1, Player wins: 1
            }
            if (CheckDraw())
            {
                return 0; // Draw
            }

            int best = isMax ? int.MinValue : int.MaxValue;

            for (int i = 1; i <= 9; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {
                    board[i] = isMax ? 'O' : 'X';
                    int value = Minimax(board, depth + 1, !isMax);
                    board[i] = (char)(i + '0'); // Undo move
                    best = isMax ? Math.Max(best, value) : Math.Min(best, value);
                }
            }
            return best;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void ResetGame() 
        {
            board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Reset the board for anew game
            currentPlayer = 1; // Player 1 starts
            isGameOver = false; // Reset the game-over 

            // Reset button fields for a new game
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";

            // Reset the textbox status
            txtStatus.Text = "Player 1's turn";
        }

    }
}
