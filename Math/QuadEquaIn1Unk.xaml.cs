using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Math.AppCore;
using Windows.UI.Popups;

#region Backup
// Back-up for the key component
//p_ratermm.Visibility = Visibility.Visible;
//p_rational.Visibility = Visibility.Visible;
//p_numer.Visibility = Visibility.Visible;
//p_ratline.Visibility = Visibility.Visible;
//p_ratdoni.Visibility = Visibility.Visible;
//p_first.Visibility = Visibility.Visible;
//p_second.Visibility = Visibility.Visible;
//p_irrational.Visibility = Visibility.Visible;
//p_coe.Visibility = Visibility.Visible;
//p_surd1.Visibility = Visibility.Visible;
//p_surd2.Visibility = Visibility.Visible;
//p_surdnumer.Visibility = Visibility.Visible;
//p_irraline.Visibility = Visibility.Visible;
//p_irratdoni.Visibility = Visibility.Visible;
//txt.Visibility = Visibility.Visible;
//n_ratermm.Visibility = Visibility.Visible;
//n_rational.Visibility = Visibility.Visible;
//n_numer.Visibility = Visibility.Visible;
//n_ratline.Visibility = Visibility.Visible;
//n_ratdoni.Visibility = Visibility.Visible;
//n_first.Visibility = Visibility.Visible;
//n_second.Visibility = Visibility.Visible;
//n_irrational.Visibility = Visibility.Visible;
//n_coe.Visibility = Visibility.Visible;
//n_surd1.Visibility = Visibility.Visible;
//n_surd2.Visibility = Visibility.Visible;
//n_surdnumer.Visibility = Visibility.Visible;
//n_irraline.Visibility = Visibility.Visible;
//n_irratdoni.Visibility = Visibility.Visible;
////
//p_ratermm.Visibility = Visibility.Collapse;
//p_rational.Visibility = Visibility.Collapse;
//p_numer.Visibility = Visibility.Collapse;
//p_ratline.Visibility = Visibility.Collapse;
//p_ratdoni.Visibility = Visibility.Collapse;
//p_first.Visibility = Visibility.Collapse;
//p_second.Visibility = Visibility.Collapse;
//p_irrational.Visibility = Visibility.Collapse;
//p_coe.Visibility = Visibility.Collapse;
//p_surd1.Visibility = Visibility.Collapse;
//p_surd2.Visibility = Visibility.Collapse;
//p_surdnumer.Visibility = Visibility.Collapse;
//p_irraline.Visibility = Visibility.Collapse;
//p_irratdoni.Visibility = Visibility.Collapse;
//txt.Visibility = Visibility.Collapse;
//n_ratermm.Visibility = Visibility.Collapse;
//n_rational.Visibility = Visibility.Collapse;
//n_numer.Visibility = Visibility.Collapse;
//n_ratline.Visibility = Visibility.Collapse;
//n_ratdoni.Visibility = Visibility.Collapse;
//n_first.Visibility = Visibility.Collapse;
//n_second.Visibility = Visibility.Collapse;
//n_irrational.Visibility = Visibility.Collapse;
//n_coe.Visibility = Visibility.Collapse;
//n_surd1.Visibility = Visibility.Collapse;
//n_surd2.Visibility = Visibility.Collapse;
//n_surdnumer.Visibility = Visibility.Collapse;
//n_irraline.Visibility = Visibility.Collapse;
//n_irratdoni.Visibility = Visibility.Collapse;
#endregion
namespace Math
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuadEquaIn1Unk : Page
    {
        public QuadEquaIn1Unk()
        {
            this.InitializeComponent();
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        
        private async void Solve(object sender, RoutedEventArgs e)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            if (at.Text == "" || bt.Text == "" || ct.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("NoneInErr"));
                await messageDialog.ShowAsync();
                return;
            } 
            if (at.Text == "0" )
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("QeouErr"));
                await messageDialog.ShowAsync();
                return;
            }
            #region Startup Check
            //Start-up Check if this is a new session
            if (Answer.Visibility == Visibility.Visible)
            {
                Answer.Visibility = Visibility.Collapsed;
                p_ratermm.Visibility = Visibility.Visible;
                p_rational.Visibility = Visibility.Visible;
                p_numer.Visibility = Visibility.Visible;
                p_ratline.Visibility = Visibility.Visible;
                p_ratdoni.Visibility = Visibility.Visible;
                p_first.Visibility = Visibility.Visible;
                p_second.Visibility = Visibility.Visible;
                p_irrational.Visibility = Visibility.Visible;
                p_coe.Visibility = Visibility.Visible;
                p_surd1.Visibility = Visibility.Visible;
                p_surd2.Visibility = Visibility.Visible;
                p_surdnumer.Visibility = Visibility.Visible;
                p_irraline.Visibility = Visibility.Visible;
                p_irratdoni.Visibility = Visibility.Visible;
                p_i.Visibility = Visibility.Collapsed;
                p_appro.Visibility = Visibility.Visible;
                txt.Visibility = Visibility.Visible;
                n_ratermm.Visibility = Visibility.Visible;
                n_rational.Visibility = Visibility.Visible;
                n_numer.Visibility = Visibility.Visible;
                n_ratline.Visibility = Visibility.Visible;
                n_ratdoni.Visibility = Visibility.Visible;
                n_first.Visibility = Visibility.Visible;
                n_second.Visibility = Visibility.Visible;
                n_irrational.Visibility = Visibility.Visible;
                n_coe.Visibility = Visibility.Visible;
                n_surd1.Visibility = Visibility.Visible;
                n_surd2.Visibility = Visibility.Visible;
                n_surdnumer.Visibility = Visibility.Visible;
                n_irraline.Visibility = Visibility.Visible;
                n_irratdoni.Visibility = Visibility.Visible;
                n_i.Visibility = Visibility.Collapsed;
                n_appro.Visibility = Visibility.Visible;

            }
            #endregion
            //Give value to numbers
            int a, b, c, m, b_b, a_b, m_b;
            int[] x = new int[2];
            int[] y = new int[2];
            a = Convert.ToInt32(at.Text);
            a_b = Convert.ToInt32(at.Text);
            b = Convert.ToInt32(bt.Text);
            b_b = Convert.ToInt32(bt.Text);
            c = Convert.ToInt32(ct.Text);
            m = b * b - 4 * a * c;
            m_b = m;
            #region Dealer
            //Dealing with imaginary answer
            if(m < 0)
            {
                p_i.Visibility = Visibility.Visible;
                n_i.Visibility = Visibility.Visible;
                m = -m;
            }
            p_second.Visibility = Visibility.Collapsed;
            n_second.Visibility = Visibility.Collapsed;
            //Dealing with the negative term;a_b and b_b are the backup of the original values when dealing in the complex form
            if (a < 0 && b < 0)
            {
                //when a and b are both negative
                p_first.Visibility = Visibility.Collapsed;
                n_first.Visibility = Visibility.Collapsed;
                b = -b;
                a = -a;
            }
            else
            {
                //when b is negative
                if (b < 0)
                {
                    p_ratermm.Visibility = Visibility.Collapsed;
                    n_ratermm.Visibility = Visibility.Collapsed;
                    b = -b;
                }
                //when a is negative
                 if (a < 0)
                {
                    p_ratermm.Visibility = Visibility.Collapsed;
                    n_ratermm.Visibility = Visibility.Collapsed;
                    p_first.Visibility = Visibility.Collapsed;
                    n_first.Visibility = Visibility.Collapsed;
                    p_second.Visibility = Visibility.Visible;
                    n_second.Visibility = Visibility.Visible;
                    a = -a;
                }
            }
            #endregion
            #region delta=0
            //When delta is zero
            if (m == 0)
            {
                p_first.Visibility = Visibility.Collapsed;
                p_second.Visibility = Visibility.Collapsed;
                p_irrational.Visibility = Visibility.Collapsed;
                Ans2.Visibility = Visibility.Collapsed;
                txt.Visibility = Visibility.Collapsed;
                //Simplify the fraction
                x[0] = b;
                x[1] = 2 * a;
                int[] rat = NDS.FracSimp(x);
                b=rat[0];
                a=rat[1];
                //When the rational donimonator is ignoreable
                if(a==1)
                {
                    p_ratline.Visibility = Visibility.Collapsed;
                    p_ratdoni.Visibility = Visibility.Collapsed;
                    p_appro.Visibility = Visibility.Collapsed;
                    n_appro.Visibility = Visibility.Collapsed;
                }
                //Generation of the approximate form
                double appro = b_b / (2 * a_b);
                p_appro.Text = "(Approximately " + appro + ")";
                //Finalise the answer
                p_numer.Text = b.ToString();
                p_ratdoni.Text = a.ToString();
            }
            #endregion
            #region rational term=0
            //When the rational term is 0
            else if (b == 0)
            {
                p_ratermm.Visibility = Visibility.Collapsed;
                n_ratermm.Visibility = Visibility.Collapsed;
                p_first.Visibility = Visibility.Collapsed;
                n_second.Visibility = Visibility.Collapsed;
                p_rational.Visibility = Visibility.Collapsed;
                n_rational.Visibility = Visibility.Collapsed;
                x = NDS.SimpSurd(m);
                y[0] = x[0];
                y[1] = 2 * a;
                int[] irrat = NDS.FracSimp(y);
                //when the coefficient is ignorable
                if (irrat[0] == 1)
                {
                    p_coe.Visibility = Visibility.Collapsed;
                    n_coe.Visibility = Visibility.Collapsed;
                }
                //when the irrational donimonator is ignoreable
                if (irrat[1] == 1)
                {
                    p_irratdoni.Visibility = Visibility.Collapsed;
                    n_irratdoni.Visibility = Visibility.Collapsed;
                    p_irraline.Visibility = Visibility.Collapsed;
                    n_irraline.Visibility = Visibility.Collapsed;
                }
                //When the number in the surd is ignoreable
                if (x[1] == 1)
                {
                    p_surd1.Visibility = Visibility.Collapsed;
                    p_surd2.Visibility = Visibility.Collapsed;
                    n_surd1.Visibility = Visibility.Collapsed;
                    n_surd2.Visibility = Visibility.Collapsed;
                }
                if (irrat[1] == 1 && x[1] == 1)
                {
                    p_appro.Visibility = Visibility.Collapsed;
                    n_appro.Visibility = Visibility.Collapsed;
                }
                //Generation of the approximate form
                double appro = System.Math.Sqrt(m) / (2 * a_b);
                if (p_i.Visibility == Visibility.Visible)
                {
                    p_appro.Visibility = Visibility.Collapsed;
                    n_appro.Visibility = Visibility.Collapsed; 
                }
                else
                {
                    p_appro.Text = "(Approximately " + appro + ")";
                    n_appro.Text = "(Approximately -" + appro + ")";
                }
                //Finalise the answer
                p_coe.Text = irrat[0].ToString();
                p_surdnumer.Text = x[1].ToString();
                p_irratdoni.Text = irrat[1].ToString();
                n_coe.Text = irrat[0].ToString();
                n_surdnumer.Text = x[1].ToString();
                n_irratdoni.Text = irrat[1].ToString();
            }
            #endregion
            #region General Term
            //Provide answer in general term
            else
            {
                p_second.Visibility = Visibility.Collapsed;
                n_second.Visibility = Visibility.Collapsed;
                p_first.Visibility = Visibility.Visible;
                n_first.Visibility = Visibility.Visible;
                x[0] = b;
                x[1] = 2 * a;
                a_b = a;
                int[] rat = NDS.FracSimp(x);
                b = rat[0];
                a = rat[1];
                x = NDS.SimpSurd(m);
                y[0] = x[0];
                y[1] = 2 * a_b;
                int[] irrat = NDS.FracSimp(y);
                //here, b is rational numerator, a is rational donimonator,x[1] is number in the surd,irrat[0] is the coefficient, irrat[1] is the irrational donimonator.
                //When the number in the surd is ignoreable
                if(x[1] == 1)
                {

                    p_first.Visibility = Visibility.Collapsed;
                    p_second.Visibility = Visibility.Collapsed;
                    n_first.Visibility = Visibility.Collapsed;
                    n_second.Visibility = Visibility.Collapsed;
                    p_irrational.Visibility = Visibility.Collapsed;
                    n_irrational.Visibility = Visibility.Collapsed;
                    int k, i, q, s, p;
                    int[] sigo = new int[2];
                        
                    if (a < irrat[1]) k = a;
                    else k = irrat[1];
                    for (i = k; i > 0; i--)
                    {
                        if (a % i == 0 && irrat[1] % i == 0)
                        {
                            q = a / i;
                            s = q * irrat[1];
                            p = b * s / a + irrat[0] * s / irrat[1];
                            sigo[0] = p;
                            sigo[1] = s;
                        }
                    }
                    int[] sig = NDS.FracSimp(sigo);

                    if (a == 1)
                    {
                        p_ratline.Visibility = Visibility.Collapsed;
                        p_ratdoni.Visibility = Visibility.Collapsed;
                        p_appro.Visibility = Visibility.Collapsed;
                        n_appro.Visibility = Visibility.Collapsed;
                    }
                    //Generation of the approximate form
                    double appro = sig[0]/sig[1];
                    if (p_i.Visibility == Visibility.Visible)
                    {
                        p_appro.Visibility = Visibility.Collapsed;
                        n_appro.Visibility = Visibility.Collapsed; 
                    }
                    else
                    {
                        p_appro.Text = "(Approximately " + appro + ")";
                        n_appro.Text = "(Approximately -" + appro + ")";
                    }
                    
                    //Finalise the answer
                    p_numer.Text = sig[0].ToString();
                    p_ratdoni.Text = sig[1].ToString();
                    n_numer.Text = sig[0].ToString();
                    n_ratdoni.Text = sig[1].ToString();
                }
                else
                {
                  //When the rational donimonator id ignorable
                  if(a==1)
                  {
                      p_ratline.Visibility = Visibility.Collapsed;
                      p_ratdoni.Visibility = Visibility.Collapsed;
                      n_ratline.Visibility = Visibility.Collapsed;
                      n_ratdoni.Visibility = Visibility.Collapsed;
                  }
                  //when the irrational coefficient is ignorable
                  if (irrat[0] == 1)
                  {
                      p_coe.Visibility = Visibility.Collapsed;
                      n_coe.Visibility = Visibility.Collapsed;
                  }
                  //when the irrational donimonator is ignorable
                  if (irrat[1] == 1)
                  {
                      p_irratdoni.Visibility = Visibility.Collapsed;
                      n_irratdoni.Visibility = Visibility.Collapsed;
                      p_irraline.Visibility = Visibility.Collapsed;
                      n_irraline.Visibility = Visibility.Collapsed;
                  }
                  //Generation of the approximate form
                  double appro1 = b_b / (2*a_b);
                  double appro2 = System.Math.Sqrt(m) / (2 * a_b);
                  if (p_i.Visibility == Visibility.Visible)
                  {
                      p_appro.Text = "(Approximately " + appro1 + "+"+ appro2 + "i)";
                      n_appro.Text = "(Approximately " + appro1 + "-" + appro2 + "i)";
                  }
                  else
                  {
                      p_appro.Text = "(Approximately " + appro1 + "+" + appro2 + ")";
                      n_appro.Text = "(Approximately " + appro1 + "-" + appro2 + ")";
                  };
                  //Finalise the answer
                  p_numer.Text = b.ToString();
                  p_ratdoni.Text = a.ToString();
                  n_numer.Text = b.ToString();
                  n_ratdoni.Text = a.ToString();
                  p_coe.Text = irrat[0].ToString();
                  p_surdnumer.Text = x[1].ToString();
                  p_irratdoni.Text = irrat[1].ToString();
                  n_coe.Text = irrat[0].ToString();
                  n_surdnumer.Text = x[1].ToString();
                  n_irratdoni.Text = irrat[1].ToString();
                }

            }
            #endregion
            //Show the Answer
            Answer.Visibility = Visibility.Visible;
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
