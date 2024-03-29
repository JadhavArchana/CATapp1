﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace CATapp
{
    public partial class Page3 : PhoneApplicationPage, INotifyPropertyChanged
    {
        private CatAppDataContext catAppDB;
        public static string DBConnectionString = "Data Source=isostore:/catappdb.sdf";
      //  public Int64 op;
        public Page3()
        {
            InitializeComponent();
            // Connect to the database and instantiate data context.
            catAppDB = new CatAppDataContext(DBConnectionString);

            // Data context and observable collection are children of the main page.
            this.DataContext = this;


        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the app that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


        private ObservableCollection<Question> _ques;
        public ObservableCollection<Question> Questions
        {
            get
            {
                return _ques;
            }
            set
            {
                if (_ques != value)
                {
                    _ques = value;
                    NotifyPropertyChanged("Questions");
                }
            }
        }



        private ObservableCollection<Option> _opts;
        public ObservableCollection<Option> Options
        {
            get
            {
                return _opts;
            }
            set
            {
                if (_opts != value)
                {
                    _opts = value;
                    NotifyPropertyChanged("Options");
                }
            }
        }
        private ObservableCollection<Category> _cats;
          public ObservableCollection<Category> Categories
        {
            get
            {
                return _cats;
            }
            set
            {
                if (_cats != value)
                {
                    _cats = value;
                    NotifyPropertyChanged("Categories");
                }
            }
        }

          private ObservableCollection<Question_category> _quecats;
          public ObservableCollection<Question_category> Question_categories
          {
              get
              {
                  return _quecats;
              }
              set
              {
                  if (_quecats != value)
                  {
                      _quecats = value;
                      NotifyPropertyChanged("Question_categories");
                  }
              }
          }

          private void queListBox_Loaded(object sender, RoutedEventArgs e)
          {
            //  var q = from Question que in catAppDB.Questions
          //       //     where que._id == 490
          //            select que;
          //    Questions = new ObservableCollection<Question>(q);
          }

        
    
      
         
         /*   var q = from Question que in catAppDB.Questions where que._id==490
                    select que;
            Questions = new ObservableCollection<Question>(q);*/
             
        /*    var q1 = from Option opt in catAppDB.Options
                     where opt.Q_id==490
                     select opt;
            Options = new ObservableCollection<Option>(q1);*/
        

       /* private int countQue(String cname1)
        {
            Page1 p = new Page1();
            if(p.catListBox.SelectedItem==cname1)
            {
           
                var cnameindex = from Category cat in catAppDB.Categories
                             where cat.Name == cname1
                             select cat;
            

               Categories = new ObservableCollection<Category>(cnameindex);
        }*/
          protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
          {
          //    IDictionary<string, string> x = this.NavigationContext.QueryString;
            //  String a = Convert.ToString(x["selectedValue"]);
              //textBox1.Text = a.ToString();
              base.OnNavigatedTo(e);
            String s=  NavigationContext.QueryString["selectedItem"];
            textBox1.Text = s;
              
          }

      private void textBox1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
      {
//          int op;
////          textBox1.Text=104;

////Question qs1=new Question();
//  //        Question_category qs2=new Question_category();
//      /*    var q = from Question qs1 in catAppDB.Questions
//                  join Question_category qs2 in catAppDB.Question_categories on qs1._id equals qs2.Q_id
//                       where qs2.C_id==104
//                  select qs1;*/

//        //  Questions = new ObservableCollection<Question>(q);
//            op = (from Option os in catAppDB.Options
//                   where os.Q_id == 50
//                   select os).Count();
//          //var opt=from Option os1 in catAppDB.Options where os1.Q_id==50
//          //        select os1;
//          //string s = opt.ToString();
//          //string [] s1=new string[5];
//         //s1=(string[])s;
        


//            System.Windows.Controls.RadioButton[] rbb = new System.Windows.Controls.RadioButton[5];
//            for (int i = 0; i < op; ++i)
//            {
//                rbb[i] = new RadioButton();
//                //rbb[i].Content =s[i];

//                // String str = "abc";
//                //   rb.GroupName = "rb1";
//                // rb.Content= str;

//                //   rbb.Content = "abc";
//                queListBox.Items.Add(rbb[i]);
//            }
  
////            Options = new ObservableCollection<Option>(opt);

//          //var q1 = from Question_category que1 in catAppDB.Question_categories
//          //        //     where que._id == 490
//          //        select que1;
          
//          //Question_categories = new ObservableCollection<Question_category>(q1);
          


      }
   

    }
}