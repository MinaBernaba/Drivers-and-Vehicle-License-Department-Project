﻿using BusinessLogicOfDVLD;
using DVLD.Applications.Application_Types;
using DVLD.Classes;
using DVLD.Controls;
using DVLD.Login_Screen;
using DVLD.People;
using DVLD.Tests.Test_Types;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{

    public partial class frmMain : Form
    {
        private clsUser _User;
        private int _UserID;
        public frmMain(int UserID)
        {
            InitializeComponent();
            _User = clsUser.FindUser(UserID);
            _UserID = UserID;
        }

        private void peropleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void usresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers usres = new frmListUsers();
            usres.ShowDialog();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Tag = 1;
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frmChangePassword.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }
    }
}
