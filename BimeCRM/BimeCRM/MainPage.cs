using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BimeCRM
{
    public partial class MainPage : Form
    {

        /// Parameters
        private List<int> mainPageOpenPages = new List<int>();


        public MainPage()
        {
            InitializeComponent();
        }

        private void menuDatacenter_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(0); 
        }


        private void menuBimeAll_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(1);
        }

        private void menuBimeSales_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(2);
        }

        private void menuBimeBadane_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(3);
        }

        private void menuBimeOthers_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(4);
        }

        private void menuPersons_Click(object sender, EventArgs e)
        {
            AddPageInMainPageView(5);
        }


        private void AddPageInMainPageView(int pageType)
        {
            //ToDo: complete it
            
            bool existPage = false;

            for (int i = 0; i < mainPageOpenPages.Count; i++)
            {
                if (mainPageOpenPages[i] == pageType)
                {
                    existPage = true;
                }
            }

            if (!existPage)
            {
                RadPageViewPage pageViewPage;
                switch (pageType)
                {
                    case 0:
                        pageViewPage = new RadPageViewPage("مدیریت داده ها");
                        
                        break;
                    case 1:
                        pageViewPage = new RadPageViewPage("همه بیمه ها");
                        break;
                    case 2:
                        pageViewPage = new RadPageViewPage("بیمه های ثالث");
                        break;
                    case 3:
                        pageViewPage = new RadPageViewPage("بیمه های بدنه");
                        break;
                    case 4:
                        pageViewPage = new RadPageViewPage("سایر بیمه ها");
                        break;
                    case 5:
                        pageViewPage = new RadPageViewPage("بیمه گذاران");
                        break;

                    default:
                        pageViewPage = new RadPageViewPage("");
                        break;
                }

                pageViewPage.Name = pageType.ToString(); //set name to find it for focus
                mainPageView.Pages.Add(pageViewPage); // add page in view
                mainPageOpenPages.Add(pageType); // add pageType in list of open page
                mainPageView.SelectedPage = mainPageView.Pages[pageType.ToString()]; // focus on page that created
            }
            else
            {
                // todo : if exist page show that


                mainPageView.SelectedPage = mainPageView.Pages[pageType.ToString()];

            }

        }

        private void mainPageView_PageRemoved(object sender, RadPageViewEventArgs e)
        {
            mainPageOpenPages.Remove(mainPageOpenPages.IndexOf(Int32.Parse(e.Page.Name)));
        }

       
    }
}
