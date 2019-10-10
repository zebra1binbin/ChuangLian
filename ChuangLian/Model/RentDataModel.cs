using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuangLian.Model
{
    public class RentDataModel : INotifyPropertyChanged
    {
        private DateTime _begintime;
        private DateTime _endtime;
        private ObservableCollection<int> _useyears;
        private ObservableCollection<int> _usemonths;
        private ObservableCollection<int> _seatrent;
        private ObservableCollection<int> _paytime;
        private double _monthlyrent;
        private int _usecount;
        private double _chummage;
        private double _service;
        private double _totalmonthlyrent;
        private double _totalchummage;
        private double _totalservice;
        private double _paymonthlyrent;
        private double _paychummage;
        private double _payservice;
        public DateTime BeginTime
        {
            get
            {
                return _begintime;
            }
            set
            {
                if (value == _begintime)
                    return;
                _begintime = value;
                Notify("BeginTime");
            }
        }
        public DateTime EndTime
        {
            get
            {
                return _endtime;
            }
            set
            {
                if (value == _endtime)
                    return;
                _endtime = value;
                Notify("EndTime");
            }
        }
        public ObservableCollection<int> UseYears
        {
            get
            {
                return _useyears;
            }
            set
            {
                if (value == _useyears)
                    return;
                _useyears = value;
                Notify("UseYears");
            }
        }
        public ObservableCollection<int> UseMonths
        {
            get
            {
                return _usemonths;
            }
            set
            {
                if (value == _usemonths)
                    return;
                _usemonths = value;
                Notify("UseMonths");
            }
        }
        public ObservableCollection<int> SeatRent
        {
            get
            {
                return _seatrent;
            }
            set
            {
                if (value == _seatrent)
                    return;
                _seatrent = value;
                Notify("SeatRent");
            }
        }
        public ObservableCollection<int> PayTime
        {
            get
            {
                return _paytime;
            }
            set
            {
                if (value == _paytime)
                    return;
                _paytime = value;
                Notify("PayTime");
            }
        }
        public double Monthlyrent
        {
            get
            {
                return _monthlyrent;
            }
            set
            {
                if (value == _monthlyrent)
                    return;
                _monthlyrent = value;
                Notify("Monthlyrent");
            }
        }
        public int UseCount
        {
            get
            {
                return _usecount;
            }
            set
            {
                if (value == _usecount)
                    return;
                _usecount = value;
                Notify("UseCount");
            }
        }
        public double Chummage
        {
            get
            {
                return _chummage;
            }
            set
            {
                if (value == _chummage)
                    return;
                _chummage = value;
                Notify("Chummage");
            }
        }
        public double Service
        {
            get
            {
                return _service;
            }
            set
            {
                if (value == _service)
                    return;
                _service = value;
                Notify("Service");
            }
        }
        public double TotalMonthlyRent
        {
            get
            {
                return _totalmonthlyrent;
            }
            set
            {
                if (value == _totalmonthlyrent)
                    return;
                _totalmonthlyrent = value;
                Notify("TotalMonthlyRent");
            }
        }
        public double TotalChummage
        {
            get
            {
                return _totalchummage;
            }
            set
            {
                if (value == _totalchummage)
                    return;
                _totalchummage = value;
                Notify("TotalChummage");
            }
        }
        public double TotalService
        {
            get
            {
                return _totalservice;
            }
            set
            {
                if (value == _totalservice)
                    return;
                _totalservice = value;
                Notify("TotalService");
            }
        }
        public double PayMonthlyRent
        {
            get
            {
                return _paymonthlyrent;
            }
            set
            {
                if (value == _paymonthlyrent)
                    return;
                _paymonthlyrent = value;
                Notify("PayMonthlyRent");
            }
        }
        public double PayChummage
        {
            get
            {
                return _paychummage;
            }
            set
            {
                if (value == _paychummage)
                    return;
                _paychummage = value;
                Notify("PayChummage");
            }
        }
        public double PayService
        {
            get
            {
                return _payservice;
            }
            set
            {
                if (value == _payservice)
                    return;
                _payservice = value;
                Notify("PayService");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string PropName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropName));
        }
    }
}
