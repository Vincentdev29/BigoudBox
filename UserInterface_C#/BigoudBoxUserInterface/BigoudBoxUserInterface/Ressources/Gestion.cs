using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigoudBoxUserInterface
{
    class Gestion
    {
        private System.Windows.Forms.Label menuLabel;
        private MainMenu_UserControl mainMenu;
        private Home_UserControl homePanel;
        private Dashboard_UserControl dashboard;
        private Statistics_UserControl statistics;
        private MenuAdherent_UserControl menuAdherent;
        private AddAdherent_UserControl addAdherent;
        private ModifyAdherent_UserControl modifyAdherent;
        private DeleteAdherent_UserControl deleteAdherent;

        public Gestion(
            System.Windows.Forms.Label menuLabel,
            //Main menu
            MainMenu_UserControl mainMenu,
            Home_UserControl home,
            Dashboard_UserControl dashboard,
            Statistics_UserControl statistics,
            //Menu Adherent 
            MenuAdherent_UserControl menuAdherent,
            AddAdherent_UserControl addAdherent,
            ModifyAdherent_UserControl modifyAdherent,
            DeleteAdherent_UserControl deleteAdherent
            )
        {
            this.menuLabel = menuLabel;
            this.mainMenu = mainMenu;
            this.homePanel = home;
            this.dashboard = dashboard;
            this.statistics = statistics;
            this.menuAdherent = menuAdherent;
            this.addAdherent = addAdherent;
            this.modifyAdherent = modifyAdherent;
            this.deleteAdherent = deleteAdherent;
        }

        public void MainPage_Action(int state)
        {
            switch (state)
            {
                case 1:
                    this.menuLabel.Text = "HOME";
                    this.homePanel.BringToFront();
                    break;

                case 2:
                    this.menuLabel.Text = "DASHBOARD";
                    this.dashboard.BringToFront();
                    break;

                case 3:
                    //menuLabel.Text = "";
                    this.menuAdherent.BringToFront();
                    break;

                case 4:
                    this.menuLabel.Text = "STATISTICS";
                    this.statistics.BringToFront();
                    break;
            }
        }

        public void AdhPage_Action(int state)
        {
            //Change the menu name if needed
            switch (state)
            {
                //Return button, display mainMenu
                case 1:
                    this.mainMenu.BringToFront();
                    break;
                    
                //New Adherent, display new adherent menu
                case 2:
                    this.menuLabel.Text = "NOUVEAU ADHERENT";
                    this.addAdherent.BringToFront();
                    break;

                //Modify Adherent, display new adherent menu
                case 3:
                    this.menuLabel.Text = "MODIFIER ADHERENT";
                    this.modifyAdherent.BringToFront();
                    break;

                //Delete adherent, display new adherent menu
                case 4:
                    this.menuLabel.Text = "SUPPRIMER ADHERENT";
                    this.deleteAdherent.BringToFront();
                    break;
            }
        }
    }
}
