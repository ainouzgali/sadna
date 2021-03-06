﻿using client.Network;
using DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class ManagerPresentation : Form
    {
        ForumConnection myConnection;
        CurrentForumState CurrentState;
        public ManagerPresentation(ForumConnection myConnectionP, CurrentForumState State)
        {
            CurrentState = State;
            this.myConnection = myConnectionP;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConnection.BuildForum(textBox1.Text);
            textBox1.Clear();
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // myConnection.promoteMemberToAdmin(listBox1.Text);
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConnection.addNewType(listBox1.Text);
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<ForumInfo> AllForums= myConnection.WatchAllForums();
            for (int i = 0; i<AllForums.Count(); i++)
            {
                listBox1.Items.Add(AllForums.ElementAt(i).name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
