using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class Run_Game : Form
    {
        public Run_Game()
        {
            InitializeComponent();
        }
        int idContest;

        public int IdContest
        {
            get { return idContest; }
            set { idContest = value; }
        }
        Contest contest = new Contest();
        Phase phase = new Phase();
        Player player = new Player();

        ContestBL contestBL = new ContestBL();
        PlayerBL playerBL = new PlayerBL();
        PhaseBL phaseBL = new PhaseBL();

        int NumStep;
        int NumLife;
        int HeightPanel;
        int WidthPanel;
        

        private void Run_Game_Load(object sender, EventArgs e)
        {
            HeightPanel = pnl_GameMap.Height;
            WidthPanel = pnl_GameMap.Width;
            
            contest.IDContest = idContest;
            phase.IDContest = idContest;
            player.IDContest = idContest;

            List<Contest> listContest;
            List<Phase> listPhase;
            List<Player> listPlayer;

            listContest = contestBL.GetContestByID(contest);
            listPhase = phaseBL.GetPhaseByIDContest(phase);
            listPlayer = playerBL.GetPlayerByIDContest(player);
            //get element in contest
            if (listContest != null)
            {
                for (int i = 0; i < listContest.Count; i++)
                {
                    NumStep = listContest.ElementAt(i).TimesTrue;
                    NumLife = listContest.ElementAt(i).TimesFalse;
                }
            }
            //Draw Player Lane
            if (listPlayer!= null)
            {
                for (int i = 0; i < listPlayer.Count; i++)
                {
                    Player_Lane PlayerLane = new Player_Lane();
                    PlayerLane.Location = new Point(PlayerLane.Location.X + ((95 * i)+5), PlayerLane.Location.Y + 5);
                    PlayerLane.lbl_IDPlayer.Text = listPlayer.ElementAt(i).Sequence.ToString();
                    pnl_GameMap.Controls.Add(PlayerLane); 
                }
            }
            
            //Draw item in Map
            foreach (Player_Lane item in pnl_GameMap.Controls)
            {
                //draw num of step to pass phase
                for (int i = 0; i < NumStep; i++)
                {
                    Node_Phase NodePhase = new Node_Phase();
                    NodePhase.Size = new System.Drawing.Size(15, 15);
                    NodePhase.Location = new Point(NodePhase.Location.X + ((17 * i)), NodePhase.Location.Y + HeightPanel-45);
                    item.Controls.Add(NodePhase);
                }
                //draw num of life in phase to end game
                for (int i = 0; i < NumLife; i++)
                {
                    Life Life = new Life();
                    Life.Size = new System.Drawing.Size(15, 15);
                    Life.Location = new Point(Life.Location.X + ((17 * i)), Life.Location.Y + HeightPanel-25);
                    item.Controls.Add(Life);
                }
                //draw phase in map
                if (listPhase != phaseBL.GetPhaseByIDContest(phase))
                {
                    for (int i = 0; i < listPhase.Count; i++)
                    {
                        Phase_Lane PhaseLane = new Phase_Lane();
                        PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + (HeightPanel - ((50 * i) + 90)));
                        PhaseLane.lbl_NamePhase.Text = listPhase.ElementAt(i).NamePhase;
                        item.Controls.Add(PhaseLane);  
                    }
                    
                }
            }

            //Phase line
            if (listPhase != phaseBL.GetPhaseByIDContest(phase))
            {
                for (int i = 0; i < listPhase.Count; i++)
                {
                    Phase_Lane PhaseLane = new Phase_Lane();
                    PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + (HeightPanel - ((50 * i) + 85)));
                    PhaseLane.BackColor = Color.LightGreen;
                    PhaseLane.lbl_NamePhase.Text = listPhase.ElementAt(i).NamePhase;
                    pnl_PhaseLine.Controls.Add(PhaseLane);
                }
            }
        }
    }
}
