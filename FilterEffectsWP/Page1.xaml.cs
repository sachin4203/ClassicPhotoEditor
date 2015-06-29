using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GoogleAds;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Resources;
using System.Windows.Media.Imaging;
using Windows.Phone.System.UserProfile;
using Microsoft.Phone.Tasks;
using System.IO.IsolatedStorage;
using System.IO;

namespace FilterEffects
{
    public partial class Page1 : PhoneApplicationPage
    {
        public static bool askforReview = (bool)IsolatedStorageSettings.ApplicationSettings["askforreview"];


       
        public Page1()
        {
            InitializeComponent();
            
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //  NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

            if (askforReview)
            {
                //make sure we only ask once! 
                var returnvalue = MessageBox.Show("Please tell us how is the app as your reveiws matter alot to us.\nPlease  Rate 5 Stars", "Please  Rate 5 Stars", MessageBoxButton.OK);
                if (returnvalue == MessageBoxResult.OK)
                {
                    IsolatedStorageSettings.ApplicationSettings["done"] = true;
                    askforReview = false;



                    var marketplaceReviewTask = new MarketplaceReviewTask();
                    marketplaceReviewTask.Show();
                }

                NavigationService.GoBack();

                }

                 else
                NavigationService.GoBack();

            }
        }
    }
