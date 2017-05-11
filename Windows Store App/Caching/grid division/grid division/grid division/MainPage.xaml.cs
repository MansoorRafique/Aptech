using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace grid_division
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            grd2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd1.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void aa_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //For over laping of images we have to do all images visibility false 
            img2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            img3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            img4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            img5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            img6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


           
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "Sir Syed university, was founded in 1990 by a group of visionaries and intellectuals to impart quality education in a stimulating and innovative environment where students are empowered with knowledge and professional skills while upholding the values of integrity, tolerance and mutual respect. Since its inception the group has promoted education in the areas of Management Sciences, Tourism, Information Technology, Bio-Science, Engineering Sciences and Journalism through its three educational campuses equipped with state of art infrastructure. IMS has attained a unique and a highly respectable place amongst the best professional education institutions in India.";
             
  

        }

        private void bb(object sender, PointerRoutedEventArgs e)
        {
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "NED University, was established to meet the ever growing demand for trained professional manpower for industries and to serve as training ground for students from this region in the Engineering profession. The Academy is situated on a sprawling campus of 28 acres in the Institutional area of NOIDA and aims to be a value-based Centre of Excellence in Technical Education. Backed by the rich experience of managing Engineering Education, JSSATE, NOIDA ranked as one of the best Technical Institutions in the state of Uttar Pradesh, is approved by the Government of Uttar Pradesh and All India Council for Technical Education and affiliated to the Uttar Pradesh Technical University (UPTU) at Lucknow. Our students have been invariably placed in the Roll of Honour of top ten rankers in UPTU.";
        }

        private void cc(object sender, PointerRoutedEventArgs e)
        {
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img3.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "Jinnah Sindh Mdical University, with captivating state of art campus having aesthetically lush green, serene and capitulating landscape of eco-friendly environment and situated on Delhi Hapur by- road, NH-24, 11 Kms from Delhi border with proximity to hub of industries, MNCs and business houses was started in 2000 with B.Tech.  ( CS, IT,EC) and MCA, with the approval from AICTE, New Delhi and affiliated to UP Technical University, Lucknow having UPTU code 032. In the following years ME (2003), MBA (2006), EEE (2008), MCA (2008) and M.Tech. were also approved.";
        }

        private void dd(object sender, PointerRoutedEventArgs e)
        {
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img4.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "Hamdard University offering Undergraduate and Postgraduate programmes in several streams of Engineering, IT, Management, Architecture and Pharmacy. This is the oldest self financed professional institute of uttarakhand which was established in the year 1998.";
        }

        private void ee(object sender, PointerRoutedEventArgs e)
        {
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "The mission of Karachi University will be to provide every opportunity for each student to attain the best of their capabilities and create in them the desire to excel. The seeds for the craving for excellence would be sown in the minds of the students as soon as they enter the portals of the KIET. Thus KIET will act as a catalyst in creating excellence in technical education. The reach for excellence would also ensure fin our mission to serve the society by producing dedicated professionals with appropriate knowledge and skills capable of providing imaginative and technologically informed solutions to industry, academia and other professions.";
        }

        private void ff(object sender, PointerRoutedEventArgs e)
        {
            grd1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            grd2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            img6.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            txt1.Text = "Welcome to Iqra University. The IU Group was founded in the year 1995. Since then the IU has grown impressively and achieved widespread recognition from corporate, academia , and professional circles. At I.T.S we are committed to provide a value driven culture along with creating a professional order. The I.T.S as a group is large and diversified group and imparts knowledge in field of Management, IT, Dentistry, Bio-technology, Physiotherapy, Pharmacy, and Engineering. The I.T.S group has more than 700 highly qualified and experienced faculty members in their respective functional areas. About 8000 students are enrolled in various courses in four campuses. The Group runs two hospitals and is one of two groups in India which have two dental colleges.";
        }

    }
}
