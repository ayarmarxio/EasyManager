using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    public class Event
    {
        private string _name;
        private string _place;
        private string _description;
        private DateTimeOffset _time;
        private DateTimeOffset _date;

        public string Name { get => _name; set => _name = value; }
        public string Place { get => _place; set => _place = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTimeOffset Time { get => _time; set => _time = value; }
        public DateTimeOffset Date { get => _date; set => _date = value; }

        public Event ( string name, string place, string description, DateTimeOffset date, DateTimeOffset time)
        {
            _name = name;
           _place = place;
           _description = description;
            _date = date;
            _time = time;
        }

        public Event()
        {
            
        }


    }
}
