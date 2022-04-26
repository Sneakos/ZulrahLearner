using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ZulrahLearner
{
    public partial class ZulrahPhaseGenerator : Form
    {
        List<Block> Blocks;
        BindingList<PhasesStruct> Phases;
        private int _LastIndex = 0;

        public ZulrahPhaseGenerator()
        {
            InitializeComponent();

            LoadFiles();

            Phases = new BindingList<PhasesStruct>();

            SetComboBox();
        }

        private void LoadFiles()
        {
            Blocks = File.ReadAllText(DataFiles.Blocks).Deserialize<List<Block>>();
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
                Font numFont = new(lblPrayer.Font.FontFamily, 14);

                g.DrawString(num, numFont, Brushes.White, point);
            }
        }

        private void LoadFromJson(string jsonText)
        {
            List<Phase> phases = jsonText.Deserialize<List<Phase>>();

            Phases.Clear();

            for (int i = 0; i < phases.Count; i++)
            {
                Phases.Add(new PhasesStruct() { Display = "Phase " + (i + 1), Phase = phases[i] });
            }
        }

        private void SetComboBox()
        {
            cmbPhases.SelectedIndexChanged -= cmbPhases_SelectedIndexChanged;

            BindingSource bindingSource = new();

            bindingSource.DataSource = Phases;

            cmbPhases.DataSource = bindingSource;

            cmbPhases.DisplayMember = "Display";
            cmbPhases.ValueMember = "Phase";

            cmbPhases.SelectedIndexChanged += cmbPhases_SelectedIndexChanged;

        }

        private void LoadPhase()
        {
            Phase phase = Phases[cmbPhases.SelectedIndex].Phase;

            //Helm
            if (phase.Helm == Helm.Mage)
            {
                rdioHelmMage.Checked = true;
            }
            else
            {
                rdioHelmRange.Checked = true;
            }

            //Weapon
            if (phase.Weapon == Weapon.Staff)
            {
                rdioWeaponStaff.Checked = true;
            }
            else
            {
                rdioWeaponCrossbow.Checked = true;
            }

            //Prayer
            if (phase.Prayer == Prayer.Mage)
            {
                rdioPrayerMage.Checked = true;
            }
            else if (phase.Prayer == Prayer.Range)
            {
                rdioPrayerRange.Checked = true;
            }
            else
            {
                rdioPrayerNone.Checked = true;
            }

            //Zulrah Style
            if (phase.ZulrahStyle == ZulrahStyle.Mage)
            {
                rdioZulrahStyleMage.Checked = true;
            }
            else if (phase.ZulrahStyle == ZulrahStyle.Range)
            {
                rdioZulrahStyleRange.Checked = true;
            }
            else
            {
                rdioZulrahStyleMelee.Checked = true;
            }

            //Zulrah Location
            if (phase.ZulrahLocationBlockID == 7)
            {
                rdioZulrahBlockID7.Checked = true;
            }
            else if (phase.ZulrahLocationBlockID == 8)
            {
                rdioZulrahBlockID8.Checked = true;
            }
            else if (phase.ZulrahLocationBlockID == 9)
            {
                rdioZulrahBlockID9.Checked = true;
            }
            else
            {
                rdioZulrahBlockID10.Checked = true;
            }

            txtPlayerBlockIDs1.Text = "";
            txtPlayerBlockIDs2.Text = "";
            txtPlayerBlockIDs3.Text = "";

            //Player Block IDS
            if (phase.PlayerBlockIDs != null)
            {
                if (phase.PlayerBlockIDs.Count > 0)
                {
                    txtPlayerBlockIDs1.Text = phase.PlayerBlockIDs[0].ToString();
                    if (phase.PlayerBlockIDs.Count > 1)
                    {
                        txtPlayerBlockIDs2.Text = phase.PlayerBlockIDs[1].ToString();
                        if (phase.PlayerBlockIDs.Count > 2)
                        {
                            txtPlayerBlockIDs3.Text = phase.PlayerBlockIDs[2].ToString();
                        }
                    }
                }
            }

            //Jad Phase
            rdioJadPhase.Checked = phase.JadPhase;
        }

        private void SavePhase()
        {
            int i = _LastIndex;

            //Helm
            if (rdioHelmMage.Checked)
            {
                Phases[i].Phase.Helm = Helm.Mage;
            }
            else
            {
                Phases[i].Phase.Helm = Helm.Range;
            }

            //Weapon
            if (rdioWeaponStaff.Checked)
            {
                Phases[i].Phase.Weapon = Weapon.Staff;
            }
            else
            {
                Phases[i].Phase.Weapon = Weapon.Crossbow;
            }

            //Prayer
            if (rdioPrayerMage.Checked)
            {
                Phases[i].Phase.Prayer = Prayer.Mage;
            }
            else if (rdioPrayerRange.Checked)
            {
                Phases[i].Phase.Prayer = Prayer.Range;
            }
            else
            {
                Phases[i].Phase.Prayer = Prayer.None;
            }

            //Zulrah Style
            if (rdioZulrahStyleMage.Checked)
            {
                Phases[i].Phase.ZulrahStyle = ZulrahStyle.Mage;
            }
            else if (rdioZulrahStyleRange.Checked)
            {
                Phases[i].Phase.ZulrahStyle = ZulrahStyle.Range;
            }
            else
            {
                Phases[i].Phase.ZulrahStyle = ZulrahStyle.Melee;
            }

            //Zulrah Location
            if (rdioZulrahBlockID7.Checked)
            {
                Phases[i].Phase.ZulrahLocationBlockID = 7;
            }
            else if (rdioZulrahBlockID8.Checked)
            {
                Phases[i].Phase.ZulrahLocationBlockID = 8;
            }
            else if (rdioZulrahBlockID9.Checked)
            {
                Phases[i].Phase.ZulrahLocationBlockID = 9;
            }
            else
            {
                Phases[i].Phase.ZulrahLocationBlockID = 10;
            }

            List<int> pBlockIDs = new List<int>();

            if (txtPlayerBlockIDs1.TextLength > 0)
            {
                try
                {
                    pBlockIDs.Add(int.Parse(txtPlayerBlockIDs1.Text));
                }
                catch
                {
                    txtPlayerBlockIDs1.Text = "NaN";
                }
            }

            if (txtPlayerBlockIDs2.TextLength > 0)
            {
                try
                {
                    pBlockIDs.Add(int.Parse(txtPlayerBlockIDs2.Text));
                }
                catch
                {
                    txtPlayerBlockIDs2.Text = "NaN";
                }
            }

            if (txtPlayerBlockIDs3.TextLength > 0)
            {
                try
                {
                    pBlockIDs.Add(int.Parse(txtPlayerBlockIDs3.Text));
                }
                catch
                {
                    txtPlayerBlockIDs3.Text = "NaN";
                }
            }

            Phases[i].Phase.PlayerBlockIDs = pBlockIDs;

            //Jad Phase
            Phases[i].Phase.JadPhase = rdioJadPhase.Checked;
        }

        #region Events

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cmbPhases.SelectedIndexChanged -= cmbPhases_SelectedIndexChanged;

            OpenFileDialog openFileDialog = new();
            openFileDialog.Title = "Open Rotation JSON File";
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.InitialDirectory = @"F:\Users\Sneakos\Desktop\Programs\C#\ZulrahLearner\Assets\Data";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadFromJson(File.ReadAllText(openFileDialog.FileName));

                _LastIndex = 0;
            }

            if (Phases.Count > 0)
            {
                pnlRotationInfo.Enabled = true;
                cmbPhases.SelectedIndex = 0;

                LoadPhase();
            }
            cmbPhases.SelectedIndexChanged += cmbPhases_SelectedIndexChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Title = "Save Rotation JSON File";
            saveFileDialog.Filter = "JSON Files|*.json";
            saveFileDialog.InitialDirectory = @"F:\Users\Sneakos\Desktop\Programs\C#\ZulrahLearner\Assets\Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _LastIndex = cmbPhases.SelectedIndex;

                SavePhase();

                string jsonString = Phases.Select(x => x.Phase).Serialize();

                File.WriteAllText(saveFileDialog.FileName, jsonString);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbPhases.SelectedIndexChanged -= cmbPhases_SelectedIndexChanged;

            pnlRotationInfo.Enabled = true;

            int nextIndex = Phases.Count;

            Phases.Add(new() { Display = "Phase " + (nextIndex+1), Phase = new() });

            cmbPhases.SelectedIndex = nextIndex;

            _LastIndex = nextIndex;

            ClearForm();
            cmbPhases.SelectedIndexChanged += cmbPhases_SelectedIndexChanged;
        }

        private void ClearForm()
        {
            rdioHelmMage.Checked = false;
            rdioHelmRange.Checked = false;

            rdioWeaponStaff.Checked = false;
            rdioWeaponCrossbow.Checked = false;

            rdioZulrahBlockID7.Checked = false;
            rdioZulrahBlockID8.Checked = false;
            rdioZulrahBlockID9.Checked = false;
            rdioZulrahBlockID10.Checked = false;

            rdioJadPhase.Checked = false;

            rdioZulrahStyleMage.Checked = false;
            rdioZulrahStyleRange.Checked = false;
            rdioZulrahStyleMelee.Checked = false;

            rdioPrayerMage.Checked = false;
            rdioPrayerRange.Checked = false;
            rdioPrayerNone.Checked = false;

            txtPlayerBlockIDs1.Text = "";
            txtPlayerBlockIDs2.Text = "";
            txtPlayerBlockIDs3.Text = "";
        }

        private void cmbPhases_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPhases.SelectedIndexChanged -= cmbPhases_SelectedIndexChanged;

            if (Phases.Count > 0)
            {
                pnlRotationInfo.Enabled = true;

                SavePhase();

                LoadPhase();

                _LastIndex = cmbPhases.SelectedIndex;
            }
            else
            {
                pnlRotationInfo.Enabled = false;
            }

            cmbPhases.SelectedIndexChanged += cmbPhases_SelectedIndexChanged;
        }

        #region Graphics

        #endregion Graphics

        #endregion Events

        private void pbZulrahShrine_Paint(object sender, PaintEventArgs e)
        {
            DrawBlocks(e.Graphics);
        }
    }

    public class PhasesStruct
    {
        public string Display { get; set; }
        public Phase Phase { get; set; }
    }
}
