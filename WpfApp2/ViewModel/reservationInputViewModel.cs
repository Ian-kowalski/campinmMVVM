using System.Windows.Input;
using WPF.MVVM.Camping.Commands;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.Views;
using WPF.MVVM.Camping.Views.subViews;

namespace WPF.MVVM.Camping.ViewModel
{
    internal class reservationInputViewModel : modelViewBase
    {
        private String _siteID;
        public String SiteID
        {
            get
            {
                return _siteID;
            }
            set
            {
                _siteID = value;
                OnPropertyChanged(nameof(SiteID));
            }
        }

        private DateTime _startDateDate;
        public DateTime StartDateDate
        {
            get
            {
                return _startDateDate;
            }
            set
            {
                _startDateDate = value;
                OnPropertyChanged(nameof(StartDateDate));
            }
        }

        private DateTime _endDateDate;
        public DateTime endDateDate
        {
            get
            {
                return _endDateDate;
            }
            set
            {
                _endDateDate = value;
                OnPropertyChanged(nameof(endDateDate));
            }
        }

        private String _firstName;
        public String FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastname;
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

        private string _proposition;
        public string Proportion
        {
            get
            {
                return _proposition;
            }
            set
            {
                _proposition = value;
                OnPropertyChanged(nameof(Proportion));
            }
        }

        private int _phoneNumber;
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        private string _adress;
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
                OnPropertyChanged(nameof(Adress));
            }
        }

        private string _houseNumber;
        public string HouseNumber
        {
            get
            {
                return _houseNumber;
            }
            set
            {
                _houseNumber = value;
                OnPropertyChanged(nameof(HouseNumber));
            }
        }

        private string _postalCode;
        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
                OnPropertyChanged(nameof(PostalCode));
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }

            set
            {
                if (_isEnabled == value)
                {
                    return;
                }

                _isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
            }
        }



        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public reservationInputViewModel(bool ResevationInfo, MainNavigationStore navigation)
        {
            IsEnabled = ResevationInfo;
            SubmitCommand = new SaveEditComand(this);
        }
    }
}
