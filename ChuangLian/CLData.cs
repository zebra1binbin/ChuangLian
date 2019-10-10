using ChuangLian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuangLian
{
    public class CLData
    {
        private RentDataModel _rentdatamodel;
        public RentDataModel RentDataModel
        {
            get
            {
                return _rentdatamodel;
            }
            set
            {
                _rentdatamodel = value;
            }
        }
        private static CLData _createdata;
        private CLData()
        {
            CreateRentDataa();
        }
        public static CLData GetInstance()
        {
            if (_createdata == null)
                _createdata = new CLData();
            return _createdata;
        }
        public void Calculation()
        {
            if (_rentdatamodel == null)
            {
                return;
            }

        }
        public DateTime CalculationEndTime(DateTime starttime,int useyear,int usemonth)
        {
            return _rentdatamodel.EndTime = starttime.AddMonths(usemonth).AddYears(useyear);
        }
        private void CreateRentDataa()
        {
            _rentdatamodel = new RentDataModel();
            _rentdatamodel.UseYears = new System.Collections.ObjectModel.ObservableCollection<int>()
            {
                0,1,2,3,4,5,6
            };
            _rentdatamodel.UseMonths = new System.Collections.ObjectModel.ObservableCollection<int>()
            {
                0,1,2,3,4,5,6,7,8,9,10,11,12
            };
            _rentdatamodel.SeatRent = new System.Collections.ObjectModel.ObservableCollection<int>()
            {
                200,260,300
            };
            _rentdatamodel.PayTime = new System.Collections.ObjectModel.ObservableCollection<int>()
            {
                0,1,2,3,4,5,6,7,8,9,10,11,12
            };
        }
    }
}
