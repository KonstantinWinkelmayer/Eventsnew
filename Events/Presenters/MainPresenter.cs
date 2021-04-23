using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Views;

namespace Events.Presenters
{
    class MainPresenter
    {
        private MainView _mainView;
        private List<SubView> _subViews;

        public MainPresenter(MainView mainView, List<SubView> subView)
        {
            _mainView = mainView;
            _subViews = subView;
        }

        public void InitializeGui()
        {
            
            foreach(var subView in _subViews)
            {
                subView.Show();
            }

            _mainView.Show();

            _mainView.TextChanged += MainView_TextChanged;
        }

        private void MainView_TextChanged(object sender, string text)
        {
            foreach(var subView in _subViews)
            {
                subView.UpdateText(text);
            }
        }
    }
}
