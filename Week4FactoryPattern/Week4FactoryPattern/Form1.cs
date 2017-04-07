using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week4FactoryPattern
{
    public partial class Form1 : Form
    {

        GenericGame thegame;
        IFactory minionFactory;
        IFactory smurfFactory;

        public Form1()
        {
            InitializeComponent();
            minionFactory = new MinionFactory();
            smurfFactory = new SmurfFactory();
        }


        private void btSing_Click(object sender, EventArgs e)
        {
            try
            {
                lb_events.Items.Add(thegame.sing((IFigure)lb_figures.SelectedItem));
            }
            catch (Exception)
            {
                MessageBox.Show("Select a figure first");
            }
        }

        private void btDance_Click(object sender, EventArgs e)
        {
            try
            {
                lb_events.Items.Add(thegame.dance((IFigure)lb_figures.SelectedItem));
            }
            catch (Exception)
            {
                MessageBox.Show("Select a figure first");
            }
        }


        private void rbMinionGame_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                thegame.setFactory(minionFactory);
            }
            catch (Exception)
            {
                MessageBox.Show("First create the game");
            }
        }

        private void rbSmurfGame_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
            thegame.setFactory(smurfFactory);
            }
            catch (Exception)
            {
                MessageBox.Show("First create the game");
            }
        }

        private void btCreateFigure_Click(object sender, EventArgs e)
        {
            try
            {
                lb_figures.Items.Add(thegame.createFig(tbName.Text));
                lb_events.Items.Add("New figure added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Select a game from radiobuttons");
            }
        }

        private void btRepairHouse_Click(object sender, EventArgs e)
        {
            try
            {
                lb_events.Items.Add(thegame.FixHouse((IHouse)lb_houses.SelectedItem));
            }
            catch (Exception)
            {
                MessageBox.Show("Select a house first");
            }
        }

        private void btMeasureHouse_Click(object sender, EventArgs e)
        {
            try
            {
                lb_events.Items.Add(thegame.GetHouseSize((IHouse)lb_houses.SelectedItem));
            }
            
            catch (Exception)
            {
                MessageBox.Show("Select a house first");
            }
        }

        private void btCreateHouse_Click(object sender, EventArgs e)
        {
            try
            {
                lb_houses.Items.Add(thegame.createHouse());
                lb_events.Items.Add("New house added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Select a game from radiobuttons");
            }
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            thegame = new GenericGame();
            lb_events.Items.Add(thegame.run());
        }



    }
}
