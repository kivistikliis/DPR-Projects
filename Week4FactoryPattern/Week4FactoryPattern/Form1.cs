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

        private void btCreateMinionGame_Click(object sender, EventArgs e)
        {
            thegame=new GenericGame(minionFactory);
            lb_events.Items.Add(thegame.run());
        }

        private void btCreateSmurfGame_Click(object sender, EventArgs e)
        {
            thegame = new GenericGame(smurfFactory);
            lb_events.Items.Add(thegame.run());
        }

        private void btSing_Click(object sender, EventArgs e)
        {
            lb_events.Items.Add(thegame.sing((IFigure)lb_figures.SelectedItem));
        }

        private void btDance_Click(object sender, EventArgs e)
        {
            lb_events.Items.Add(thegame.dance((IFigure)lb_figures.SelectedItem));
        }

        private void btCreateMinion_Click(object sender, EventArgs e)
        {
            thegame.setFactory(minionFactory);
            lb_figures.Items.Add(thegame.createFig(tbName.Text));
            lb_events.Items.Add("New minion added!");
        }

        private void btCreateSmurf_Click(object sender, EventArgs e)
        {
            thegame.setFactory(smurfFactory);
            lb_figures.Items.Add(thegame.createFig(tbName.Text));
            lb_events.Items.Add("New smurf added!");
        }

        private void btSmurfHouse_Click(object sender, EventArgs e)
        {
            thegame.setFactory(smurfFactory);
            lb_events.Items.Add(thegame.FixHouse());
            lb_events.Items.Add(thegame.GetHouseSize());
        }

        private void btMinHouse_Click(object sender, EventArgs e)
        {
            thegame.setFactory(minionFactory);
            lb_events.Items.Add(thegame.FixHouse());
            lb_events.Items.Add(thegame.GetHouseSize());
        }
    }
}
