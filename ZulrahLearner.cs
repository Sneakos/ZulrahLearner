using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZulrahLearner
{
    public partial class Zulrah : Form
    {
        #region Constants

        private const int PhaseSpeed = 100;
        private const int PhaseStepSpeed = 100;
        private const int NextPhaseSpeed = 1;

        // private const int PhaseSpeed = 6;
        // private const int NextPhaseSpeed = 3;
        // private const int PhaseStepSpeed = 4;

        #endregion Constants

        #region Instance Variables

        private DateTime _startTime, _endTime;

        public Rotation Rotation;
        public List<Block> Blocks;
        private GameState GameState;

        #endregion Instance Variables

        #region Setup

        public Zulrah()
        {
            InitializeComponent();

            ResizeAllImages();

            gearScreen.Visible = false;
            prayerScreen.Visible = false;

            cmbPhase.SelectedIndex = 0;
            lblTimeLeft.Text = "";
            lblRotation.Text = "";
            loadingBar = new SharedControls.LoadingBar
            {
                CurrentValue = 0,
                MaxValue = 10000
            };

            InitializeGameState();

            LoadBlocks();

            Refresh();
        }

        private void InitializeGameState()
        {
            GameState.Debug_mode = true;

            if (GameState.Debug_mode)
            {
                pbZulrahShrine.Image = Images.ZulrahShrineWithGridLines;
            }
        }

        private void LoadBlocks()
        {
            string blockJson = File.ReadAllText(DataFiles.Blocks);

            Blocks = blockJson.Deserialize<List<Block>>();
        }

        private void SetInformationLabels(bool hasSub)
        {
            if (GameSettings.HideRotation)
            {
                lblRotation.Text = "";
                return;
            }

            lblRotation.Text = Rotation.ToString();

            if (hasSub)
            {
                char subPhase = (char)(97 + GameState.PhaseBlock);

                lblRotation.Text += subPhase;
            }
        }

        private void SetZulrahImage()
        {
            Size pbSize = Blocks[Rotation.CurrentPhase.ZulrahLocationBlockID].Size;
            Point pbLoc = Blocks[Rotation.CurrentPhase.ZulrahLocationBlockID].Point;

            switch (Rotation.CurrentPhase.ZulrahStyle)
            {
                case ZulrahStyle.Mage:
                    pbZulrah.Image = Images.ZulrahMage.Resize(pbSize);
                    break;
                case ZulrahStyle.Range:
                    pbZulrah.Image = Images.ZulrahRange.Resize(pbSize);
                    break;
                case ZulrahStyle.Melee:
                    pbZulrah.Image = Images.ZulrahMelee.Resize(pbSize);
                    break;
            }

            pbZulrah.Location = pbLoc;
            pbZulrah.Size = pbSize;

            pbZulrah.Visible = true;
        }

        private void SetRotation()
        {
            switch (cmbPhase.SelectedIndex)
            {
                case 0: Rotation = new("A"); break;
                case 1: Rotation = new("B"); break;
                case 2: Rotation = new("C"); break;
                case 3: Rotation = new("D"); break;
                case 4: Rotation = GetRandomRotation(); break;
            }

            SetInformationLabels(false);
        }

        #endregion Setup

        #region Private Methods

        #region Graphics

        private void ResizeAllImages()
        {

        }

        private void DrawBlocks(Graphics g)
        {
            foreach (Block block in Blocks)
            {
                Point point = block.Point;
                Size size = block.Size;

                g.DrawRectangle(Pens.White, new Rectangle(point, size));

                point.X = point.X + (size.Width / 3);
                point.Y = point.Y + (size.Height / 4);
                string num = block.ID.ToString();
                Font numFont = new(lblTimeLeft.Font.FontFamily, 14);

                g.DrawString(num, numFont, Brushes.White, point);
            }
        }

        #endregion Graphics

        #region Timer

        private void InitializeLoadingBar()
        {
            _startTime = DateTime.Now;
            _endTime = _startTime.AddSeconds(GameSettings.CurrentSpeed);

            loadingBar.CurrentValue = 0;
            loadingBar.MaxValue = 10000;
        }

        private void SetLoadingBarPositionTickUp()
        {
            DateTime currTime = DateTime.Now;

            TimeSpan startDiff = currTime - _startTime;
            TimeSpan totalDiff = _endTime - _startTime;

            double percentDiff = startDiff / totalDiff;

            loadingBar.CurrentValue = (int)(loadingBar.MaxValue * percentDiff);

            if (loadingBar.CurrentValue > loadingBar.MaxValue)
            {
                loadingBar.CurrentValue = loadingBar.MaxValue;
            }

            int timeLeft = GameSettings.CurrentSpeed - ((int)(GameSettings.CurrentSpeed * percentDiff));

            lblTimeLeft.Text = (timeLeft > 9 ? "" : " ") + timeLeft;

            loadingBar.Refresh();
        }

        private void SetLoadingBarPositionTickDown()
        {
            DateTime currTime = DateTime.Now;

            TimeSpan startDiff = currTime - _startTime;
            TimeSpan totalDiff = _endTime - _startTime;

            double percentDiff = startDiff / totalDiff;

            loadingBar.CurrentValue = loadingBar.MaxValue - (int)(loadingBar.MaxValue * percentDiff);

            if (loadingBar.CurrentValue > loadingBar.MaxValue)
            {
                loadingBar.CurrentValue = loadingBar.MaxValue;
            }

            loadingBar.Refresh();
        }

        private void StartTimer()
        {
            InitializeLoadingBar();

            PhaseTimer.Start();
        }

        #endregion Timer

        #region Phase

        private void NextPhase()
        {
            PhaseTimer.Stop();

            GameState.PhaseBlock = 0;
            GameSettings.CurrentSpeed = PhaseSpeed;

            if (GameState.Correct)
            {
                GameState.CorrectCount++;
            }
            else
            {
                GameState.IncorrectCount++;
            }

            SetScoreLabel();

            cbJadPhase.Checked = false;

            bool done = Rotation.NextPhase();

            if (done)
            {
                loadingBar.BackColor = Color.FromArgb(46, 252, 56);
                InitializeLoadingBar();
                loadingBar.Refresh();
                lblRotation.Text = "Rotation Complete";

                if (GameSettings.Loop)
                {
                    SetRotation();

                    PreNextPhase();
                }
            }
            else
            {
                PreNextPhase();
            }
        }

        private void SetScoreLabel()
        {
            int totalCount = GameState.CorrectCount + GameState.IncorrectCount;

            string spaceCorrect = GameState.CorrectCount > 9 ? " " : "";
            string spaceTotal = totalCount > 9 ? " " : "";

            lblScore.Text = spaceCorrect + GameState.CorrectCount + " / " + spaceTotal + totalCount;
        }

        private void PreNextPhase()
        {
            lblTimeLeft.Location = new Point(686, 51);
            lblTimeLeft.Font = new Font(lblTimeLeft.Font.FontFamily, 12);
            lblTimeLeft.Text = "Next Phase...";

            PhaseTimer.Tick -= PhaseTimer_TickUp;
            PhaseTimer.Tick += PhaseTimer_TickDown;

            GameSettings.CurrentSpeed = NextPhaseSpeed;

            loadingBar.BackColor = Color.Blue;
            pbZulrah.Visible = false;

            InitializeLoadingBar();

            PhaseTimer.Start();
        }

        private void FinishNextPhase()
        {
            PhaseTimer.Stop();

            GameSettings.CurrentSpeed = PhaseSpeed;
            GameState.ShowCorrectSquare = false;

            InitializeLoadingBar();

            SetZulrahImage();

            SetInformationLabels(Rotation.CurrentPhase.PlayerBlockIDs.Count > 1);

            lblTimeLeft.Location = new Point(731, 39);
            lblTimeLeft.Font = new Font(lblTimeLeft.Font.FontFamily, 20.25f);
            lblTimeLeft.Text = "";

            PhaseTimer.Tick -= PhaseTimer_TickDown;
            PhaseTimer.Tick += PhaseTimer_TickUp;

            loadingBar.BackColor = Color.FromArgb(46, 252, 56);

            Refresh();

            PhaseTimer.Start();
        }

        public void StepThroughBlocks()
        {
            PhaseTimer.Stop();

            GameState.PhaseBlock++;

            GameSettings.CurrentSpeed = PhaseStepSpeed;

            SetInformationLabels(true);

            InitializeLoadingBar();

            PhaseTimer.Start();
        }

        private void FailPhase()
        {
            GameState.ShowCorrectSquare = true;
            GameState.Correct = false;
            Refresh();
        }

        private void PassPhase()
        {
            GameState.ShowCorrectSquare = false;
            GameState.Correct = true;
        }

        #endregion Phase

        #region Misc Methods

        private void CheckIfCorrect()
        {
            Phase phase = Rotation.CurrentPhase;

            if (GameState.CurrentPrayer == phase.Prayer &&
                GameState.CurrentWeapon == phase.Weapon &&
                GameState.CurrentHelm == phase.Helm &&
                cbJadPhase.Checked == phase.JadPhase)
            {
                if (GameState.CorrectSpotClicked)
                {
                    if (GameState.PhaseBlock < phase.PlayerBlockIDs.Count - 1)
                    {
                        StepThroughBlocks();
                    }
                    else
                    {
                        PassPhase();

                        NextPhase();
                    }
                }
            }
        }

        private Rotation GetRandomRotation()
        {
            Random randomNumGenerator = new();

            string phase = ((char)randomNumGenerator.Next('A', 'E')).ToString();

            return new(phase);
        }

        #endregion Misc Methods

        #endregion Private Methods

        #region Events

        #region Interface Clicks

        private void pbMage_Click(object sender, EventArgs e)
        {
            if (GameState.CurrentPrayer == Prayer.Mage)
            {
                // pbMage.Image = Images.MagePrayerOff.Resize(pbMage.Size);
                GameState.CurrentPrayer = Prayer.None;
            }
            else
            {
                //  pbMage.Image = Images.MagePrayerOn.Resize(pbMage.Size);
                GameState.CurrentPrayer = Prayer.Mage;

                //pbRange.Image = Images.RangePrayerOff.Resize(pbRange.Size);
                // pbMelee.Image = Images.MeleePrayerOff.Resize(pbMelee.Size);
            }
        }

        private void pbRange_Click(object sender, EventArgs e)
        {
            if (GameState.CurrentPrayer == Prayer.Range)
            {
                //pbRange.Image = Images.RangePrayerOff.Resize(pbRange.Size);
                GameState.CurrentPrayer = Prayer.None;
            }
            else
            {
                //pbRange.Image = Images.RangePrayerOn.Resize(pbRange.Size);
                GameState.CurrentPrayer = Prayer.Range;

                //pbMage.Image = Images.MagePrayerOff.Resize(pbMage.Size);
                // pbMelee.Image = Images.MeleePrayerOff.Resize(pbMelee.Size);
            }
        }

        private void pbMelee_Click(object sender, EventArgs e)
        {
            if (GameState.CurrentPrayer == Prayer.Melee)
            {
                //pbMelee.Image = Images.MeleePrayerOff.Resize(pbMelee.Size);
                GameState.CurrentPrayer = Prayer.None;
            }
            else
            {
                //pbMelee.Image = Images.MeleePrayerOn.Resize(pbMelee.Size);
                GameState.CurrentPrayer = Prayer.Melee;

                // pbMage.Image = Images.MagePrayerOff.Resize(pbMage.Size);
                //pbRange.Image = Images.RangePrayerOff.Resize(pbRange.Size);
            }
        }

        private void pbWeapon_Click(object sender, EventArgs e)
        {
            if (GameState.CurrentWeapon == Weapon.Crossbow)
            {
                //pbWeapon.Image = Images.Crossbow.Resize(pbWeapon.Size);
                GameState.CurrentWeapon = Weapon.Staff;
            }
            else
            {
                //pbWeapon.Image = Images.Staff.Resize(pbWeapon.Size);
                GameState.CurrentWeapon = Weapon.Crossbow;
            }
        }

        private void pbHelm_Click(object sender, EventArgs e)
        {
            if (GameState.CurrentHelm == Helm.Range)
            {
                //pbHelm.Image = Images.RangeHelm.Resize(pbHelm.Size);
                GameState.CurrentHelm = Helm.Mage;
            }
            else
            {
                //pbHelm.Image = Images.MageHelm.Resize(pbHelm.Size);
                GameState.CurrentHelm = Helm.Range;
            }
        }

        #endregion Interface Clicks

        #region Form and PictureBox Events

        private void Zulrah_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void pbZulrahShrine_MouseDown(object sender, MouseEventArgs e)
        {
            if (PhaseTimer.Enabled == false)
                return;

            GameState.PointClicked = new Point(e.Location.X - 10, e.Location.Y - 5);
            GameState.CorrectSpotClicked = false;

            List<int> correctBlockIDs = Rotation.CurrentPhase.PlayerBlockIDs[GameState.PhaseBlock];

            foreach (int blockID in correctBlockIDs)
            {
                Rectangle blockRectangle = new(Blocks[blockID].Point, Blocks[blockID].Size);

                if (blockRectangle.Contains(e.Location))
                {
                    GameState.CorrectSpotClicked = true;
                }
            }

            pbZulrahShrine.Refresh();
        }

        private void pbZulrahShrine_Paint(object sender, PaintEventArgs e)
        {
            if (GameState.Debug_mode)
            {
                if (Rotation != null)
                {
                    foreach (int blockID in Rotation.CurrentPhase.PlayerBlockIDs[GameState.PhaseBlock])
                    {
                        Point playerPoint = Blocks[blockID].Point;
                        Size playerSize = Blocks[blockID].Size;

                        e.Graphics.DrawRectangle(Pens.White, new Rectangle(playerPoint, playerSize));
                    }
                }
            }

            if (GameState.ShowCorrectSquare)
            {
                Phase currentPhase = Rotation.CurrentPhase;

                foreach (int blockID in currentPhase.PlayerBlockIDs[GameState.PhaseBlock])
                {
                    Point playerPoint = Blocks[blockID].Point;
                    Size playerSize = Blocks[blockID].Size;

                    e.Graphics.DrawRectangle(Pens.White, new Rectangle(playerPoint, playerSize));
                }
            }

            Font font = new(lblTimeLeft.Font.FontFamily, 14);
            e.Graphics.DrawString("X", font, Brushes.Yellow, GameState.PointClicked);

            //DrawBlocks(e.Graphics);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) //Inventory
            {
                //pbHelm.Visible = true;
                //pbWeapon.Visible = true;

                //pbMage.Visible = false;
                //pbRange.Visible = false;
                //pbMelee.Visible = false;

                //lblInterface.Text = "Inventory";

                return true;
            }
            else if (keyData == Keys.F5) //Prayer
            {
                //pbHelm.Visible = false;
                //pbWeapon.Visible = false;

                //pbMage.Visible = true;
                //pbRange.Visible = true;
                //pbMelee.Visible = true;

                //lblInterface.Text = " Prayers";

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion Form and PictureBox Events

        #region Other Click Events

        private void pbZulrah_Click(object sender, EventArgs e)
        {
            CheckIfCorrect();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            PhaseTimer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (PhaseTimer.Enabled)
                PhaseTimer.Stop();

            ResetGame();

            StartTimer();
        }

        private void ResetGame()
        {
            SetRotation();

            InitializeGameState();

            LoadBlocks();

            SetZulrahImage();

            btnStart.Text = "Restart";

            loadingBar.BackColor = Color.FromArgb(46, 252, 56);
            PhaseTimer.Tick -= PhaseTimer_TickDown;
            PhaseTimer.Tick -= PhaseTimer_TickUp;
            PhaseTimer.Tick += PhaseTimer_TickUp;

            SetScoreLabel();

            Refresh();
        }

        #endregion Other Click Events

        #region Timer Events

        private void PhaseTimer_TickUp(object sender, EventArgs e)
        {
            if (DateTime.Now >= _endTime)
            {
                FailPhase();

                NextPhase();
            }
            else
            {
                SetLoadingBarPositionTickUp();
            }
        }

        private void phaseGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZulrahPhaseGenerator phaseGen = new ZulrahPhaseGenerator();

            phaseGen.ShowDialog();

            ResetGame();
        }

        private void cmbPhase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhase.SelectedIndex == 4) //random
            {
                GameSettings.HideRotation = true;
            }
            else
            {
                GameSettings.HideRotation = false;
            }
        }

        private void PhaseTimer_TickDown(object sender, EventArgs e)
        {
            if (DateTime.Now >= _endTime)
            {
                FinishNextPhase();
            }
            else
            {
                SetLoadingBarPositionTickDown();
            }
        }

        #endregion Timer Events

        #endregion Events

        private void Zulrah_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZulrahLearnerSettings settings = new ZulrahLearnerSettings();

            settings.ShowDialog();
        }
    }
}