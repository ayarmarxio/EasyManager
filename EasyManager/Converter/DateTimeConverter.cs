﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyManager.Model;
using EasyManager.ViewModel;

namespace EasyManager.Converter
{
    public class DateTimeConverter
    {
       

        public DateTimeConverter ()
        {
            
        }

        public DateTimeOffset DateToDate( DateTimeOffset InsertedDate)
        {

       
            return InsertedDate.Date;
        }

        public TimeSpan DateToTime (TimeSpan InsertedTime)
        {
            return InsertedTime;
        }
     

        
    }
}
