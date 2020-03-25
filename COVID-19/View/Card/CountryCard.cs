﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using COVID_19.Classes;
using COVID_19.API;

namespace COVID_19.View.Card
{
    public partial class CountryCard : UserControl
    {
        private string _country, _pictureurl = string.Empty;
        private Int64 _cases = 0;
        public CountryCard(string country, Int64 cases, string pictureurl)
        {
            InitializeComponent();
            _country = country;
            _cases = cases;
            _pictureurl = pictureurl;
        }

        private void CountryCard_Load(object sender, EventArgs e)
        {
            lblcountry.Text = _country;
            lblcases.Text = string.Format("{0:n0}", _cases);
            pictureBox1.LoadAsync(string.Format("{0}", _pictureurl));
            //pictureBox1.LoadAsync(string.Format("https://www.countryflags.io/{0}/shiny/64.png",ConvertNameToTwoLetterName(_country)));
        }

        //public string ConvertNameToTwoLetterName(string name)
        //{
        //    name = name.ToUpper();
        //    CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        //    foreach (CultureInfo culture in cultures)
        //    {
        //        RegionInfo region = new RegionInfo(culture.LCID);
        //        if (region.EnglishName.ToUpper() == name)
        //        {
        //            return region.TwoLetterISORegionName;
        //        }
        //    }
        //    return null;
        //}
    }
}
