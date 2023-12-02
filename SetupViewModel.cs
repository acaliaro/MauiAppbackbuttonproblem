using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppbackbuttonproblem
{
    public partial class SetupViewModel : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        bool isFirstTime;

        public SetupViewModel()
        {
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {

            if (query.ContainsKey("isinizializzazione"))
            {
                query.TryGetValue("isinizializzazione", out object oggetto);
                IsFirstTime = (bool)oggetto;
            }

        }

        partial void OnIsFirstTimeChanged(bool value)
        {
            System.Diagnostics.Debug.WriteLine("OnIsFirstTimeChanged value = " + value);
        }
    }
}
