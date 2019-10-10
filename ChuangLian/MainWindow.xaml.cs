using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChuangLian
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _MonthTotalMoney; //月租金
        private int _UserPeopleCount; //租用人数
        private double _MonthLease; //月租赁费
        private double _MonthService; //月服务费
        private int _MonthMoney;
        private int month;
        private int year;
        private double _TotalMoney;
        private double _LeaseTotalMoney;
        private double _ServiceTotalMoney;

        private CLData _createdata;
        public MainWindow()
        {
            InitializeComponent();
            _createdata = CLData.GetInstance();
            InitControl();
        }

        private void InitControl()
        {
            DP_StartTime.SelectedDate = DateTime.Now;
            CB_UseYears.ItemsSource = _createdata.RentDataModel.UseYears;
            CB_UseYears.SelectedIndex = 0;
            CB_UseMonth.ItemsSource = _createdata.RentDataModel.UseMonths;
            CB_UseMonth.SelectedIndex = 0;
            CB_Pay.ItemsSource = _createdata.RentDataModel.PayTime ;
            CB_Pay.SelectedIndex = 0;
        }

        private void CB_UseTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DateTime starttime = DP_StartTime.SelectedDate.Value.AddDays(-1.0);
                if (CB_UseMonth.SelectedIndex == -1)
                    month = 0;
                else
                    month = CB_UseMonth.SelectedIndex;
                if (CB_UseYears.SelectedIndex == -1)
                    year = 0;
                else
                    year = CB_UseYears.SelectedIndex;
                DateTime endtime = starttime.AddMonths(month).AddYears(year);
                TB_EndTime.Text = endtime.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_CalService_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Verification())
                {
                    return;
                }
                _MonthLease = _MonthMoney * _UserPeopleCount; //月租赁费
                if (_MonthLease > _MonthTotalMoney)
                {
                    MessageBox.Show("月房租必须大于租赁费");
                    return;
                }
                _MonthService = _MonthTotalMoney - _MonthLease; //月服务费
                _TotalMoney = (year * 12 + month) * _MonthTotalMoney;
                _LeaseTotalMoney = (year * 12 + month) * _MonthLease;
                _ServiceTotalMoney = (year * 12 + month) * _MonthService;
                TB_MonthLease.Text = _MonthLease.ToString();
                TB_MonthService.Text = _MonthService.ToString();
                TB_TotalMoney.Text = _TotalMoney.ToString();
                TB_LeaseTotalMoney.Text = _LeaseTotalMoney.ToString();
                TB_ServiceTotalMoney.Text = _ServiceTotalMoney.ToString();
                double paylease = CB_Pay.SelectedIndex * _MonthLease;
                TB_PayLease.Text = paylease.ToString();
                double payservice = CB_Pay.SelectedIndex * _MonthService;
                TB_PayService.Text = payservice.ToString();
                double paytotal = CB_Pay.SelectedIndex * _MonthTotalMoney;
                TB_Paytotal.Text = paytotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Verification()
        {
            if (string.IsNullOrEmpty(TB_MonthTotalMoney.Text.Trim()))
            {
                MessageBox.Show("请填写月租金");
                return false;
            }
            else
            {
                _MonthTotalMoney = double.Parse(TB_MonthTotalMoney.Text);
            }
            if (string.IsNullOrEmpty(TB_UserPeopleCount.Text.Trim()))
            {
                MessageBox.Show("请填写租用人数");
                return false;
            }
            else
            {
                _UserPeopleCount = int.Parse(TB_UserPeopleCount.Text);
            }
            if (string.IsNullOrEmpty(TB_MonthMoney.Text.Trim()))
            {
                MessageBox.Show("请填写正确座位租金数");
                return false;
            }
            else
            {
                _MonthMoney = int.Parse(TB_MonthMoney.Text);
            }
            if (CB_Pay.SelectedIndex == -1 || CB_Pay.SelectedIndex == 0)
            {
                MessageBox.Show("请选择正确的首付");
                return false;
            }
            if (month != 0 || year != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("请选择服务时间");
                return false;
            }
        }
    }
}
