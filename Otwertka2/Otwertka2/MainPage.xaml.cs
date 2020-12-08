using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections;

namespace Otwertka2
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            ProfileImage.Source = ImageSource.FromFile("imflag.jpg");
            aboutlis.ItemsSource = MenuList();
            var homepage = typeof(Imperial.Imperia);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }
        public List<Class1> MenuList()
        {
            var list = new List<Class1>();
            list.Add(new Class1()
            {
                Text = "Империя",
                Detail = "О режиме империи",
                ImagePath = "kartinka.png",
                TargetPage = typeof(Imperial.Imperia)
            });
            list.Add(new Class1()
            {
                Text = "Главные лица империи",
                Detail = "Те кого все уважали и боялись",
                ImagePath = "praviteli.png",
                TargetPage = typeof(Imperial.praviteli)
            });
            list.Add(new Class1()
            {
                Text = "Структуры Империи",
                Detail = "Все о структурах Империи",
                ImagePath = "voiska.png",
                TargetPage = typeof(Imperial.voiska)
            });
            list.Add(new Class1()
            {
                Text = "Наймники",
                Detail = "Самые изваестные Имперские наемники",
                ImagePath = "najom.jpg",
                TargetPage = typeof(Imperial.najom)
            });
            list.Add(new Class1()
            {
                Text = "Враги Империи",
                Detail = "От пиратов, до повстанцев",
                ImagePath = "protivniki.png",
                TargetPage = typeof(Imperial.protivniki)
            });
            return list;
        }
        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedMenuItems = (Class1)e.SelectedItem;
            Type selectedPage = SelectedMenuItems.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
