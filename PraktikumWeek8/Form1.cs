using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtTeam = new DataTable();
            sqlQuery = "select team_name as 'NAMA TIM' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            DataTable dtTeam2 = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam2);
            cBoxHome.DataSource = dtTeam;
            cBoxHome.DisplayMember = "NAMA TIM";
            cBoxHome.ValueMember = "NAMA TIM";
            cBoxAway.DataSource = dtTeam2;
            cBoxAway.DisplayMember = "NAMA TIM";
            cBoxAway.ValueMember = "NAMA TIM";
        }

        private void cBoxHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtManager1 = new DataTable();
                sqlQuery = "SELECT m.manager_name FROM manager m, team t WHERE m.manager_id = t.manager_id and t.team_name ='" + cBoxHome.SelectedValue+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtManager1);
                labelOutputManager1.Text = dtManager1.Rows[0][0].ToString();

                DataTable dtCaptain1 = new DataTable();
                sqlQuery = "SELECT p.player_name FROM team t, player p WHERE p.player_id = t.captain_id and team_name = '" + cBoxHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCaptain1);
                labelOutputCaptain1.Text = dtCaptain1.Rows[0][0].ToString();

                DataTable dtStadium = new DataTable();
                sqlQuery = "SELECT concat(home_stadium, ', ', city) as 'Stadium' FROM `team` where team_name = '" + cBoxHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStadium);
                labelOutputStadium.Text = dtStadium.Rows[0][0].ToString();

                DataTable dtCapacity = new DataTable();
                sqlQuery = "SELECT capacity FROM `team` where team_name = '" + cBoxHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCapacity);
                labelOutputCapacity.Text = dtCapacity.Rows[0][0].ToString();
            }
            catch (Exception)
            {

            }
            
        }

        private void cBoxAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtManager2 = new DataTable();
                sqlQuery = "SELECT m.manager_name FROM manager m, team t WHERE m.manager_id = t.manager_id and t.team_name ='" + cBoxAway.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtManager2);
                labelOutputManager2.Text = dtManager2.Rows[0][0].ToString();

                DataTable dtCaptain2 = new DataTable();
                sqlQuery = "SELECT p.player_name FROM team t, player p WHERE p.player_id = t.captain_id and team_name = '" + cBoxAway.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCaptain2);
                labelOutputCaptain2.Text = dtCaptain2.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTglSkor = new DataTable();
                sqlQuery = "select date_format(m.match_date, '%d %M %Y') as 'Tanggal', concat(goal_home, ' - ', goal_away) as 'Skor' from `match` m, team t, team t2 where t.team_id = m.team_home and t2.team_id = m.team_away and t.team_name = '"+cBoxHome.SelectedValue+"' and t2.team_name = '"+cBoxAway.SelectedValue+"';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTglSkor);
                labelOutTanggal.Text = dtTglSkor.Rows[0]["Tanggal"].ToString();
                labelOutSkor.Text = dtTglSkor.Rows[0]["Skor"].ToString();
                DataTable dtmatch = new DataTable();
                sqlQuery = "select dm.minute, if(dm.type = 'GW',  if(dm.team_id != t.team_id, p.player_name, ' '),if(dm.team_id = t.team_id, p.player_name, ' ')) as 'Player Name 1',  if(dm.type = 'GW', if(dm.team_id != t.team_id, 'Own Goal', ' '),if(dm.team_id = t.team_id, if(dm.type = 'CY', 'Yellow Card', if(dm.type = 'CR', 'Red Card', if(dm.type = 'GO', 'Goal', if(dm.type = 'GP', 'Goal Penalty', if(dm.type = 'GW', 'Own Goal', 'Penalty Miss'))))),' ')) as 'Type 1',  if(dm.type = 'GW', if(dm.team_id != t2.team_id, p.player_name, ' '), if(dm.team_id = t2.team_id, p.player_name, ' ')) as 'Player Name 2',  if(dm.type = 'GW', if(dm.team_id != t2.team_id, p.player_name, ' '), if(dm.team_id = t2.team_id,if(dm.type = 'CY', 'Yellow Card', if(dm.type = 'CR', 'Red Card', if(dm.type = 'GO', 'Goal', if(dm.type = 'GP', 'Goal Penalty', if(dm.type = 'GW', 'Own Goal', 'Penalty Miss'))))), ' ')) as 'Type 2' from dmatch dm, team t, `match` m, player p, team t2 where t.team_id = m.team_home and t2.team_id = m.team_away and m.match_id = dm.match_id and t.team_name = '" + cBoxHome.SelectedValue+"' and t2.team_name = '"+cBoxAway.SelectedValue+"' and p.player_id = dm.player_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtmatch);
                dgvMatch.DataSource = dtmatch;
            }
            catch (Exception)
            {

            }
        }
    }
}
