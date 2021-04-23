using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Events.Presenters;
using Events.Views;

namespace Events
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create main view
            MainView mainView = new MainView();

            //create empty list
            List<SubView> subViews = new List<SubView>();

            //Create sub views
            subViews.Add(new SubView());
            subViews.Add(new SubView());
            subViews.Add(new SubView());

            //create presenter
            MainPresenter presenter = new MainPresenter(mainView, subViews);

            //initialize gui
            presenter.InitializeGui();


            Application.Run();
        }
    }
}
